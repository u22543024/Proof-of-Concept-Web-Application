# Proof-of-Concept Web Application — Front End

## Overview

This project is a **Proof-of-Concept (PoC) web application** developed to evaluate whether software development productivity can be improved through the use of the **Angular framework**.

The application consists of:

* **Front End:** Angular
* **Back End:** .NET 8 Web API
* **Database:** Microsoft SQL Server

The application demonstrates a complete **Create, Read, Update, and Delete (CRUD)** workflow for products stored in a SQL Server database.

## Use Case

The client requested a proof-of-concept application using **Angular** and **.NET 8 Web API** to evaluate the productivity benefits of using the Angular framework for software development.

The application provides users with the ability to:

* View products
* Add new products
* Edit existing products
* Delete products
* Navigate between pages using Angular routing

When the application is launched, the **Product Listing** page is displayed as the landing page.

---

## Application Features

### Product Listing

The Product Listing page retrieves product records from the backend API and displays them as product cards.

Each product card displays:

* **Name**
* **Description**
* **Price**

Each product also has:

* **Edit** button
* **Delete** button

#### Delete Product

Clicking the **Delete** button removes the selected product from the database and refreshes the product listing to display the updated records.

#### Edit Product

Clicking the **Edit** button navigates the user to the **Edit Product** page, where the selected product can be modified.

---

### Edit Product

The Edit Product page allows users to update:

* Product Name
* Product Description
* Product Price

Users can update one, two, or all three fields.

After submitting the form:

1. The product is updated in the database.
2. The user is redirected to the **Product Listing** page.
3. The updated product information is displayed.

The **Cancel** button returns the user to the Product Listing page without making any changes.

---

### Add Product

The Add Product page allows users to create a new product.

The form contains:

* Product Name
* Product Description
* Product Price

The **Submit** button remains disabled until values have been provided for all three form controls.

After submitting:

1. A new product is created in the database.
2. The user is redirected to the **Product Listing** page.
3. The newly added product appears as the **first item** in the product listing.

The **Cancel** button returns the user to the Product Listing page without creating a product.

---

## Navigation

The application uses **Angular Routing** to navigate between pages.

The navigation bar is shared across the application's pages and contains:

* **Product Listing** — navigates to the Product Listing page
* **Add Product** — navigates to the Add Product page

The Product Listing page is configured as the application's landing page.

---

## Architecture

The application follows a client-server architecture:

```text
┌─────────────────────────────┐
│        Angular Front End    │
│                             │
│  Product Listing            │
│  Add Product                │
│  Edit Product               │
│                             │
│  Angular Routing            │
│  Forms                      │
│  HTTP Services              │
└──────────────┬──────────────┘
               │
               │ HTTP Requests
               │
┌──────────────▼──────────────┐
│       .NET 8 Web API        │
│                             │
│       CRUD Operations       │
└──────────────┬──────────────┘
               │
               │ Entity Framework /
               │ Database Access
               │
┌──────────────▼──────────────┐
│       SQL Server            │
│                             │
│       Product Table         │
└─────────────────────────────┘
```

---

## Technologies Used

### Front End

* Angular
* TypeScript
* HTML5
* CSS3
* Bootstrap
* Bootstrap Icons
* RxJS
* Angular Router
* Angular Forms
* Angular HTTP Client

### Back End

* .NET 8
* ASP.NET Core Web API
* Entity Framework Core

### Database

* Microsoft SQL Server

---

## Front-End Pages

The Angular application contains the following main pages:

| Page            | Purpose                                  |
| --------------- | ---------------------------------------- |
| Product Listing | Displays products retrieved from the API |
| Add Product     | Creates a new product                    |
| Edit Product    | Updates an existing product              |

---

## CRUD Functionality

The application implements the following CRUD operations:

| Operation  | Functionality                 |
| ---------- | ----------------------------- |
| **Create** | Add a new product             |
| **Read**   | Retrieve and display products |
| **Update** | Edit an existing product      |
| **Delete** | Remove an existing product    |

---

## Getting Started

### Prerequisites

Before running the application, ensure that the following are installed:

* Node.js
* npm
* Angular CLI
* .NET 8 SDK
* Microsoft SQL Server
* Visual Studio Code or another suitable IDE

Verify Node.js and npm:

```bash
node --version
npm --version
```

Verify Angular CLI:

```bash
ng version
```

Verify .NET:

```bash
dotnet --version
```

---

## Installation

Clone the repository:

```bash
git clone https://github.com/u22543024/Proof-of-Concept-Web-Application.git
```

Navigate to the project directory:

```bash
cd Proof-of-Concept-Web-Application
```

Install the Angular dependencies:

```bash
npm install
```

---

## Running the Front End

Start the Angular development server:

```bash
ng serve
```

The application will normally be available at:

```text
http://localhost:4200/
```

Open the URL in a web browser to access the application.

---

## Backend API

The Angular application communicates with a **.NET 8 Web API** to perform CRUD operations against the SQL Server database.

The API is responsible for:

* Retrieving products
* Creating products
* Updating products
* Deleting products

The database is populated with the seed data configured in `AppDbContext.cs` when the database migration is applied.

---

## Product Data

The Product table contains product information including:

* Name
* Description
* Price

The Product Listing page displays these fields to the user.

---

## Project Structure

A typical Angular project structure is:

```text
src/
├── app/
│   ├── components/
│   │   ├── product-listing/
│   │   ├── add-product/
│   │   └── edit-product/
│   │
│   ├── services/
│   ├── models/
│   ├── app.routes.ts
│   └── ...
│
├── assets/
├── styles.css
└── main.ts
```

---

## Branch

The front-end implementation is maintained in the:

```text
front-end-code
```

branch.

---

## Project Repository

**GitHub Repository:**
https://github.com/u22543024/Proof-of-Concept-Web-Application

## Author

**Wanda Bhadula**
