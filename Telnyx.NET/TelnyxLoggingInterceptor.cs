using System.Collections.Concurrent;
using System.Text;
using RestSharp.Interceptors;

namespace Telnyx.NET;

/// <summary>
/// Interceptor for logging Telnyx API requests and responses
/// </summary>
public class TelnyxLoggingInterceptor(StreamWriter logWriter) : Interceptor, IDisposable
{
    private readonly StreamWriter _logWriter = logWriter ?? throw new ArgumentNullException(nameof(logWriter));
    private readonly Lock _logLock = new();
    private bool _disposed;
    
    // Use ConcurrentDictionary instead of HashSet for thread safety
    private readonly ConcurrentDictionary<string, byte> _processedRequests = new();
    private readonly ConcurrentDictionary<string, byte> _processedResponses = new();

    private void LogMessage(string message)
    {
        if (_disposed) return;

        lock (_logLock)
        {
            try
            {
                _logWriter.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {message}");
                _logWriter.Flush(); // Ensure writes are flushed
            }
            catch (ObjectDisposedException)
            {
                // Log writer was disposed, ignore
            }
        }
    }

    public override async ValueTask BeforeHttpRequest(HttpRequestMessage requestMessage,
        CancellationToken cancellationToken)
    {
        if (_disposed) return;

        try
        {
            requestMessage.Headers.TryGetValues("X-Correlation-ID", out var values);
            var requestId = values?.FirstOrDefault() ?? "";

            // Skip if we've already processed this request ID
            if (!_processedRequests.TryAdd(requestId, 1)) return;

            var sb = new StringBuilder();
            sb.AppendLine($"=== Telnyx API Request [{requestId}]===");
            sb.AppendLine($"Method: {requestMessage.Method}");
            sb.AppendLine($"URL: {requestMessage.RequestUri}");

            // Log headers (excluding authorization)
            sb.AppendLine("Request Headers:");
            foreach (var header in requestMessage.Headers)
            {
                if (!header.Key.Equals("Authorization", StringComparison.OrdinalIgnoreCase))
                {
                    sb.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");
                }
            }

            if (requestMessage.Content != null)
            {
                foreach (var header in requestMessage.Content.Headers)
                {
                    sb.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");
                }

                // Log raw request body
                var content = await requestMessage.Content.ReadAsStringAsync(cancellationToken);
                if (!string.IsNullOrEmpty(content))
                {
                    sb.AppendLine("Request Body:");
                    sb.AppendLine(content);
                }
            }

            LogMessage(sb.ToString());
        }
        catch (Exception ex)
        {
            LogMessage($"Error logging request: {ex}");
        }
    }

    public override async ValueTask AfterHttpRequest(HttpResponseMessage responseMessage,
        CancellationToken cancellationToken)
    {
        if (_disposed) return;

        try
        {
            var requestId = "";
            if (responseMessage.RequestMessage != null)
            {
                responseMessage.RequestMessage.Headers.TryGetValues("X-Correlation-ID", out var values);
                requestId = values?.FirstOrDefault() ?? "";
            }

            // Skip if we've already processed this response ID
            if (!_processedResponses.TryAdd(requestId, 1)) return;

            var sb = new StringBuilder();
            sb.AppendLine($"=== Telnyx API Response [{requestId}]===");
            sb.AppendLine($"Status Code: {(int)responseMessage.StatusCode} {responseMessage.StatusCode}");
            sb.AppendLine($"Reason: {responseMessage.ReasonPhrase}");

            // Log response headers
            sb.AppendLine("Response Headers:");
            foreach (var header in responseMessage.Headers)
            {
                sb.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");
            }

            foreach (var header in responseMessage.Content.Headers)
            {
                sb.AppendLine($"{header.Key}: {string.Join(", ", header.Value)}");
            }

            // Log raw response body
            var content = await responseMessage.Content.ReadAsStringAsync(cancellationToken);
            if (!string.IsNullOrEmpty(content))
            {
                sb.AppendLine("Response Body:");
                sb.AppendLine(content);
            }

            LogMessage(sb.ToString());
        }
        catch (Exception ex)
        {
            LogMessage($"Error logging response: {ex}");
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        _disposed = true;
        try
        {
            lock (_logLock)
            {
                _logWriter?.Flush();
            }
        }
        catch
        {
            // Ignore disposal errors
        }

        // Clear the tracking collections
        _processedRequests.Clear();
        _processedResponses.Clear();
    }
}