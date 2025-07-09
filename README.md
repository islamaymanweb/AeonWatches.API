# 🕰 AeonWatches.API - Modern Watch Ecommerce REST API

Welcome to **AeonWatches.API**, a fully-featured, modular and scalable RESTful API built with **ASP.NET Core**, designed for high-performance e-commerce experiences in the luxury and modern watch industry.

> "Timeless Code for Timeless Craftsmanship."

---

## 📦 Features

- 🔐 **Authentication & Authorization**  
  - JWT-based login & registration for customers
  - Role-based access for admins and users

- 🧭 **Watch Catalog Management**
  - Detailed Watch specs with rich metadata
  - Filter by Brand, Type, Calibre, Price, etc.

- 🛒 **Shopping Cart**
  - Add to cart, remove, and view watch selections

- 📦 **Order Management**
  - Place orders, track order history, and status filtering

- 👤 **User Profiles**
  - View & update user info, fetch customer details

- 📸 **Media Support**
  - Multiple photos per watch with a main image

---

## 📂 API Structure

| Resource | Methods | Description |
|----------|---------|-------------|
| `/api/Account` | `POST /register`, `POST /login` | Auth endpoints |
| `/api/Watch` | `GET`, `POST`, `PUT`, `DELETE` | Main watch resource |
| `/api/Order` | `GET`, `POST`, `GET /status/{id}`, `GET /history` | Order management |
| `/api/User` | `GET /profile`, `POST /details` | User info |
| `/api/Cart/watches` | `GET` | Retrieve current cart |
| `/api/Brand` | `GET` | List all brands |
| `/api/WatchType` | `GET` | List all watch types |
| `/api/Watch/filters` | `GET` | Get filtering options |

For full Swagger documentation:  
📎 [https://localhost:7027/swagger/index.html](https://localhost:7027/swagger/index.html)

---

## 🧠 Tech Stack

- **Backend:** ASP.NET Core 8.0  
- **Authentication:** JWT  
- **Database:** SQL Server  
- **API Docs:** Swagger (OpenAPI 3.0)

---

## 🛠 Setup & Run

1. Clone the repo:

   ```bash
   git clone[ https://github.com/yourusername/AeonWatches.API.git](https://github.com/islamaymanweb/AeonWatches.API)
   cd AeonWatches.API
