using Microsoft.AspNetCore.Components;
using TelnyxSharp.Components.BlazorWebRTC.Models;
using TelnyxSharp.Components.BlazorWebRTC.Services;

namespace TelnyxSharp.Components.BlazorWebRTC.Components;


/// <summary>
/// Telnyx RTC component for making and receiving calls
/// </summary>
public partial class TelnyxRTC : ComponentBase
{
    /// <summary>
    /// Gets the current service instance
    /// </summary>
    public ITelnyxService? Service => _telnyxService;

    /// <summary>
    /// Gets whether the client is connected
    /// </summary>
    public bool IsConnected => _telnyxService?.IsConnected ?? false;

    /// <summary>
    /// Gets the current call state
    /// </summary>
    public CallState? CurrentCallState => CurrentCall;
}