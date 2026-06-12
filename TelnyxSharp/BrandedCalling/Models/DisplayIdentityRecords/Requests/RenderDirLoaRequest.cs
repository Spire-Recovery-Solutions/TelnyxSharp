using System.Text.Json.Serialization;
using TelnyxSharp.Base;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests
{
    /// <summary>
    /// Represents a request to render a pre-filled Letter of Authorization (LOA) PDF for a DIR.
    /// Enterprise identity and the DIR display name are read server-side; the caller supplies the
    /// telephone numbers to authorize, an optional Authorized Agent block, and an optional signature.
    /// </summary>
    public class RenderDirLoaRequest : ITelnyxRequest
    {
        /// <summary>
        /// Telephone numbers to authorize on the DIR, in +E164 format. 1-15 per request. Required.
        /// </summary>
        [JsonPropertyName("phone_numbers")]
        public List<string>? PhoneNumbers { get; set; }

        /// <summary>
        /// Optional. The third-party reseller / partner managing the enterprise's phone numbers.
        /// Omit when working directly with Telnyx; the LOA marks the Authorized Agent block as N/A.
        /// </summary>
        [JsonPropertyName("agent")]
        public LoaAgent? Agent { get; set; }

        /// <summary>
        /// Optional. When provided the rendered PDF embeds the signature image, printed name, and
        /// signed-at date. When absent the PDF is returned unsigned so the customer can sign it
        /// externally and upload it via the Documents API.
        /// </summary>
        [JsonPropertyName("signature")]
        public LoaSignature? Signature { get; set; }
    }

    /// <summary>
    /// Represents the third-party reseller / partner block on a rendered LOA.
    /// </summary>
    public class LoaAgent
    {
        /// <summary>
        /// Legal name of the agent (max 200 characters).
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string? LegalName { get; set; }

        /// <summary>
        /// Optional trading name of the agent (max 200 characters).
        /// </summary>
        [JsonPropertyName("dba")]
        public string? Dba { get; set; }

        /// <summary>
        /// Street address of the agent.
        /// </summary>
        [JsonPropertyName("street_address")]
        public string? StreetAddress { get; set; }

        /// <summary>
        /// Optional extended address (e.g. suite number).
        /// </summary>
        [JsonPropertyName("extended_address")]
        public string? ExtendedAddress { get; set; }

        /// <summary>
        /// City of the agent.
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// State or province of the agent.
        /// </summary>
        [JsonPropertyName("administrative_area")]
        public string? AdministrativeArea { get; set; }

        /// <summary>
        /// Postal code of the agent.
        /// </summary>
        [JsonPropertyName("postal_code")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the agent.
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Name of the agent's contact person.
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string? ContactName { get; set; }

        /// <summary>
        /// Job title of the agent's contact person.
        /// </summary>
        [JsonPropertyName("contact_title")]
        public string? ContactTitle { get; set; }

        /// <summary>
        /// Email address of the agent's contact person.
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Phone number of the agent's contact person (max 30 characters).
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string? ContactPhone { get; set; }
    }

    /// <summary>
    /// Represents a drawn signature embedded into a rendered LOA PDF.
    /// </summary>
    public class LoaSignature
    {
        /// <summary>
        /// PNG image, base64-encoded. Required.
        /// </summary>
        [JsonPropertyName("image_base64")]
        public string? ImageBase64 { get; set; }

        /// <summary>
        /// Optional printed name of the signer. When absent the rendered PDF falls back to the
        /// enterprise contact's legal name.
        /// </summary>
        [JsonPropertyName("signer_name")]
        public string? SignerName { get; set; }
    }
}
