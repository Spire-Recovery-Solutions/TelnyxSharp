# Telnyx.NET

Welcome to the Telnyx.NET SDK! This library provides a simple and intuitive way to interact with the Telnyx API using .NET. 🚀

## Installation

To install the Telnyx.NET SDK, you can use the NuGet package manager:

```bash
dotnet add package Telnyx.NET
```

Or via the NuGet Package Manager Console:

```bash
Install-Package Telnyx.NET
```

## Usage

Here's a quick example to get you started:

```csharp
using Telnyx.NET;
using Telnyx.NET.Messaging.Models.Messages.Requests;
using Telnyx.NET.Messaging.Models.Messages.Responses;

var apiKey = "YOUR_API_KEY";
var client = new TelnyxClient(apiKey);

// Create a message request
var messageRequest = new SendMessageRequest
{
    From = "+1234567890",
    To = new List<string> { "+0987654321" },
    Text = "Hello from Telnyx.NET!"
};

// Send the message
SendMessageResponse response = await client.Messages.Send(messageRequest);

Console.WriteLine($"Message sent with ID: {response.Id}");
```

## Contributing

We welcome contributions! Please read our [contributing guidelines](CONTRIBUTING.md) to get started.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
