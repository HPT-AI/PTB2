
# 📘 Quadratic Equation Solver (WinForms C#)

## 📝 Project Description
This project is a simple Windows Forms application written in C# that solves quadratic equations of the form:

\[
ax^2 + bx + c = 0
\]

The application allows users to:
- Input coefficients (a, b, c).
- Solve the quadratic equation and display the results.
- Save the solved equations into a SQL Server database.
- View the history of solved equations.
- Delete specific equations from the database.

---

## 🚀 Features
- **Input coefficients:** 3 TextBoxes for a, b, and c.
- **Solve equation:** Calculate solutions based on Δ (Delta).
- **Clear input:** Quickly reset all fields.
- **Save result:** Automatically save the equation and its solutions to the database.
- **View history:** Display previously solved equations in a DataGridView.
- **Delete history:** Delete any selected equation from the database.

---

## 🛠️ Technologies Used
- C# (.NET Framework)
- Windows Forms (WinForms)
- SQL Server (LocalDB or Server connection)
- ADO.NET for database operations

---

## 🗄️ Database Structure
**Table: PhuongTrinhBac2**

| Column Name | Data Type    | Description              |
|-------------|--------------|---------------------------|
| Id          | INT (Identity, PK) | Primary key |
| A           | FLOAT         | Coefficient a            |
| B           | FLOAT         | Coefficient b            |
| C           | FLOAT         | Coefficient c            |
| KetQua      | NVARCHAR(MAX) | Solution result          |
| NgayGiai    | DATETIME      | Solve date and time       |

**Note:**  
- The application will automatically create the table if it does not exist.

---

## 📋 How to Run the Project
1. Clone the repository.
2. Open the solution (.sln) file in Visual Studio.
3. Update the SQL Server connection string in `app.config` if needed.
4. Build and run the project.

---

## ⚙️ Configuration
- Connection string should be placed in `App.config`.
- Make sure SQL Server is running and accessible.

Example connection string:
```xml
<connectionStrings>
  <add name="DbConnection" 
       connectionString="Data Source=.;Initial Catalog=QuadraticSolverDB;Integrated Security=True" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

---

## 📈 Future Improvements
- Export history to Excel.
- Improve UI with more modern controls.
- Add support for complex roots (when Δ < 0).

---

## 👨‍💻 Author
- Developed by [Your Name Here]
