# Bike Management System Desktop
Desktop App written in C# for managing bikes in a rental service. Uses WinForms as a GUI.

## Compiling
Bike Management System requires at least .NET 9 to run.

1. Compile project using VS Studio 2022 with C# and .NET extensions installed

## Migration
Update `DesignTimeBikeManagementDbContext.cs` in BikeManagementSystemLib to your needs.

### Creating migration
```ps
Add-Migration InitialCreate -Project BikeManagementSystemLib -StartupProject BikeManagementSystemDesktop
```

### Updating database
```ps
Update-Database -Project BikeManagementSystemLib -StartupProject BikeManagementSystemDesktop
```

## Running
1. Compile code
2. Do database migration
3. Run app

## Images

### Bike table
Allows CRUD operations with pagination on bikes.

![Bike table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeTable.jpg?raw=true)

### Add/edit bike form
Form used to create/update bikes.

![Bike add form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeEditForm.jpg?raw=true)

### Vendor table
Supports CRUD operations with pagination on vendors.

![Vendor table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/vendorTable.jpg?raw=true)

### Bike type table
Provides CRUD operations with pagination support on bike types.

![Bike type table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeTypeTable.jpg?raw=true)

### Bike rental
Allows to rent bikes for selected client.

![Bike rental](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/bikeRental.jpg?raw=true)

### Active rentals table
Shows active rentals with pagination and lets you return bikes from a selected rental.

![Active rentals table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/activeRentalsTable.jpg?raw=true)

### Active rental form
Displays details of the selected rental and rented bikes. Used to return them.

![Active rental form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/activeRentalForm.jpg?raw=true)

### Return bike form
Allows to describe state in which bike was returned.

![Return bike form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/returnBikeForm.jpg?raw=true)

### Worn bikes
Displays bikes requiring maintenance.

![Worn bikes table](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/wearedBikesTable.jpg?raw=true)

### Maintenance form
Used to describe bike maintenance process.

![Maintenance form](https://github.com/ArtiFixal/BikeManagementSystem/blob/docs/docs/image/maintenanceForm.jpg?raw=true)