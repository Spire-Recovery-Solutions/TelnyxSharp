using System.Collections;
using System.Net;
using System.Text.Json;
using Polly.RateLimit;
using Polly.Retry;
using RestSharp;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;

namespace Telnyx.NET;
public abstract class BaseOperations
{
    protected IRestClient Client { get; set; }
    protected AsyncRetryPolicy RateLimitRetryPolicy { get; set; }

    protected BaseOperations()
    {
    }

    protected BaseOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    {
        Client = client;
        RateLimitRetryPolicy = rateLimitRetryPolicy;
    }

    protected async Task<T> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default) 
        where T : ITelnyxResponse, new()
    {
        return await RateLimitRetryPolicy.ExecuteAsync(async () =>
        {
            request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());
            var response = await Client.ExecuteAsync(request, cancellationToken);

            var result = new T
            {
                StatusCode = response.StatusCode,
                IsSuccessful = response.IsSuccessful,
                ErrorMessage = response.ErrorMessage
            };

            // Handle rate limiting
            if (response.StatusCode == HttpStatusCode.TooManyRequests)
            {
                var resetSeconds = response.Headers?
                    .FirstOrDefault(h => h.Name.Equals("x-ratelimit-reset", StringComparison.OrdinalIgnoreCase))?
                    .Value?.ToString();

                var delay = int.TryParse(resetSeconds, out var parsedDelay) ? parsedDelay : 1;
                throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
            }

            // If we have content and the request was successful, try to deserialize
            if (response is not { IsSuccessful: true, Content: not null }) return result;

            var deserializedResult =
                JsonSerializer.Deserialize<T>(response.Content, TelnyxJsonSerializerContext.Default.Options);

            if (deserializedResult == null) return result;

            result = deserializedResult;
            result.StatusCode = response.StatusCode;
            result.IsSuccessful = response.IsSuccessful;
            result.ErrorMessage = response.ErrorMessage;

            // Handle pagination if necessary
            var pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
            var metaProperty = typeof(T).GetProperty("Meta");
            var dataProperty = typeof(T).GetProperty("Data");

            if (metaProperty?.GetValue(result) is not PaginationMeta meta || dataProperty == null ||
                meta.PageNumber >= meta.TotalPages) return result;

            var dataType = dataProperty.PropertyType.GetGenericArguments()[0];
            var listType = typeof(List<>).MakeGenericType(dataType);
            var allData = (IList)Activator.CreateInstance(listType);

            if (dataProperty.GetValue(result) is IEnumerable initialData)
                foreach (var item in initialData)
                    allData.Add(item);

            while (meta.PageNumber < meta.TotalPages)
            {
                await RateLimitRetryPolicy.ExecuteAsync(async () =>
                {
                    request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());
                    request.RemoveParameter(pageParam);
                    request.AddParameter("page[number]", meta.PageNumber + 1);
                    response = await Client.ExecuteAsync(request, cancellationToken);

                    if (response.StatusCode != HttpStatusCode.TooManyRequests) return Task.CompletedTask;
                    
                    var resetSeconds = response.Headers?
                        .FirstOrDefault(h =>
                            h.Name.Equals("x-ratelimit-reset", StringComparison.OrdinalIgnoreCase))?
                        .Value?.ToString();

                    var delay = int.TryParse(resetSeconds, out var parsedDelay) ? parsedDelay : 1;
                    throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
                });

                if (!response.IsSuccessful || response.Content == null)
                {
                    result.IsSuccessful = false;
                    result.StatusCode = response.StatusCode;
                    result.ErrorMessage = response.ErrorMessage;
                    break;
                }

                var nextResult = JsonSerializer.Deserialize<T>(response.Content,
                    TelnyxJsonSerializerContext.Default.Options);
                if (nextResult == null) break;

                var nextData = dataProperty.GetValue(nextResult);
                if (nextData is IEnumerable pageData)
                    foreach (var item in pageData)
                        allData.Add(item);

                metaProperty.SetValue(result, metaProperty.GetValue(nextResult));
                meta = (PaginationMeta)metaProperty.GetValue(result);
                pageParam = request.Parameters.FirstOrDefault(p => p.Name == "page[number]");
            }

            dataProperty.SetValue(result, allData);
            return result;
        });
    }
}