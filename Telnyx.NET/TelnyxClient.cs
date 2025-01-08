using Polly;
using Polly.RateLimit;
using RestSharp;
using RestSharp.Authenticators;
using Telnyx.NET.Base;
using Telnyx.NET.Messaging;
using Telnyx.NET.Messaging.Interfaces;

namespace Telnyx.NET;

public class TelnyxClient : BaseOperations, ITelnyxClient
{
    private static readonly string DefaultLogPath = Path.Combine(Path.GetTempPath(), "TelnyxSDK", "logs");
    private readonly StreamWriter? _logWriter;
    private readonly FileStream? _logFileStream;

    // Lazy-loaded API sections
    private readonly Lazy<ISmsMmsOperations> _smsmms;
    private readonly Lazy<ITollFreeOperations> _tollFreeVerification;
    private readonly Lazy<ITenDlcOperations> _tenDlc;

    // Public properties
    public ISmsMmsOperations SmsMms => _smsmms.Value;
    public ITollFreeOperations TollFreeVerification => _tollFreeVerification.Value;
    public ITenDlcOperations TenDlcOperations => _tenDlc.Value;

    public TelnyxClient(string apiKey)
    {
        var options = new RestClientOptions("https://api.telnyx.com/v2/")
        {
            Authenticator = new JwtAuthenticator(apiKey),
            ThrowOnDeserializationError = false,
            ThrowOnAnyError = false,
        };

        const bool debugMode = false;
        if (debugMode)
        {
            Directory.CreateDirectory(DefaultLogPath);
            var logFileName = $"telnyx-debug-{DateTime.Now:yyyy-MM-dd}.log";
            var logFilePath = Path.Combine(DefaultLogPath, logFileName);

            _logFileStream = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.Read);
            _logWriter = new StreamWriter(_logFileStream) { AutoFlush = true };

            _logWriter.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] TelnyxSDK Debug Log File: {logFilePath}");
            _logWriter.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] Session Started: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

            options.Interceptors = [new TelnyxAsyncLoggingInterceptor(_logWriter)];
            options.ThrowOnAnyError = debugMode;
            options.ThrowOnDeserializationError = debugMode;
        }

        var rateLimitRetryPolicy = Policy
            .Handle<RateLimitRejectedException>()
            .WaitAndRetryAsync(
                retryCount: 3,
                sleepDurationProvider: (attempt, exception, context) =>
                {
                    var ex = exception as RateLimitRejectedException;
                    return ex?.RetryAfter ?? TimeSpan.FromSeconds(1);
                },
                onRetryAsync: (exception, timeSpan, attempt, context) => Task.CompletedTask);

        // Initialize base with configured options
        base.Client = new RestClient(options);
        base.RateLimitRetryPolicy = rateLimitRetryPolicy;

        // Initialize lazy-loaded sections
        _smsmms = new Lazy<ISmsMmsOperations>(() =>
            new SmsMmsOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _tollFreeVerification = new Lazy<ITollFreeOperations>(() =>
            new TollFreeOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

         _tenDlc = new Lazy<ITenDlcOperations>(() =>
            new TenDlcOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);
    }

    public void Dispose()
    {
        // Dispose any initialized components
        if (_smsmms.IsValueCreated && _smsmms.Value is IDisposable disposableSmsMms)
        {
            disposableSmsMms.Dispose();
        }
        if (_tollFreeVerification.IsValueCreated && _tollFreeVerification.Value is IDisposable disposableTollFreeVerification)
        {
            disposableTollFreeVerification.Dispose();
        }
        if (_tenDlc.IsValueCreated && _tenDlc.Value is IDisposable disposableTenDlc)
        {
            disposableTenDlc.Dispose();
        }

        _logWriter?.Dispose();
        _logFileStream?.Dispose();
        Client?.Dispose();
        GC.SuppressFinalize(this);
    }
}