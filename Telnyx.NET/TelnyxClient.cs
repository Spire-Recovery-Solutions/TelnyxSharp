using Polly;
using Polly.RateLimit;
using RestSharp;
using RestSharp.Authenticators;
using Telnyx.NET.Base;
using Telnyx.NET.Identity.Interfaces;
using Telnyx.NET.Identity.Operations.NumberLookup;
using Telnyx.NET.Messaging.Interfaces;
using Telnyx.NET.Messaging.Operations.SmsMms;
using Telnyx.NET.Messaging.Operations.TenDlc;
using Telnyx.NET.Messaging.Operations.TollFreeVerification;
using Telnyx.NET.Numbers.Interfaces;
using Telnyx.NET.Numbers.Operations.Numbers.ChannelZones;
using Telnyx.NET.Numbers.Operations.Numbers.InboundChannels;
using Telnyx.NET.Numbers.Operations.Numbers.NumberPortout;
using Telnyx.NET.Numbers.Operations.Numbers.PhoneNumbers;
using Telnyx.NET.Numbers.Operations.Numbers.Voicemail;
using Telnyx.NET.Voice.Interfaces;
using Telnyx.NET.Voice.Operations.ProgrammableVoice;

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
    private readonly Lazy<ILookUpNumberOperations> _lookUpNumberOperations;
    private readonly Lazy<IPhoneNumberOperations> _phoneNumberOperations;
    private readonly Lazy<IProgrammableVoiceOperations> _programmableVoiceOperations;
    private readonly Lazy<IVoicemailOperations> _voicemailOperations;
    private readonly Lazy<IChannelZonesOperations> _channelZones;
    private readonly Lazy<IInboundChannelsOperations> _inboundChannels;
    private readonly Lazy<INumberPortoutOperations> _numberPortout;

    // Public properties
    public ISmsMmsOperations SmsMms => _smsmms.Value;
    public ITollFreeOperations TollFreeVerification => _tollFreeVerification.Value;
    public ITenDlcOperations TenDlc => _tenDlc.Value;
    public ILookUpNumberOperations LookUpNumber => _lookUpNumberOperations.Value;
    public IPhoneNumberOperations PhoneNumbers => _phoneNumberOperations.Value;
    public IProgrammableVoiceOperations ProgrammableVoice => _programmableVoiceOperations.Value;
    public IVoicemailOperations Voicemail => _voicemailOperations.Value;
    public IChannelZonesOperations ChannelZones => _channelZones.Value;
    public IInboundChannelsOperations InboundChannels => _inboundChannels.Value;
    public INumberPortoutOperations NumberPortout => _numberPortout.Value;


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

        // Initialize base with configured optionsQ
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

        _lookUpNumberOperations = new Lazy<ILookUpNumberOperations>(() =>
           new LookUpNumberOperations(Client, RateLimitRetryPolicy),
           LazyThreadSafetyMode.ExecutionAndPublication);

        _phoneNumberOperations = new Lazy<IPhoneNumberOperations>(() =>
            new PhoneNumberOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _programmableVoiceOperations = new Lazy<IProgrammableVoiceOperations>(() =>
            new ProgrammableVoiceOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _voicemailOperations = new Lazy<IVoicemailOperations>(() =>
            new VoicemailOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _channelZones = new Lazy<IChannelZonesOperations>(() =>
            new ChannelZonesOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _inboundChannels = new Lazy<IInboundChannelsOperations>(() =>
            new InboundChannelsOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _numberPortout = new Lazy<INumberPortoutOperations>(() =>
            new NumberPortoutOperations(Client, RateLimitRetryPolicy),
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
        if (_lookUpNumberOperations.IsValueCreated && _lookUpNumberOperations.Value is IDisposable disposableLookUpNumber)
        {
            disposableLookUpNumber.Dispose();
        }
        if (_phoneNumberOperations.IsValueCreated && _phoneNumberOperations.Value is IDisposable disposablePhoneNumberOperations)
        {
            disposablePhoneNumberOperations.Dispose();
        }
        if (_programmableVoiceOperations.IsValueCreated && _programmableVoiceOperations.Value is IDisposable disposableProgrammableVoice)
        {
            disposableProgrammableVoice.Dispose();
        }
        if (_voicemailOperations.IsValueCreated && _voicemailOperations.Value is IDisposable disposableVoicemail)
        {
            disposableVoicemail.Dispose();
        }
        if (_channelZones.IsValueCreated && _channelZones.Value is IDisposable disposableChannelZones)
        {
            disposableChannelZones.Dispose();
        }
        if (_inboundChannels.IsValueCreated && _inboundChannels.Value is IDisposable disposableInboundChannels)
        {
            disposableInboundChannels.Dispose();
        }
        if (_numberPortout.IsValueCreated && _numberPortout.Value is IDisposable disposableNumberPortout)
        {
            disposableNumberPortout.Dispose();
        }

        _logWriter?.Dispose();
        _logFileStream?.Dispose();
        Client?.Dispose();
        GC.SuppressFinalize(this);
    }
}