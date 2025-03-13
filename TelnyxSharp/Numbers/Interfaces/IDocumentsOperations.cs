namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Defines the document-related operations available within the Telnyx API.
    /// </summary>
    public interface IDocumentsOperations
    {
        /// <summary>
        /// Provides operations related to managing documents.
        /// </summary>
        IDocumentOperations Document { get; }

        /// <summary>
        /// Provides operations related to managing requirements for documents.
        /// </summary>
        IRequirementsOperations Requirements { get; }

        /// <summary>
        /// Provides operations related to managing requirement types for documents.
        /// </summary>
        IRequirementTypesOperations RequirementTypes { get; }
    }
}