using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.RequirementTypes;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.RequirementTypes;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines the operations related to managing requirement types within the Telnyx API.
    /// </summary>
    public interface IRequirementTypesOperations
    {
        /// <summary>
        /// Lists requirement types based on the provided filters and sorting.
        /// </summary>
        /// <param name="request">The request object containing filters like name and sorting criteria.</param>
        /// <param name="cancellationToken">The token used to cancel the operation, if necessary.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of requirement types.</returns>
        Task<ListRequirementTypesResponse> List(ListRequirementTypesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific requirement type based on the requirement type ID.
        /// </summary>
        /// <param name="requirementTypeId">The ID of the requirement type to retrieve.</param>
        /// <param name="cancellationToken">The token used to cancel the operation, if necessary.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved requirement type.</returns>
        Task<RetrieveRequirementTypeResponse> Get(string requirementTypeId, CancellationToken cancellationToken = default);
    }
}
