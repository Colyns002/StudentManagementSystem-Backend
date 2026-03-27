# Student Management API - Backend

### **Project Overview**
This is a secure RESTful API built with **ASP.NET Core 10.0** to manage students, departments, and courses. It implements a **Zero Trust** security model using **ASP.NET Core Identity** and **JWT (JSON Web Tokens)**.

---

### **Setup & Installation**

**1. Database Configuration**
Open `appsettings.json` and verify the `DefaultConnection`. 
* Current setting: `Server=.` (Local SQL Instance).

**2. Apply Migrations**
Open the **Package Manager Console** and run:
`Update-Database`
*This creates the schema and inserts the seed data automatically.*

**3. Running the Application**
* Press `F5` to launch Swagger UI.
* **Note:** You must Register and Login to receive a JWT token before accessing protected endpoints.

---

### **API Endpoints Summary**

| Category | Endpoint | Method | Auth | Description |
| :--- | :--- | :--- | :--- | :--- |
| **Auth** | `/api/Account/register` | POST | No | Create a new user account. |
| **Auth** | `/api/Account/login` | POST | No | Get your JWT Bearer Token. |
| **Data** | `/api/Students` | GET | **Yes** | List all students. |
| **Data** | `/api/Departments` | GET | No | List academic departments. |

---

### **Technical Implementation**
* **Stateless Auth:** Uses JWT to avoid server-side session overhead.
* **Token Security:** Signed with a **512-bit HMAC-SHA512** key.
* **Entity Mapping:** Implements One-to-Many relationships between Departments and Students.

---

### **Swagger UI Preview**
![Swagger UI Screenshot](./src/StudentManagementAPI/StudentManagementAPI/swagger-screenshot.png)