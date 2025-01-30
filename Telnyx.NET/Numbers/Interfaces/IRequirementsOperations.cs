using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.Requirements;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.Requirements;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines the operations related to managing document requirements within the Telnyx API.
    /// </summary>
    public interface IRequirementsOperations
    {
        /// <summary>
        /// Lists document requirements based on the provided filters and pagination.
        /// </summary>
        /// <param name="request">The request object containing filters for listing requirements.</param>
        /// <param name="cancellationToken">The token used to cancel the operation, if necessary.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of document requirements.</returns>
        Task<ListRequirementResponse> List(ListRequirementsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific document requirement based on the requirement ID.
        /// </summary>
        /// <param name="requirementId">The ID of the requirement to retrieve.</param>
        /// <param name="cancellationToken">The token used to cancel the operation, if necessary.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved document requirement.</returns>
        Task<RetrieveDocumentRequirementResponse> Retrieve(string requirementId, CancellationToken cancellationToken = default);
    }
}
