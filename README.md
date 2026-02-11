Project Task URL : https://roadmap.sh/projects/task-tracker

🖥 CLI Task Manager

A Command Line Interface (CLI)–based Task Management application built with C#.
This application allows users to manage tasks efficiently through structured terminal commands.

📌 Overview

CLI Task Manager is a console application designed to handle task management operations directly from the terminal.
It implements structured logic, status tracking, and filtered task views to provide a clear and organized workflow.
The project emphasizes clean code organization and separation of concerns.

🚀 Features

- Add new tasks
- Update existing tasks
- Delete tasks
- Mark tasks as:
  - Not Done
  - In Progress
  - Done
- List all tasks
- List completed tasks
- List unfinished tasks
- List tasks in progress

🏗 Project Structure
CLI_Project/
│
├── Models/
│   └── data.cs
│
├── Services/
│   ├── Service.cs
│   └── FileService.cs
│
├── Utilities/
│   └── Utility.cs
│
├── Program.cs
└── CLI_Project.csproj

Structure Explanation
- Models → Defines the task data structure
- Services → Contains business logic and file handling
- Utilities → Helper methods
- Program.cs → Application entry point and CLI interaction

🛠 Technologies Used

- C#
- .NET Console Application
- File-based data storage
- Git for version control

📦 How to Run
1. Clone the repository:  git clone https://github.com/adityaputras021/Simple-Crud-Console-Program-V2---Aditya
2. Navigate to the project directory:  cd CLI_Project
3. Run the application:  dotnet run

🎯 Purpose

This project was built to strengthen understanding of:
-  CLI application development
-  CRUD operations
-  State-based task management
-  Code modularization and separation of concerns
-  Git workflow fundamentals
