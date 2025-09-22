using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TelnyxSharp;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberOrders;
using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using Xunit;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests.Numbers
{
    public class NumberManagementTestFixture : IAsyncLifetime
    {
        private readonly TelnyxClient _client;
        private readonly bool _runIntegrationTests;
        private readonly bool _purchaseTestNumber;
        
        public string? PurchasedNumber { get; private set; }
        public string? PurchasedNumberId { get; private set; }
        public string? AvailableNumberToPurchase { get; private set; }
        
        public NumberManagementTestFixture()
        {
            _client = SharedTelnyxClient.Instance;
            _runIntegrationTests = Environment.GetEnvironmentVariable("TELNYX_RUN_INTEGRATION_TESTS") == "true";
            _purchaseTestNumber = Environment.GetEnvironmentVariable("TELNYX_PURCHASE_TEST_NUMBER") == "true";
        }
        
        public async Task InitializeAsync()
        {
            if (!_runIntegrationTests || !_purchaseTestNumber)
            {
                return;
            }
            
            // Check for existing test number
            var listRequest = new ListNumbersRequest
            {
                PageSize = 100
            };
            
            var existingNumbers = await _client.PhoneNumbers.PhoneNumberConfiguration.List(listRequest);
            if (existingNumbers?.Data != null)
            {
                var testNumber = existingNumbers.Data.FirstOrDefault(n => 
                    !string.IsNullOrEmpty(n.Id) && // Only use numbers with valid IDs
                    (n.CustomerReference == "SDK_TEST_NUMBER" || 
                     (n.Tags != null && n.Tags.Contains("SDK_TEST"))));
                    
                if (testNumber != null)
                {
                    PurchasedNumberId = testNumber.Id;
                    PurchasedNumber = testNumber.PhoneNumber;
                    return;
                }
            }
            
            // If no existing test number, purchase one
            var searchRequest = new AvailablePhoneNumbersRequest
            {
                CountryCode = "US",
                NationalDestinationCode = 716,
                Limit = 5,
                BestEffort = true,
                PhoneNumberType = "local"
            };
            
            var availableNumbers = await _client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(searchRequest);
            if (availableNumbers?.Data == null || !availableNumbers.Data.Any())
            {
                throw new InvalidOperationException("No 716 area code numbers available for testing");
            }
            
            AvailableNumberToPurchase = availableNumbers.Data.First().PhoneNumber;
            
            // Purchase the number
            var purchaseRequest = new CreateNumberOrderRequest
            {
                PhoneNumbers = new List<CreateNumberOrderPhoneNumber>
                {
                    new CreateNumberOrderPhoneNumber
                    {
                        PhoneNumber = AvailableNumberToPurchase
                    }
                },
                CustomerReference = "SDK_TEST_NUMBER"
            };
            
            var orderResponse = await _client.PhoneNumbers.PhoneNumberOrders.Create(purchaseRequest);
            if (orderResponse?.Data == null)
            {
                throw new InvalidOperationException("Failed to create number order");
            }
            
            // Wait for number to be provisioned with retry logic
            var purchasedPhoneNumber = await WaitForNumberProvisioningAsync(AvailableNumberToPurchase, listRequest);
            
            if (purchasedPhoneNumber != null)
            {
                PurchasedNumber = purchasedPhoneNumber.PhoneNumber;
                PurchasedNumberId = purchasedPhoneNumber.Id;
                Console.WriteLine($"[FIXTURE] Successfully provisioned number: {PurchasedNumber} (ID: {PurchasedNumberId})");
                
                // Track the purchase  
                var trackingPath = "/Users/smarter/srs-dev/TelnyxSharp/PURCHASE_TRACKING.md";
                if (File.Exists(trackingPath))
                {
                    var content = await File.ReadAllTextAsync(trackingPath);
                    var lines = content.Split('\n').ToList();
                    
                    // Find the line with purchased numbers table
                    var insertIndex = -1;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (lines[i].Contains("| Time | Phone Number | Order ID | Status | Notes |") && i + 2 < lines.Count)
                        {
                            // Insert after the separator line
                            insertIndex = i + 2;
                            break;
                        }
                    }
                    
                    if (insertIndex > 0 && insertIndex < lines.Count)
                    {
                        var newEntry = $"| {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC | {PurchasedNumber} | {orderResponse.Data.Id} | pending | Local 716 area code with SDK_TEST_NUMBER reference |";
                        lines.Insert(insertIndex, newEntry);
                    }
                    
                    await File.WriteAllTextAsync(trackingPath, string.Join('\n', lines));
                }
            }
            else
            {
                throw new InvalidOperationException($"Failed to provision number {AvailableNumberToPurchase} - number not found with valid ID after retries");
            }
        }
        
        public async Task DisposeAsync()
        {
            // Cleanup is manual per user requirements
            await Task.CompletedTask;
        }
        
        /// <summary>
        /// Waits for a newly purchased number to appear in the ListNumbers API with a valid ID.
        /// Uses exponential backoff retry logic to handle timing issues with number provisioning.
        /// </summary>
        private async Task<TelnyxSharp.Numbers.Models.PhoneNumbers.Responses.PhoneNumberConfigurations.NumberConfigurationData?> 
            WaitForNumberProvisioningAsync(string phoneNumber, TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations.ListNumbersRequest listRequest)
        {
            const int maxRetries = 6; // Up to ~2 minutes total (2+4+8+16+32+64 seconds) 
            const int baseDelayMs = 2000; // Start with 2 seconds
            const int maxDelayMs = 30000; // Cap at 30 seconds per attempt (local numbers provision faster)
            
            for (int attempt = 0; attempt < maxRetries; attempt++)
            {
                var delayMs = Math.Min(baseDelayMs * (int)Math.Pow(2, attempt), maxDelayMs);
                
                Console.WriteLine($"[FIXTURE] Attempt {attempt + 1}/{maxRetries}: Waiting {delayMs}ms for number {phoneNumber} to be provisioned...");
                await Task.Delay(delayMs);
                
                try
                {
                    var refreshedNumbers = await _client.PhoneNumbers.PhoneNumberConfiguration.List(listRequest);
                    if (refreshedNumbers?.Data != null)
                    {
                        var foundNumber = refreshedNumbers.Data.FirstOrDefault(n => n.PhoneNumber == phoneNumber);
                        
                        if (foundNumber != null)
                        {
                            if (!string.IsNullOrEmpty(foundNumber.Id))
                            {
                                Console.WriteLine($"[FIXTURE] SUCCESS: Number {phoneNumber} found with ID: {foundNumber.Id}");
                                return foundNumber;
                            }
                            else
                            {
                                Console.WriteLine($"[FIXTURE] Number {phoneNumber} found but ID is null/empty, retrying...");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"[FIXTURE] Number {phoneNumber} not found in list, retrying...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[FIXTURE] Error checking number status: {ex.Message}");
                }
            }
            
            Console.WriteLine($"[FIXTURE] TIMEOUT: Failed to find number {phoneNumber} with valid ID after {maxRetries} attempts");
            return null;
        }
    }
}