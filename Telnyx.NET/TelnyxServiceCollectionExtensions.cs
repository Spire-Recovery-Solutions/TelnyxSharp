using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Telnyx.NET.Interfaces;
using Telnyx.NET.Models;

namespace Telnyx.NET
{
    public static class TelnyxServiceCollectionExtensions
    {
        public static IServiceCollection AddTelnyxClient(
            this IServiceCollection services,
            Action<TelnyxClientOptions> configureOptions)
        {
            services.Configure(configureOptions);

            services.AddSingleton<ITelnyxClient>(provider =>
            {
                var options = provider.GetRequiredService<IOptions<TelnyxClientOptions>>().Value;
                
                // Validate API key
                 if (string.IsNullOrWhiteSpace(options.ApiKey))
                            throw new InvalidOperationException("Telnyx API Key is required");

                return new TelnyxClient(
                    options.ApiKey
                );
            });

            return services;
        }
    }
}
