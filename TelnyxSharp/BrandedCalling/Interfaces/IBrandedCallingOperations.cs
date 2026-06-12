namespace TelnyxSharp.BrandedCalling.Interfaces
{
    /// <summary>
    /// Provides operations for the Telnyx Branded Calling API — enterprise registration,
    /// Display Identity Records (DIRs), DIR phone numbers and batches, comments,
    /// infringement claims, reference data, and Terms of Service.
    /// </summary>
    public interface IBrandedCallingOperations : IDisposable
    {
        /// <summary>
        /// Gets the operations for managing enterprises — the legal entities that represent
        /// businesses on the Telnyx platform.
        /// </summary>
        IEnterpriseOperations Enterprises { get; }

        /// <summary>
        /// Gets the operations for managing Display Identity Records (DIRs) — the brand
        /// identities shown to call recipients.
        /// </summary>
        IDisplayIdentityRecordsOperations DisplayIdentityRecords { get; }

        /// <summary>
        /// Gets the operations for managing the phone numbers attached to a DIR.
        /// </summary>
        IDirPhoneNumberOperations PhoneNumbers { get; }

        /// <summary>
        /// Gets the operations for inspecting the phone-number batches of a DIR.
        /// </summary>
        IDirPhoneNumberBatchOperations PhoneNumberBatches { get; }

        /// <summary>
        /// Gets the operations for reading and posting customer-visible comments on a DIR.
        /// </summary>
        IDirCommentOperations Comments { get; }

        /// <summary>
        /// Gets the operations for handling infringement claims filed against a DIR.
        /// </summary>
        IInfringementClaimOperations InfringementClaims { get; }

        /// <summary>
        /// Gets the operations for Branded Calling reference data — the pre-vetted call-reason
        /// library and the supported document types.
        /// </summary>
        IBrandedCallingReferenceOperations ReferenceData { get; }

        /// <summary>
        /// Gets the operations for the Branded Calling Terms of Service.
        /// </summary>
        IBrandedCallingTosOperations TermsOfService { get; }
    }
}
