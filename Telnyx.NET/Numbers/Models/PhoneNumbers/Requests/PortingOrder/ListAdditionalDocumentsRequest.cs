using Telnyx.NET.Base;
using Telnyx.NET.Enums;

namespace Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder
{
    /// <summary>
    /// Represents a request to list additional documents for a porting order, 
    /// with options for filtering by document type, sorting, and pagination.
    /// </summary>
    public class ListAdditionalDocumentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of documents to retrieve per page. 
        /// Used for pagination.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets the specific document type to filter the request by.
        /// </summary>
        public string? DocumentType { get; set; }

        /// <summary>
        /// Gets or sets a list of document types to filter the request by.
        /// Allows for multiple types to be specified.
        /// </summary>
        public List<string>? DocumentTypes { get; set; }

        /// <summary>
        /// Gets or sets the sort order for the request. 
        /// Determines the order in which documents are returned.
        /// </summary>
        public RequirementSort? Sort { get; set; }
    }
}