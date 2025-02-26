# MvcWebApp

## Description
MvcWebApp is a simple ASP.NET Core MVC web application designed to log and display visitor information, including date, time, and IP address, on the Home page. The latest 5 visit logs are displayed on the **View Log** page, stored in a MongoDB database for easy management and retrieval.

## Features
- **Visitor Logging**: Captures and stores visitor's IP address and visit date-time.
- **MongoDB Integration**: Utilizes MongoDB for storing and retrieving logs.
- **Log Management**: Retains only the 5 most recent logs by deleting the oldest entry when a new one is added.
- **Navigation**: Easy navigation between **Home** and **View Log** pages.
- **PC-Optimized UI**: Clean and responsive design tailored for desktop viewing using Bootstrap.

## Tech Stack
- **Frontend**: HTML, CSS, Bootstrap
- **Backend**: C#, ASP.NET Core MVC
- **Database**: MongoDB
- **Tools**: Visual Studio, MongoDB.Driver

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/)
- [MongoDB](https://www.mongodb.com/try/download/community)

### Installation
1. **Clone the Repository**:
   ```sh
   git clone https://github.com/your-username/MvcWebApp.git
   cd MvcWebApp
   ```

2. **Configure MongoDB**:
   - Ensure MongoDB is running locally on the default port `27017`.
   - The default database name is `UserLogsDB` with a collection named `UserLogs`.

3. **Update appsettings.json**:
   Make sure your MongoDB connection string is correct:
   ```json
   "MongoDbSettings": {
     "ConnectionString": "mongodb://localhost:27017",
     "DatabaseName": "UserLogsDB",
     "CollectionName": "UserLogs"
   }
   ```

4. **Restore Packages and Run the App**:
   ```sh
   dotnet restore
   dotnet run
   ```

### Usage
1. Visit the Home page to automatically log your visit.
2. Click on **View Log Page** to see the latest 5 visit logs.
3. Navigate back to the Home page using the provided button.


## Acknowledgments
- [MongoDB.Driver](https://www.mongodb.com/docs/drivers/csharp/)
- [Bootstrap](https://getbootstrap.com/)
- [ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-7.0)
