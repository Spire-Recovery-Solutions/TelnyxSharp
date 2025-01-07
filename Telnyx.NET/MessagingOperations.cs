using Polly.Retry;
using RestSharp;

namespace Telnyx.NET;

public interface IMessagingOperations : IDisposable
{
    IMessagingProfileOperations Profiles { get; }
    ISmsOperations SMS { get; }
    IShortCodeOperations ShortCodes { get; }
    IMessagingUrlDomainOperations UrlDomains { get; }
}
public class MessagingOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IMessagingOperations
{
    private readonly Lazy<IMessagingProfileOperations> _profiles = new(() => 
            new MessagingProfileOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private readonly Lazy<ISmsOperations> _sms = new(() => 
            new SmsOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private readonly Lazy<IShortCodeOperations> _shortCodes = new(() => 
            new ShortCodeOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);
    private readonly Lazy<IMessagingUrlDomainOperations> _urlDomains = new(() => 
            new MessagingUrlDomainOperations(client, rateLimitRetryPolicy),
        LazyThreadSafetyMode.ExecutionAndPublication);

    public IMessagingProfileOperations Profiles => _profiles.Value;
    public ISmsOperations SMS => _sms.Value;
    public IShortCodeOperations ShortCodes => _shortCodes.Value;
    public IMessagingUrlDomainOperations UrlDomains => _urlDomains.Value;

    public void Dispose()
    {
        if (_profiles.IsValueCreated && _profiles.Value is IDisposable disposableProfiles)
            disposableProfiles.Dispose();

        if (_sms.IsValueCreated && _sms.Value is IDisposable disposableSms)
            disposableSms.Dispose();

        if (_shortCodes.IsValueCreated && _shortCodes.Value is IDisposable disposableShortCodes)
            disposableShortCodes.Dispose();

        if (_urlDomains.IsValueCreated && _urlDomains.Value is IDisposable disposableUrlDomains)
            disposableUrlDomains.Dispose();

        GC.SuppressFinalize(this);
    }
}