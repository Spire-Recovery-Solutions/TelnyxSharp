using Microsoft.Extensions.DependencyInjection;
using TelnyxSharp.Components.BlazorWebRTC.Services;

namespace TelnyxSharp.Components.BlazorWebRTC.Extensions;


/// <summary>
/// Extension methods for configuring Telnyx services
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Telnyx WebRTC services to the service collection
    /// </summary>
    public static IServiceCollection AddTelnyxRTC(this IServiceCollection services)
    {
        services.AddScoped<ITelnyxService, TelnyxService>();
        return services;
    }
}