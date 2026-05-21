# ⚡ Load Shedding Cost Estimator

A desktop application built with **C# Windows Forms** that helps users track electrical appliance usage during load shedding outages and automatically calculates the financial loss incurred.

> **CS-412 Visual Programming — Semester Project**


## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Screenshots](#screenshots)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Database Design](#database-design)
- [Getting Started](#getting-started)
- [How to Use](#how-to-use)
- [Loss Calculation Formula](#loss-calculation-formula)
- [NuGet Packages](#nuget-packages)

---

## 📖 About the Project

In Pakistan, frequent load shedding causes significant disruption to daily life and businesses. This application allows users to:

- Log each load shedding **outage** with start and end time
- Manage their **electrical appliances** (fan, AC, fridge, etc.) with wattage and rate
- Record which appliances were running during each outage
- Automatically **calculate the financial loss** in PKR
- View a **dashboard** with statistics and charts
- Generate a **PDF report** of all outage records

---

## ✨ Features

| Feature | Description |
|--------|-------------|
| 🔐 User Registration & Login | Multi-user support — each user sees only their own data |
| ⏱️ Outage Logging | Record load shedding start/end time — duration auto-calculated |
| 🔌 Appliance Management | Add/delete appliances with wattage and electricity rate |
| 📊 Usage Tracking | Log which appliances ran during each outage and for how long |
| 💰 Loss Calculation | Automatic PKR loss calculation using the formula below |
| 📈 Dashboard | Summary stats, bar chart (outages per day), insights |
| 📄 PDF Report | Export full report with chart using iTextSharp |
| 🗃️ DB Browser Integration | Database created and managed with DB Browser for SQLite |

---

## 🖥️ Tech Stack

| Component | Technology |
|-----------|-----------|
| Language | C# (.NET Framework 4.7.2) |
| UI Framework | Windows Forms |
| Database | SQLite (via DB Browser for SQLite) |
| Data Access | ADO.NET |
| PDF Generation | iTextSharp 5.5.13.5 |
| Password Hashing | BCrypt.Net-Next 4.1.0 |
| Version Control | Git / GitHub |

---

## 📁 Project Structure

```
LoadSheddingCostEstimator/
│
├── Models/                     ← Data model classes
│   ├── User.cs                 ← Represents Users table
│   ├── Appliance.cs            ← Represents Appliances table
│   ├── OutageLog.cs            ← Represents OutageLogs table
│   ├── UsageLog.cs             ← Represents UsageLogs table
│   └── LossRecord.cs           ← Represents LossRecords table
│
├── DBHelper.cs                 ← Centralized Data Access Layer
│                                  GetDataTable(), ExecuteNonQuery(),
│                                  ExecuteScalar(), Param()
│
├── LoginForm.cs                ← User authentication
├── RegisterForm.cs             ← New user registration
├── DashboardForm.cs            ← Main dashboard, charts, PDF report
├── OutageForm.cs               ← Log load shedding outages
├── ApplianceForm.cs            ← Manage electrical appliances
├── UsageForm.cs                ← Log appliance usage per outage
├── Program.cs                  ← Application entry point
│
├── LoadSheddingDB.sqlite       ← SQLite database file (DB Browser)
├── packages.config             ← NuGet dependencies
└── LoadSheddingCostEstimator.csproj
```

### Architecture — 3 Layers

```
┌─────────────────────────────────────────┐
│         UI Layer (Forms)                │
│  Login, Register, Dashboard, Outage,    │
│  Appliance, Usage                       │
├─────────────────────────────────────────┤
│       Business Logic                    │
│  CalculateLoss(), SaveLoss()            │
│  Validation, Data processing            │
├─────────────────────────────────────────┤
│       Data Access Layer                 │
│  DBHelper.cs — all SQL queries here     │
│  ADO.NET + SQLite                       │
└─────────────────────────────────────────┘
                   ↕
        LoadSheddingDB.sqlite
```

---

## 🗄️ Database Design

**Database:** `LoadSheddingDB.sqlite` (created with DB Browser for SQLite)

### Tables

```
Users
├── UserID     INTEGER  PK AUTOINCREMENT
├── Username   TEXT
└── Password   TEXT

Appliances
├── ApplianceID    INTEGER  PK AUTOINCREMENT
├── ApplianceName  TEXT
├── Wattage        INTEGER
└── Rate           REAL  (PKR per unit)

OutageLogs
├── OutageID       INTEGER  PK AUTOINCREMENT
├── UserID         INTEGER  FK → Users.UserID
├── StartTime      TEXT
├── EndTime        TEXT
└── DurationHours  REAL

UsageLogs
├── UsageID      INTEGER  PK AUTOINCREMENT
├── OutageID     INTEGER  FK → OutageLogs.OutageID
├── ApplianceID  INTEGER  FK → Appliances.ApplianceID
└── HoursUsed    REAL

LossRecords
├── LossID      INTEGER  PK AUTOINCREMENT
├── OutageID    INTEGER  FK → OutageLogs.OutageID
├── TotalLoss   REAL
└── RecordDate  TEXT
```

### Relationships

```
Users ──────────────────→ OutageLogs (1 user : many outages)
OutageLogs ─────────────→ UsageLogs  (1 outage : many usage records)
OutageLogs ─────────────→ LossRecords (1 outage : 1 loss record)
Appliances ─────────────→ UsageLogs  (1 appliance : many usage records)
```

---

## 🚀 Getting Started

### Prerequisites

- Windows 10 / 11 (64-bit)
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) or higher
- [Visual Studio 2019 or 2022](https://visualstudio.microsoft.com/) (Community edition is free)
- [DB Browser for SQLite](https://sqlitebrowser.org/) *(optional — for viewing the database)*

### Installation

**Step 1 — Clone the repository**
```bash
git clone https://github.com/YourUsername/LoadSheddingCostEstimator.git
cd LoadSheddingCostEstimator
```

**Step 2 — Open in Visual Studio**
```
File → Open → Project/Solution → select LoadSheddingCostEstimator.slnx
```

**Step 3 — Restore NuGet Packages**
```
Tools → NuGet Package Manager → Restore NuGet Packages
```
> All packages are included in the `packages/` folder — internet not required.

**Step 4 — Run the application**
```
Press F5  or  click the ▶ Start button
```

The application will open with the **Login Form**.

### Database Setup

The database file `LoadSheddingDB.sqlite` is already included in the project.

On build, it automatically copies to `bin\Debug\` via the `.csproj` setting:

```xml
<Content Include="LoadSheddingDB.sqlite">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
</Content>
```

To **view or edit** the database manually:
1. Open **DB Browser for SQLite**
2. Click **Open Database**
3. Select `LoadSheddingDB.sqlite`

To **recreate the database from scratch**, run this SQL in DB Browser:

```sql
CREATE TABLE IF NOT EXISTS Users (
    UserID   INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT,
    Password TEXT
);
CREATE TABLE IF NOT EXISTS Appliances (
    ApplianceID   INTEGER PRIMARY KEY AUTOINCREMENT,
    ApplianceName TEXT,
    Wattage       INTEGER,
    Rate          REAL
);
CREATE TABLE IF NOT EXISTS OutageLogs (
    OutageID      INTEGER PRIMARY KEY AUTOINCREMENT,
    UserID        INTEGER,
    StartTime     TEXT,
    EndTime       TEXT,
    DurationHours REAL,
    FOREIGN KEY(UserID) REFERENCES Users(UserID)
);
CREATE TABLE IF NOT EXISTS UsageLogs (
    UsageID     INTEGER PRIMARY KEY AUTOINCREMENT,
    OutageID    INTEGER,
    ApplianceID INTEGER,
    HoursUsed   REAL,
    FOREIGN KEY(OutageID)    REFERENCES OutageLogs(OutageID),
    FOREIGN KEY(ApplianceID) REFERENCES Appliances(ApplianceID)
);
CREATE TABLE IF NOT EXISTS LossRecords (
    LossID     INTEGER PRIMARY KEY AUTOINCREMENT,
    OutageID   INTEGER,
    TotalLoss  REAL,
    RecordDate TEXT,
    FOREIGN KEY(OutageID) REFERENCES OutageLogs(OutageID)
);
```

---

## 📖 How to Use

### 1. Register
- Open the app → click **Register**
- Enter a username and password → click **Register**
- Go back to Login

### 2. Login
- Enter your credentials → click **Login**
- Dashboard opens automatically

### 3. Add Appliances
- Click **Appliances** on the Dashboard
- Enter appliance name, wattage (W), and rate (PKR/unit)
- Click **Add** — appliance saved to database

### 4. Log an Outage
- Click **Add Outage** on the Dashboard
- Select start time and end time
- Duration is auto-calculated
- Click **Save**

### 5. Log Usage
- Click **Usage** on the Dashboard
- Select the outage and the appliance that ran
- Enter hours used → click **Save**
- Loss is automatically calculated and saved

### 6. View Dashboard
- Total outages, total cost, average duration shown
- Bar chart shows outages per day
- Click **Refresh** to update

### 7. Generate PDF Report
- Click **Report** on the Dashboard
- PDF saved as `LoadShedding_Report.pdf` in the application folder

---

## 🔢 Loss Calculation Formula

```
Loss (PKR) = (HoursUsed × Wattage × Rate) / 1000
```

**Example:**
```
Fan = 100W | Rate = 50 PKR/unit | Ran for 3 hours

Loss = (3 × 100 × 50) / 1000 = 15 PKR
```

This formula is applied in `DashboardForm.CalculateLoss(outageID)` which joins `UsageLogs` with `Appliances` to get wattage and rate for each appliance used during an outage.

---

## 📦 NuGet Packages

| Package | Version | Purpose |
|---------|---------|---------|
| System.Data.SQLite | 1.0.119.0 | SQLite database driver for ADO.NET |
| iTextSharp | 5.5.13.5 | PDF report generation |
| BCrypt.Net-Next | 4.1.0 | Password hashing (installed, ready to use) |
| BouncyCastle.Cryptography | 2.6.2 | Cryptography support for BCrypt |

---

## 🛠️ Troubleshooting

| Problem | Solution |
|---------|----------|
| `No such table: Users` | Ensure `LoadSheddingDB.sqlite` is in the same folder as the `.exe` |
| DLL not found error | Right-click solution → **Restore NuGet Packages** |
| .NET Framework error | Install [.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472) |
| App won't start | Try running as Administrator (right-click → Run as administrator) |

---

## 👨‍💻 Author

**[Samia Akram]**
Roll No: [2024-ag-5348]
Course: CS-412 Visual Programming
Semester: [4th]

---

## 📄 License

This project is submitted as a semester project for academic purposes.
