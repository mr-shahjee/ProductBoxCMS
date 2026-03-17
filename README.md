# ProductBoxCMS

## Backend API Output
<img width="1366" height="1349" alt="image" src="https://github.com/user-attachments/assets/3e3c0a2f-b132-4069-8454-236109022b78" />

## Frontend Output
<img width="1366" height="617" alt="image" src="https://github.com/user-attachments/assets/09fd1bc5-be61-4876-a068-14904e1f4ca8" />
<img width="1366" height="685" alt="image" src="https://github.com/user-attachments/assets/0b289591-47e0-4d08-bd9d-46e7771041a3" />

## Unit Test
<img width="1366" height="735" alt="image" src="https://github.com/user-attachments/assets/0f64d18b-af0a-45aa-893d-1f9fb76a31e1" />


# Customer Management System

## 📌 Overview

This project is a full-stack application built as part of a technical assessment. It demonstrates the implementation of a RESTful Web API using ASP.NET Core (.NET 8) with Entity Framework Core, following Clean Architecture principles, along with a React-based frontend.

The system allows users to manage customers and their associated customer types with complete CRUD functionality.

---

## 🏗️ Architecture

The backend follows **Clean Architecture** with clear separation of concerns:

* **Domain Layer** → Entities
* **Application Layer** → Interfaces & Services
* **Infrastructure Layer** → Repository implementations & EF Core
* **API Layer** → Controllers

### Flow:

Controller → Service → Repository → DbContext → Database

---

## 🚀 Technologies Used

### Backend

* ASP.NET Core (.NET 8)
* Entity Framework Core
* SQL Server
* Repository Pattern
* Dependency Injection
* xUnit & Moq (Unit Testing)

### Frontend

* React.js
* Axios
* Bootstrap (UI Styling)

---

## 🗂️ Database Design

### CustomerType

* Id (PK)
* Name

### Customer

* Id (PK)
* Name
* CustomerTypeId (FK)
* Description
* Address
* City
* State
* Zip
* LastUpdated

---

## 🌱 Data Seeding

Initial migration includes:

* 3 CustomerTypes:

  * Regular
  * Premium
  * Corporate

* 5 Customers linked to the above types

---

## 🔌 API Endpoints

### CustomerType

| Method | Endpoint                | Description |
| ------ | ----------------------- | ----------- |
| GET    | /api/customertypes      | Get all     |
| GET    | /api/customertypes/{id} | Get by id   |
| POST   | /api/customertypes      | Create      |
| PUT    | /api/customertypes/{id} | Update      |
| DELETE | /api/customertypes/{id} | Delete      |

---

### Customer

| Method | Endpoint            | Description |
| ------ | ------------------- | ----------- |
| GET    | /api/customers      | Get all     |
| GET    | /api/customers/{id} | Get by id   |
| POST   | /api/customers      | Create      |
| PUT    | /api/customers/{id} | Update      |
| DELETE | /api/customers/{id} | Delete      |

---

## ✅ Features

* Full CRUD operations
* Clean Architecture implementation
* Repository & Service layers
* Dependency Injection
* Input validation
* Proper HTTP status codes
* Entity relationships (1-to-many)

---

## 🧪 Unit Testing

Unit tests are implemented using:

* xUnit
* Moq
* FluentAssertions

### Covered Scenarios:

* Get all records
* Get by Id
* Create entity
* Update entity
* Delete entity
* Not found cases

---

## 💻 Frontend Features

* Display customers in table
* Add new customer
* Edit existing customer
* Delete customer
* Dropdown for CustomerType
* Display CustomerType name instead of ID

---

## 🎁 Bonus Implementations

* Validation handling (backend + frontend)
* Error handling with proper responses
* Pagination / filtering (optional)
* Clean UI with Bootstrap

---

## ⚙️ Setup Instructions

### Backend

```bash
cd Backend
dotnet restore
dotnet ef database update
dotnet run
```

---

### Frontend

```bash
cd frontend
npm install
npm start
```

---

## 📊 Sample Data

The database is automatically seeded with sample CustomerTypes and Customers during migration.

---

## 📌 Notes

* The project follows best practices for scalability and maintainability.
* Designed to be easily extendable for additional features.

---

## 👨‍💻 Author

Developed as part of a technical assessment.
