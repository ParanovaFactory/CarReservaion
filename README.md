# CarBook - Car Rental Platform

Welcome to **CarBook**! 🚘🌍 This is a full-stack platform where users can perform car rental transactions, access vehicle details, and view prices based on their location. It also includes features like rental history, reviews, and more.

---

## 📊 Features

### **User Interface (Website)**
- **Filter & Rent Vehicles:** Rent vehicles based on location with filters for easy browsing.
- **Read Blogs & Comment:** Stay updated with blog posts and comment on them.
- **Send Messages:** Contact support or send inquiries through the contact panel.
- **View Testimonials:** Browse testimonials and reviews from users.

### **Admin Panel Features**
- **Dynamic CRUD Operations:** Easily manage all content on the site including vehicles, blogs, testimonials, and more.
- **Track Site Statistics:** Monitor key metrics and data about the site.
- **Vehicle Management:** Admins can manage vehicles by brand and make adjustments to their details.
- **Author-based Blog Management:** Admins can list blogs based on the authors.
- **User Management:** Admins can view, manage, and track user activity and rental history.

### **Login & Register Pages**
- **JWT-based Authentication:** Secure login and registration system using JWT.
- **Role-based Access Control:** Restrict access to pages based on user roles (Admin, User).

---

## 🧠 Technical Infrastructure

This project is built using the following technologies:

- 💥 **ASP.NET Core 8.0 Web API & MVC**  
- 🏛️ **Onion Architecture**  
- ⚙️ **CQRS, Mediator, Repository Pattern**  
- 🔐 **JWT Authentication (Admin Login Information Username=admin_user, Password=securePassword123)**  
- 📡 **Live Data Tracking with SignalR**  
- 🛡️ **Form Validation with FluentValidation**

---

## 📂 Project Structure

The project follows a clean architecture and includes the following layers:

- **Presentation Layer:** The UI components including MVC views and API controllers.
- **Application Layer:** Contains the business logic such as handling CRUD operations, managing user requests, and communicating with the data access layer.
- **Domain Layer:** Core domain entities and services are defined here.
- **Infrastructure Layer:** The technical details such as database communication, SignalR services, and external integrations are handled here.

---

## 🔧 Technologies Used

- **Backend:** ASP.NET Core 8.0 Web API & MVC
- **Database:** SQL Server and Additional Triggers added via migrations
- **Authentication:** JWT-based authentication for secure login and registration
- **Real-Time Communication:** SignalR for live data tracking
- **Validation:** FluentValidation for form validation and input checks
- **CQRS, Mediator, Repository Pattern** for maintaining clean separation of concerns and better maintainability.

---

## 📈 Site Statistics

The **Admin Panel** includes detailed statistics about the site's performance, user engagement, and car rental data. This provides valuable insights into how the platform is being used and helps in making data-driven decisions for further improvements.

---

## 🚗 Project Overview

<p float="left">
  <img src="./assets/images/carbook1.png" width="250" alt="CarBook Main Page 1" />
  <img src="./assets/images/carbook2.png" width="250" alt="CarBook Main Page 2" />
  <img src="./assets/images/carbook3.png" width="250" alt="About Us Page" />
</p>

<p float="left">
  <img src="./assets/images/carbook4.png" width="250" alt="Pricing Page" />
  <img src="./assets/images/carbook5.png" width="250" alt="Car Listing Page" />
  <img src="./assets/images/carbook13.png" width="250" alt="Car Detail Page" />
</p>

<p float="left">
  <img src="./assets/images/carbook14.png" width="250" alt="Car Detail Page" />
  <img src="./assets/images/carbook15.png" width="250" alt="Car Detail Page" />
  <img src="./assets/images/carbook7.png" width="250" alt="Blog Detail Page" />
</p>

<p float="left">
  <img src="./assets/images/carbook6.png" width="250" alt="Blog Overview Page" />
  <img src="./assets/images/carbook8.png" width="250" alt="Booking Form Page" />
  <img src="./assets/images/carbook9.png" width="250" alt="Admin Panel - Car List" />
</p>

<p float="left">
  <img src="./assets/images/carbook10.png" width="250" alt="Admin Panel - Brand List" />
  <img src="./assets/images/carbook11.png" width="250" alt="Admin Panel - Blog List" />
  <img src="./assets/images/carbook12.png" width="250" alt="Admin Panel - Category List" />
</p>

---

## 👤 Author

**Sadık Berkay Karaduman**  
📧 [karadumansadikberkay@gmail.com](mailto:karadumansadikberkay@gmail.com)  
🔗 [GitHub – ParanovaFactory](https://github.com/ParanovaFactory)

---

## 📄 License

MIT License — Feel free to use, modify, and contribute.

