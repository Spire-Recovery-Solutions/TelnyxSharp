using System.Text.Json.Serialization;
using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Messaging.Models.PhoneNumberCampaign.Requests
{
    /// <summary>
    /// Represents a request to retrieve phone number campaigns based on specific filters and pagination parameters.
    /// </summary>
    public class RetrievePhoneNumberCampaignsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to retrieve per page.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx campaign ID to filter the campaigns.
        /// </summary>
        public string? FilterTelnyxCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the Telnyx brand ID to filter the campaigns.
        /// </summary>
        public string? FilterTelnyxBrandId { get; set; }

        /// <summary>
        /// Gets or sets the TCR (The Campaign Registry) campaign ID to filter the campaigns.
        /// </summary>
        public string? FilterTcrCampaignId { get; set; }

        /// <summary>
        /// Gets or sets the TCR brand ID to filter the campaigns.
        /// </summary>
        public string? FilterTcrBrandId { get; set; }

        /// <summary>
        /// Gets or sets the sorting order for the campaigns. Default is by creation date in descending order.
        /// </summary>
        public Sort? Sort { get; set; } = NET.Enums.Sort.CreatedAtDesc;
    }
}