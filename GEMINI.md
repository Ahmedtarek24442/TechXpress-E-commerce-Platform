# NeatThread - Project Context

## Project Overview
NeatThread is an e-commerce platform for an online clothing store, developed with **ASP.NET Core**. The project aims to provide a secure and user-friendly shopping experience, including product browsing, a shopping cart, secure checkout with Stripe integration, and an administrative dashboard for inventory and order management.

### Technical Stack
- **Framework:** .NET 10.0 (ASP.NET Core)
- **Database:** SQL Server (Planned with Entity Framework Core)
- **Authentication:** ASP.NET Identity (Planned)
- **Architecture:** N-Tier Architecture (Planned separation of Presentation, Business Logic, and Data Access layers)
- **Patterns:** Repository and Unit of Work patterns (Planned)

### Current Status
The project is currently in the initial setup phase. The codebase contains the default ASP.NET Core Web API template. Detailed requirements and design specifications are available in `Neathread2/README.md` and the `Neathread2/Documentation/` directory.

## Building and Running
As a standard .NET 10 web project, use the following commands:

- **Restore dependencies:** `dotnet restore`
- **Build the project:** `dotnet build`
- **Run the application:** `dotnet run --project Neathread2/Neathread2.csproj`
- **Development mode (with hot reload):** `dotnet watch --project Neathread2/Neathread2.csproj`

## Development Conventions
Based on the project documentation, the following conventions and architectural goals should be followed:

### Architecture
- **N-Tier Separation:** Ensure logic is separated into distinct layers (Web/API, Services/BLL, Data/DAL) as implementation progresses.
- **Dependency Injection:** Use the built-in ASP.NET Core DI container for service registration.

### Coding Standards
- **Naming:** Follow standard C#/.NET PascalCase naming conventions for classes and methods.
- **Nullability:** Nullable reference types are enabled (`<Nullable>enable</Nullable>`).
- **Safety:** Implement role-based access control (Admin vs. Customer) using ASP.NET Identity.

### Testing & Validation
- **Status:** No test projects are currently initialized.
- **Requirement:** New features should include unit tests following the planned N-Tier structure.

## Key Files & Directories
- `Neathread2/Program.cs`: Entry point and service configuration.
- `Neathread2/README.md`: Comprehensive project specification and team structure.
- `Neathread2/Documentation/`: Contains ERDs, schema designs, and project documentation.
- `Neathread2/appsettings.json`: Configuration settings (Logging, Connection Strings, etc.).
