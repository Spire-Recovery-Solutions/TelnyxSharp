using RestSharp.Interceptors;
using System.Collections.Concurrent;
using System.Text;

namespace Telnyx.NET
{
    /// <summary>
    /// Interceptor for asynchronously logging Telnyx API requests and responses.
    /// Logs request and response details (headers, body, status) to a specified log writer.
    /// The logging is performed asynchronously in the background to avoid blocking API calls.
    /// </summary>
    public class TelnyxAsyncLoggingInterceptor : Interceptor, IDisposable
    {
        private readonly StreamWriter _logWriter;
        private readonly ConcurrentQueue<string> _logQueue;
        private readonly CancellationTokenSource _cancellationSource;
        private readonly Task _processTask;
        private readonly TimeSpan _flushInterval;
        private bool _disposed;

        // Track processed requests/responses to avoid duplicates
        private readonly ConcurrentDictionary<string, byte> _processedRequests;
        private readonly ConcurrentDictionary<string, byte> _processedResponses;

        /// <summary>
        /// Initializes the interceptor with a log writer and an optional flush interval.
        /// </summary>
        /// <param name="logWriter">The <see cref="StreamWriter"/> where the log entries will be written.</param>
        /// <param name="flushInterval">The interval at which the logs are flushed to the writer. Defaults to 1 second if not provided.</param>
        public TelnyxAsyncLoggingInterceptor(StreamWriter logWriter, TimeSpan? flushInterval = null)
        {
            _logWriter = logWriter ?? throw new ArgumentNullException(nameof(logWriter));
            _logQueue = new ConcurrentQueue<string>();
            _cancellationSource = new CancellationTokenSource();
            _flushInterval = flushInterval ?? TimeSpan.FromSeconds(1);
            _processedRequests = new ConcurrentDictionary<string, byte>();
            _processedResponses = new ConcurrentDictionary<string, byte>();

            // Start background processing task
            _processTask = ProcessLogsAsync(_cancellationSource.Token);
        }

        /// <summary>
        /// Processes and flushes queued log entries asynchronously.
        /// Logs are written to the <see cref="StreamWriter"/> at regular intervals.
        /// </summary>
        private async Task ProcessLogsAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    // Process all currently queued messages
                    while (_logQueue.TryDequeue(out var message))
                    {
                        await _logWriter.WriteLineAsync(message);
                    }

                    await _logWriter.FlushAsync(cancellationToken);
                    await Task.Delay(_flushInterval, cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    // Log processing error - in a production environment, 
                    // you might want to emit this to a different error log
                    try
                    {
                        await _logWriter.WriteLineAsync($"Error processing logs: {ex}");
                        await _logWriter.FlushAsync(cancellationToken);
                    }
                    catch
                    {
                        // Ignore errors during error logging
                    }
                }
            }

            // Final flush on shutdown
            try
            {
                while (_logQueue.TryDequeue(out var message))
                {
                    await _logWriter.WriteLineAsync(message);
                }
                await _logWriter.FlushAsync(cancellationToken);
            }
            catch
            {
                // Ignore errors during shutdown
            }
        }

        /// <summary>
        /// Adds a log message to the queue, with a timestamp.
        /// </summary>
        private void EnqueueMessage(string message)
        {
            if (!_disposed)
            {
                _logQueue.Enqueue($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] {message}");
            }
        }

        /// <summary>
        /// Called before an HTTP request is sent. Logs the request details.
        /// </summary>
        /// <param name="requestMessage">The <see cref="HttpRequestMessage"/> to be sent.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
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

                EnqueueMessage(sb.ToString());
            }
            catch (Exception ex)
            {
                EnqueueMessage($"Error logging request: {ex}");
            }
        }

        /// <summary>
        /// Called after an HTTP request has completed. Logs the response details.
        /// </summary>
        /// <param name="responseMessage">The <see cref="HttpResponseMessage"/> received.</param>
        /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
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

                EnqueueMessage(sb.ToString());
            }
            catch (Exception ex)
            {
                EnqueueMessage($"Error logging response: {ex}");
            }
        }

        /// <summary>
        /// Disposes of the interceptor, ensuring that the background task and resources are properly cleaned up.
        /// </summary>
        public void Dispose()
        {
            if (_disposed) return;

            _disposed = true;

            try
            {
                // Signal the processing task to stop
                _cancellationSource.Cancel();

                // Wait for the processing task to complete (with timeout)
                if (!_processTask.Wait(TimeSpan.FromSeconds(5)))
                {
                    // If task didn't complete in time, force a final flush
                    while (_logQueue.TryDequeue(out var message))
                    {
                        _logWriter.WriteLine(message);
                    }
                    _logWriter.Flush();
                }
            }
            catch
            {
                // If async wait failed, attempt one final synchronous flush
                try
                {
                    while (_logQueue.TryDequeue(out var message))
                    {
                        _logWriter.WriteLine(message);
                    }
                    _logWriter.Flush();
                }
                catch
                {
                    // Ignore final flush errors
                }
            }
            finally
            {
                _cancellationSource.Dispose();

                // Clear the tracking collections
                _processedRequests.Clear();
                _processedResponses.Clear();

                // Clear any remaining items in queue (should be empty at this point)
                while (_logQueue.TryDequeue(out _)) { }
            }
        }
    }
}