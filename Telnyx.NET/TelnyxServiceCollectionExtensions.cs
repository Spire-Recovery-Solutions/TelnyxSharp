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

                var rateLimitConfig = new TelnyxRateLimitConfiguration
                {
                    NumberLookups = options.RateLimits?.NumberLookups ?? 10,
                    NumberSearch = options.RateLimits?.NumberSearch ?? 5,
                    NumberOrders = options.RateLimits?.NumberOrders ?? 5,
                    PhoneNumbers = options.RateLimits?.PhoneNumbers ?? 10,
                    NumberReservations = options.RateLimits?.NumberReservations ?? 5,
                    PortNumbers = options.RateLimits?.PortNumbers ?? 5,
                    SendMessage = options.RateLimits?.SendMessage ?? 10,
                    Calls = options.RateLimits?.Calls ?? 10
                };

                // Validate API key
                 if (string.IsNullOrWhiteSpace(options.ApiKey))
                            throw new InvalidOperationException("Telnyx API Key is required");


                return new TelnyxClient(
                    options.ApiKey,
                    rateLimitConfig
                );
            });

            return services;
        }
    }
}
