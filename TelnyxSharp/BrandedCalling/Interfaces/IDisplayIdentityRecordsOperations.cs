using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Requests;
using TelnyxSharp.BrandedCalling.Models.DisplayIdentityRecords.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for managing Display Identity Records (DIRs) in the Branded Calling API.
    /// </summary>
    public interface IDisplayIdentityRecordsOperations
    {
        /// <summary>
        /// Lists DIRs across all enterprises owned by the caller, paginated.
        /// </summary>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirsResponse> List(ListDirsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists the DIRs of a single enterprise, paginated.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListDirsResponse> ListByEnterprise(string enterpriseId, ListDirsRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a DIR under an enterprise.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="request">The DIR details.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirResponse> Create(string enterpriseId, CreateDirRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a single DIR by id.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirResponse> Retrieve(string dirId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a DIR. Only the supplied fields are updated.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The fields to update.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirResponse> Update(string dirId, UpdateDirRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a DIR.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DeleteDirResponse> Delete(string dirId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Submits a DIR for vetting.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DirResponse> Submit(string dirId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates a pre-filled Letter of Authorization (LOA) PDF for a DIR.
        /// The rendered PDF bytes are returned on the response.
        /// </summary>
        /// <param name="dirId">The DIR id.</param>
        /// <param name="request">The phone numbers to authorize, plus optional agent and signature blocks.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<RenderDirLoaResponse> RenderLoa(string dirId, RenderDirLoaRequest request,
            CancellationToken cancellationToken = default);
    }
}
