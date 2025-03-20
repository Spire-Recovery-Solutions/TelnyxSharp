namespace TelnyxSharp.V1Operations.Interfaces
{
    /// <summary>
    /// Defines operations for interacting with Telnyx v1 endpoints.
    /// This interface currently exposes functionality related to CDR requests,
    /// including creating, listing, retrieving, and deleting CDR requests.
    /// </summary>
    public interface IV1ApiOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations for managing CDR requests via the v1 API.
        /// </summary>
        ICdrRequestsOperations CdrRequests { get; }
    }
}