# 🖥️ CLI Task Manager

A robust Command Line Interface (CLI) application for efficient task management, built with **C#**. This project is an implementation of the [Task Tracker](https://roadmap.sh/projects/task-tracker) challenge from **roadmap.sh**.

## 📌 Overview

CLI Task Manager is designed to handle task operations directly from the terminal. It emphasizes clean code architecture, separation of concerns, and state-based task tracking to provide an organized workflow for developers and power users.

## 🚀 Features

- **Task Management**: Add, Update, and Delete tasks seamlessly.
- **Status Tracking**: Mark tasks as:
  - `todo` (Not Done)
  - `in-progress`
  - `done`
- **Smart Filtering**:
  - List all tasks.
  - List only completed tasks.
  - List pending or in-progress tasks.
- **Persistent Storage**: All tasks are saved locally to ensure data persistence between sessions.

## 🏗️ Project Structure

CLI_Project/
│
├── Models/
│   └── data.cs          # Defines the Task data structure
├── Services/
│   ├── Service.cs       # Core business logic
│   └── FileService.cs   # JSON/File handling for persistence
├── Utilities/
│   └── Utility.cs       # Helper methods and formatting
├── Program.cs           # Entry point and CLI command parsing
└── CLI_Project.csproj

🛠️ Technologies Used
Language: C#

- Framework: .NET Console Application

- Storage: File-based (JSON/Plain Text)

- Version Control: Git

## 📦 How to Run

1. Clone the repository: git clone [https://github.com/adityaputras021/Simple-Crud-Console-Program-V2---Aditya](https://github.com/adityaputras021/Simple-Crud-Console-Program-V2---Aditya)
2. Navigate to the directory: cd CLI_Project
3. Run the application: dotnet run


## 🎯 Learning Objectives
This project was developed to master:

- CLI Design: Handling arguments and user inputs via terminal.
- CRUD Operations: Create, Read, Update, and Delete logic.
- Modularization: Applying clean architecture and separation of concerns.
- State Management: Managing task transitions and filtered views.

Developed by Aditya | Task Tracker Challenge
