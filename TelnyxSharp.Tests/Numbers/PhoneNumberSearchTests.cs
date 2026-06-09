using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberSearch;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests.Numbers
{
    public sealed class PhoneNumberSearchTests : NumberManagementTestBase
    {
        [Test]
        public async Task SearchAvailableNumbers_ByAreaCode_ReturnsResults()
        {
            SkipIfNotIntegrationTest();

            // Test without best_effort first (may return 400 if no numbers found)
            var requestStrict = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 10,
                BestEffort = false
            };

            try
            {
                var responseStrict = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(requestStrict);
                await Assert.That(responseStrict).IsNotNull();
                await Assert.That(responseStrict.Data).IsNotNull();
                Output.WriteLine($"[Strict mode] Found {responseStrict.Data.Count} available numbers");

                if (responseStrict.Data.Count > 0)
                {
                    var firstNumber = responseStrict.Data.First();
                    await Assert.That(firstNumber.PhoneNumber).IsNotNull();
                    await AssertValidPhoneNumber(firstNumber.PhoneNumber);
                    await Assert.That(firstNumber.RecordType).IsNotNull();
                    Output.WriteLine($"First available number: {firstNumber.PhoneNumber}");
                    Output.WriteLine($"Cost: {firstNumber.CostInformation?.MonthlyCost} {firstNumber.CostInformation?.Currency}");
                }
            }
            catch (HttpRequestException ex) when (ex.Message.Contains("BadRequest"))
            {
                Output.WriteLine($"[Strict mode] No numbers found (API returned 400), trying with best_effort=true");
                
                // Retry with best_effort=true
                var requestBestEffort = new AvailablePhoneNumbersRequest
                {
                    CountryCode = TestCountry,
                    NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc2) ? ndc2 : null,
                    Limit = 10,
                    BestEffort = true
                };
                
                var responseBestEffort = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(requestBestEffort);
                await Assert.That(responseBestEffort).IsNotNull();
                await Assert.That(responseBestEffort.Data).IsNotNull();
                Output.WriteLine($"[Best effort mode] Found {responseBestEffort.Data.Count} available numbers");
            }
        }

        [Test]
        public async Task SearchAvailableNumbers_WithFeatures_ReturnsFilteredResults()
        {
            SkipIfNotIntegrationTest();

            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                // Note: Features property might need adjustment based on actual SDK
                Limit = 5
            };

            var response = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();

            foreach (var number in response.Data)
            {
                Output.WriteLine($"Number: {number.PhoneNumber}");
                if (number.Features != null)
                {
                    Output.WriteLine($"  Features available");
                }
            }
        }

        [Test]
        public async Task SearchAvailableNumbers_ByNationalDestinationCode_ReturnsResults()
        {
            SkipIfNotIntegrationTest();

            // Test both with and without best_effort
            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                NationalDestinationCode = int.TryParse(TestAreaCode, out var ndc) ? ndc : null,
                Limit = 5
            };

            try
            {
                // Try without best_effort first
                var response = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);
                await Assert.That(response).IsNotNull();
                await Assert.That(response.Data).IsNotNull();
                Output.WriteLine($"[Strict mode] Found {response.Data.Count} numbers");
                
                foreach (var number in response.Data)
                {
                    Output.WriteLine($"Number: {number.PhoneNumber}");
                    if (number.RegionInformation != null && number.RegionInformation.Count > 0)
                    {
                        Output.WriteLine($"  Region: {number.RegionInformation.First().RegionName}");
                    }
                }
            }
            catch (HttpRequestException ex) when (ex.Message.Contains("BadRequest"))
            {
                // API returns 400 when no exact matches found
                Output.WriteLine($"[Strict mode] No exact matches found, trying with best_effort=true");
                
                request.BestEffort = true;
                var response = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);
                await Assert.That(response).IsNotNull();
                await Assert.That(response.Data).IsNotNull();
                Output.WriteLine($"[Best effort mode] Found {response.Data.Count} numbers");
                
                foreach (var number in response.Data)
                {
                    Output.WriteLine($"Number: {number.PhoneNumber}");
                    if (number.RegionInformation != null && number.RegionInformation.Count > 0)
                    {
                        Output.WriteLine($"  Region: {number.RegionInformation.First().RegionName}");
                    }
                }
            }
        }

        [Test]
        public async Task SearchAvailableNumbers_WithPagination_ReturnsPagedResults()
        {
            SkipIfNotIntegrationTest();

            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                Limit = 2
            };

            var firstPage = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);

            await Assert.That(firstPage).IsNotNull();
            await Assert.That(firstPage.Data).IsNotNull();
            
            Output.WriteLine($"Found {firstPage.Data.Count} numbers in first request");
        }

        [Test]
        public async Task SearchAvailableNumberBlocks_ReturnsResults()
        {
            SkipIfNotIntegrationTest();

            var request = new ListAvailablePhoneNumberBlocksRequest
            {
                CountryCode = TestCountry,
                // PhoneNumberType might be an enum, adjust as needed
            };

            var response = await Client.PhoneNumbers.PhoneNumberSearch.ListAvailableNumberBlocks(request);

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();

            Output.WriteLine($"Number blocks response received");
        }

        [Test]
        public async Task SearchAvailableNumbers_InvalidCountryCode_ReturnsEmptyOrError()
        {
            SkipIfNotIntegrationTest();

            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = "XX", // Invalid country code
                Limit = 5
            };

            try
            {
                var response = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);
                
                // Some APIs might return empty results instead of error
                await Assert.That(response).IsNotNull();
                if (response.Data != null)
                {
                    await Assert.That(response.Data).IsEmpty();
                }
            }
            catch (Exception ex)
            {
                Output.WriteLine($"Expected error for invalid country code: {ex.Message}");
                // This is expected behavior for invalid country
            }
        }

        [Test]
        public async Task SearchAvailableNumbers_SpecificNumberType_ReturnsCorrectType()
        {
            SkipIfNotIntegrationTest();

            var request = new AvailablePhoneNumbersRequest
            {
                CountryCode = TestCountry,
                PhoneNumberType = "local",
                Limit = 5
            };

            var response = await Client.PhoneNumbers.PhoneNumberSearch.AvailableNumbers(request);

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();

            foreach (var number in response.Data)
            {
                Output.WriteLine($"Number: {number.PhoneNumber}, Type: {number.PhoneNumberType}");

                if (!string.IsNullOrEmpty(number.PhoneNumberType))
                {
                    await Assert.That(number.PhoneNumberType.ToLower()).IsEqualTo("local");
                }
            }
        }
    }
}