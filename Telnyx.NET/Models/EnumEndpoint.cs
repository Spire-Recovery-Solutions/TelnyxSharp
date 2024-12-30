namespace Telnyx.NET.Models
{
    /// <summary>
    /// Represents the various endpoints used within the Telnyx.NET system.
    /// </summary>
    public enum EnumEndpoint
    {
        /// <summary>
        /// Endpoint for Mobile Network Operator (MNO) information.
        /// </summary>
        Mno,

        /// <summary>
        /// Endpoint for retrieving optional attributes.
        /// </summary>
        OptionalAttributes,

        /// <summary>
        /// Endpoint for retrieving use case information.
        /// </summary>
        Usecase,

        /// <summary>
        /// Endpoint for retrieving vertical industry details.
        /// </summary>
        Vertical,

        /// <summary>
        /// Endpoint for retrieving alternative business identification types.
        /// </summary>
        AltBusinessIdType,

        /// <summary>
        /// Endpoint for checking the status of brand identity.
        /// </summary>
        BrandIdentityStatus,

        /// <summary>
        /// Endpoint for retrieving brand relationships.
        /// </summary>
        BrandRelationship,

        /// <summary>
        /// Endpoint for retrieving campaign statuses.
        /// </summary>
        CampaignStatus,

        /// <summary>
        /// Endpoint for retrieving entity type details.
        /// </summary>
        EntityType,

        /// <summary>
        /// Endpoint for retrieving external vetting provider details.
        /// </summary>
        ExtVettingProvider,

        /// <summary>
        /// Endpoint for checking vetting status.
        /// </summary>
        VettingStatus,

        /// <summary>
        /// Endpoint for retrieving brand statuses.
        /// </summary>
        BrandStatus,

        /// <summary>
        /// Endpoint for checking operational statuses.
        /// </summary>
        OperationStatus,

        /// <summary>
        /// Endpoint for approved public companies.
        /// </summary>
        ApprovedPublicCompany,

        /// <summary>
        /// Endpoint for retrieving stock exchange information.
        /// </summary>
        StockExchange,

        /// <summary>
        /// Endpoint for retrieving vetting classes.
        /// </summary>
        VettingClass
    }
}