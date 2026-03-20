# C# Coding Standards for CSE 210 Examples

These examples are designed for an introductory Object-Oriented Programming class. To ensure clarity for students and focus on fundamental concepts, adhere to the following traditional C# syntax rules:

## Core Mandates

- **No Modern Syntax:** Avoid "syntactic sugar" introduced in later versions of C# that might obscure underlying logic for beginners.
- **Private Member Variables:** Use explicit private fields with an underscore prefix (e.g., `private string _name;`).
- **No Automatic Properties:** Do not use `{ get; set; }`. Use explicit private fields and provide public methods (like `GetName()`) or full properties if access is required.
- **No LINQ:** Use traditional `foreach` loops and conditional logic instead of LINQ extension methods (e.g., `.Where()`, `.Select()`).
- **No `var` Keyword:** Always use explicit type declarations (e.g., `List<Book> books = new List<Book>();` instead of `var books = ...`).
- **No Lambda Expressions:** Avoid the `=>` operator. Use named methods or traditional delegates if necessary.
- **String Interpolation is Permitted:** Using `$""` and `string.Format()` is acceptable for building strings.
- **Explicit Types:** Prioritize readability and explicit structure over brevity.
- **Single Class Per File:** Each public class must be defined in its own file, where the filename matches the class name (e.g., `Book.cs` for `public class Book`).

## Project Structure & Configuration

- **Target Framework:** All projects must target **.NET 10.0** (`<TargetFramework>net10.0</TargetFramework>`).
- **Solution Integration:** Every `.csproj` file must be added to the root solution file (`cse210-examples.slnx`).
- **VS Code Integration:** Every project must have a corresponding launch configuration in `.vscode/launch.json` to allow for easy debugging.
