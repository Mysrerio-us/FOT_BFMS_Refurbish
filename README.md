# BFMS: Batch Fund Management System

The **Batch Fund Management System (BFMS)** is a robust C# Windows Forms desktop application designed to streamline the management of funds, member contributions, and approval workflows for batches.

## 🚀 Key Features

* **User Authentication:** Secure Login and Signup system with OTP verification logic.
* **Member Management:** Comprehensive tracking and profile management for all batch members.
* **Fund Operations:** Automated handling of deposits and withdrawal requests.
* **Approval Workflow:** Centralized Request Approval Management for administrative oversight.
* **Admin Dashboard:** Real-time visual analytics including charts and progress bars to monitor batch financial health.
* **Security & Recovery:** Built-in Forgot Password functionality.

## 🛠 Technical Overview

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** MS SQL Server (`.mdf`)
* **Data Access:** Strongly-typed DataSets (`.xsd`) for schema management and SQL connectivity.

## 📂 Project Structure

* **AdminDashboard:** Central hub for viewing batch analytics and system status.
* **MemberUI/MembersForm:** Interface for managing individual member details and status.
* **Financial Forms:** Includes `DepositMoneyUI`, `WithdrawRequestForm`, and `CentralFundForm`.
* **Data Layer:** `SQLConnect.cs` and `Global.cs` handle secure database transactions and connectivity.

## ⚙️ Setup Instructions

1.  **Clone the repository:** `git clone <your-repo-url>`
2.  **Open in Visual Studio:** Load the `FOT_BFMS.slnx` or `FOT_BFMS.csproj` file.
3.  **Database Configuration:** * Refer to `DatabaseCreationQuerry.txt` to set up the necessary SQL tables.
    * Ensure the connection strings in `App.config` match your local environment.
4.  **Dependencies:** Ensure all required NuGet packages are restored via `packages.config`.
5.  **Build & Run:** Compile the project and launch the `Login` form to begin.

## 📝 Recent Progress
* Finalized UI components for `MembersUI` and `AdminDashboard`.
* Integrated database connectivity for all core request modules.
* Added placeholder forms for future Analytics, Backup, and Settings expansion.

---
*Built with passion for batch financial transparency and efficiency.*
