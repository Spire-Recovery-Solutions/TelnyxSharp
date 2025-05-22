namespace TelnyxSharp.Components.BlazorWebRTC.Models;

/// <summary>
/// Represents the current state of a call
/// </summary>
public class CallState
{
    public string Id { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string PrevState { get; set; } = string.Empty;
    public string Direction { get; set; } = string.Empty;
    public bool IsActive => State == "active";
    public bool IsRinging => State == "ringing";
    public bool IsHeld => State == "held";
    public bool IsEnded => State == "hangup" || State == "destroy";
}