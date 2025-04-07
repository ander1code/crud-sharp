# CrudSharp 2.0

![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white&color=blue)
![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?logo=.net&logoColor=white&color=blue)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?logo=microsoftsqlserver&logoColor=white) ![PostgreSQL](https://img.shields.io/badge/PostgreSQL-4169E1?logo=postgresql&logoColor=white&color=darkblue) ![SQLite](https://img.shields.io/badge/SQLite-003B57?logo=sqlite&logoColor=white&color=blue) ![MySQL](https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=white&color=orange)
![Platform: Windows](https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=white)
![Last Commit](https://img.shields.io/github/last-commit/ander1code/crud-sharp?color=yellow&logo=github) ![Size](https://img.shields.io/github/repo-size/ander1code/crud-sharp?color=blue&logo=files) ![License](https://img.shields.io/github/license/ander1code/crud-sharp?color=black&logo=open-source-initiative)

## 1. Description
**CrudSharp 2.0** is a versatile registration system developed in **C#**, featuring multi-database support. The system allows users to choose their preferred database during configuration, ensuring flexibility across different environments.

## 2. System Characteristics
- **Database Connection Options:**
  - SQL Server
  - PostgreSQL
  - SQLite
  - MySQL
- **Login System:** Secured with **SHA512 encryption**.
- **Registration Features:**
  - Physical person registration.
  - Juridical person registration.
- **Search Functionality:**
  - Physical person search.
  - Juridical person search.
- **Reports:** Generate and view detailed data reports.
- **User Management:** Manage users and their roles within the system.
- **System Log:** Text-based logging for system activities and errors.
- **Toolbar Icon Management:** Option to hide icons in the toolbar.

## 3. Software and Tools Used
- **IDE:** Visual Studio 2013
- **Framework:** .NET Framework 4.8
- **Database Connection Libraries:**
  - `SqlConnection` for SQL Server.
  - `NpgsqlConnection` for PostgreSQL.
  - `SQLiteConnection` for SQLite.
  - `MySqlConnection` for MySQL.

### Design Patterns Implemented
To ensure scalability and maintainability, the following design patterns were used:
- **Singleton:** Manages a single instance of objects across the application.
- **Facade:** Simplifies complex subsystems for easy interaction.
- **Factory:** Creates objects without specifying their concrete classes.
- **Abstract Factory:** Provides an interface for creating families of related objects.
- **Adapter:** Allows incompatible interfaces to work together.

---