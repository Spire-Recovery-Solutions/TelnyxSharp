using System.Collections;
using System.Net;
using System.Text.Json;
using Polly.RateLimit;
using Polly.Retry;
using RestSharp;
using Telnyx.NET.Models;

namespace Telnyx.NET.Base
{
    /// <summary>
    /// A base class that provides common operations for interacting with Telnyx API endpoints.
    /// Handles API request execution, rate-limiting, and pagination.
    /// </summary>
    public abstract class BaseOperations
    {
        protected IRestClient Client { get; set; }
        protected AsyncRetryPolicy RateLimitRetryPolicy { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperations"/> class.
        /// </summary>
        protected BaseOperations() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOperations"/> class with the specified client and rate limit retry policy.
        /// </summary>
        /// <param name="client">The RestSharp client used for making API requests.</param>
        /// <param name="rateLimitRetryPolicy">The retry policy for rate-limiting.</param>
        protected BaseOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        {
            Client = client;
            RateLimitRetryPolicy = rateLimitRetryPolicy;
        }

        /// <summary>
        /// Executes an API request asynchronously and returns the response deserialized to the specified type.
        /// Handles rate-limiting, response deserialization, and pagination.
        /// </summary>
        /// <typeparam name="T">The type of the response model to deserialize into.</typeparam>
        /// <param name="request">The RestSharp request to execute.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        /// <returns>A task representing the asynchronous operation, with a result of type <typeparamref name="T"/>.</returns>
        protected async Task<T> ExecuteAsync<T>(RestRequest request, CancellationToken cancellationToken = default)
            where T : ITelnyxResponse, new()
        {
            return await RateLimitRetryPolicy.ExecuteAsync(async () =>
            {
                // Add a unique correlation ID header for tracking.
                request.AddOrUpdateHeader("X-Correlation-ID", Guid.NewGuid());

                var response = await Client.ExecuteAsync(request, cancellationToken);

                // Initialize the result with the response's basic status information.
                var result = new T
                {
                    StatusCode = response.StatusCode,
                    IsSuccessful = response.IsSuccessful,
                    ErrorMessage = response.ErrorMessage
                };

                // Handle rate-limiting by checking for 429 Too Many Requests status.
                if (response.StatusCode == HttpStatusCode.TooManyRequests)
                {
                    var resetSeconds = response.Headers?
                        .FirstOrDefault(h => h.Name.Equals("x-ratelimit-reset", StringComparison.OrdinalIgnoreCase))?
                        .Value?.ToString();

                    var delay = int.TryParse(resetSeconds, out var parsedDelay) ? parsedDelay : 1;
                    throw new RateLimitRejectedException(TimeSpan.FromSeconds(delay));
                }

                // If the response is successful and contains content, attempt to deserialize it.
                if (response is not { IsSuccessful: true, Content: not null }) return result;

                var deserializedResult =
                    JsonSerializer.Deserialize<T>(response.Content, TelnyxJsonSerializerContext.Default.Options);

                if (deserializedResult == null) return result;

                result = deserializedResult;
                result.StatusCode = response.StatusCode;
                result.IsSuccessful = response.IsSuccessful;
                result.ErrorMessage = response.ErrorMessage;

                // Handle pagination if the response includes paginated data.
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

                // Continue fetching pages if there are more.
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

                    // If the response is not successful, break the loop.
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
}