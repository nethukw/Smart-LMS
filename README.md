# SmartLMS — Learning Management System

**SmartLMS** is a Windows desktop Learning Management System (LMS) built with **C#**, **Windows Forms**, and **MySQL**. It is designed to help educational institutions manage users, courses, assignments, submissions, grading, and day-to-day academic activities through role-specific interfaces.

> **Project type:** Desktop application  
> **Developer:** Nethmi Wijekoon  
> **Development environment:** Microsoft Visual Studio  
> **Project files:** `SmartLMS.sln` and the `SmartLMS/` application folder

## Overview

SmartLMS brings core teaching and learning workflows into one application. Students can access course information and assignments, lecturers can manage coursework and review submissions, and administrators can oversee users, courses, and system activity.

The application is organized around three user roles: **Admin**, **Lecturer**, and **Student**.

## Key Features

### Authentication and profiles
- Login and registration interfaces with role selection.
- Dedicated dashboards for administrators, lecturers, and students.
- User profile and password-management interfaces.

### Student tools
- View enrolled courses, schedules, and lecturer details.
- Browse assignments and search or filter by course/title.
- Track assignment due dates and submission status.
- Submit assignment files with optional comments.
- Access discussion/forum navigation where available.

### Lecturer tools
- View and manage assigned courses.
- Create, edit, and remove course assignments.
- Review student submissions and open submitted files.
- Record grades and feedback.
- View and search student lists.

### Administration
- Dashboard with user, course, and assignment summaries.
- Add, view, update, and delete user records.
- Manage courses and assign lecturers.
- Access analytics, reports, and user activity information through the admin interface.

### Additional interfaces
- Search and filtering controls throughout the application.
- Settings screen for appearance and other preferences.
- Forms for course creation, user registration, and administration.

> **Implementation note:** Features above are based on the supplied SmartLMS project proposal and interface documentation. Some documented screens or controls may represent designed functionality; implementation and database integration should be verified in the source code.

## Technology Stack

| Component | Technology |
| --- | --- |
| Programming language | C# |
| Desktop user interface | Windows Forms (.NET) |
| Database | MySQL |
| Database connectivity | MySQL Connector / project-configured MySQL library |
| IDE | Microsoft Visual Studio |
| Project format | Visual Studio solution (`.sln`) |

## Project Structure

The solution structure shown in the project folder is approximately:

```text
SmartLMS/
├── SmartLMS.sln          # Visual Studio solution
├── SmartLMS/             # C# Windows Forms application
│   ├── Properties/
│   ├── Resources/
│   ├── *.cs               # Application and form logic
│   ├── *.Designer.cs      # Windows Forms designer code
│   ├── *.resx             # Form resources
│   └── App.config         # Application configuration
└── packages/              # Local NuGet package files (if present)
```

Generated folders such as `.vs/`, `bin/`, and `obj/` are **not** necessary in the GitHub repository and should be excluded using `.gitignore`.

## Getting Started

### Requirements

- Windows
- Microsoft Visual Studio with **.NET desktop development** support
- A compatible .NET Framework/.NET development target (check the project properties)
- MySQL Server
- NuGet package restore/internet access if the project uses NuGet dependencies

### 1. Clone the repository

```bash
git clone <YOUR_SMARTLMS_REPOSITORY_URL>
cd <YOUR_REPOSITORY_FOLDER>
```

Or download the repository as a ZIP and extract it.

### 2. Open the solution

Open `SmartLMS.sln` in Visual Studio. If prompted, restore the required NuGet packages. Check the application's targeted .NET version in its project properties and install the required developer pack if Visual Studio requests it.

### 3. Set up MySQL

1. Start a local MySQL instance.
2. Create or import the database using the **SQL schema/backup supplied with the project**, if one is available.
3. Check the application's configuration and data-access classes for the connection string.
4. Set the correct server, database name, username, and password for your local environment.

**Note:** The supplied documentation does not identify a database name or include an SQL initialization script. The program will need its actual database schema and a valid local connection configuration to run correctly.

**Security:** Do not commit actual database passwords or other secrets. Remove or replace any hard-coded credentials before publishing the source code.

### 4. Build and run

1. In Visual Studio, select the appropriate startup project.
2. Choose **Build > Build Solution**.
3. Start the application using **F5** or **Start**.
4. Use a test account configured in your local database to sign in, if the application requires one.

## Main User Roles

| Role | Primary responsibilities |
| --- | --- |
| **Admin** | Manage users and courses; access analytics and reports |
| **Lecturer** | Manage courses and assignments; review, grade, and provide feedback on submissions |
| **Student** | Explore enrolled courses, view assignments, submit work, and access lecturer information |

## Software Design

The project is designed around object-oriented programming principles and common desktop application patterns, including:

- **Encapsulation and abstraction:** organizing application functionality in classes and forms.
- **CRUD operations:** creating, reading, updating, and deleting academic and user records.
- **Role-based navigation:** providing interfaces appropriate to each user type.
- **Database integration:** working with structured academic records stored in MySQL.
- **Input validation and error handling:** important considerations for reliable desktop workflows.

## Learning Outcomes

Developing SmartLMS offered practical experience with:

- Building a multi-screen desktop application in C# and Windows Forms.
- Structuring course, student, assignment, and submission workflows.
- Working with relational data and database-driven interfaces.
- Designing role-specific navigation and administrative forms.
- Applying object-oriented design and CRUD concepts in an educational application.

## Project Documentation

The project includes separate documentation covering its original proposal and interface designs, including student, lecturer, and administrator screens. These documents can be added to the repository separately if desired.

## Author

**Nethmi Wijekoon**  
- [LinkedIn](https://www.linkedin.com/in/nethukzz)
- [Portfolio](https://nethmi-wijekoon-portfolio.netlify.app/)

---

*SmartLMS — a desktop-focused solution for managing academic workflows.*
