using TelnyxSharp.Numbers.Models.NumberPortout.Requests;
using TelnyxSharp.Numbers.Models.NumberPortout.Responses;

namespace TelnyxSharp.Numbers.Interfaces
{
    public interface INumberPortoutOperations
    {
        /// <summary>
        /// Lists port-out requests based on the provided filters.
        /// </summary>
        /// <param name="request">The request object containing filters for port-out requests.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of port-out requests.</returns>
        Task<ListPortoutResponse> List(ListPortoutRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific port-out request by ID.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the port-out details.</returns>
        Task<GetPortoutResponse> Get(string portoutId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the status of a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="status">The new status for the port-out request.</param>
        /// <param name="request">The request object containing additional details for the update.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated status response.</returns>
        Task<UpdatePortoutStatusResponse> UpdateStatus(string portoutId, string status, UpdatePortoutStatusRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all comments for a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of port-out comments.</returns>
        Task<PortoutCommentsResponse> ListPortoutComments(string portoutId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a comment for a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="request">The request object containing the comment details.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response for the created comment.</returns>
        Task<CreatePortoutCommentResponse> CreatePortoutComments(string portoutId, CreatePortoutCommentRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all supporting documents for a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of supporting documents.</returns>
        Task<ListPortoutSupportingDocumentsResponse> ListSupportingDocuments(string portoutId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates supporting documents for a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="request">The request object containing the document details.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response for the created supporting document.</returns>
        Task<CreatePortoutSupportingDocumentsResponse> CreateSupportingDocuments(string portoutId, CreatePortoutSupportingDocumentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all port-out reports based on the provided filters.
        /// </summary>
        /// <param name="request">The request object containing filters for port-out reports.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of port-out reports.</returns>
        Task<ListPortoutReportsResponse> ListPortoutReports(ListPortoutReportsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a port-out report.
        /// </summary>
        /// <param name="request">The request object containing the report details.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the response for the created report.</returns>
        Task<CreatePortoutReportResponse> CreatePortoutReports(CreatePortoutReportRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific port-out report by ID.
        /// </summary>
        /// <param name="reportId">The ID of the report.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the report details.</returns>
        Task<GetPortoutReportResponse> GetPortoutReports(string reportId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all rejection codes for a specific port-out request.
        /// </summary>
        /// <param name="portoutId">The ID of the port-out request.</param>
        /// <param name="request">The request object containing filters for rejection codes.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of rejection codes.</returns>
        Task<ListPortoutRejectionCodesResponse> ListRejectionCodes(string portoutId, ListPortoutRejectionCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists all port-out events based on the provided filters.
        /// </summary>
        /// <param name="request">The request object containing filters for events.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the list of port-out events.</returns>
        Task<ListPortoutEventsResponse> ListEvent(ListPortoutEventsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves details of a specific port-out event by ID.
        /// </summary>
        /// <param name="eventId">The ID of the event.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the event details.</returns>
        Task<GetPortoutEventResponse> GetEvent(string eventId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Republishes a specific port-out event by ID.
        /// </summary>
        /// <param name="eventId">The ID of the event to republish.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the republished event response.</returns>
        Task<RepublishPortoutEventResponse> RepublishEvent(string eventId, CancellationToken cancellationToken = default);
    }
}
