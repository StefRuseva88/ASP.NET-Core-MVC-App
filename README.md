# ASP.NET Core MVC WebApp
[![C#](https://img.shields.io/badge/Made%20with-C%23-239120.svg)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-5C2D91.svg)](https://dotnet.microsoft.com/)
[![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4.svg)](https://github.com/dotnet/aspnetcore)

---
### This repository contains the assignments for the **ASP.NET Fundamentals** course @ SoftUni

## Table of Contents
1. [Introduction](#introduction)
2. [Prerequisites](#prerequisites)
3. [Getting Started](#getting-started)
   - [1. Create a New ASP.NET Core MVC Project](#1-create-a-new-aspnet-core-mvc-project)
   - [2. Add Controllers and Views](#2-add-controllers-and-views)
   - [3. Configure Routing](#3-configure-routing)
   - [4. Run the Application](#4-run-the-application)
4. [Assignments](#assignments)
5. [Conclusion](#conclusion)
6. [Contributing](#contributing)
7. [License](#license)
8. [Contact](#contact)

## Introduction
This document outlines the steps and tasks for creating an ASP.NET Core MVC application. The goal is to familiarize you with the basics of ASP.NET Core and the Model-View-Controller (MVC) pattern.

## Prerequisites
Before you begin, ensure you have the following installed:
- .NET 6.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

## Getting Started
### 1. Create a New ASP.NET Core MVC Project
- Open Visual Studio 2022 or Visual Studio Code.
- Create a new project.
- Select **ASP.NET Core Web App (Model-View-Controller)**.
- Choose a name for your project and specify the location.
- Ensure **.NET 6.0 (Long-term support)** is selected.

### 2. Add Controllers and Views
- In Solution Explorer, right-click on the `Controllers` folder.
- Select **Add** > **Controller**.
- Choose **MVC Controller - Empty** and name it `HomeController`.
- Repeat to add additional controllers as needed.
- To add views, right-click on the `Views` folder, create a new folder with the name of your controller (e.g., `Home`), and add a new view (e.g., `Index.cshtml`) within that folder.

### 3. Configure Routing
1. Open `Startup.cs` or `Program.cs` (depending on your project setup).
2. Ensure the following code is present to configure routing:

   ```csharp
   app.UseRouting();
   app.UseEndpoints(endpoints =>
   {
       endpoints.MapControllerRoute(
           name: "default",
           pattern: "{controller=Home}/{action=Index}/{id?}");
   });

### 4. Run the Application
Press `F5` or click the **Run** button to start the application.

Open a web browser and navigate to `https://localhost:{port}` to view your pages.

## Assignments
### Task 1: Create a Home Page
- Create an Index action in the HomeController.
- Add a view for the Index action.
- Add a welcome message and some basic HTML content.
- Ensure it is set as the default page.

### Task 2: Create an About Page
- Create an `About` page.
- Add information about the application or the developer.
- Link this page from the home page.

### Task 3: Create a Contact Page
- Create a `Contact` page.
- Add a form for users to submit their contact information.
- Implement basic form validation.

### Task 4: Add Navigation Links
- To add links, go the `_Layout.cshtml` partial view in the `/Views/Shared` folder, as this view is responsible for
the common design of all pages.
- The `asp-controller` and `asp-action` tag helpers set the controller and action names of the page.
- Try out if the links work correctly.

### Task 5: Create "Products Controller" 
- Create the `ProductController` in the "Controllers" folder.
- Create a `ProductViewModel` for these products, which should have an id,name and price.
- Add a field with products to the `ProductController`.

### Task 6: Create "All Products" Page
- **Return "All Products" as JSON**.
- **Return "All Products" as Plain Text**.
- **Download "All Products" as Text File**.
- **Access the "All Products" Page on Another URL**.
- **Add Search to the "All Products" Page**.

### Task 7: Add Navigation Links
- Modify the `_Layout.cshtml` view to have all the necessary links.
- Try out all new links in the browser. They should access the correct pages.
  
### Task 8: Create Simple Chat ASP.NET Core MVC App

### Task 9: Create Text Splitter App

### Task 10: Styling the Pages
- Add a `wwwroot` folder and include a CSS file.
- Apply basic styling to your pages.
- Ensure the styles are consistent across all pages.
  
## Conclusion
By completing these tasks, you will have a basic understanding of how to create and manage simple pages in an ASP.NET Core application using Model-View-Controller. For more advanced features and functionalities, refer to the official [ASP.NET Core documentation](https://docs.microsoft.com/en-us/aspnet/core/).

## Contributing
Contributions are welcome! If you have any improvements or bug fixes, feel free to open a pull request.

## License
This project is licensed under the [MIT License](LICENSE). See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or suggestions, please open an issue in the repository.
