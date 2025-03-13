using Polly.Retry;
using RestSharp;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.Numbers.Interfaces;
using TelnyxSharp.Numbers.Models.Documents.Requests;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.Documents;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.Documents;

namespace TelnyxSharp.Numbers.Operations.Numbers.Documents
{
    public class DocumentOperations(IRestClient client, AsyncRetryPolicy rateLimitRetryPolicy)
    : BaseOperations(client, rateLimitRetryPolicy), IDocumentOperations
    {
        /// <inheritdoc />
        public async Task<ListDocumentsResponse> List(ListDocumentsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("documents")
                .AddFilter("filter[filename][contains]", request.FilenameContains)
                .AddFilter("filter[customer_reference][eq]", request.CustomerReference)
                .AddFilter("filter[customer_reference][in][]", request.CustomerReferences)
                .AddFilter("filter[created_at][gt]", request.CreatedAfter)
                .AddFilter("filter[created_at][lt]", request.CreatedBefore)
                .AddFilter("sort[]", request.Sort)
                .AddPagination(request.PageSize);

            return await ExecuteAsync<ListDocumentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UploadDocumentResponse> Upload(UploadDocumentRequest request, string fileName, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("documents", Method.Post)
                .AddFile("file", request.File, fileName)
                .AddParameter("customer_reference", request.CustomerReference)
                .AddHeader("Content-Type", "multipart/form-data");

            return await ExecuteAsync<UploadDocumentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<GetDocumentResponse> Get(string documentId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"documents/{documentId}");
            return await ExecuteAsync<GetDocumentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DeleteDocumentResponse> Delete(string documentId, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"documents/{documentId}", Method.Delete);
            return await ExecuteAsync<DeleteDocumentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UpdateDocumentResponse> Update(string id, UpdateDocumentRequest request,
           CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"documents/{id}", Method.Patch);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));
            return await ExecuteAsync<UpdateDocumentResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DownloadDocumentResponse> Download(string id, CancellationToken cancellationToken = default)
        {
            var req = new RestRequest($"documents/{id}/dowload", Method.Patch);
            return await ExecuteAsync<DownloadDocumentResponse>(req, cancellationToken);
        }
        
        /// <inheritdoc />
        public async Task<ListDocumentLinksResponse> ListDocumentLinks(ListDocumentLinksRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new RestRequest("document_links")
                .AddPagination(request.PageSize)
                .AddFilter("filter[document_id]",request.DocumentId)
                .AddFilter("filter[linked_record_type]",request.LinkedRecordType)
                .AddFilter("filter[linked_resource_id]", request.LinkedResourceId);

            return await ExecuteAsync<ListDocumentLinksResponse>(req, cancellationToken);
        }

    }
}
