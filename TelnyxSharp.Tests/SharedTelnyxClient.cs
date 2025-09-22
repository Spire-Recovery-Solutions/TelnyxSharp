using System;

namespace TelnyxSharp.Tests
{
    /// <summary>
    /// Provides a shared singleton instance of TelnyxClient for all tests.
    /// This ensures proper rate limiting across test execution.
    /// </summary>
    public static class SharedTelnyxClient
    {
        private static readonly Lazy<TelnyxClient> _lazyClient = new Lazy<TelnyxClient>(() =>
        {
            var apiKey = Environment.GetEnvironmentVariable("TELNYX_API_KEY");
            var v1ApiUser = Environment.GetEnvironmentVariable("TELNYX_V1_API_USER");
            var v1ApiToken = Environment.GetEnvironmentVariable("TELNYX_V1_API_TOKEN");
            
            // Always enable debug mode for integration tests to capture API mismatches
            var debugLogPath = Path.Combine(Path.GetTempPath(), "TelnyxTests", "Logs");
            
            return new TelnyxClient(apiKey, v1ApiUser, v1ApiToken, debugMode: true, debugLogPath: debugLogPath);
        });

        /// <summary>
        /// Gets the shared TelnyxClient instance.
        /// </summary>
        public static TelnyxClient Instance => _lazyClient.Value;

        /// <summary>
        /// Gets whether integration tests are enabled (API key is set).
        /// </summary>
        public static bool IsIntegrationTestEnabled => 
            !string.IsNullOrEmpty(Environment.GetEnvironmentVariable("TELNYX_API_KEY"));
    }
}