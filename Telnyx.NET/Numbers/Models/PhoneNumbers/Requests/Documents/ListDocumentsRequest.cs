using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.Documents.Requests
{
    /// <summary>
    /// Represents a request to list documents from the Telnyx API.
    /// This request allows filtering and sorting of documents based on various criteria.
    /// </summary>
    public class ListDocumentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the filename filter.
        /// Filters documents where the filename contains the specified substring.
        /// </summary>
        public string? FilenameContains { get; set; }

        /// <summary>
        /// Gets or sets the customer reference filter.
        /// Filters documents associated with the specified customer reference.
        /// </summary>
        public string? CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the array of customer references filter.
        /// Filters documents associated with any of the specified customer references.
        /// </summary>
        public string[]? CustomerReferences { get; set; }

        /// <summary>
        /// Gets or sets the created after filter.
        /// Filters documents created after the specified ISO 8601 date-time.
        /// </summary>
        public string? CreatedAfter { get; set; }

        /// <summary>
        /// Gets or sets the created before filter.
        /// Filters documents created before the specified ISO 8601 date-time.
        /// </summary>
        public string? CreatedBefore { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the documents.
        /// Specifies the field and order (ascending or descending) to sort the results by.
        /// </summary>
        public DocumentSort? Sort { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of documents to return per page.
        /// Default is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;
    }
}