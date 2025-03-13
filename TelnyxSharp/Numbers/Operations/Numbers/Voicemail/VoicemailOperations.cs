using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.Voicemail.Requests;
using TelnyxSharp.Numbers.Models.Voicemail.Responses;

namespace TelnyxSharp.Numbers.Operations.Numbers.Voicemail
{
    public class VoicemailOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IVoicemailOperations
    {
        /// <inheritdoc />
        public async Task<GetVoicemailResponse> Get(string phoneNumberId, 
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voicemail");
            return await ExecuteAsync<GetVoicemailResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<CreateVoicemailResponse> Create(string phoneNumberId, CreateVoicemailRequest request, 
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voicemail", Method.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            
            return await ExecuteAsync<CreateVoicemailResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<UpdateVoicemailResponse> Update(string phoneNumberId,UpdateVoicemailRequest request, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"phone_numbers/{phoneNumberId}/voicemail", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            
            return await ExecuteAsync<UpdateVoicemailResponse>(req, cancellationToken);
        }
    }
}