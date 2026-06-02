# TelnyxSharp

A comprehensive .NET SDK for the Telnyx API, providing seamless integration with Telnyx telephony services including SMS/MMS messaging, voice calls, number management, WebRTC, and more. Built exclusively for .NET 9 with full async support and built-in rate limiting.

[![NuGet](https://img.shields.io/nuget/v/TelnyxSharp.svg)](https://www.nuget.org/packages/TelnyxSharp/)
[![Build Status](https://github.com/Spire-Recovery-Solutions/TelnyxSharp/workflows/Publish%20to%20NuGet/badge.svg)](https://github.com/Spire-Recovery-Solutions/TelnyxSharp/actions)
[![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Prerequisites

- **.NET 9.0 or later** (This SDK targets .NET 9 exclusively)
- A Telnyx account with API credentials

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

## Features

- 📱 **SMS/MMS Messaging** - Send and receive text and multimedia messages
- 📞 **Voice Calls** - Programmable voice capabilities
- 🔢 **Number Management** - Phone number ordering, porting, and configuration
- 🌐 **WebRTC** - Real-time communication support (via Blazor components)
- 📊 **10DLC Campaigns** - Support for A2P messaging campaigns
- 🔍 **Number Lookup** - Carrier and caller ID information
- 📝 **Call Detail Records** - Access and search call records
- ⚡ **Built-in Rate Limiting** - Automatic retry with exponential backoff
- 🔄 **Full Async Support** - All operations support async/await patterns
- 💉 **Dependency Injection Ready** - First-class DI support for modern .NET applications

## Requirements

- .NET 9.0 SDK or later
- Compatible with:
  - ASP.NET Core 9.0+
  - Blazor Server/WebAssembly 9.0+
  - Console Applications
  - Azure Functions
  - Any .NET 9.0+ compatible platform

## Contributing

We welcome contributions! Please read our [contributing guidelines](CONTRIBUTING.md) to get started.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
