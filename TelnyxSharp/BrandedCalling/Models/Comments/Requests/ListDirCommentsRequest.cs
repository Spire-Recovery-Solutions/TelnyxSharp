using TelnyxSharp.Base;
using TelnyxSharp.Enums;

namespace TelnyxSharp.BrandedCalling.Models.Comments.Requests
{
    /// <summary>
    /// Represents a request for listing the customer-visible comments on a Display Identity Record (DIR).
    /// </summary>
    public class ListDirCommentsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items per page (default 50, maximum 250).
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets a filter restricting results to comments of this category.
        /// Customer-visible categories only: internal-only comments are filtered out regardless.
        /// </summary>
        public DirCommentType? CommentType { get; set; }
    }
}
