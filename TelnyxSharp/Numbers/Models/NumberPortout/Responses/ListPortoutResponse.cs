using System.Text.Json.Serialization;
using TelnyxSharp.Models;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Responses
{
    /// <summary>
    /// Represents the response containing a list of portout data objects.
    /// </summary>
    public class ListPortoutResponse : TelnyxResponse<List<PortoutData>>
    {
        // This class inherits from TelnyxResponse<List<PortoutData>>, encapsulating the list of portout data objects.
    }

    /// <summary>
    /// Represents an individual portout data object.
    /// This object contains details about a portout request, including phone numbers, carrier information, user details, and timestamps.
    /// </summary>
    public class PortoutData
    {
        /// <summary>
        /// Gets or sets the unique identifier for the portout data.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the record type associated with the portout data.
        /// </summary>
        [JsonPropertyName("record_type")]
        public string? RecordType { get; set; }

        /// <summary>
        /// Gets or sets the list of phone numbers involved in the portout.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or sets the authorized name for the portout request.
        /// </summary>
        [JsonPropertyName("authorized_name")]
        public string? AuthorizedName { get; set; }

        /// <summary>
        /// Gets or sets the name of the carrier initiating the portout.
        /// </summary>
        [JsonPropertyName("carrier_name")]
        public string? CarrierName { get; set; }

        /// <summary>
        /// Gets or sets the current carrier for the phone numbers being ported.
        /// </summary>
        [JsonPropertyName("current_carrier")]
        public string? CurrentCarrier { get; set; }

        /// <summary>
        /// Gets or sets the end user's name associated with the portout request.
        /// </summary>
        [JsonPropertyName("end_user_name")]
        public string? EndUserName { get; set; }

        /// <summary>
        /// Gets or sets the city of the user associated with the portout.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Gets or sets the state of the user associated with the portout.
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Gets or sets the zip code of the user associated with the portout.
        /// </summary>
        [JsonPropertyName("zip")]
        public string? Zip { get; set; }

        /// <summary>
        /// Gets or sets the list of LSR (Local Service Request) IDs associated with the portout.
        /// </summary>
        [JsonPropertyName("lsr")]
        public List<string>? Lsr { get; set; }

        /// <summary>
        /// Gets or sets the PON (Port Order Number) associated with the portout.
        /// </summary>
        [JsonPropertyName("pon")]
        public string? Pon { get; set; }

        /// <summary>
        /// Gets or sets the reason for the portout request.
        /// </summary>
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Gets or sets the rejection code for the portout, if applicable.
        /// </summary>
        [JsonPropertyName("rejection_code")]
        public int? RejectionCode { get; set; }

        /// <summary>
        /// Gets or sets the service address associated with the portout.
        /// </summary>
        [JsonPropertyName("service_address")]
        public string? ServiceAddress { get; set; }

        /// <summary>
        /// Gets or sets the FOC (Firm Order Commitment) date for the portout.
        /// </summary>
        [JsonPropertyName("foc_date")]
        public string? FocDate { get; set; }

        /// <summary>
        /// Gets or sets the requested FOC date for the portout.
        /// </summary>
        [JsonPropertyName("requested_foc_date")]
        public string? RequestedFocDate { get; set; }

        /// <summary>
        /// Gets or sets the SPID (Service Profile Identifier) for the portout.
        /// </summary>
        [JsonPropertyName("spid")]
        public string? Spid { get; set; }

        /// <summary>
        /// Gets or sets the support key for the portout.
        /// </summary>
        [JsonPropertyName("support_key")]
        public string? SupportKey { get; set; }

        /// <summary>
        /// Gets or sets the current status of the portout.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the portout request has already been processed (ported).
        /// </summary>
        [JsonPropertyName("already_ported")]
        public bool? AlreadyPorted { get; set; }

        /// <summary>
        /// Gets or sets the user ID associated with the portout request.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Gets or sets the vendor associated with the portout.
        /// </summary>
        [JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the portout was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the portout was inserted into the system.
        /// </summary>
        [JsonPropertyName("inserted_at")]
        public string? InsertedAt { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the portout was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
    }
}