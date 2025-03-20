using Polly;
using Polly.RateLimit;
using RestSharp;
using RestSharp.Authenticators;
using TelnyxSharp.Base;
using TelnyxSharp.CdrReports.Interfaces;
using TelnyxSharp.CdrReports.Operations;
using TelnyxSharp.DetailRecords.Interfaces;
using TelnyxSharp.DetailRecords.Operations;
using TelnyxSharp.Identity.Interfaces;
using TelnyxSharp.Identity.Operations.NumberLookup;
using TelnyxSharp.Messaging.Interfaces;
using TelnyxSharp.Messaging.Operations.SmsMms;
using TelnyxSharp.Messaging.Operations.TenDlc;
using TelnyxSharp.Messaging.Operations.TollFreeVerification;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Operations.Numbers.ChannelZones;
using TelnyxSharp.Numbers.Operations.Numbers.Documents;
using TelnyxSharp.Numbers.Operations.Numbers.InboundChannels;
using TelnyxSharp.Numbers.Operations.Numbers.NumberPortout;
using TelnyxSharp.Numbers.Operations.Numbers.PhoneNumberPorting;
using TelnyxSharp.Numbers.Operations.Numbers.PhoneNumbers;
using TelnyxSharp.Numbers.Operations.Numbers.PortingOrder;
using TelnyxSharp.Numbers.Operations.Numbers.Voicemail;
using TelnyxSharp.Voice.Interfaces;
using TelnyxSharp.Voice.Operations.ProgrammableVoice;

namespace TelnyxSharp;

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
    private readonly Lazy<IPhoneNumberPortingOperations> _phoneNumberPorting;
    private readonly Lazy<IDocumentsOperations> _documents;
    private readonly Lazy<IPortingOrderOperations> _portingOrder;
    private readonly Lazy<IDetailRecordsOperations> _detailRecordsSearch;
    private readonly Lazy<ICdrRequestsOperations> _cdrRequests;

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
    public IPhoneNumberPortingOperations PhoneNumberOrders => _phoneNumberPorting.Value;
    public IDocumentsOperations Documents => _documents.Value;
    public IPortingOrderOperations PortingOrder => _portingOrder.Value;
    public IDetailRecordsOperations DetailRecordsSearch => _detailRecordsSearch.Value;
    public ICdrRequestsOperations CdrRequests => _cdrRequests.Value;

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

        _phoneNumberPorting = new Lazy<IPhoneNumberPortingOperations>(() =>
            new PhoneNumberPortingOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _documents = new Lazy<IDocumentsOperations>(() =>
            new DocumentsOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _portingOrder = new Lazy<IPortingOrderOperations>(() =>
            new PortingOrderOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _detailRecordsSearch = new Lazy<IDetailRecordsOperations>(() =>
            new DetailRecordsOperations(Client, RateLimitRetryPolicy),
            LazyThreadSafetyMode.ExecutionAndPublication);

        _cdrRequests = new Lazy<ICdrRequestsOperations>(() =>
            new CdrRequestsOperations(Client, RateLimitRetryPolicy),
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
        if (_phoneNumberPorting.IsValueCreated && _phoneNumberPorting.Value is IDisposable disposablePhoneNumberPorting)
        {
            disposablePhoneNumberPorting.Dispose();
        }
        if (_documents.IsValueCreated && _documents.Value is IDisposable disposableDocuments)
        {
            disposableDocuments.Dispose();
        }
        if (_portingOrder.IsValueCreated && _portingOrder.Value is IDisposable disposablePortingOrder)
        {
            disposablePortingOrder.Dispose();

        }
        if (_detailRecordsSearch.IsValueCreated && _detailRecordsSearch.Value is IDisposable disposableDetailRecordsSearch)
        {
            disposableDetailRecordsSearch.Dispose();
        }
        if (_cdrRequests.IsValueCreated && _cdrRequests.Value is IDisposable disposableCdrRequests)
        {
            disposableCdrRequests.Dispose();
        }

        _logWriter?.Dispose();
        _logFileStream?.Dispose();
        Client?.Dispose();
        GC.SuppressFinalize(this);
    }
}