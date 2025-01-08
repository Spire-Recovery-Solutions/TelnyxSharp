using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Telnyx.NET.Base;
using Telnyx.NET.Models;

namespace Telnyx.NET
{
    /// <summary>
    /// Extension methods for registering Telnyx client services in the <see cref="IServiceCollection"/>.
    /// </summary>
    public static class TelnyxServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the Telnyx client to the service collection and configures it with the provided options.
        /// This method ensures that the Telnyx client is available for dependency injection throughout the application.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to add the services to.</param>
        /// <param name="configureOptions">Action to configure the Telnyx client options.</param>
        /// <returns>The updated <see cref="IServiceCollection"/> for fluent configuration.</returns>
        public static IServiceCollection AddTelnyxClient(
            this IServiceCollection services,
            Action<TelnyxClientOptions> configureOptions)
        {
            // Configure the TelnyxClientOptions from the provided action
            services.Configure(configureOptions);

            // Add the TelnyxClient as a singleton service implementing ITelnyxClient
            services.AddSingleton<ITelnyxClient>(provider =>
            {
                // Retrieve the configured options from DI container
                var options = provider.GetRequiredService<IOptions<TelnyxClientOptions>>().Value;

                // Validate API key
                if (string.IsNullOrWhiteSpace(options.ApiKey))
                    throw new InvalidOperationException("Telnyx API Key is required");

                // Return a new instance of TelnyxClient with the provided API key
                return new TelnyxClient(
                    options.ApiKey
                );
            });

            return services;
        }
    }
}