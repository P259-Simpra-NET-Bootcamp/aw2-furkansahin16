# AW2-SimparApi

## Project Description
AW2-SimparApi is an API project that enables CRUD operations on Staff entities. It is built using ASP.NET Core Web API 6.0. This project utilizes various technologies and frameworks, including:

- Entity Framework
- AutoMapper
- In-Memory Caching
- Fluent Validation
- MSSQL and PostgreSQL
- Bogus

## Installation
To run the AW2-SimparApi project locally, you can choose either of the following options:

1. **Using Git Command Line**:
   - Clone the repository from GitHub using the command: `git clone [repository URL]`
   - Navigate to the project directory: `cd AW2-SimparApi`
   - Build the project: `dotnet build`
   - Run the project: `dotnet run`

2. **Using GitHub**:
   - Visit the project repository on GitHub: [AW2-SimparApi](https://github.com/your-username/AW2-SimparApi)
   - Click on the **Code** button and select **Download ZIP**
   - Extract the downloaded ZIP file
   - Open the project in your preferred development environment
   - Build and run the project

## Usage
To configure the database type (MSSQL or PostgreSQL), you can modify the connection string in the `appsettings.json` file. Follow the steps below:

1. Open the `appsettings.json` file in your project.
2. Locate the `"ConnectionStrings"` section.
3. Set the appropriate connection string for either MSSQL or PostgreSQL.

**Sample Connection String Configuration:**

```json
"ConnectionStrings": {
  "DefaultConnection": "your-connection-string-here"
}

