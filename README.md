# TelnyxSharp

Welcome to the TelnyxSharp SDK! This library provides a simple and intuitive way to interact with the Telnyx API using .NET. 🚀

## Installation

To install the TelnyxSharp SDK, you can use the NuGet package manager:

```bash
dotnet add package TelnyxSharp
```

Or via the NuGet Package Manager Console:

```bash
Install-Package TelnyxSharp
```

## Usage

### Direct Initialization

Here's a quick example to get you started:

```csharp
using TelnyxSharp;
using TelnyxSharp.Messaging.Models.Messages.Requests;
using TelnyxSharp.Messaging.Models.Messages.Responses;

var apiKey = "YOUR_API_KEY";
var client = new TelnyxClient(apiKey);

// Create a message request
var messageRequest = new SendMessageRequest
{
    From = "+1234567890",
    To = new List<string> { "+0987654321" },
    Text = "Hello from TelnyxSharp!"
};

// Send the message
SendMessageResponse response = await client.Messages.Send(messageRequest);

Console.WriteLine($"Message sent with ID: {response.Id}");
```

### Using Dependency Injection

For applications using Microsoft.Extensions.DependencyInjection, you can register the Telnyx client in your service collection:

```csharp
using Microsoft.Extensions.DependencyInjection;
using TelnyxSharp;

// In your Startup.cs or Program.cs
services.AddTelnyxClient(options =>
{
    options.ApiKey = "YOUR_API_KEY";
});
```

Then inject ITelnyxClient into your classes:

```csharp
public class MessagingService
{
    private readonly ITelnyxClient _telnyxClient;

    public MessagingService(ITelnyxClient telnyxClient)
    {
        _telnyxClient = telnyxClient;
    }

    public async Task SendMessage(string to, string text)
    {
        var messageRequest = new SendMessageRequest
        {
            From = "+1234567890",
            To = new List<string> { to },
            Text = text
        };

        var response = await _telnyxClient.Messages.Send(messageRequest);
        Console.WriteLine($"Message sent with ID: {response.Id}");
    }
}
```

This approach is recommended for ASP.NET Core applications and other scenarios where you want to manage the lifetime of the client through dependency injection.

## Contributing

We welcome contributions! Please read our [contributing guidelines](CONTRIBUTING.md) to get started.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
