#  Image Upload with Cloudinary – ASP.NET Core MVC + Web API

This project is an **ASP.NET Core MVC application** integrated with a **Web API** that uploads images to **Cloudinary**.  
It demonstrates full **CRUD operations**, **image upload**, **Cloudinary integration**, and **clean architecture using Repository Pattern**.

---

##  Features

- **Add Human**: Save name, gender, and profile picture.
- **Cloudinary Integration**: Upload images via a dedicated Web API.
- **Instant Preview**: View the image immediately after selection using JavaScript.
- **Hybrid Storage**: Stores profile images as `byte[]` in SQL Server for data integrity.
- **Full CRUD**: List, Edit, and Delete records with ease.
- **Clean Architecture**: Implements the Repository pattern for the image service.

---

##  Technologies Used

- **Framework**: ASP.NET Core 8.0 (MVC & Web API)
- **Database**: SQL Server (Entity Framework Core)
- **Cloud Storage**: Cloudinary (.NET SDK)
- **Frontend**: Bootstrap 5, JavaScript (Fetch API)

---

##  Project Folder Structure
```
image_API/
├──  Controllers/
│   ├── AdminController.cs      # Handles Web UI logic (Returning Views for Add/Edit/List).
│   └── ImageController.cs      # API Endpoint for image processing (returns JSON/data).
│
├──  Data/
│   └── HumanDbContext.cs       # Entity Framework Core context; manages SQL Server connection.
│
├──  ImageRepository/          # Abstraction Layer for Image Handling
│   ├── IImageRepo.cs           # Contract defining image operations (Upload, Delete, etc.).
│   └── CloudinaryImageRepo.cs  # Third-party implementation for Cloudinary cloud storage.
│
├──  Models/
│   ├── Domain/                 # Enterprise/Database Entities
│   │   └── Human.cs            # Maps directly to the SQL database table.
│   └── ViewModels/             # Data Transfer Objects (DTOs) for UI
│       ├── AddHumanViewModel.cs   # Form data required for creating a record.
│       └── EditHumanViewModel.cs  # Data required for updating existing records.
│
├──  Views/                   # Razor Pages for the Admin Dashboard
│   └── Admin/
│       ├── Add.cshtml          # Form to create new "Human" entries.
│       ├── List.cshtml         # Data table to display all records.
│       └── Edit.cshtml         # Form to modify existing entries.
│
├──  Configuration/
│   ├── appsettings.json        # Stores Connection Strings and Cloudinary API Keys.
│   ├── Program.cs              # Application startup; handles Dependency Injection (DI) registration.
│   └── README.md               # Project documentation and setup guide.
```
