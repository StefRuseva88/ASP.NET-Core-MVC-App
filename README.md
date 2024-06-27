# ASP.NET-Core-MVC-App
# Create Simple Pages in an ASP.NET Core App

This repository contains the exercise assignments for the **Create Simple Pages in an ASP.NET Core App** course at SoftUni.

## Table of Contents
1. [Introduction](#introduction)
2. [Prerequisites](#prerequisites)
3. [Getting Started](#getting-started)
   - [1. Create a New ASP.NET Core Project](#1-create-a-new-aspnet-core-project)
   - [2. Add Razor Pages](#2-add-razor-pages)
   - [3. Configure Routing](#3-configure-routing)
   - [4. Run the Application](#4-run-the-application)
4. [Exercise Assignments](#exercise-assignments)
5. [Conclusion](#conclusion)

## Introduction

This document outlines the steps and exercises for creating simple pages in an ASP.NET Core application. The goal is to familiarize you with the basics of ASP.NET Core and Razor Pages.

## Prerequisites

Before you begin, ensure you have the following installed:
- .NET 6.0 SDK or later
- Visual Studio 2022 or Visual Studio Code
- Basic knowledge of C# and HTML

## Getting Started

### 1. Create a New ASP.NET Core Project

1. Open Visual Studio 2022 or Visual Studio Code.
2. Create a new project.
3. Select **ASP.NET Core Web App**.
4. Choose a name for your project and specify the location.
5. Ensure **.NET 6.0 (Long-term support)** is selected.
6. Click **Create**.

### 2. Add Razor Pages

1. In Solution Explorer, right-click on the `Pages` folder.
2. Select **Add** > **New Item**.
3. Choose **Razor Page** and name it `Index`.
4. Repeat to add additional pages as needed.

### 3. Configure Routing

1. Open `Startup.cs` or `Program.cs` (depending on your project setup).
2. Ensure the following code is present to configure routing:

   ```csharp
   app.MapRazorPages();

