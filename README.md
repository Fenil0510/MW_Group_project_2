# MW_Group_project_2

Overview

This project is a Task Management System developed using ASP.NET Core MVC with Identity. The system allows users to create, assign, and manage tasks with proper role-based access control (Admin, Manager, User).

The main goal of this application is to demonstrate authentication, authorization, and secure task handling in a web application.

# Technologies Used
ASP.NET Core MVC (.NET 8)
Entity Framework Core
SQL Server
ASP.NET Identity
Bootstrap (for UI)
# Authentication & Security

The application uses ASP.NET Identity for secure authentication and authorization.

Implemented Security Features:
Password hashing (handled by Identity)
Role-based authorization (Admin, Manager, User)
Anti-forgery protection on all POST requests
Secure login system (no manual password handling)
Authentication cookies managed by Identity
Email confirmation handled programmatically (for testing)
# User Roles & Permissions
# Admin
View all tasks
Create tasks
Edit any task
Delete tasks
Assign roles to users
# Manager
View all tasks
Create tasks
Edit any task
❌ Cannot delete tasks
# User
View only their assigned tasks
Create tasks
Edit only their own tasks
❌ Cannot delete tasks
🧩 Features
✅ Task Management
Create new tasks
Assign tasks to users
Edit task details
View task list with status
Delete tasks (Admin only)
✅ Role Management
Admin can assign roles (Admin / Manager / User)
Roles control access to features
✅ UI Features
Clean and responsive interface using Bootstrap
Status badges (Pending, In Progress, Completed)
Dropdown for assigning users
Role-based button visibility (Edit/Delete)
🗄# Database Structure

The system uses SQL Server with the following main tables:

AspNetUsers → stores users
AspNetRoles → stores roles
AspNetUserRoles → maps users to roles
TaskItems → stores tasks
# Setup Instructions
Open the project in Visual Studio
Configure connection string in appsettings.json

Open Package Manager Console and run:

Update-Database
Run the application
# Default Admin User

A default admin is automatically created when the application runs:

Email: admin@gmail.com
Password: Admin@123
# System Logic
The system uses role-based filtering:
Users see only their tasks
Managers and Admins see all tasks
Edit permissions are restricted based on role
Delete functionality is restricted to Admin only
# Testing the System

You can test the following:

Register new users
Assign roles using Admin panel
Create and assign tasks
Verify role-based restrictions
📸 Screenshots Included
Login page
Admin dashboard
Role assignment
Task creation
Task list (role-based)
Edit & Delete functionality
# Conclusion

This project demonstrates a complete implementation of:

Authentication & Authorization
Role-based access control
Secure web application practices
MVC architecture with Entity Framework
