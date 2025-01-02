using System.Text;
using RestSharp.Interceptors;

namespace Telnyx.NET;

public class TelnyxLoggingInterceptor(StreamWriter logWriter) : Interceptor, IDisposable
{
    private readonly Lock _logLock = new();
    private bool _disposed;

    private void LogMessage(string message)
    {
        if (_disposed) return;

        lock (_logLock)
        {
            try
            {
                logWriter.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {message}");
                logWriter.Flush(); // Ensure writes are flushed
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
            var sb = new StringBuilder();
            sb.AppendLine("=== Telnyx API Request ===");
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
                sb.AppendLine("Request Body:");
                sb.AppendLine(content);
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
            var sb = new StringBuilder();
            sb.AppendLine("=== Telnyx API Response ===");
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
            sb.AppendLine("Response Body:");
            sb.AppendLine(content);

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
                logWriter?.Flush();
            }
        }
        catch
        {
            // Ignore disposal errors
        }
    }
}