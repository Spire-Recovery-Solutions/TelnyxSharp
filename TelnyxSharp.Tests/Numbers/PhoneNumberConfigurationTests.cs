using TelnyxSharp.Numbers.Models.PhoneNumbers.Requests.PhoneNumberConfigurations;
using TUnit.Assertions;
using TUnit.Assertions.Extensions;
using TUnit.Core;

namespace TelnyxSharp.Tests.Numbers
{
    public sealed class PhoneNumberConfigurationTests : NumberManagementTestBase
    {
        [Test]
        public async Task ListPhoneNumbers_ReturnsOwnedNumbers()
        {
            SkipIfNotIntegrationTest();

            var request = new ListNumbersRequest
            {
                PageSize = 10
            };

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.List(request);

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();

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
                    await Assert.That(number.Id).IsNotNull();
                    await Assert.That(number.Id).IsNotEmpty();
                    if (!string.IsNullOrEmpty(number.PhoneNumber))
                    {
                        await AssertValidPhoneNumber(number.PhoneNumber);
                    }
                }
            }
        }

        [Test]
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

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();
            await Assert.That(response.Data.Id).IsEqualTo(phoneNumberId);
            
            Output.WriteLine($"Retrieved phone number: {response.Data.PhoneNumber}");
            Output.WriteLine($"  Type: {response.Data.PhoneNumberType}");
            Output.WriteLine($"  Status: {response.Data.Status}");
            Output.WriteLine($"  Created: {response.Data.CreatedAt}");
        }

        [Test]
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

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();
            if (response.Data.Tags != null)
            {
                await Assert.That(response.Data.Tags).Contains($"{TestPrefix}integration_test");
            }

            // Restore original tags
            var restoreRequest = new UpdateNumberConfigurationRequest
            {
                Tags = originalTags?.ToArray() ?? new string[0]
            };
            
            await Client.PhoneNumbers.PhoneNumberConfiguration.Update(phoneNumberId.ToString(), restoreRequest);
            Output.WriteLine("Restored original configuration");
        }

        [Test]
        public async Task ListPhoneNumbers_WithFilters_ReturnsFilteredResults()
        {
            SkipIfNotIntegrationTest();

            var request = new ListNumbersRequest
            {
                PageSize = 10,
                Status = "active"
            };

            var response = await Client.PhoneNumbers.PhoneNumberConfiguration.List(request);

            await Assert.That(response).IsNotNull();
            await Assert.That(response.Data).IsNotNull();

            if (response.Data != null)
            {
                foreach (var number in response.Data)
                {
                    Output.WriteLine($"Number: {number.PhoneNumber}, Status: {number.Status}");

                    if (!string.IsNullOrEmpty(number.Status))
                    {
                        await Assert.That(number.Status.ToLower()).IsEqualTo("active");
                    }
                }
            }
        }
    }
}