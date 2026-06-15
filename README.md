# Unit Conversion API

## Overview

Unit Conversion API is a RESTful ASP.NET Core Web API that converts numerical values between different units of measurement.

The application currently supports the following conversion categories:

* Length

  * Meter
  * Kilometer
  * Foot
  * Centimeter
  * Millimeter

* Weight

  * Gram
  * Kilogram
  * Pound

* Temperature

  * Celsius
  * Fahrenheit
  * Kelvin

The solution is designed to be easily extensible, allowing additional conversion categories and units to be added with minimal changes to the existing codebase.

---

## Project Structure

```text
UnitConversionApi/
│
├── UnitConversionApi/          # ASP.NET Core Web API
├── UnitConversionApi.Tests/    # xUnit test project
└── README.md
```

---

## Technologies Used

* ASP.NET Core (.NET 10)
* Dependency Injection
* Swagger / OpenAPI
* xUnit

---

## Running the Application Locally

### Prerequisites

* .NET 10 SDK
* Visual Studio 2022 or Visual Studio Code

### Clone the Repository

```bash
git clone <repository-url>
```

### Restore Dependencies

Navigate to the solution folder and run:

```bash
dotnet restore
```

### Build the Solution

```bash
dotnet build
```

### Run the Application

```bash
dotnet run --project UnitConversionApi
```

After the application starts, open the URL displayed in the console and navigate to:

```text
/swagger
```

to access the Swagger UI and test the API endpoints.

---

## Running Unit Tests

Execute the following command from the solution directory:

```bash
dotnet test
```

---

## Sample Request

### POST /api/conversion/convert

```json
{
  "category": "Length",
  "value": 10,
  "fromUnit": "Meter",
  "toUnit": "Foot"
}
```

### Sample Response

```json
{
  "category": "Length",
  "fromUnit": "Meter",
  "toUnit": "Foot",
  "originalValue": 10,
  "convertedValue": 32.8084
}
```

---

## Design Decisions

### Strategy-Based Design

Each conversion category is implemented as a separate converter class that implements a common `IUnitConverter` interface. This separates conversion logic by category and makes the application easier to maintain and extend.

### Dependency Injection

ASP.NET Core's built-in dependency injection container is used to manage services and converter implementations, promoting loose coupling and testability.

### Extensibility

Although conversion factors are currently hardcoded to satisfy the assignment requirements, the design allows future enhancements such as:

* Database-backed unit definitions
* Additional conversion categories
* External configuration sources

### Testing

Unit tests are implemented using xUnit to verify conversion accuracy and ensure reliable behavior.

---

## Trade-Offs

* Conversion factors and unit definitions are stored in memory rather than a database to keep the implementation simple and focused on the conversion logic.
* Authentication and authorization are not included because they are outside the scope of this project.
* Only a subset of units is implemented, but the architecture is designed to support future expansion with minimal changes.

---

## Future Enhancements

Potential future improvements include:

* Support for additional measurement categories
* Database-driven unit management
* Caching for frequently used conversions
* Versioned APIs
* Additional automated test coverage

```
```
