using Microsoft.JSInterop;
using TelnyxSharp.Components.BlazorWebRTC.Models;

namespace TelnyxSharp.Components.BlazorWebRTC.Services;

/// <summary>
/// JavaScript interop wrapper for Telnyx SDK
/// </summary>
internal class TelnyxJsInterop
{
    private readonly IJSRuntime _jsRuntime;

    public TelnyxJsInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task<bool> CreateClientAsync(string clientId, TelnyxClientOptions options,
        DotNetObjectReference<TelnyxService> dotNetRef)
    {
        return await _jsRuntime.InvokeAsync<bool>("TelnyxBlazor.createClient", clientId, options, dotNetRef);
    }

    public async Task ConnectAsync(string clientId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.connect", clientId);
    }

    public async Task DisconnectAsync(string clientId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.disconnect", clientId);
    }

    public async Task<bool> IsConnectedAsync(string clientId)
    {
        return await _jsRuntime.InvokeAsync<bool>("TelnyxBlazor.isConnected", clientId);
    }

    public async Task<CallState> NewCallAsync(string clientId, CallOptions options)
    {
        return await _jsRuntime.InvokeAsync<CallState>("TelnyxBlazor.newCall", clientId, options);
    }

    public async Task AnswerCallAsync(string callId, object? options)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.answerCall", callId, options);
    }

    public async Task HangupCallAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.hangupCall", callId);
    }

    public async Task HoldCallAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.holdCall", callId);
    }

    public async Task UnholdCallAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.unholdCall", callId);
    }

    public async Task ToggleHoldAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.toggleHold", callId);
    }

    public async Task MuteAudioAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.muteAudio", callId);
    }

    public async Task UnmuteAudioAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.unmuteAudio", callId);
    }

    public async Task ToggleAudioMuteAsync(string callId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.toggleAudioMute", callId);
    }

    public async Task SendDTMFAsync(string callId, string digit)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.sendDTMF", callId, digit);
    }

    public async Task<List<MediaDeviceInfo>> GetDevicesAsync(string clientId)
    {
        return await _jsRuntime.InvokeAsync<List<MediaDeviceInfo>>("TelnyxBlazor.getDevices", clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetAudioInDevicesAsync(string clientId)
    {
        return await _jsRuntime.InvokeAsync<List<MediaDeviceInfo>>("TelnyxBlazor.getAudioInDevices", clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetAudioOutDevicesAsync(string clientId)
    {
        return await _jsRuntime.InvokeAsync<List<MediaDeviceInfo>>("TelnyxBlazor.getAudioOutDevices", clientId);
    }

    public async Task<List<MediaDeviceInfo>> GetVideoDevicesAsync(string clientId)
    {
        return await _jsRuntime.InvokeAsync<List<MediaDeviceInfo>>("TelnyxBlazor.getVideoDevices", clientId);
    }

    public async Task SetLocalElementAsync(string clientId, string elementId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.setLocalElement", clientId, elementId);
    }

    public async Task SetRemoteElementAsync(string clientId, string elementId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.setRemoteElement", clientId, elementId);
    }

    public async Task<bool> CheckPermissionsAsync(string clientId, bool audio, bool video)
    {
        return await _jsRuntime.InvokeAsync<bool>("TelnyxBlazor.checkPermissions", clientId, audio, video);
    }

    public async Task DisposeAsync(string clientId)
    {
        await _jsRuntime.InvokeVoidAsync("TelnyxBlazor.dispose", clientId);
    }
}