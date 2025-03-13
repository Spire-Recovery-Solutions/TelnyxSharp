using TelnyxSharp.Base;

namespace TelnyxSharp.Numbers.Models.NumberPortout.Requests
{
    /// <summary>
    /// Represents a request to list the rejection codes for port-out requests.
    /// This request can be filtered by a specific rejection code or a list of rejection codes.
    /// </summary>
    public class ListPortoutRejectionCodesRequest : ITelnyxRequest
    {
        /// <summary>
        /// Gets or sets a specific rejection code to filter the port-out rejection codes by.
        /// If provided, only rejection codes matching this specific code will be returned.
        /// </summary>
        public int? Code { get; set; }

        /// <summary>
        /// Gets or sets a list of rejection codes to filter the port-out rejection codes by.
        /// If provided, only rejection codes in this list will be returned.
        /// </summary>
        public List<int>? CodesIn { get; set; }
    }
}