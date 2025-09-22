using System;
using System.Threading.Tasks;
using TelnyxSharp;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = Environment.GetEnvironmentVariable("TELNYX_API_KEY");
        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Please set TELNYX_API_KEY environment variable");
            return;
        }
        
        var client = new TelnyxClient(apiKey, debugMode: true, debugLogPath: "./test_debug");
        
        try
        {
            Console.WriteLine("Testing rate limiting behavior...");
            
            // Try to make rapid requests to trigger rate limiting
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Request #{i + 1}");
                var request = new ListNumberOrdersRequest();
                var response = await client.PhoneNumbers.PhoneNumberOrders.List(request);
                Console.WriteLine($"  Success: {response.IsSuccessful}, Status: {response.StatusCode}");
                
                if (response.IsSuccessful && response.Data != null)
                {
                    Console.WriteLine($"  Orders found: {response.Data.Count}");
                }
                
                // Small delay to test rate limiting
                await Task.Delay(100);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.GetType().Name}: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"  Inner: {ex.InnerException.GetType().Name}: {ex.InnerException.Message}");
            }
        }
    }
}