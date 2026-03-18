# Student Management System - Full Stack Backend

## Project Overview
This project provides a comprehensive backend solution for an academic management system. It transitions from a relational database design to a functional RESTful API built with .NET 9.0 and SQL Server.

## Phase 1: Database Architecture

Requirements Analysis: Designed a relational model for a Student Management Information System (SMIS).

Normalization: Implemented 3rd Normal Form (3NF) to eliminate data redundancy.

Schema Design: Created four core tables:

Departments: Academic units.

Students: Profiles linked to departments.

Courses: Subject catalog.

Enrollments: Junction table for many-to-many relationships.

Integrity: Enforced Primary Keys, Foreign Keys, and Check Constraints using T-SQL.

## Phase 2: API & Backend Development

Framework: Developed using ASP.NET Core Web API and C#.

ORM: Integrated Entity Framework Core to map SQL tables to C# Models.

CRUD Operations: Implemented full Create, Read, Update, and Delete logic for student records.

Documentation: Integrated Swagger/OpenAPI for real-time API testing and endpoint visualization.

## Technical Stack

Language: C#

Backend Framework: .NET 9.0 / ASP.NET Core

Database: Microsoft SQL Server

ORM: Entity Framework Core (EF Core)

Tools: Visual Studio 2022, SSMS, Git, NuGet

## API Endpoints (CRUD)

GET /api/Students: Retrieves a list of all students.

POST /api/Students: Adds a new student record (automatically handles ID generation).

PUT /api/Students/{id}: Updates existing student details based on a matching ID.

DELETE /api/Students/{id}: Removes a student record from the database.

## How to Run the Project

### 1. Database Setup

Navigate to the /scripts folder.

Execute Schema.sql to create the table structures.

Execute SeedData.sql to populate the tables with sample data.

Update the ConnectionStrings in appsettings.json with your local SQL Server instance details.

### 2. Launch the API

Open the solution file (.sln) in Visual Studio.

Select the http profile from the debug dropdown menu.

Press F5 to start the application.

Open your browser and go to http://localhost:5178/swagger to start testing.
