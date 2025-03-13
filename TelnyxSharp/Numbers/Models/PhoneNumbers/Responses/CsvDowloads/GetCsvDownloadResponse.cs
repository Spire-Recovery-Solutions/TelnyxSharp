using TelnyxSharp.Models;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.CsvDownloads;

namespace TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.CsvDowloads
{
    /// <summary>
    /// Represents the response for retrieving CSV downloads.
    /// This includes a list of <see cref="CsvDownload"/> objects containing details of the downloads.
    /// </summary>
    public class GetCsvDownloadResponse : TelnyxResponse<List<CsvDownload>>
    {
    }
}
