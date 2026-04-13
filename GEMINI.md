# Neathread

## Project Overview
Neathread is a modern web application built using the ASP.NET Core MVC framework. It targets **.NET 10.0** and follows standard MVC (Model-View-Controller) architectural patterns. The application uses server-side rendering for its views and includes standard client-side libraries like Bootstrap and jQuery for styling and interaction.

- **Primary Framework:** ASP.NET Core 10.0 (Web SDK)
- **Architecture:** MVC (Model-View-Controller)
- **Frontend Technologies:** CSHTML (Razor Views), CSS, JavaScript, Bootstrap, jQuery
- **Configuration:** Managed through `appsettings.json` and `Program.cs`

## Project Structure
- `Neathread/Controllers/`: Contains the application logic for handling HTTP requests.
- `Neathread/Models/`: Data models used for views and application state.
- `Neathread/Views/`: Razor components for the user interface.
- `Neathread/wwwroot/`: Static assets (CSS, JS, libraries).
- `Neathread.slnx`: New XML-based Visual Studio solution file.

## Building and Running

### Prerequisites
- .NET 10 SDK or later

### Commands
- **Build the project:**
  ```bash
  dotnet build
  ```
- **Run the project:**
  ```bash
  dotnet run --project Neathread/Neathread.csproj
  ```
- **Watch for changes (Hot Reload):**
  ```bash
  dotnet watch --project Neathread/Neathread.csproj
  ```
- **Restore dependencies:**
  ```bash
  dotnet restore
  ```

## Development Conventions
- **Nullable Reference Types:** Enabled (`<Nullable>enable</Nullable>`).
- **Implicit Usings:** Enabled (`<ImplicitUsings>enable</ImplicitUsings>`).
- **Standard Routing:** Uses default MVC route pattern `{controller=Home}/{action=Index}/{id?}`.
- **Static Assets:** Managed through `MapStaticAssets()` in `Program.cs`.
- **Naming Conventions:** Follows standard C# and .NET naming conventions (PascalCase for classes and methods, camelCase for local variables).
