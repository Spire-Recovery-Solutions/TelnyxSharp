using System.Text.Json.Serialization;
using Telnyx.NET.Models;

namespace Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Responses
{
    /// <summary>
    /// Represents the response for retrieving phone number campaigns, containing a list of campaigns, pagination details, and potential errors.
    /// </summary>
    public class RetrievePhoneNumberCampaignsResponse : TelnyxResponse
    {
        /// <summary>
        /// Gets or sets the list of phone number campaigns retrieved by the API.
        /// </summary>
        [JsonPropertyName("records")]
        public List<RetrievePhoneNumberCampaign> Records { get; set; } = new();

        /// <summary>
        /// Gets or sets the current page number of the retrieved results.
        /// </summary>
        [JsonPropertyName("page")]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the total number of records available across all pages.
        /// </summary>
        [JsonPropertyName("totalRecords")]
        public int TotalRecords { get; set; }
    }

    /// <summary>
    /// Represents a single phone number campaign, inheriting from the base phone number campaigns model.
    /// </summary>
    public class RetrievePhoneNumberCampaign : BasePhoneNumberCampaigns
    {
    }

}