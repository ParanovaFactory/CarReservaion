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

![CarBook Main Page 1](Frontends/CarBook.WebUI/Assets/images/carbook1.png)
![CarBook Main Page 2](Frontends/CarBook.WebUI/Assets/images/carbook2.png)
![About Us Page](Frontends/CarBook.WebUI/Assets/images/carbook3.png)

![Pricing Page](Frontends/CarBook.WebUI/Assets/images/carbook4.png)
![Car Listing Page](Frontends/CarBook.WebUI/Assets/images/carbook5.png)
![Car Detail Page](Frontends/CarBook.WebUI/Assets/images/carbook13.png)

![Car Detail Page](Frontends/CarBook.WebUI/Assets/images/carbook14.png)
![Car Detail Page](Frontends/CarBook.WebUI/Assets/images/carbook15.png)
![Blog Detail Page](Frontends/CarBook.WebUI/Assets/images/carbook7.png)

![Blog Overview Page](Frontends/CarBook.WebUI/Assets/images/carbook6.png)
![Booking Form Page](Frontends/CarBook.WebUI/Assets/images/carbook8.png)
![Admin Panel - Car List](Frontends/CarBook.WebUI/Assets/images/carbook9.png)

![Admin Panel - Brand List](Frontends/CarBook.WebUI/Assets/images/carbook10.png)
![Admin Panel - Blog List](Frontends/CarBook.WebUI/Assets/images/carbook11.png)
![Admin Panel - Category List](Frontends/CarBook.WebUI/Assets/images/carbook12.png)


---

## 👤 Author

**Sadık Berkay Karaduman**  
📧 [karadumansadikberkay@gmail.com](mailto:karadumansadikberkay@gmail.com)  
🔗 [GitHub – ParanovaFactory](https://github.com/ParanovaFactory)

---

## 📄 License

MIT License — Feel free to use, modify, and contribute.

