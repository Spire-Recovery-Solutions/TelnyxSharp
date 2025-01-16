using Telnyx.NET.Messaging.Models.Brands.Requests;
using Telnyx.NET.Messaging.Models.Brands.Responses;

namespace Telnyx.NET.Messaging.Interfaces
{
    public interface IBrandOperations
    {
        /// <summary>
        /// Lists all brands with optional filters such as pagination and search criteria.
        /// </summary>
        /// <param name="request">The request containing the filters for listing brands.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A list of brands based on the provided filters.</returns>
        Task<ListBrandsResponse?> ListBrandsAsync(ListBrandsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new brand with the provided details.
        /// </summary>
        /// <param name="request">The request containing the details for the brand creation.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the details of the created brand.</returns>
        Task<CreateBrandResponse?> Create(CreateBrandRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a brand by its unique identifier.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to retrieve.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the details of the requested brand.</returns>
        Task<GetBrandResponse?> Retrieve(string brandId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a brand's details by its unique identifier.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to update.</param>
        /// <param name="request">The request containing the updated brand details.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response containing the updated brand details.</returns>
        Task<UpdateBrandResponse?> Update(string brandId, UpdateBrandRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a brand by its unique identifier.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to delete.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the deletion of the brand.</returns>
        Task<DeleteBrandResponse?> Delete(string brandId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Resends a two-factor authentication (2FA) email for the specified brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to resend the 2FA email.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response indicating whether the 2FA email was resent successfully.</returns>
        Task<ResendBrand2FAEmailResponse?> Resend2FAEmailAsync(string brandId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Reverts any recent changes made to a brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to revert changes.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response indicating whether the revert operation was successful.</returns>
        Task<RevetBrandResponse?> Revet(string brandId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists external vetting records associated with a specific brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to retrieve external vetting records for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A list of external vetting records associated with the specified brand.</returns>
        Task<ListExternalVettingResponse?> ListExternalVetting(string brandId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Imports an external vetting record for a specified brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to import the external vetting record for.</param>
        /// <param name="request">The request containing the details of the external vetting record to import.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response indicating whether the external vetting record was imported successfully.</returns>
        Task<ImportExternalVettingResponse?> ImportExternalVettingRecord(string brandId, ImportExternalVettingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Orders external vetting for a specified brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to order external vetting for.</param>
        /// <param name="request">The request containing the details of the external vetting order.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The response confirming the external vetting order for the brand.</returns>
        Task<OrderExternalVettingResponse?> OrderExternalVetting(string brandId, OrderExternalVettingRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves feedback associated with a specific brand.
        /// </summary>
        /// <param name="brandId">The unique identifier of the brand to retrieve feedback for.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>The feedback response for the specified brand.</returns>
        Task<GetBrandFeedbackResponse?> GetFeedback(string brandId, CancellationToken cancellationToken = default);
    }
}