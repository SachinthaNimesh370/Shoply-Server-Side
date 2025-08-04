# 🛒 Shoply Backend - ASP.NET Core Web API

This is the backend service for **Shoply**, a simple e-commerce product catalog application. It provides RESTful APIs to manage products and integrates with a frontend (e.g., built with React.js). This project uses **ASP.NET Core Web API**, **Entity Framework Core**, and **SQL Server**.

---

## 🚀 Features

- ✅ Product Listing (GET all products)
- 🔗 RESTful API built with ASP.NET Core
- 🗂️ Uses Entity Framework Core for data access
- 🔒 CORS policy setup for frontend integration
- 📦 Swagger UI for testing endpoints
- 🛢️ SQL Server database integration

---

## 🧱 Technologies Used

- ASP.NET Core 7 
- Entity Framework Core
- SQL Server
- Swagger (Swashbuckle)
- Dependency Injection
- CORS

---

## 📁 Project Structure
```

Shoply_Server_Side/
│
├── Shoply_Data_Access/
│   ├── Migrations/
│   ├── Class1.cs
│   └── ProductDbContext.cs
│
├── Shoply_Model/
│   ├── Product.cs
│   └── Rating.cs
│
├── Shoply_Server_Side/
│   ├── Controllers/
│   │   └── ProductController.cs
│   ├── appsettings.json
│   └── Program.cs
│
├── Shoply_Service/
│   ├── IProductRepository.cs
│   ├── ProductService.cs
│   └── ProductSQLServer.cs

```

---

## ⚙️ Setup Instructions

 1. Clone the repository

```bash
git clone https://github.com/SachinthaNimesh370/shoply-backend.git
cd shoply-backend
```

2. Update the database connection string
Edit appsettings.json:
```

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=ShoplyDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

3. Apply Migrations and Update Database
```
dotnet ef migrations add InitialCreate --project .\Shoply_Data_Access
dotnet ef database update --project .\Shoply_Data_Access
```

4. Run the application
```
dotnet run --project .\Shoply_Server_Side
```
---

API will be available at:

API Base URL: https://localhost:5175

---


🔄 API Endpoints
Method	Endpoint	Description
GET	/api/Product    	 Get all products
GET	/api/Product/{id}	 Get product by ID
---


🌐 CORS Configuration
Allows requests from:

http://localhost:3000 (React Frontend)

CORS policy is named "AllowFrontend" and applied globally.

---

🛠️ Developer Notes
Make sure you have .NET SDK, SQL Server, and EF Tools installed.

Always check Program.cs for correct service and middleware configuration.

ProductDbContext must include a constructor with DbContextOptions.

---



👨‍💻 Author
Sachintha Nimesh
