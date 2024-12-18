using System.Text.Json.Serialization;

namespace Telnyx.NET.Models;

/// <summary>
/// Configuration options for integrating Dialogflow in a Telnyx call.
/// This class allows the customization of Dialogflow AI interactions,
/// such as sentiment analysis and partial automated agent replies during the call.
/// </summary>
public class DialDialogflowConfig
{
    /// <summary>
    /// Specifies whether sentiment analysis should be enabled during the call.
    /// When enabled, Dialogflow will analyze the sentiment of the spoken words.
    /// </summary>
    [JsonPropertyName("analyze_sentiment")]
    public bool? AnalyzeSentiment { get; set; }

    /// <summary>
    /// Specifies whether partial replies from Dialogflow's automated agent 
    /// should be sent during the call. 
    /// When enabled, responses will be delivered in real-time as Dialogflow processes them.
    /// </summary>
    [JsonPropertyName("partial_automated_agent_reply")]
    public bool? PartialAutomatedAgentReply { get; set; }
}