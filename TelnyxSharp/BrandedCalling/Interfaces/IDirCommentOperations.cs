using TelnyxSharp.BrandedCalling.Models.Comments.Requests;
using TelnyxSharp.BrandedCalling.Models.Comments.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for reading and posting customer-visible comments on a
    /// Display Identity Record (DIR).
    /// </summary>
    public interface IDirCommentOperations
    {
        /// <summary>
        /// Lists the customer-visible comments on a DIR, paginated.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirCommentsResponse> List(string dirId, ListDirCommentsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Posts a customer comment on a DIR.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The comment body.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirCommentResponse> Create(string dirId, CreateDirCommentRequest request,
            CancellationToken cancellationToken = default);
    }
}
