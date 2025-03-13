using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementGroups;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementGroups;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Interface defining the operations related to requirement groups in the Telnyx API.
    /// It includes methods for creating, listing, updating, deleting, and submitting requirement groups,
    /// as well as updating sub-number and phone number orders with requirements.
    /// </summary>
    public interface IRequirementGroupsOperations
    {
        /// <summary>
        /// Updates the sub-number order requirement group by submitting a POST request.
        /// </summary>
        /// <param name="subNumberOrderId">The ID of the sub-number order to update.</param>
        /// <param name="request">The request containing the updated requirement group data.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing the updated sub-number order requirement data.</returns>
        Task<UpdateSubNumberOrderRequirementResponse> UpdateSubNumber(string subNumberOrderId, UpdateSubNumberOrderRequirementRequest request,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the phone number order requirement group by submitting a POST request.
        /// </summary>
        /// <param name="phoneNumberOrderId">The ID of the phone number order to update.</param>
        /// <param name="request">The request containing the updated requirement group data.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing the updated phone number order requirement data.</returns>
        Task<UpdatePhoneNumberOrderRequirementResponse> UpdatePhoneNumber(string phoneNumberOrderId, UpdatePhoneNumberOrderRequirementRequest request,
           CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of requirement groups based on provided filter parameters.
        /// </summary>
        /// <param name="request">The request containing filter parameters for listing requirement groups.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing a list of requirement groups based on the specified filters.</returns>
        Task<ListRequirementGroupsResponse> List(ListRequirementGroupsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new requirement group by submitting a POST request.
        /// </summary>
        /// <param name="request">The request containing the requirement group data to create.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing the created requirement group data.</returns>
        Task<CreateRequirementGroupResponse> Create(CreateRequirementGroupRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the details of a specific requirement group by ID.
        /// </summary>
        /// <param name="id">The ID of the requirement group to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing the details of the specified requirement group.</returns>
        Task<GetRequirementGroupResponse> Get(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a specific requirement group by ID.
        /// </summary>
        /// <param name="id">The ID of the requirement group to delete.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response confirming the deletion of the requirement group.</returns>
        Task<DeleteRequirementGroupResponse> Delete(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the details of a specific requirement group by ID.
        /// </summary>
        /// <param name="id">The ID of the requirement group to update.</param>
        /// <param name="request">The request containing the updated requirement group data.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response containing the updated requirement group data.</returns>
        Task<UpdateRequirementGroupResponse> Update(string id, UpdateRequirementGroupRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Submits a requirement group for approval by sending a POST request.
        /// </summary>
        /// <param name="id">The ID of the requirement group to submit for approval.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A response confirming the submission of the requirement group for approval.</returns>
        Task<SubmitRequirementGroupApprovalResponse> SubmitForApproval(string id, CancellationToken cancellationToken = default);
    }
}
