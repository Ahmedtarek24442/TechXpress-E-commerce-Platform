# NeatThread - Online Clothing Store

## Project Overview

**NeatThread** is a web-based e-commerce platform developed using **ASP.NET Core** that allows customers to browse clothing products, add items to a shopping cart, and complete purchases through a secure checkout system. The platform also includes an admin panel that enables administrators to manage products, categories, and customer orders efficiently. The system follows **NTier Architecture** to separate the presentation, business logic, and data access layers, improving maintainability and scalability.

### Problem Statement

Many online clothing stores have complex interfaces, limited product organization, and inefficient management systems for administrators. Customers often struggle to easily browse products, compare items, and complete purchases smoothly, while store owners need a better way to manage products, categories, and orders efficiently.

### Proposed Solution

NeatThread provides a clean, user-friendly shopping experience with well-organized product categories, secure authentication, and an efficient admin management system. The platform focuses on simplicity, performance, and maintainability through the use of modern ASP.NET Core architecture and design patterns.

### Target Audience

- Customers who prefer online shopping for clothing
- Young adults interested in fashion and trendy clothing
- Small clothing store owners who want to sell products online

### Unique Value Proposition (UVP)

NeatThread provides a clean, user-friendly shopping experience with well-organized product categories, secure authentication, and an efficient admin management system. The platform focuses on simplicity, performance, and maintainability through the use of modern ASP.NET Core architecture and design patterns.

### Core Features

- User registration and login using ASP.NET Identity
- Browse clothing products by categories
- Search and filter products
- View product details (images, price, description, availability)
- Add products to the shopping cart
- Manage shopping cart (add, remove, update quantity)
- Secure checkout and order placement
- Online payment integration (e.g., Stripe)
- User profile with order history and account management
- Role-based access control (Admin and Customer)
- Admin dashboard for managing the store
- Product management (add, edit, delete products)
- Category management
- Order management and tracking

## Team Structure

**Team Size:** 6 Members

**Team Collaboration Approach:**

The project will be developed collaboratively by all team members. Each member will participate in both front-end and back-end development, as well as database design, testing, and documentation.

### Team Members

1. **Ahmed Tarek Abouelnaga Hasaballah** – Team Leader / Full Stack Developer (Front-end, Back-end, and Database development)
2. **Karim Salama Hosny Elbanna** – Full Stack Developer (Front-end, Back-end, and Database development)
3. **Ziad Mohamed Mostafa Abouelnaga** – Full Stack Developer (Front-end, Back-end, and Database development)
4. **Eslam Mohamady Abdelmoaty Mohamady** – Full Stack Developer (Front-end, Back-end, and Database development)
5. **Ziad Eid Abdelrazek** – Full Stack Developer (Front-end, Back-end, and Database development)
6. **Mohamed Ashraf Abdelsalam Kaffafi** – Full Stack Developer (Front-end, Back-end, and Database development)

### Team Responsibilities

- Developing the front-end and back-end of the application
- Designing and implementing the database structure
- Implementing business logic using ASP.NET Core
- Testing and debugging the system
- Collaborating on documentation and project deployment

## System Analysis & Design

### Functional Requirements

| Requirement ID | Requirement Statement |
|----------------|------------------------|
| FR01 | The application shall display a login/sign-up screen when the user opens the application. |
| FR02 | The application shall display username and password input fields when the user chooses to log in. |
| FR03 | The application shall allow users to register with a username, email, and password. |
| FR04 | The application shall allow users to reset their password if forgotten. |
| FR05 | The application shall display products by categories on the home page. |
| FR06 | The application shall allow users to search and filter products by name, category, or price. |
| FR07 | The application shall display detailed product information including images, price, description, and availability. |
| FR08 | The application shall allow users to add products to a shopping cart. |
| FR09 | The application shall allow users to update product quantities or remove products from the shopping cart. |
| FR10 | The application shall allow users to proceed to checkout and place an order. |
| FR11 | The application shall integrate a secure payment gateway (e.g., Stripe) for order payment. |
| FR12 | The application shall maintain user profiles and display order history. |
| FR13 | The application shall implement role-based access control for Admin and Customer. |
| FR14 | The application shall provide an Admin dashboard to manage products, categories, and orders, including adding, editing, deleting products/categories, and updating order statuses. |

### Non Functional Requirements

| Measure | Details |
|---------|---------|
| Performance | The application shall respond to user actions (page load, search, filter) within 2 seconds under normal load. |
| Security | Users shall be authenticated using ASP.NET Identity; role-based access will control admin and customer actions. |
| Usability | The application shall have a clean, intuitive interface that users can navigate without training. |
| Reliability | The system shall be available 99% of the time, with proper error handling for unexpected failures. |
| Scalability | The application shall support at least 500 concurrent users without performance degradation. |
| Maintainability | The system shall use N-Tier architecture, design patterns (Repository, Unit of Work), and proper documentation to ease maintenance. |
| Compatibility | The application shall work on modern browsers (Chrome, Edge, Firefox) and support both desktop and mobile screens. |
| Availability | The system shall be deployed on Microsoft Azure with daily backups to ensure data availability. |

## Database Design (ERD)

![NeatThread Database ERD](Screenshot%20From%202026-03-10%2021-45-10.png)
## Case Study & Feasibility Study

### Technical Feasibility

- The project will be developed using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server** for the database.
- All team members have experience with **C#, .NET, HTML, CSS, and JavaScript**, ensuring the technical skills required to build the system.
- The tech stack supports **scalability, maintainability, and integration with payment gateways** like Stripe.
- Development can be completed within the **given semester timeframe**.

### Economic Feasibility

- **Costs:** Hosting on Microsoft Azure (~$20/month), domain (~$10/year), and optional SSL certificate (~$10/year).
- **Expected value/ROI:** The platform can help small clothing store owners sell online, improving sales and reaching more customers. It can also be extended to other clothing brands in the future.

### Operational Feasibility

- End-users (customers) can easily browse products, add items to a cart, and checkout using a simple and intuitive interface.
- Admin users can manage products, categories, and orders efficiently from a central dashboard.
- Minimal training is required for both customers and admins, ensuring smooth adoption.

### Competitor Analysis

- **Competitor 1:** Local online clothing stores (e.g., "FashionMart") – Strength: wide product variety; Weakness: outdated UI, poor navigation.
- **Competitor 2:** International platforms like **ASOS** – Strength: well-known brand, fast delivery; Weakness: not tailored for local users, higher prices.
- **Competitive Edge:** NeatThread provides a **user-friendly, lightweight, and locally relevant platform** with a simple admin dashboard for small store owners, which competitors often lack.

### Risk Assessment

- **Risk 1:** Running out of time → Mitigation: divide tasks clearly among team members and follow a weekly schedule.
- **Risk 2:** Payment gateway integration failure → Mitigation: test Stripe sandbox environment before live deployment.
- **Risk 3:** Unexpected bugs or crashes → Mitigation: implement proper error handling, backup database regularly, and use version control (Git).
- **Risk 4:** Security threats → Mitigation: use HTTPS, secure passwords with hashing, and role-based access control.


## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- ASP.NET Identity
- HTML5, CSS3, JavaScript
- Git & GitHub

