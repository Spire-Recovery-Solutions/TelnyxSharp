using Polly.Retry;
using System.Text.Json;
using TelnyxSharp.Base;
using TelnyxSharp.BrandedCalling.Interfaces;
using TelnyxSharp.BrandedCalling.Models.Comments.Requests;
using TelnyxSharp.BrandedCalling.Models.Comments.Responses;

namespace TelnyxSharp.BrandedCalling.Operations
{
    /// <summary>
    /// Provides operations for reading and posting customer-visible comments on a
    /// Display Identity Record (DIR). Implements the <see cref="IDirCommentOperations"/> interface.
    /// </summary>
    public class DirCommentOperations(HttpClient client, AsyncRetryPolicy rateLimitRetryPolicy)
        : BaseOperations(client, rateLimitRetryPolicy), IDirCommentOperations
    {
        /// <inheritdoc />
        public async Task<ListDirCommentsResponse> List(string dirId, ListDirCommentsRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/comments");
            req.AddFilter("comment_type", request.CommentType);
            req.AddPagination(request.PageSize);

            return await ExecuteAsync<ListDirCommentsResponse>(req, cancellationToken);
        }

        /// <inheritdoc />
        public async Task<DirCommentResponse> Create(string dirId, CreateDirCommentRequest request,
            CancellationToken cancellationToken = default)
        {
            var req = new TelnyxRequest($"dir/{dirId}/comments", TelnyxMethod.Post);
            req.AddBody(JsonSerializer.Serialize(request, TelnyxJsonSerializerContext.Default.Options));

            return await ExecuteAsync<DirCommentResponse>(req, cancellationToken);
        }
    }
}
