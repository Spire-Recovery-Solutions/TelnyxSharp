using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.CsvDownloads
{
    /// <summary>
    /// Represents a request to list CSV downloads, including pagination options.
    /// </summary>
    public class ListCsvDownloadsRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets the number of items to include per page in the response.
        /// Defaults to 20 if not specified.
        /// </summary>
        public int PageSize { get; set; } = 20;
    }
}