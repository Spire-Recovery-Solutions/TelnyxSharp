using System.Text.Json.Serialization;

namespace Telnyx.NET.Voice.Models.CallCommands.Requests;

/// <summary>
/// Configuration settings for answering machine detection (AMD) analysis.
/// These parameters control the detection timing and silence thresholds used
/// to determine whether an answering machine or a human answered the call.
/// Default values for each parameter are specified.
/// </summary>
public class AnsweringMachineDetectionConfig
{
    /// <summary>
    /// Total time (in milliseconds) allowed for analysis of the call audio. 
    /// Default value: 3500.
    /// </summary>
    [JsonPropertyName("total_analysis_time_millis")]
    public int? TotalAnalysisTimeMillis { get; set; }

    /// <summary>
    /// Duration of silence (in milliseconds) after a greeting before AMD analysis concludes. 
    /// Default value: 800.
    /// </summary>
    [JsonPropertyName("after_greeting_silence_millis")]
    public int? AfterGreetingSilenceMillis { get; set; }

    /// <summary>
    /// Maximum allowable silence duration (in milliseconds) between spoken words during greeting analysis. 
    /// Default value: 50.
    /// </summary>
    [JsonPropertyName("between_words_silence_millis")]
    public int? BetweenWordsSilenceMillis { get; set; }

    /// <summary>
    /// Maximum duration (in milliseconds) of the greeting that AMD will analyze. 
    /// Default value: 3500.
    /// </summary>
    [JsonPropertyName("greeting_duration_millis")]
    public int? GreetingDurationMillis { get; set; }

    /// <summary>
    /// Duration of silence (in milliseconds) at the beginning of the call before audio starts. 
    /// Default value: 3500.
    /// </summary>
    [JsonPropertyName("initial_silence_millis")]
    public int? InitialSilenceMillis { get; set; }

    /// <summary>
    /// Maximum number of words that AMD will process during the call. 
    /// Default value: 5.
    /// </summary>
    [JsonPropertyName("maximum_number_of_words")]
    public int? MaximumNumberOfWords { get; set; }

    /// <summary>
    /// Maximum allowable length (in milliseconds) for each word during the greeting. 
    /// Default value: 3500.
    /// </summary>
    [JsonPropertyName("maximum_word_length_millis")]
    public int? MaximumWordLengthMillis { get; set; }

    /// <summary>
    /// Threshold for detecting silence. Used to determine when silence is sufficient to trigger further analysis. 
    /// Default value: 256.
    /// </summary>
    [JsonPropertyName("silence_threshold")]
    public int? SilenceThreshold { get; set; }

    /// <summary>
    /// Total analysis time (in milliseconds) for detecting the greeting. 
    /// Default value: 5000.
    /// </summary>
    [JsonPropertyName("greeting_total_analysis_time_millis")]
    public int? GreetingTotalAnalysisTimeMillis { get; set; }

    /// <summary>
    /// Duration of silence (in milliseconds) during the greeting that will trigger detection conclusions. 
    /// Default value: 1500.
    /// </summary>
    [JsonPropertyName("greeting_silence_duration_millis")]
    public int? GreetingSilenceDurationMillis { get; set; }
}