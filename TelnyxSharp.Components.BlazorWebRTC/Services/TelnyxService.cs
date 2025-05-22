using System.Text.Json;
using Microsoft.JSInterop;
using TelnyxSharp.Components.BlazorWebRTC.Models;

namespace TelnyxSharp.Components.BlazorWebRTC.Services;

/// <summary>
/// Implementation of Telnyx WebRTC service
/// </summary>
public class TelnyxService : ITelnyxService
{
    private readonly IJSRuntime _jsRuntime;
    private readonly TelnyxJsInterop _jsInterop;
    private readonly string _clientId;
    private DotNetObjectReference<TelnyxService>? _dotNetRef;
    private bool _isInitialized;

    public event EventHandler? Ready;
    public event EventHandler<string>? Error;
    public event EventHandler<TelnyxNotification>? Notification;
    public event EventHandler? SocketOpen;
    public event EventHandler? SocketClose;

    public bool IsConnected { get; private set; }

    public TelnyxService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _jsInterop = new TelnyxJsInterop(jsRuntime);
        _clientId = Guid.NewGuid().ToString();
    }

    public async Task<bool> InitializeAsync(TelnyxClientOptions options)
    {
        if (_isInitialized)
        {
            throw new InvalidOperationException("Service is already initialized");
        }

        _dotNetRef = DotNetObjectReference.Create(this);
        _isInitialized = await _jsInterop.CreateClientAsync(_clientId, options, _dotNetRef);

        return _isInitialized;
    }

    public async Task ConnectAsync()
    {
        EnsureInitialized();
        await _jsInterop.ConnectAsync(_clientId);
    }

    public async Task DisconnectAsync()
    {
        if (!_isInitialized) return;

        await _jsInterop.DisconnectAsync(_clientId);
        IsConnected = false;
    }

    public async Task<CallState> NewCallAsync(CallOptions options)
    {
        EnsureInitialized();
        return await _jsInterop.NewCallAsync(_clientId, options);
    }

    public async Task AnswerCallAsync(string callId, object? options = null)
    {
        EnsureInitialized();
        await _jsInterop.AnswerCallAsync(callId, options);
    }

    public async Task HangupCallAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.HangupCallAsync(callId);
    }

    public async Task HoldCallAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.HoldCallAsync(callId);
    }

    public async Task UnholdCallAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.UnholdCallAsync(callId);
    }

    public async Task ToggleHoldAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.ToggleHoldAsync(callId);
    }

    public async Task MuteAudioAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.MuteAudioAsync(callId);
    }

    public async Task UnmuteAudioAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.UnmuteAudioAsync(callId);
    }

    public async Task ToggleAudioMuteAsync(string callId)
    {
        EnsureInitialized();
        await _jsInterop.ToggleAudioMuteAsync(callId);
    }

    public async Task SendDTMFAsync(string callId, string digit)
    {
        EnsureInitialized();
        await _jsInterop.SendDTMFAsync(callId, digit);
    }

    public async Task<List<MediaDeviceInfo>> GetDevicesAsync()
    {
        EnsureInitialized();
        return await _jsInterop.GetDevicesAsync(_clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetAudioInDevicesAsync()
    {
        EnsureInitialized();
        return await _jsInterop.GetAudioInDevicesAsync(_clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetAudioOutDevicesAsync()
    {
        EnsureInitialized();
        return await _jsInterop.GetAudioOutDevicesAsync(_clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetVideoDevicesAsync()
    {
        EnsureInitialized();
        return await _jsInterop.GetVideoDevicesAsync(_clientId);
    }

    public async Task SetLocalElementAsync(string elementId)
    {
        EnsureInitialized();
        await _jsInterop.SetLocalElementAsync(_clientId, elementId);
    }

    public async Task SetRemoteElementAsync(string elementId)
    {
        EnsureInitialized();
        await _jsInterop.SetRemoteElementAsync(_clientId, elementId);
    }

    public async Task<bool> CheckPermissionsAsync(bool audio = true, bool video = true)
    {
        EnsureInitialized();
        return await _jsInterop.CheckPermissionsAsync(_clientId, audio, video);
    }

    // JS Callback methods
    [JSInvokable]
    public void OnReady()
    {
        IsConnected = true;
        Ready?.Invoke(this, EventArgs.Empty);
    }

    [JSInvokable]
    public void OnError(string error)
    {
        Error?.Invoke(this, error);
    }

    [JSInvokable]
    public void OnNotification(string notificationJson)
    {
        try
        {
            var notification = JsonSerializer.Deserialize<TelnyxNotification>(notificationJson);
            if (notification != null)
            {
                Notification?.Invoke(this, notification);
            }
        }
        catch (Exception ex)
        {
            Error?.Invoke(this, $"Failed to parse notification: {ex.Message}");
        }
    }

    [JSInvokable]
    public void OnSocketOpen()
    {
        SocketOpen?.Invoke(this, EventArgs.Empty);
    }

    [JSInvokable]
    public void OnSocketClose()
    {
        IsConnected = false;
        SocketClose?.Invoke(this, EventArgs.Empty);
    }

    private void EnsureInitialized()
    {
        if (!_isInitialized)
        {
            throw new InvalidOperationException("Service is not initialized. Call InitializeAsync first.");
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_isInitialized)
        {
            await _jsInterop.DisposeAsync(_clientId);
        }

        _dotNetRef?.Dispose();
    }
}