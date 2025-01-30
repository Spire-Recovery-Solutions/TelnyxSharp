using Telnyx.NET.Numbers.Models.PhoneNumbers.Requests.PortingOrder;
using Telnyx.NET.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace Telnyx.NET.Numbers.Interfaces
{
    /// <summary>
    /// Defines operations for managing porting orders and related resources in the Telnyx API.
    /// </summary>
    public interface IPortingOrderOperations
    {
        /// <summary>
        /// Creates a new porting order.
        /// </summary>
        /// <param name="request">The request containing porting order details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreatePortingOrderResponse> Create(CreatePortingOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of porting orders based on specified filters.
        /// </summary>
        /// <param name="request">The request containing filter criteria and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingOrdersResponse> List(ListPortingOrdersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific porting order by ID.
        /// </summary>
        /// <param name="id">The unique identifier of the porting order.</param>
        /// <param name="request">Additional retrieval options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<RetrievePortingOrderResponse> Get(string id, RetrievePortingOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies an existing porting order.
        /// </summary>
        /// <param name="id">The unique identifier of the porting order.</param>
        /// <param name="request">The request containing updated porting order details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<EditPortingOrderResponse> Edit(string id, EditPortingOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a porting order.
        /// </summary>
        /// <param name="id">The unique identifier of the porting order to delete.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DeletePortingOrderResponse> Delete(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Downloads a Letter of Authorization (LOA) template for a porting order.
        /// </summary>
        /// <param name="PortingOrderId">The ID of the porting order.</param>
        /// <param name="request">Template download options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DownloadLoaTemplateResponse> DownloadTemplate(string PortingOrderId, DownloadLoaTemplateRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves sub-request details for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<GetSubRequestResponse> GetSubRequest(string portingOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order to cancel.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CancelPortingOrderResponse> Cancel(string portingOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirms a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order to confirm.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ConfirmPortingOrderResponse> Confirm(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Shares a porting order with other users.
        /// </summary>
        /// <param name="id">The ID of the porting order to share.</param>
        /// <param name="request">Sharing options and recipient details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<SharePortingOrderResponse> Share(string id, SharePortingOrderRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Activates a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order to activate.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ActivatePortingOrderResponse> Activate(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists activation jobs for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingActivationJobsResponse> ListActivationJobs(string id, ListPortingActivationJobsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific activation job for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="activationJobId">The ID of the activation job.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<GetPortingActivationJobsResponse> GetActivationJobs(string id, string activationJobId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an activation job for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="activationJobId">The ID of the activation job.</param>
        /// <param name="request">Updated activation job details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<UpdatePortingActivationJobResponse> UpdateActivationJob(string id, string activationJobId, UpdatePortingActivationJobRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a comment on a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">The comment details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreatePortingCommentResponse> CreateComment(string portingOrderId, CreatePortingCommentRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists comments on a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingCommentsResponse> ListComment(string portingOrderId, ListPortingCommentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists allowed FOC (Firm Order Commitment) windows for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListAllowedFocWindowsResponse> ListAllowedFocWindows(string portingOrderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists requirements for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingOrderRequirementsResponse> ListRequirements(string portingOrderId, ListPortingOrderRequirementsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists exception types for porting orders.
        /// </summary>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingExceptionTypesResponse> ListExceptionTypes(CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists phone number configurations.
        /// </summary>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPhoneNumberConfigurationsResponse> ListPhoneNumberConfigurations(ListPhoneNumberConfigurationsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists phone numbers associated with porting orders.
        /// </summary>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingPhoneNumbersResponse> ListPhoneNumbers(ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists verification codes for a porting order.
        /// </summary>
        /// <param name="Id">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListVerificationCodesResponse> ListVerificationCodes(string Id, ListVerificationCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Verifies codes for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="request">Verification details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<VerifyCodesResponse> VerifyVerificationCodes(string id, VerifyCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends verification codes for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="request">Sending options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<SendVerificationCodesResponse> SendVerificationCodes(string id, SendVerificationCodesRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists additional documents for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListAdditionalDocumentsResponse> ListAdditionalDocuments(string id, ListAdditionalDocumentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates additional documents for a porting order.
        /// </summary>
        /// <param name="id">The ID of the porting order.</param>
        /// <param name="request">Document details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreateAdditionalDocumentsResponse> CreateAdditionalDocuments(string id, CreateAdditionalDocumentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an additional document from a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="additionalDocumentId">The ID of the document to delete.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DeleteAdditionalDocumentsResponse> DeleteAdditionalDocument(string portingOrderId, string additionalDocumentId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists phone number extensions for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPhoneNumberExtensionsResponse> ListPhoneNumberExtensions(string portingOrderId, ListPhoneNumberExtensionsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates phone number extensions for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Extension details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreatePhoneNumberExtensionsResponse> CreatePhoneNumberExtensions(string portingOrderId, CreatePhoneNumberExtensionsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a phone number extension from a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="extensionId">The ID of the extension to delete.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DeletePhoneNumberExtensionsResponse> DeletePhoneNumberExtensionAsync(string portingOrderId, string extensionId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists phone number blocks for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingPhoneBlocksResponse> ListPhoneNumberBlocks(string portingOrderId, ListPortingPhoneBlocksRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates phone number blocks for a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="request">Block details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreatePortingPhoneBlockResponse> CreatePhoneNumberBlocks(string portingOrderId, CreatePortingPhoneBlockRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a phone number block from a porting order.
        /// </summary>
        /// <param name="portingOrderId">The ID of the porting order.</param>
        /// <param name="id">The ID of the block to delete.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DeletePortingPhoneBlockResponse> DeletePhoneNumberBlocks(string portingOrderId, string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists porting reports.
        /// </summary>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingReportsResponse> ListPortingReports(ListPortingReportsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a specific porting report by ID.
        /// </summary>
        /// <param name="id">The ID of the report to retrieve.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<GetPortingReportResponse> GetPortingReports(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists LOA configurations.
        /// </summary>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListLoaConfigurationsResponse> ListPortingReports(ListLoaConfigurationsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new LOA configuration.
        /// </summary>
        /// <param name="request">Configuration details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<CreateLoaConfigurationResponse> CreatePortingReports(CreateLoaConfigurationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Previews LOA configuration parameters.
        /// </summary>
        /// <param name="request">Preview configuration options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<PreviewLoaConfigurationResponse> PreviewConfigurationParamters(PreviewLoaConfigurationParamRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific LOA configuration.
        /// </summary>
        /// <param name="id">The ID of the configuration.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<GetLoaConfigurationResponse> GetConfiguration(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing LOA configuration.
        /// </summary>
        /// <param name="id">The ID of the configuration to update.</param>
        /// <param name="request">Updated configuration details.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<UpdateLoaConfigurationResponse> UpdateConfiguration(string id, UpdateLoaConfigurationRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a LOA configuration.
        /// </summary>
        /// <param name="id">The ID of the configuration to delete.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<DeleteLoaConfigurationResponse> DeleteConfiguration(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Previews a LOA configuration.
        /// </summary>
        /// <param name="id">The ID of the configuration to preview.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<PreviewLoaConfigurationResponse> PreviewLoaConfiguration(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists porting events.
        /// </summary>
        /// <param name="request">Filter and pagination options.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<ListPortingEventsResponse> ListPortingEvents(ListPortingEventsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a specific porting event.
        /// </summary>
        /// <param name="id">The ID of the event to retrieve.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<GetPortingEventResponse> GetPortingEvents(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Republishes porting events.
        /// </summary>
        /// <param name="id">The ID of the event to republish.</param>
        /// <param name="cancellationToken">Optional cancellation token.</param>
        Task<RepublishPortingEventsResponse> RepublishPortingEvents(string id, CancellationToken cancellationToken = default);
    }
}