using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using Xunit;
using Xunit.Abstractions;

namespace TelnyxSharp.Tests.Numbers
{
    [Trait("Category", "Integration")]
    [Trait("Module", "Numbers")]
    public class PhoneNumberConfigurationTests : NumberManagementTestBase
    {
        public PhoneNumberConfigurationTests(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public async Task ListPhoneNumbers_ReturnsOwnedNumbers()
        {
            SkipIfNotIntegrationTest();

            var request = new ListNumbersRequest
            {
                PageSize = 10
            };

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.List(request);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);

            Output.WriteLine($"Found {response.Data?.Count ?? 0} owned phone numbers");

            if (response.Data != null)
            {
                foreach (var number in response.Data)
                {
                    Output.WriteLine($"Number: {number.PhoneNumber}");
                    Output.WriteLine($"  Status: {number.Status}");
                    Output.WriteLine($"  Connection: {number.ConnectionName}");
                    Output.WriteLine($"  Messaging Profile: {number.MessagingProfileName}");
                    
                    // ID is a string UUID
                    Assert.NotNull(number.Id);
                    Assert.NotEmpty(number.Id);
                    if (!string.IsNullOrEmpty(number.PhoneNumber))
                    {
                        AssertValidPhoneNumber(number.PhoneNumber);
                    }
                }
            }
        }

        [Fact]
        public async Task GetPhoneNumber_WithValidId_ReturnsDetails()
        {
            SkipIfNotIntegrationTest();

            // First, get a list of numbers to find a valid ID
            var listRequest = new ListNumbersRequest { PageSize = 1 };
            var listResponse = await Client.PhoneNumbers.PhoneNumberConfiguration.List(listRequest);

            if (listResponse?.Data == null || listResponse.Data.Count == 0)
            {
                Output.WriteLine("No phone numbers available for testing");
                return;
            }

            var phoneNumberId = listResponse.Data.First().Id;
            if (string.IsNullOrEmpty(phoneNumberId))
            {
                Output.WriteLine("Phone number ID is null or empty");
                return;
            }

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.Get(phoneNumberId);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            Assert.Equal(phoneNumberId, response.Data.Id);
            
            Output.WriteLine($"Retrieved phone number: {response.Data.PhoneNumber}");
            Output.WriteLine($"  Type: {response.Data.PhoneNumberType}");
            Output.WriteLine($"  Status: {response.Data.Status}");
            Output.WriteLine($"  Created: {response.Data.CreatedAt}");
        }

        [Fact]
        public async Task UpdatePhoneNumberConfiguration_ModifiesSettings()
        {
            SkipIfNotIntegrationTest();

            // First, get a phone number to test with
            var listRequest = new ListNumbersRequest { PageSize = 1 };
            var listResponse = await Client.PhoneNumbers.PhoneNumberConfiguration.List(listRequest);

            if (listResponse?.Data == null || listResponse.Data.Count == 0)
            {
                Output.WriteLine("No phone numbers available for testing");
                return;
            }

            var phoneNumber = listResponse.Data.First();
            var phoneNumberId = phoneNumber.Id;
            if (string.IsNullOrEmpty(phoneNumberId))
            {
                Output.WriteLine("Phone number ID is null or empty");
                return;
            }

            var originalTags = phoneNumber.Tags;

            // Update configuration with tags
            var updateRequest = new UpdateNumberConfigurationRequest
            {
                Tags = new[] { $"{TestPrefix}integration_test", "test_tag" }
            };

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.Update(phoneNumberId, updateRequest);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);
            if (response.Data.Tags != null)
            {
                Assert.Contains($"{TestPrefix}integration_test", response.Data.Tags);
            }

            // Restore original tags
            var restoreRequest = new UpdateNumberConfigurationRequest
            {
                Tags = originalTags?.ToArray() ?? new string[0]
            };
            
            await Client.PhoneNumbers.PhoneNumberConfiguration.Update(phoneNumberId.ToString(), restoreRequest);
            Output.WriteLine("Restored original configuration");
        }

        [Fact]
        public async Task ListPhoneNumbers_WithFilters_ReturnsFilteredResults()
        {
            SkipIfNotIntegrationTest();

            var request = new ListNumbersRequest
            {
                PageSize = 10,
                Status = "active"
            };

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.List(request);

            Assert.NotNull(response);
            Assert.NotNull(response.Data);

            if (response.Data != null)
            {
                foreach (var number in response.Data)
                {
                    Output.WriteLine($"Number: {number.PhoneNumber}, Status: {number.Status}");
                    
                    if (!string.IsNullOrEmpty(number.Status))
                    {
                        Assert.Equal("active", number.Status.ToLower());
                    }
                }
            }
        }
    }
}