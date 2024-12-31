using System.Text.Json.Serialization;

namespace Telnyx.NET.Models.Events;

public class TranscriptionData
{
    [JsonPropertyName("confidence")]
    public double Confidence { get; set; }

    [JsonPropertyName("is_final")]
    public bool IsFinal { get; set; }

    [JsonPropertyName("transcript")]
    public string Transcript { get; set; }
}