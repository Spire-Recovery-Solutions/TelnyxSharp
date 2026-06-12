using TelnyxSharp.BrandedCalling.Models.Enterprises.Requests;
using TelnyxSharp.BrandedCalling.Models.Enterprises.Responses;

namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for managing enterprises in the Branded Calling API.
    /// </summary>
    public interface IEnterpriseOperations
    {
        /// <summary>
        /// Lists the enterprises owned by the caller, paginated.
        /// </summary>
        /// <param name="request">The listing request with optional filters.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<ListEnterprisesResponse> List(ListEnterprisesRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the legal entity (enterprise) that represents a business on the Telnyx platform.
        /// </summary>
        /// <param name="request">The enterprise details.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<EnterpriseResponse> Create(CreateEnterpriseRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a single enterprise by id.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<EnterpriseResponse> Retrieve(string enterpriseId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an enterprise. Only the supplied fields are updated.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="request">The fields to update.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<EnterpriseResponse> Update(string enterpriseId, UpdateEnterpriseRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an enterprise.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<DeleteEnterpriseResponse> Delete(string enterpriseId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Activates Branded Calling on an enterprise.
        /// </summary>
        /// <param name="enterpriseId">The enterprise id.</param>
        /// <param name="cancellationToken">A token to cancel the request, if needed.</param>
        Task<EnterpriseResponse> ActivateBrandedCalling(string enterpriseId,
            CancellationToken cancellationToken = default);
    }
}
