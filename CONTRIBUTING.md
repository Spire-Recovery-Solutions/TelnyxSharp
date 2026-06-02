# Contributing to TelnyxSharp

Thank you for your interest in contributing to TelnyxSharp! We welcome contributions from the community and are grateful for any help you can provide.

## Prerequisites

Before contributing, please ensure you have:

- .NET 9.0 SDK or later installed
- Git for version control
- A GitHub account
- Familiarity with the [Telnyx API documentation](https://developers.telnyx.com)

## Getting Started

1. **Fork the Repository**
   - Click the "Fork" button on the GitHub repository page
   - Clone your fork locally:
     ```bash
     git clone https://github.com/YOUR_USERNAME/TelnyxSharp.git
     cd TelnyxSharp
     ```

2. **Create a Branch**
   - Create a new branch for your feature or bug fix:
     ```bash
     git checkout -b feature/your-feature-name
     # or
     git checkout -b fix/your-bug-fix
     ```

3. **Set Up Development Environment**
   - Restore dependencies:
     ```bash
     dotnet restore
     ```
   - Build the project:
     ```bash
     dotnet build
     ```

## Development Guidelines

### Code Style

- Follow C# coding conventions and .NET naming guidelines
- Use meaningful variable and method names
- Keep methods focused and concise
- Add XML documentation comments to all public APIs
- Ensure your code is properly formatted (use IDE auto-format)

### Testing

- Write unit tests for new features
- Ensure all existing tests pass:
  ```bash
  dotnet test
  ```
- Aim for high code coverage on new code
- Test edge cases and error conditions

### Commit Messages

- Use clear and descriptive commit messages
- Follow the pattern: `type: brief description`
- Types: `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`
- Example: `feat: add support for number porting API`

## Making Changes

### For Bug Fixes

1. Ensure the bug is reproducible
2. Write a failing test that demonstrates the bug
3. Fix the bug
4. Ensure the test now passes
5. Run all tests to ensure nothing else broke

### For New Features

1. Discuss the feature in an issue first
2. Implement the feature following our patterns
3. Add comprehensive tests
4. Update documentation and examples
5. Ensure backward compatibility when possible

### For Documentation

- Update README.md for user-facing changes
- Add XML documentation to new public APIs
- Include code examples where helpful
- Check for spelling and grammar

## Submitting Changes

1. **Commit Your Changes**
   ```bash
   git add .
   git commit -m "type: your descriptive message"
   ```

2. **Push to Your Fork**
   ```bash
   git push origin your-branch-name
   ```

3. **Create a Pull Request**
   - Go to the original repository on GitHub
   - Click "New Pull Request"
   - Select your fork and branch
   - Fill in the PR template with:
     - Description of changes
     - Related issue numbers
     - Testing performed
     - Breaking changes (if any)

## Pull Request Guidelines

Your PR should:

- Have a clear title and description
- Reference any related issues
- Pass all CI checks
- Include tests for new functionality
- Not break existing functionality
- Be based on the latest `main` branch
- Have commits squashed if there are many small commits

## Code Review Process

1. A maintainer will review your PR
2. Address any feedback or requested changes
3. Once approved, your PR will be merged
4. Your contribution will be included in the next release

## API Implementation Guidelines

When implementing new Telnyx API endpoints:

1. **Follow Existing Patterns**
   - Check similar operations in the codebase
   - Use the same base classes and interfaces
   - Follow the async/await pattern

2. **Model Structure**
   - Create request/response models in appropriate namespace
   - Use `JsonPropertyName` attributes for JSON mapping
   - Implement nullable reference types correctly

3. **Operations Class**
   - Inherit from `BaseOperations`
   - Implement standard CRUD methods as applicable
   - Include proper error handling

4. **Integration**
   - Add the new operations to `TelnyxClient`
   - Update `TelnyxJsonSerializerContext` with new types
   - Add to dependency injection setup if needed

## Questions or Need Help?

- Open an issue for bugs or feature requests
- Start a discussion for questions or ideas
- Check existing issues and PRs to avoid duplicates
- Review the [Telnyx API documentation](https://developers.telnyx.com)

## Recognition

Contributors will be recognized in our release notes. Thank you for helping make TelnyxSharp better!

## License

By contributing, you agree that your contributions will be licensed under the MIT License.