using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder
{
    /// <summary>
    /// Represents the response returned when activating a porting order. 
    /// Inherits from TelnyxResponse and contains a PortingActivationJob object.
    /// </summary>
    public class ActivatePortingOrderResponse : TelnyxResponse<PortingActivationJob>
    {
    }

    /// <summary>
    /// Represents a Porting Activation Job, which contains the details of the activation process of a porting order.
    /// </summary>
    public class PortingActivationJob
    {
        /// <summary>
        /// Gets or sets the unique identifier for the porting activation job.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the status of the porting activation job.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the activation type of the porting job (e.g., immediate, scheduled).
        /// </summary>
        [JsonPropertyName("activation_type")]
        public string? ActivationType { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the porting activation will occur.
        /// </summary>
        [JsonPropertyName("activate_at")]
        public DateTimeOffset? ActivateAt { get; set; }

        /// <summary>
        /// Gets or sets the activation windows for the porting activation job, indicating the start and end times.
        /// </summary>
        [JsonPropertyName("activation_windows")]
        public List<ActivationWindow>? ActivationWindows { get; set; }

        /// <summary>
        /// Gets or sets the record type for the porting activation.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the porting activation job was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the porting activation job was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }

    /// <summary>
    /// Represents an activation window for the porting job, which contains the start and end times.
    /// </summary>
    public class ActivationWindow
    {
        /// <summary>
        /// Gets or sets the start time of the activation window.
        /// </summary>
        [JsonPropertyName("start_at")]
        public DateTimeOffset? StartAt { get; set; }

        /// <summary>
        /// Gets or sets the end time of the activation window.
        /// </summary>
        [JsonPropertyName("end_at")]
        public DateTimeOffset? EndAt { get; set; }
    }
}
