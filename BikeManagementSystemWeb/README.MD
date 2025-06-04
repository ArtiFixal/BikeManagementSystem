# Bike Management System Web
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

## Images

### Bike table
Allows CRUD operations with pagination on bikes and view their maintenance history.

![Bike table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeTableWeb.jpg?raw=true)

### Bike maintenances
Displays the bike's full maintenance history.

![Bike maintenances](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeMaintenancesWeb.jpg?raw=true)

### Bike Add/Edit form
Form used to create/update bikes.

![Bike edit form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeEditFormWeb.jpg?raw=true)

### Vendor table
Supports CRUD operations with pagination on vendors.

![Vendor table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/vendorTableWeb.jpg?raw=true)

### Bike type table
Provides CRUD operations with pagination support on bike types.

![Bike type table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeTypeTableWeb.jpg?raw=true)

### Bike rental
Allows to rent bikes for selected client.

![Bike rental](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeRentalWeb.jpg?raw=true)

### Active rentals table
Shows active rentals with pagination and lets you return bikes from a selected rental.

![Active rental table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/activeRentalsTableWeb.jpg?raw=true)

### Active rental form
Displays details of the selected rental and rented bikes. Used to return them.

![Active rental form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/activeRentalFormWeb.jpg?raw=true)

### Return bike form
Allows to describe state in which bike was returned.

![Return bike form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/returnBikeFormWeb.jpg?raw=true)

### Worn bikes
Displays bikes requiring maintenance.

![Worn bikes table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/wornBikesTableWeb.jpg?raw=true)

### Maintenance form
Used to describe bike maintenance process.

![Bike maintenance form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/maintenanceFormWeb.jpg?raw=true)