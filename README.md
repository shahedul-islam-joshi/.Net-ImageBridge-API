# 📸 Image Upload with Cloudinary – ASP.NET Core MVC + Web API

This project is an **ASP.NET Core MVC application** integrated with a **Web API** that uploads images to **Cloudinary**.  
It demonstrates full **CRUD operations**, **image upload**, **Cloudinary integration**, and **clean architecture using Repository Pattern**.

---

## 🚀 Features

- **Add Human**: Save name, gender, and profile picture.
- **Cloudinary Integration**: Upload images via a dedicated Web API.
- **Instant Preview**: View the image immediately after selection using JavaScript.
- **Hybrid Storage**: Stores profile images as `byte[]` in SQL Server for data integrity.
- **Full CRUD**: List, Edit, and Delete records with ease.
- **Clean Architecture**: Implements the Repository pattern for the image service.

---

## 🛠️ Technologies Used

- **Framework**: ASP.NET Core 8.0 (MVC & Web API)
- **Database**: SQL Server (Entity Framework Core)
- **Cloud Storage**: Cloudinary (.NET SDK)
- **Frontend**: Bootstrap 5, JavaScript (Fetch API)

---

## 📁 Project Folder Structure

```text
image_API
│
├── Controllers
│   ├── AdminController.cs      # MVC Logic
│   └── ImageController.cs      # API Logic
│
├── Data
│   └── HumanDbContext.cs       # SQL Database Context
│
├── ImageRepository
│   ├── IImageRepo.cs           # Interface
│   └── CloudinaryImageRepo.cs  # Implementation
│
├── Models
│   ├── Domain
│   │   └── Human.cs            # Database Entity
│   └── ViewModels
│       ├── AddHumanViewModel.cs
│       └── EditHumanViewModel.cs
│
├── Views
│   └── Admin
│       ├── Add.cshtml
│       ├── List.cshtml
│       └── Edit.cshtml
│
├── appsettings.json
├── Program.cs
└── README.md


hedul-islam-joshi/CRUD-ASP.NET-MVC.git](https://github.com/shahedul-islam-joshi/CRUD-ASP.NET-MVC.git)
cd CRUD-ASP.NET-MVC
