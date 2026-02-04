# Entishar - Simple .NET Core MVC App

## Description
This is a simple ASP.NET Core MVC application built for a technical task.  
It includes:
- User Authentication (Login / Logout)
- User Management (CRUD for Users)
- Server-side Validation
- Session-based authentication
- Simple UI (no CSS framework)

---

## Features

1. **Authentication**
   - Login page
   - Session-based authentication
   - Only active users can log in
   - After login, redirected to Home page with a welcome message

2. **User Management**
   - Create, Read, Update, Delete (CRUD) Users
   - Fields:
     - Id
     - Username
     - Password (plain text as per task requirement)
     - UserFullName
     - IsActive
     - DateOfBirth
     - CreationDate
   - Only logged-in users can access Edit/Delete/Index pages
   - Anyone can access Create page to register a new user

3. **Validation**
   - Server-side validation for required fields
   - DataType validation for DateOfBirth
   - UserFullName, Username, and Password are required

---

## Prerequisites

- .NET 8 SDK
- SQL Server Express (or any SQL Server)
- Visual Studio 2022 or later

---

## Setup Instructions

1. **Clone the repository**
```bash
git clone <your-repo-link>
