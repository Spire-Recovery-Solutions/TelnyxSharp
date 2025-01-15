using Polly.Retry;
using RestSharp;
using Telnyx.NET.Base;
using Telnyx.NET.PhoneNumber.Interfaces;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Requests;
using Telnyx.NET.PhoneNumber.Models.PhoneNumber.Responses;

namespace Telnyx.NET.PhoneNumber.Operations.PhoneNumber
{
    public class PortingOrderOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IPortingOrderOperations
    {
        /// <inheritdoc />
        public async Task<ListPortingOrdersResponse> List(ListPortingOrdersRequest request,
         CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("porting_orders")
                            .AddFilter("filter[status]", request.Status)
                            .AddFilter("include_phone_numbers", request.IncludePhoneNumbers.ToString())
                            .AddFilter("filter[customer_reference]", request.CustomerReference)
                            .AddFilter("sort[]", request.Sort)
                            .AddPagination(request.PageSize)
                            .AddFilter("filter[parent_support_key]", request.ParentSupportKey)
                            .AddFilter("filter[phone_numbers.carrier_name]", request.CarrierName)
                            .AddFilter("filter[misc.type]", request.PortingOrderType)
                            .AddFilter("filter[end_user.admin.entity_name]", request.EntityName)
                            .AddFilter("filter[end_user.admin.auth_person_name]", request.AuthorizedPerson)
                            .AddFilter("filter[activation_settings.fast_port_eligible]", request.FastPortEligible?.ToString())
                            .AddFilter("filter[activation_settings.foc_datetime_requested][gt]", request.FocDatetimeRequestedAfter?.ToString())
                            .AddFilter("filter[activation_settings.foc_datetime_requested][lt]", request.FocDatetimeRequestedBefore?.ToString())
                            .AddFilter("filter[phone_numbers.phone_number][contains]", request.PhoneNumber)
                            .AddFilterList("filter[status][in]", request.StatusList);

            return await ExecuteAsync<ListPortingOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingPhoneNumbersResponse> ListPhoneNumbers(
            ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_phone_numbers")
                        .AddFilter("filter[porting_order_id]", request.PortingOrderId?.ToString())
                        .AddFilterList("filter[porting_order_id][in]", request.PortingOrderIds)
                        .AddFilter("filter[support_key][eq]", request.SupportKeyEq)
                        .AddFilterList("filter[support_key][in]", request.SupportKeyIn)
                        .AddFilter("filter[phone_number]", request.PhoneNumber)
                        .AddFilterList("filter[phone_number][in]", request.PhoneNumberIn)
                        .AddFilter("filter[porting_order_status]", request.PortingOrderStatus)
                        .AddFilter("filter[activation_status]", request.ActivationStatus)
                        .AddFilter("filter[portability_status]", request.PortabilityStatus)
                        .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingPhoneNumbersResponse>(req, cancellationToken);
        }
    }
}
