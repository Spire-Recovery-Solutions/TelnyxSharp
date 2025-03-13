using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.NumberPortout.Requests;
using TelnyxSharp.Numbers.Models.NumberPortout.Responses;

namespace TelnyxSharp.Numbers.Operations.Numbers.NumberPortout
{
    public class NumberPortoutOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), INumberPortoutOperations
    {
        /// <inheritdoc />
        public async Task<ListPortoutResponse> List(ListPortoutRequest request,
            CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("portouts")
                .AddFilter("filter[carrier_name]", request.CarrierName)
                .AddFilter("filter[spid]", request.Spid)
                .AddFilter("filter[status]", request.Status)
                .AddFilter("filter[phone_number]", request.PhoneNumber)
                .AddFilter("filter[support_key]", request.SupportKey)
                .AddFilter("filter[status_in]", request.StatusList)
                .AddFilter("filter[ported_out_at][gte]", request.PortedOutAfter)
                .AddFilter("filter[ported_out_at][lte]", request.PortedOutBefore)
                .AddFilter("filter[inserted_at][gte]", request.InsertedAfter)
                .AddFilter("filter[inserted_at][lte]", request.InsertedBefore)
                .AddFilter("filter[foc_date]", request.FocDate)
                .AddPagination(request.PageSize);


            return await ExecuteAsync<ListPortoutResponse>(restRequest, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortoutResponse> Get(string portoutId,
            CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest($"portouts/{portoutId}");
            return await ExecuteAsync<GetPortoutResponse>(restRequest, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdatePortoutStatusResponse> UpdateStatus(string portoutId, string status, UpdatePortoutStatusRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/{portoutId}/{status}", Method.Patch);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdatePortoutStatusResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<PortoutCommentsResponse> ListPortoutComments(string portoutId,
            CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest($"portouts/{portoutId}/comments");
            return await ExecuteAsync<PortoutCommentsResponse>(restRequest, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePortoutCommentResponse> CreatePortoutComments(string portoutId, CreatePortoutCommentRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/{portoutId}/comments", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreatePortoutCommentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortoutSupportingDocumentsResponse> ListSupportingDocuments(string portoutId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/{portoutId}/supporting_documents");

            return await ExecuteAsync<ListPortoutSupportingDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePortoutSupportingDocumentsResponse> CreateSupportingDocuments(string portoutId, CreatePortoutSupportingDocumentsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/{portoutId}/supporting_documents", Method.Post);

            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<CreatePortoutSupportingDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortoutReportsResponse> ListPortoutReports(ListPortoutReportsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("portouts/reports")
                            .AddFilter("filter[report_type]", request.ReportType)
                            .AddFilter("filter[status]", request.Status)
                            .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortoutReportsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreatePortoutReportResponse> CreatePortoutReports(CreatePortoutReportRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("portouts/reports", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<CreatePortoutReportResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortoutReportResponse> GetPortoutReports(string reportId,
           CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest($"portouts/reports/{reportId}");

            return await ExecuteAsync<GetPortoutReportResponse>(restRequest, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortoutRejectionCodesResponse> ListRejectionCodes(string portoutId, ListPortoutRejectionCodesRequest request,
                CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest($"portouts/rejections/{portoutId}")
                .AddFilter("filter[code]", request?.Code)
                .AddFilter("filter[code][in]", request?.CodesIn);

            return await ExecuteAsync<ListPortoutRejectionCodesResponse>(restRequest, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortoutEventsResponse> ListEvent(ListPortoutEventsRequest request,
          CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("portouts/events")
                .AddFilter("filter[event_type]", request.EventType)
                .AddFilter("filter[portout_id]", request.PortoutId)
                .AddPagination(request.PageSize)
                .AddFilter("filter[created_at][gte]", request.CreatedAtFrom)
                .AddFilter("filter[created_at][lte]", request.CreatedAtTo);

            return await ExecuteAsync<ListPortoutEventsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetPortoutEventResponse> GetEvent(string eventId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/events/{eventId}");
            return await ExecuteAsync<GetPortoutEventResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<RepublishPortoutEventResponse> RepublishEvent(string eventId,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"portouts/events/{eventId}/republish");
            return await ExecuteAsync<RepublishPortoutEventResponse>(req, cancellationToken);
        }
    }
}
