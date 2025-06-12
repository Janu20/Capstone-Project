# Capstone-Project
#  Online Book Library System (MVC – Single Controller)

**A simple ASP.NET Core MVC web app to manage a personal library of books (CRUD), backed by SQL Server.**

---

##  Table of Contents

- [About the Project](#about-the-project)  
- [Features](#features)  
- [Tech Stack](#tech-stack)  
- [Prerequisites](#prerequisites)  
- [Setup & Installation](#setup--installation)  
- [Usage](#usage)  
- [Project Structure](#project-structure)  
- [Database Schema](#database-schema)  
- [Deployment](#deployment)  

---

##  About the Project

This project is a straightforward Online Book Library System implemented in ASP.NET Core MVC. It lets users **Create**, **Read**, **Update**, and **Delete** book entries—ideal for learning MVC, EF Core, Razor views, and SQL integration.

---

##  Features

- Add a new book  
- View a list of all books  
- Edit and update book details  
- View detailed information about each book  
- Delete books with confirmation  

---

##  Tech Stack

- **ASP.NET Core MVC**  
- **Entity Framework Core**  
- **SQL Server** / Azure SQL  
- **Razor Views** styled with Bootstrap  
- **Azure App Service** deployment  
- **Git** for version control

---

##  Prerequisites

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)  
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (LocalDB / Express / Azure SQL)  
- Git installed locally  

---

##  Setup & Installation

```bash
git clone https://github.com/yourusername/OnlineBookLibrarySystem.git
cd OnlineBookLibrarySystem
dotnet restore
# Update `appsettings.json` with your SQL Server connection string
dotnet ef database update
dotnet run

##Usage

Navigate to /Books.

Click Create New to add books.

Use Edit or Details for book-specific actions.

Use Delete for removing entries (confirmation required).

##Project Structure

OnlineBookLibrarySystem/
├── Controllers/
│   └── BooksController.cs
├── Models/
│   └── Book.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Views/
│   └── Books/ (Index, Create, Edit, Details, Delete)
├── appsettings.json
└── README.md

##Database Schema

| Column        | Type   | Description         |
| ------------- | ------ | ------------------- |
| Id            | int    | Primary Key         |
| Title         | string | Book title          |
| Author        | string | Author's name       |
| Genre         | string | Genre/category      |
| PublishedYear | int    | Year published      |
| IsAvailable   | bool   | Availability status |


##Deployment

-->  Set up an Azure App Service and Azure SQL instance

--> Update ConnectionStrings:DefaultConnection in appsettings.json

--> Publish via Visual Studio or dotnet publish

--> Apply EF Core migrations (dotnet ef database update)

--> Visit your live URL


