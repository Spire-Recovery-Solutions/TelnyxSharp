using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.Json;

namespace TelnyxSharp.Base
{
    /// <summary>
    /// The HTTP method for a <see cref="TelnyxRequest"/>.
    /// Mirrors the RestSharp <c>Method</c> names the operation files reference.
    /// </summary>
    public enum TelnyxMethod
    {
        Get,
        Post,
        Put,
        Patch,
        Delete
    }

    /// <summary>
    /// Describes how a parameter participates in a request.
    /// Mirrors the RestSharp <c>ParameterType</c> names the operation files reference.
    /// </summary>
    public enum ParameterType
    {
        /// <summary>Parameter is appended to the query string.</summary>
        QueryString,

        /// <summary>
        /// Parameter is added to the query string, or (when a file is present) to the multipart body.
        /// This is the default for <see cref="TelnyxRequest.AddParameter(string, object?)"/>.
        /// </summary>
        GetOrPost,

        /// <summary>Parameter represents the raw request body.</summary>
        RequestBody
    }

    /// <summary>
    /// A single parameter entry. Stored in an ordered list so duplicate names
    /// (e.g. repeated <c>key[]</c> filters) are preserved on the wire.
    /// </summary>
    public sealed class TelnyxParameter
    {
        public string Name { get; }
        public object? Value { get; }
        public ParameterType Type { get; }

        public TelnyxParameter(string name, object? value, ParameterType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
    }

    /// <summary>
    /// A request builder that mirrors the RestSharp <c>RestRequest</c> surface the operation files use,
    /// but produces native <see cref="HttpRequestMessage"/> instances backed by <see cref="HttpClient"/>.
    /// <para>
    /// A single builder may be sent more than once (pagination increments <c>page[number]</c> and re-sends),
    /// so callers must obtain a fresh <see cref="HttpRequestMessage"/> for every send via
    /// <see cref="BuildHttpRequestMessage"/> — an <see cref="HttpRequestMessage"/> cannot be reused.
    /// </para>
    /// </summary>
    public class TelnyxRequest
    {
        private readonly List<TelnyxParameter> _parameters = new();
        private readonly List<KeyValuePair<string, string>> _headers = new();
        private readonly List<FilePart> _files = new();
        private string? _body;

        /// <summary>The relative resource path (e.g. <c>"documents"</c>), resolved against the client's base address.</summary>
        public string Resource { get; }

        /// <summary>The HTTP method for this request.</summary>
        public TelnyxMethod Method { get; }

        /// <summary>The ordered parameter store. Exposed so the pagination loop can locate and replace <c>page[number]</c>.</summary>
        public IReadOnlyList<TelnyxParameter> Parameters => _parameters;

        private sealed class FilePart
        {
            public string Name { get; init; } = string.Empty;
            public byte[] Bytes { get; init; } = Array.Empty<byte>();
            public string FileName { get; init; } = string.Empty;
        }

        /// <summary>Initializes a request for the given resource using <see cref="TelnyxMethod.Get"/>.</summary>
        public TelnyxRequest(string resource) : this(resource, TelnyxMethod.Get) { }

        /// <summary>Initializes a request for the given resource and method.</summary>
        public TelnyxRequest(string resource, TelnyxMethod method)
        {
            Resource = resource;
            Method = method;
        }

        /// <summary>
        /// Adds a parameter using the default <see cref="ParameterType.GetOrPost"/> behavior.
        /// </summary>
        public TelnyxRequest AddParameter(string name, object? value)
            => AddParameter(name, value, ParameterType.GetOrPost);

        /// <summary>
        /// Adds a parameter with the specified <see cref="ParameterType"/>.
        /// </summary>
        public TelnyxRequest AddParameter(string name, object? value, ParameterType type)
        {
            _parameters.Add(new TelnyxParameter(name, value, type));
            return this;
        }

        /// <summary>
        /// Removes a previously added parameter instance (used by the pagination loop to drop the
        /// current <c>page[number]</c> before re-adding it with an incremented value).
        /// </summary>
        public TelnyxRequest RemoveParameter(TelnyxParameter? parameter)
        {
            if (parameter != null)
                _parameters.Remove(parameter);
            return this;
        }

        /// <summary>Adds a header, replacing any existing header with the same name.</summary>
        public TelnyxRequest AddOrUpdateHeader(string name, object value)
        {
            _headers.RemoveAll(h => string.Equals(h.Key, name, StringComparison.OrdinalIgnoreCase));
            _headers.Add(new KeyValuePair<string, string>(name, value?.ToString() ?? string.Empty));
            return this;
        }

