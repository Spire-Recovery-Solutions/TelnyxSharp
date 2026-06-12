using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests
{
    /// <summary>
    /// Represents a request for listing Display Identity Records (DIRs), either across all
    /// enterprises or scoped to a single enterprise.
    /// </summary>
    public class ListDirsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the sort field (e.g. "created_at", "display_name", "status").
        /// Prefix with "-" for descending. Defaults to "-created_at".
        /// </summary>
        public string? Sort { get; set; }

        /// <summary>
        /// Gets or sets a filter on enterprise id.
        /// Only applies when listing across all enterprises.
        /// </summary>
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// Gets or sets a filter on DIR status.
        /// </summary>
        public DirStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets a case-insensitive partial match filter on display name.
        /// </summary>
        public string? DisplayNameContains { get; set; }

        /// <summary>
        /// Gets or sets a case-insensitive partial match filter on call reason.
        /// </summary>
        public string? CallReasonContains { get; set; }

        /// <summary>
        /// Gets or sets a lower bound (ISO 8601) on the DIR expiration timestamp.
        /// </summary>
        public string? ExpiringAtGte { get; set; }

        /// <summary>
        /// Gets or sets an upper bound (ISO 8601) on the DIR expiration timestamp.
        /// </summary>
        public string? ExpiringAtLte { get; set; }

        /// <summary>
        /// Gets or sets a convenience filter returning DIRs expiring within the next N days (1-365).
        /// Only applies when listing DIRs for a specific enterprise; mutually exclusive with the
        /// explicit expiring-at bounds.
        /// </summary>
        public int? ExpiringWithinDays { get; set; }
    }
}
