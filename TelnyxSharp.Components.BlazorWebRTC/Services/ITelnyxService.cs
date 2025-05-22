using TelnyxSharp.Components.BlazorWebRTC.Models;

namespace TelnyxSharp.Components.BlazorWebRTC.Services;

/// <summary>
/// Interface for Telnyx WebRTC service
/// </summary>
public interface ITelnyxService : IAsyncDisposable
{
    /// <summary>
    /// Event fired when the client is ready
    /// </summary>
    event EventHandler? Ready;

    /// <summary>
    /// Event fired when an error occurs
    /// </summary>
    event EventHandler<string>? Error;

    /// <summary>
    /// Event fired when a notification is received
    /// </summary>
    event EventHandler<TelnyxNotification>? Notification;

    /// <summary>
    /// Event fired when the socket connection opens
    /// </summary>
    event EventHandler? SocketOpen;

    /// <summary>
    /// Event fired when the socket connection closes
    /// </summary>
    event EventHandler? SocketClose;

    /// <summary>
    /// Gets whether the client is connected
    /// </summary>
    bool IsConnected { get; }

    /// <summary>
    /// Initialize the Telnyx client
    /// </summary>
    Task<bool> InitializeAsync(TelnyxClientOptions options);

    /// <summary>
    /// Connect to Telnyx
    /// </summary>
    Task ConnectAsync();

    /// <summary>
    /// Disconnect from Telnyx
    /// </summary>
    Task DisconnectAsync();

    /// <summary>
    /// Create a new call
    /// </summary>
    Task<CallState> NewCallAsync(CallOptions options);

    /// <summary>
    /// Answer an incoming call
    /// </summary>
    Task AnswerCallAsync(string callId, object? options = null);

    /// <summary>
    /// Hangup a call
    /// </summary>
    Task HangupCallAsync(string callId);

    /// <summary>
    /// Hold a call
    /// </summary>
    Task HoldCallAsync(string callId);

    /// <summary>
    /// Unhold a call
    /// </summary>
    Task UnholdCallAsync(string callId);

    /// <summary>
    /// Toggle hold state
    /// </summary>
    Task ToggleHoldAsync(string callId);

    /// <summary>
    /// Mute audio
    /// </summary>
    Task MuteAudioAsync(string callId);

    /// <summary>
    /// Unmute audio
    /// </summary>
    Task UnmuteAudioAsync(string callId);

    /// <summary>
    /// Toggle audio mute
    /// </summary>
    Task ToggleAudioMuteAsync(string callId);

    /// <summary>
    /// Send DTMF tone
    /// </summary>
    Task SendDTMFAsync(string callId, string digit);

    /// <summary>
    /// Get all media devices
    /// </summary>
    Task<List<MediaDeviceInfo>> GetDevicesAsync();

    /// <summary>
    /// Get audio input devices
    /// </summary>
    Task<List<MediaDeviceInfo>> GetAudioInDevicesAsync();

    /// <summary>
    /// Get audio output devices
    /// </summary>
    Task<List<MediaDeviceInfo>> GetAudioOutDevicesAsync();

    /// <summary>
    /// Get video devices
    /// </summary>
    Task<List<MediaDeviceInfo>> GetVideoDevicesAsync();

    /// <summary>
    /// Set local media element
    /// </summary>
    Task SetLocalElementAsync(string elementId);

    /// <summary>
    /// Set remote media element
    /// </summary>
    Task SetRemoteElementAsync(string elementId);

    /// <summary>
    /// Check media permissions
    /// </summary>
    Task<bool> CheckPermissionsAsync(bool audio = true, bool video = true);
}

public class MediaDeviceInfo
{
    public string DeviceId { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public string GroupId { get; set; } = string.Empty;
}