        /// <summary>Adds a header.</summary>
        public TelnyxRequest AddHeader(string name, string value)
        {
            _headers.Add(new KeyValuePair<string, string>(name, value));
            return this;
        }

        /// <summary>
        /// Sets the JSON request body. The operation files pass an already-serialized JSON string;
        /// such strings are used verbatim. Any other object is serialized via the source-gen context.
        /// </summary>
        public TelnyxRequest AddJsonBody(object body) => AddBody(body);

        /// <summary>
        /// Sets the JSON request body. The operation files pass an already-serialized JSON string;
        /// such strings are used verbatim. Any other object is serialized via the source-gen context.
        /// </summary>
        [UnconditionalSuppressMessage("Trimming", "IL2026",
            Justification = "All operation files pass a pre-serialized JSON string; the reflective Serialize fallback is never reached at runtime.")]
        [UnconditionalSuppressMessage("AOT", "IL3050",
            Justification = "All operation files pass a pre-serialized JSON string; the reflective Serialize fallback is never reached at runtime.")]
        public TelnyxRequest AddBody(object body)
        {
            _body = body as string
                ?? JsonSerializer.Serialize(body, body.GetType(), TelnyxJsonSerializerContext.Default.Options);
            return this;
        }

        /// <summary>Adds a file as a multipart/form-data part.</summary>
        public TelnyxRequest AddFile(string name, byte[] bytes, string fileName)
        {
            _files.Add(new FilePart { Name = name, Bytes = bytes, FileName = fileName });
            return this;
        }

        /// <summary>
        /// Builds a fresh <see cref="HttpRequestMessage"/> from the current builder state.
        /// Must be called once per send: <see cref="HttpRequestMessage"/> instances cannot be reused.
        /// </summary>
        public HttpRequestMessage BuildHttpRequestMessage()
        {
            var query = BuildQueryString();
            var uri = string.IsNullOrEmpty(query) ? Resource : $"{Resource}?{query}";

            var message = new HttpRequestMessage(MapMethod(Method), uri);

            if (_files.Count > 0)
            {
                var multipart = new MultipartFormDataContent();
                foreach (var file in _files)
                {
                    var fileContent = new ByteArrayContent(file.Bytes);
                    multipart.Add(fileContent, file.Name, file.FileName);
                }

                // GetOrPost / RequestBody parameters become form fields alongside the file(s).
                foreach (var p in _parameters)
                {
                    if (p.Type is ParameterType.QueryString) continue;
                    multipart.Add(new StringContent(p.Value?.ToString() ?? string.Empty), p.Name);
                }

                message.Content = multipart;
            }
            else if (_body != null)
            {
                message.Content = new StringContent(_body, Encoding.UTF8, "application/json");
            }

            foreach (var header in _headers)
            {
                // Content-Type is owned by the content (multipart boundary / json) — never set it as a request header.
                if (string.Equals(header.Key, "Content-Type", StringComparison.OrdinalIgnoreCase))
                    continue;

                message.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            return message;
        }

        /// <summary>
        /// Assembles the query string from QueryString parameters (and, when no file is present,
        /// GetOrPost parameters). Bracketed keys are escaped via <see cref="Uri.EscapeDataString"/>,
        /// matching the wire format RestSharp produced. Duplicate names are preserved.
        /// </summary>
        private string BuildQueryString()
        {
            var parts = new List<string>();
            var hasFile = _files.Count > 0;

            foreach (var p in _parameters)
            {
                var goesToQuery = p.Type == ParameterType.QueryString
                                  || (p.Type == ParameterType.GetOrPost && !hasFile);
                if (!goesToQuery) continue;
                if (p.Value is null) continue;

                parts.Add($"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.Value.ToString() ?? string.Empty)}");
            }

            return string.Join("&", parts);
        }

        private static HttpMethod MapMethod(TelnyxMethod method) => method switch
        {
            TelnyxMethod.Get => HttpMethod.Get,
            TelnyxMethod.Post => HttpMethod.Post,
            TelnyxMethod.Put => HttpMethod.Put,
            TelnyxMethod.Patch => HttpMethod.Patch,
            TelnyxMethod.Delete => HttpMethod.Delete,
            _ => HttpMethod.Get
        };
    }
}
