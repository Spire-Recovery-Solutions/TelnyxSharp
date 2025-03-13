using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.CountryCoverage;

namespace TelnyxSharp.Numbers.Interfaces
{
    /// <summary>
    /// Provides operations related to country coverage for phone numbers, including retrieving coverage details for specific countries or for all countries.
    /// </summary>
    public interface ICountryCoverageOperations
    {
        /// <summary>
        /// Lists the country coverage details, such as phone number availability in different countries.
        /// </summary>
        /// <remarks>
        /// Use this operation to retrieve coverage details for all countries, including which phone numbers are available in each country.
        /// </remarks>
        /// <param name="cancellationToken">A token for cancelling the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation, containing a <see cref="ListCountryCoverageResponse"/> with the list of country coverages.
        /// </returns>
        Task<ListCountryCoverageResponse> List(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the country coverage details for a specific country, identified by the country code.
        /// </summary>
        /// <remarks>
        /// This operation provides detailed coverage information for a specific country, including phone number availability and types.
        /// </remarks>
        /// <param name="countryCode">The country code (e.g., "US" for the United States) for which to retrieve coverage details.</param>
        /// <param name="cancellationToken">A token for cancelling the operation.</param>
        /// <returns>
        /// A task that represents the asynchronous operation, containing a <see cref="GetCountryCoverageResponse"/> with the country's coverage details.
        /// </returns>
        Task<GetCountryCoverageResponse> Get(string countryCode, CancellationToken cancellationToken = default);
    }
}
