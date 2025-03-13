using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PortingOrder;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PortingOrder;

namespace TelnyxSharp.Numbers.Operations.Numbers.PortingOrder
{
    public class PortingOrderOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPortingOrderOperations
    {
        /// <inheritdoc />
        public async Task<CreatePortingOrderResponse> Create(CreatePortingOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting_orders", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreatePortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingOrdersResponse> List(ListPortingOrdersRequest request,
         CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting_orders")
                            .AddFilter("filter[status]", request.Status)
                            .AddFilter("include_phone_numbers", request.IncludePhoneNumbers)
                            .AddFilter("filter[customer_reference]", request.CustomerReference)
                            .AddFilter("sort[]", request.Sort)
                            .AddPagination(request.PageSize)
                            .AddFilter("filter[parent_support_key]", request.ParentSupportKey)
                            .AddFilter("filter[phone_numbers.carrier_name]", request.CarrierName)
                            .AddFilter("filter[misc.type]", request.PortingOrderType)
                            .AddFilter("filter[end_user.admin.entity_name]", request.EntityName)
                            .AddFilter("filter[end_user.admin.auth_person_name]", request.AuthorizedPerson)
                            .AddFilter("filter[activation_settings.fast_port_eligible]", request.FastPortEligible)
                            .AddFilter("filter[activation_settings.foc_datetime_requested][gt]", request.FocDatetimeRequestedAfter)
                            .AddFilter("filter[activation_settings.foc_datetime_requested][lt]", request.FocDatetimeRequestedBefore)
                            .AddFilter("filter[phone_numbers.phone_number][contains]", request.PhoneNumber)
                            .AddFilterList("filter[status][in]", request.StatusList);

            return await ExecuteAsync<ListPortingOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RetrievePortingOrderResponse> Get(string id, RetrievePortingOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}")
                .AddFilter("include_phone_numbers", request.IncludePhoneNumbers);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<RetrievePortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<EditPortingOrderResponse> Edit(string id, EditPortingOrderRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<EditPortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeletePortingOrderResponse> Delete(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}", Method.Delete);

            return await ExecuteAsync<DeletePortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DownloadLoaTemplateResponse> DownloadTemplate(string PortingOrderId, DownloadLoaTemplateRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{PortingOrderId}/loa_template")
                .AddFilter("loa_configuration_id", request.LoaConfigurationId);

            return await ExecuteAsync<DownloadLoaTemplateResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetSubRequestResponse> GetSubRequest(string portingOrderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/sub_request");
            return await ExecuteAsync<GetSubRequestResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CancelPortingOrderResponse> Cancel(string portingOrderId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/actions/cancel", Method.Post);
            return await ExecuteAsync<CancelPortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ConfirmPortingOrderResponse> Confirm(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/actions/confirm", Method.Post);
            return await ExecuteAsync<ConfirmPortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SharePortingOrderResponse> Share(string id, SharePortingOrderRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/actions/share", Method.Post);
            req.AddJsonBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<SharePortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ActivatePortingOrderResponse> Activate(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/actions/activate", Method.Post);
            return await ExecuteAsync<ActivatePortingOrderResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingActivationJobsResponse> ListActivationJobs(string id, ListPortingActivationJobsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/activation_jobs")
                .AddPagination(request?.PageSize);

            return await ExecuteAsync<ListPortingActivationJobsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortingActivationJobsResponse> GetActivationJobs(string id, string activationJobId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/activation_jobs/{activationJobId}");

            return await ExecuteAsync<GetPortingActivationJobsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePortingActivationJobResponse> UpdateActivationJob(string id, string activationJobId, UpdatePortingActivationJobRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/activation_jobs/{activationJobId}", Method.Patch);
            req.AddJsonBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdatePortingActivationJobResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePortingCommentResponse> CreateComment(string portingOrderId, CreatePortingCommentRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/comments", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreatePortingCommentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingCommentsResponse> ListComment(string portingOrderId, ListPortingCommentsRequest request,
                   CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/comments")
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingCommentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAllowedFocWindowsResponse> ListAllowedFocWindows(string portingOrderId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/allowed_foc_windows");
            return await ExecuteAsync<ListAllowedFocWindowsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingOrderRequirementsResponse> ListRequirements(string portingOrderId, ListPortingOrderRequirementsRequest request,
        CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/requirements")
                            .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingOrderRequirementsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingExceptionTypesResponse> ListExceptionTypes(CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting_orders/exception_types");

            return await ExecuteAsync<ListPortingExceptionTypesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPhoneNumberConfigurationsResponse> ListPhoneNumberConfigurations(ListPhoneNumberConfigurationsRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting_orders/phone_number_configurations")
                .AddPagination(request.PageSize)
                .AddFilter("filter[porting_order_id]", request.PortingOrderId)
                .AddFilter("filter[porting_order_id][in][]", request.PortingOrderIds)
                .AddFilter("filter[porting_order.status]", request.PortingOrderStatus)
                .AddFilter("filter[porting_order.status][in][]", request.PortingOrderStatuses)
                .AddFilter("filter[porting_phone_number]", request.PortingPhoneNumberId)
                .AddFilter("filter[porting_phone_number][in][]", request.PortingPhoneNumberIds)
                .AddFilter("filter[user_bundle_id]", request.UserBundleId)
                .AddFilter("filter[user_bundle_id][in][]", request.UserBundleIds)
                .AddFilter("sort[]", request.Sort);

            return await ExecuteAsync<ListPhoneNumberConfigurationsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingPhoneNumbersResponse> ListPhoneNumbers(ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_phone_numbers")
                        .AddFilter("filter[porting_order_id]", request.PortingOrderId)
                        .AddFilterList("filter[porting_order_id][in][]", request.PortingOrderIds)
                        .AddFilter("filter[support_key][eq]", request.SupportKeyEq)
                        .AddFilterList("filter[support_key][in][]", request.SupportKeyIn)
                        .AddFilter("filter[phone_number]", request.PhoneNumber)
                        .AddFilterList("filter[phone_number][in][]", request.PhoneNumberIn)
                        .AddFilter("filter[porting_order_status]", request.PortingOrderStatus)
                        .AddFilter("filter[activation_status]", request.ActivationStatus)
                        .AddFilter("filter[portability_status]", request.PortabilityStatus)
                        .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingPhoneNumbersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListVerificationCodesResponse> ListVerificationCodes(string Id, ListVerificationCodesRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{Id}/verification_codes")
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[phone_number][in][]", request.PhoneNumbers)
                .AddFilter("filter[verified]", request.Verified)
                .AddPagination(request.PageSize)
                .AddFilter("sort[]", request.Sort);

            return await ExecuteAsync<ListVerificationCodesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<VerifyCodesResponse> VerifyVerificationCodes(string id, VerifyCodesRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/verification_codes/verify", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<VerifyCodesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<SendVerificationCodesResponse> SendVerificationCodes(string id, SendVerificationCodesRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/verification_codes/send", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<SendVerificationCodesResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListAdditionalDocumentsResponse> ListAdditionalDocuments(string id, ListAdditionalDocumentsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/additional_documents")
                .AddFilter("filter[document_type]", request.DocumentType)
                .AddFilter("filter[document_type][in][]", request.DocumentTypes)
                .AddPagination(request.PageSize)
                .AddFilter("sort[]", request.Sort);

            return await ExecuteAsync<ListAdditionalDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateAdditionalDocumentsResponse> CreateAdditionalDocuments(string id, CreateAdditionalDocumentsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{id}/additional_documents", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreateAdditionalDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteAdditionalDocumentsResponse> DeleteAdditionalDocument(string portingOrderId, string additionalDocumentId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/additional_documents/{additionalDocumentId}", Method.Delete);
            return await ExecuteAsync<DeleteAdditionalDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPhoneNumberExtensionsResponse> ListPhoneNumberExtensions(string portingOrderId, ListPhoneNumberExtensionsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_extensions")
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[phone_number][in][]", request.PhoneNumbers)
                .AddFilter("filter[porting_phone_number_id]", request.PortingPhoneNumberId)
                .AddFilter("filter[porting_phone_number_id][in][]", request.PortingPhoneNumberIds)
                .AddPagination(request.PageSize)
                .AddFilter("sort[]", request.Sort);

            return await ExecuteAsync<ListPhoneNumberExtensionsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePhoneNumberExtensionsResponse> CreatePhoneNumberExtensions(string portingOrderId, CreatePhoneNumberExtensionsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_extensions", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreatePhoneNumberExtensionsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeletePhoneNumberExtensionsResponse> DeletePhoneNumberExtensionAsync(string portingOrderId, string extensionId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_extensions/{extensionId}", Method.Delete);
            return await ExecuteAsync<DeletePhoneNumberExtensionsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingPhoneBlocksResponse> ListPhoneNumberBlocks(string portingOrderId, ListPortingPhoneBlocksRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_blocks")
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[phone_number][in][]", request.PhoneNumbers)
                .AddFilter("sort[]", request.Sort)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingPhoneBlocksResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePortingPhoneBlockResponse> CreatePhoneNumberBlocks(string portingOrderId, CreatePortingPhoneBlockRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_blocks", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreatePortingPhoneBlockResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeletePortingPhoneBlockResponse> DeletePhoneNumberBlocks(string portingOrderId, string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_orders/{portingOrderId}/phone_number_blocks/{id}", Method.Delete);
            return await ExecuteAsync<DeletePortingPhoneBlockResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingReportsResponse> ListPortingReports(ListPortingReportsRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting/reports")
                .AddPagination(request.PageSize)
                .AddFilter("filter[report_type]", request.ReportType)
                .AddFilter("filter[status]", request.Status);

            return await ExecuteAsync<ListPortingReportsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortingReportResponse> GetPortingReports(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/reports/{id}");
            return await ExecuteAsync<GetPortingReportResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListLoaConfigurationsResponse> ListPortingReports(ListLoaConfigurationsRequest request,
                CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting/loa_configurations")
                            .AddPagination(request.PageSize);

            return await ExecuteAsync<ListLoaConfigurationsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateLoaConfigurationResponse> CreatePortingReports(CreateLoaConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting/loa_configurations", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreateLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<PreviewLoaConfigurationResponse> PreviewConfigurationParamters(PreviewLoaConfigurationParamRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting/loa_configuration/preview", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<PreviewLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetLoaConfigurationResponse> GetConfiguration(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/loa_configurations/{id}");
            return await ExecuteAsync<GetLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateLoaConfigurationResponse> UpdateConfiguration(string id, UpdateLoaConfigurationRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/loa_configurations/{id}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<UpdateLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteLoaConfigurationResponse> DeleteConfiguration(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/loa_configurations/{id}", Method.Delete);

            return await ExecuteAsync<DeleteLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<PreviewLoaConfigurationResponse> PreviewLoaConfiguration(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/loa_configurations/{id}/preview");

            return await ExecuteAsync<PreviewLoaConfigurationResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingEventsResponse> ListPortingEvents(ListPortingEventsRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting/events")
                .AddPagination(request?.PageSize)
                .AddFilter("filter[type]", request?.EventType)
                .AddFilter("filter[porting_order_id]", request?.PortingOrderId)
                .AddFilter("filter[created_at][gte]", request?.CreatedAtGte)
                .AddFilter("filter[created_at][lte]", request?.CreatedAtLte);

            return await ExecuteAsync<ListPortingEventsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortingEventResponse> GetPortingEvents(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/events/{id}");
            return await ExecuteAsync<GetPortingEventResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RepublishPortingEventsResponse> RepublishPortingEvents(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting/events/{id}/republish", Method.Post);
            return await ExecuteAsync<RepublishPortingEventsResponse>(req, cancellationToken);
        }
    }
}
