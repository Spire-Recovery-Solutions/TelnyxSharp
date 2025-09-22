# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

TelnyxSharp is a .NET SDK for the Telnyx API, providing a comprehensive client library for interacting with Telnyx telephony services including SMS/MMS, voice calls, number management, and WebRTC functionality.

## Build and Development Commands

**Note: dotnet CLI is located at `~/.dotnet/dotnet`**

### Build the project
```bash
~/.dotnet/dotnet build
~/.dotnet/dotnet build --configuration Release
```

### Run tests
```bash
~/.dotnet/dotnet test
~/.dotnet/dotnet test TelnyxSharp.Tests/TelnyxSharp.Tests.csproj
```

### Run a single test
```bash
~/.dotnet/dotnet test --filter "FullyQualifiedName~TestClassName.TestMethodName"
~/.dotnet/dotnet test --filter "DisplayName~TestName"
```

### Package creation
```bash
~/.dotnet/dotnet pack --configuration Release
```

### Restore dependencies
```bash
~/.dotnet/dotnet restore
```

## Architecture Overview

### Core Structure

The SDK follows a modular architecture with these key components:

1. **TelnyxClient** (`TelnyxSharp/TelnyxClient.cs`): Main entry point that provides lazy-loaded access to all API operations
2. **Base Operations** (`TelnyxSharp/Base/`): Common functionality and interfaces shared across all operations
3. **Domain-Specific Operations**: Organized by functionality:
   - `Messaging/` - SMS/MMS, 10DLC campaigns, toll-free verification
   - `Voice/` - Programmable voice operations
   - `Numbers/` - Phone number management, porting, documents
   - `Identity/` - Number lookup operations
   - `DetailRecords/` - Call detail records search
   - `V1Operations/` - Legacy V1 API support

### Key Design Patterns

- **Lazy Loading**: All API operation sections are lazy-loaded to optimize memory usage
- **Rate Limiting**: Built-in Polly-based retry policies for rate limit handling
- **Dependency Injection Support**: Can be used directly or registered with DI container via `AddTelnyxClient` extension
- **Async/Await**: All API operations are async-first

### API Versions

- **V2 API** (Primary): `https://api.telnyx.com/v2/` - Used for most operations
- **V1 API** (Legacy): `https://api.telnyx.com/` - Optional, requires separate credentials

### Testing

- Uses xUnit as the test framework
- Tests located in `TelnyxSharp.Tests/`
- Mocking with Moq for unit tests

### WebRTC Components

The solution includes a Blazor WebRTC component library (`TelnyxSharp.Components.BlazorWebRTC/`) for building real-time communication features in Blazor applications.

## External Resources

- **Telnyx API OpenAPI Specification**: https://github.com/team-telnyx/openapi
- **NuGet Package**: Published automatically via GitHub Actions on push to main branch

## Development Notes

- Target Framework: .NET 9.0
- Package dependencies managed via NuGet
- Continuous deployment configured in `.github/workflows/publish.yml`
- Rate limiting and retry policies are built into the client
- Debug logging can be enabled by setting `debugMode = true` in TelnyxClient constructor