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
                .AddFilter("status", request.Status)
                .AddFilter("include_phone_numbers", request.IncludePhoneNumbers.ToString())
                .AddFilter("customer_reference", request.CustomerReference)
                .AddFilter("sort[]", request.Sort)
                .AddPagination(request.PageSize)
                .AddFilter("parent_support_key", request.ParentSupportKey)
                .AddFilter("phone_numbers.carrier_name", request.CarrierName)
                .AddFilter("misc.type", request.PortingOrderType)
                .AddFilter("end_user.admin.entity_name", request.EntityName)
                .AddFilter("end_user.admin.auth_person_name", request.AuthorizedPerson)
                .AddFilter("activation_settings.fast_port_eligible", request.FastPortEligible?.ToString())
                .AddFilter("activation_settings.foc_datetime_requested[gt]", request.FocDatetimeRequestedAfter?.ToString())
                .AddFilter("activation_settings.foc_datetime_requested[lt]", request.FocDatetimeRequestedBefore?.ToString())
                .AddFilter("phone_numbers.phone_number[contains]", request.PhoneNumber)
                .AddFilterList("status[in]", request.StatusList);

            return await ExecuteAsync<ListPortingOrdersResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<ListPortingPhoneNumbersResponse> ListPhoneNumbers(
            ListPortingPhoneNumbersRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"porting_phone_numbers")
                .AddFilter("porting_order_id", request.PortingOrderId?.ToString())
                .AddFilterList("porting_order_id[in]", request.PortingOrderIds)
                .AddFilter("support_key[eq]", request.SupportKeyEq)
                .AddFilterList("support_key[in]", request.SupportKeyIn)
                .AddFilter("phone_number", request.PhoneNumber)
                .AddFilterList("phone_number[in]", request.PhoneNumberIn)
                .AddFilter("porting_order_status", request.PortingOrderStatus)
                .AddFilter("activation_status", request.ActivationStatus)
                .AddFilter("portability_status", request.PortabilityStatus)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListPortingPhoneNumbersResponse>(req, cancellationToken);
        }
    }
}
