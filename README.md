# 📚 Boutique Publisher — Desktop Database Application
 
A Windows Forms desktop application built with **C# (.NET Framework 4.7.2)** and **Microsoft SQL Server** for managing a boutique publishing company. The system handles authors, books, formats, retail partners, orders, and royalty reporting through a clean, database-driven UI.
 
---
 
## 📸 Screenshots
 
| Dashboard | Authors |
|-----------|---------|
| ![Dashboard](Assets/Dashboard.png) | ![Authors](Assets/Authors.png) |
 
| Books | Book Search |
|-------|------------|
| ![Books](Assets/books.png) | ![Search](Assets/search.png) |
 
| Formats | Retail Partners |
|---------|----------------|
| ![Formats](Assets/formats.png) | ![Partners](Assets/partners.png) |
 
| Process Orders | Royalty Report |
|---------------|----------------|
| ![Orders](Assets/orders.png) | ![Report](Assets/report.png) |
 
---
 
## 🗂️ Entity Relationship Diagram
 
![ERD](Assets/ERD.png)
 
---
 
## ✨ Features
 
- **Dashboard** — Live statistics (total authors, books, orders, partners) with a real-time clock and a database reset option
- **Author Management** — Add, update, delete, and browse authors with royalty percentage tracking
- **Book Management** — CRUD operations on books with genre (Fantasy, Horror, Romance, Drama, Sci-Fi) and target age group (Kids, Teens, Adults)
- **Format Management** — Manage book formats (e.g. Hardcover, Paperback, eBook) with production cost and retail price
- **Author–Book Assignment** — Link multiple authors to multiple books (many-to-many relationship)
- **Retail Partners** — Manage partner stores that place orders
- **Process Orders** — Place orders by selecting a partner, book format, and quantity; auto-calculates total price
- **Search Books** — Filter books by Title, ISBN, Genre, Author, or Format across all records
- **Royalty Report** — Aggregated report showing total sales and royalty amounts owed per author per book, sorted by highest royalty
---
 
## 🗄️ Database Schema
 
The application uses a SQL Server database named `BoutiquePublisherDB` with the following tables:
 
| Table | Description |
|-------|-------------|
| `AUTHOR` | Author ID, Name, Biography, Royalty % |
| `BOOK` | ISBN (PK), Title, Genre, Target Age Group |
| `AUTHOR_BOOK` | Junction table linking authors to books (many-to-many) |
| `FORMAT` | Format ID, ISBN (FK), Format Type, Production Cost, Retail Price |
| `RETAILPARTNER` | Partner ID, Partner Name |
| `ORDER` | Order ID, Format ID (FK), Partner ID (FK), Order Date, Quantity |
 
Foreign keys use `ON DELETE CASCADE` so removing a book or author automatically cleans up related records.
 
---
 
## 🛠️ Prerequisites
 
- **Windows** (10 or later recommended)
- **Visual Studio 2022** (or later)
- **SQL Server Express** (or any SQL Server edition)
- **.NET Framework 4.7.2**
---
 
## 🚀 Getting Started
 
### 1. Clone the repository
 
```bash
git clone https://github.com/your-username/Boutique_Publisher-DB-Project.git
cd Boutique_Publisher-DB-Project
```
 
### 2. Set up the database
 
Open **SQL Server Management Studio (SSMS)** and run the setup script:
 
```
SQL Database/Boutique_Publisher.sql
```
 
This script creates the `BoutiquePublisherDB` database and all tables with the correct constraints.
 
### 3. Configure the connection string
 
The connection string is defined in `DataBase/DataBaseHelper.cs`:
 
```csharp
public static string ConnectionString =
    "Data Source=.\\SQLEXPRESS;Initial Catalog=BoutiquePublisherDB;Integrated Security=True";
```
 
If your SQL Server instance has a different name, update `Data Source` accordingly (e.g., `.\SQLSERVER2019` or a named server).
 
### 4. Build and run
 
Open `Boutique_Publisher.slnx` in Visual Studio, build the solution (`Ctrl+Shift+B`), and press **F5** to run.
 
---
 
## 📁 Project Structure
 
```
Boutique_Publisher-DB-Project/
├── Assets/                          # Screenshots and ERD diagram
├── config/
│   └── App.config                   # Application configuration
├── DataBase/
│   └── DataBaseHelper.cs            # Shared connection string
├── FORMS/
│   ├── Dashboard.cs                 # Main hub with live stats
│   ├── Author.cs                    # Author CRUD
│   ├── Books.cs                     # Book CRUD
│   ├── Formats.cs                   # Format CRUD
│   ├── AssignBookAuthor.cs          # Author–Book assignment
│   ├── RetailPartners.cs            # Retail partner CRUD
│   ├── ProcessOrder.cs              # Order processing
│   ├── SearchBooks.cs               # Multi-filter book search
│   └── RoyaltyReport.cs             # Aggregated royalty report
├── ICONS/                           # UI icon assets
├── Properties/                      # Assembly & resource files
├── Resources/                       # Embedded resources
├── SQL Database/
│   └── Boutique_Publisher.sql       # Full DB creation script
├── BoutiquePublisherDBDataSet.xsd   # Typed DataSet schema
├── Program.cs                       # Application entry point
└── Boutique_Publisher.csproj        # Project file
```
 
---
 
## 🧰 Tech Stack
 
| Layer | Technology |
|-------|-----------|
| Language | C# |
| Framework | .NET Framework 4.7.2 |
| UI | Windows Forms (WinForms) |
| Database | Microsoft SQL Server (SQL Express) |
| Data Access | ADO.NET (`SqlConnection`, `SqlCommand`, `SqlDataAdapter`) |
| IDE | Visual Studio 2022 |
 
---
 
## 📋 Usage Notes
 
- **Royalty Report** calculates earnings as: `Retail Price × Quantity Sold × (Royalty % / 100)`
- The **Dashboard reset button** clears all data from every table and reseeds identity columns — use with caution
- Orders are linked to a specific **format** (not just a book), so pricing is determined per edition
- The search form supports partial matching (`LIKE %keyword%`) across all fields simultaneously when "All" filter is selected
---
 
## 📄 License
 
This project is for educational purposes. Feel free to fork and build upon it.