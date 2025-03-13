using TelnyxSharp.Numbers.Models.Documents.Requests;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.Documents;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.Documents;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines the operations available for managing documents in the Telnyx API.
    /// </summary>
    public interface IDocumentOperations
    {
        /// <summary>
        /// Lists documents based on provided filter criteria.
        /// </summary>
        /// <param name="request">The request object containing filter criteria for the list of documents.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="ListDocumentsResponse"/>.</returns>
        Task<ListDocumentsResponse> List(ListDocumentsRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Uploads a document to the Telnyx platform.
        /// </summary>
        /// <param name="request">The request object containing the document file and metadata.</param>
        /// <param name="fileName">The name of the file to upload.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="UploadDocumentResponse"/>.</returns>
        Task<UploadDocumentResponse> Upload(UploadDocumentRequest request, string fileName, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a specific document by its ID.
        /// </summary>
        /// <param name="documentId">The ID of the document to retrieve.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="GetDocumentResponse"/>.</returns>
        Task<GetDocumentResponse> Get(string documentId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a specific document by its ID.
        /// </summary>
        /// <param name="documentId">The ID of the document to delete.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="DeleteDocumentResponse"/>.</returns>
        Task<DeleteDocumentResponse> Delete(string documentId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a specific document by its ID.
        /// </summary>
        /// <param name="id">The ID of the document to update.</param>
        /// <param name="request">The request object containing the updated document information.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="UpdateDocumentResponse"/>.</returns>
        Task<UpdateDocumentResponse> Update(string id, UpdateDocumentRequest request, CancellationToken cancellationToken = default);

        /// <summary>
        /// Downloads a specific document by its ID.
        /// </summary>
        /// <param name="id">The ID of the document to download.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="DownloadDocumentResponse"/>.</returns>
        Task<DownloadDocumentResponse> Download(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Lists document links based on filter criteria.
        /// </summary>
        /// <param name="request">The request object containing filter criteria for document links.</param>
        /// <param name="cancellationToken">Cancellation token for the asynchronous operation.</param>
        /// <returns>A task representing the asynchronous operation, with a result of <see cref="ListDocumentLinksResponse"/>.</returns>
        Task<ListDocumentLinksResponse> ListDocumentLinks(ListDocumentLinksRequest request, CancellationToken cancellationToken = default);
    }
}