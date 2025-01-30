using Telnyx.NET.Base;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.Documents
{
    /// <summary>
    /// Represents a request to list document links associated with phone numbers.
    /// This request allows filtering by document ID, linked record type, and linked resource ID,
    /// as well as configuring pagination options.
    /// </summary>
    public class ListDocumentLinksRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of records to return per page.
        /// Default value is 20.
        /// </summary>
        public int? PageSize { get; set; } = 20;

        /// <summary>
        /// Gets or sets the unique identifier of the document to filter by.
        /// If null, all document links will be retrieved regardless of document ID.
        /// </summary>
        public string? DocumentId { get; set; }

        /// <summary>
        /// Gets or sets the type of linked record to filter by.
        /// For example, this could represent the type of resource associated with the document link.
        /// </summary>
        public string? LinkedRecordType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the linked resource to filter by.
        /// This allows narrowing down the results to document links associated with a specific resource.
        /// </summary>
        public string? LinkedResourceId { get; set; }
    }
}