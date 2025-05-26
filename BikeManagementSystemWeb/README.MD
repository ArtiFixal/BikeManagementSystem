# Bike Management System Library
Web App written in C# for managing bikes in a rental service. Uses ASP.NET Core MVC as frontend.

## Compiling
Bike Management System requires at least .NET 9 to run.

1. Compile project using VS Studio 2022 with C# and .NET extensions installed

## Migration
Update `DesignTimeBikeManagementDbContext.cs` in BikeManagementSystemLib to your needs.

### Creating migration
```ps
Add-Migration InitialCreate -Project BikeManagementSystemLib -StartupProject BikeManagementSystemWeb
```

### Updating database
```ps
Update-Database -Project BikeManagementSystemLib -StartupProject BikeManagementSystemWeb
```

## Running
1. Compile code
2. Do database migration
3. Run app

