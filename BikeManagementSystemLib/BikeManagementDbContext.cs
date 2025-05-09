using BikeManagementSystemLib.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeManagementSystemLib
{
    public class BikeManagementDbContext : DbContext
    {
        public BikeManagementDbContext(DbContextOptions options) : base(options){}

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeType> BikeTypes { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentedBike> RentedBikes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>(entity => {
                entity.Property(bike => bike.Id)
                .ValueGeneratedOnAdd();

                entity.HasOne(bike => bike.Type)
                .WithMany(type => type.Bikes)
                .HasForeignKey(bike => bike.TypeId);

                entity.HasOne(bike => bike.Vendor)
                .WithMany(vendor => vendor.Bikes)
                .HasForeignKey(bike => bike.VendorId);

                entity.HasOne(bike => bike.Image)
                .WithMany(image => image.Bikes)
                .HasForeignKey(bike => bike.ImageId);

                entity.HasOne(bike => bike.LastMaintenance)
                .WithOne(maintenance => maintenance.Bike)
                .HasForeignKey<Bike>(bike=>bike.LastMaintenanceId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Maintenance>(entity => {
                entity.Ignore(maintenance=>maintenance.Bike);
                entity.HasOne(Maintenance => Maintenance.Bike)
                .WithMany(bike => bike.Maintenances)
                .HasForeignKey(bike => bike.BikeId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Rental>(entity => {
                entity.Property(rental => rental.Id)
                .ValueGeneratedOnAdd();

                entity.HasOne(rental => rental.Client)
                .WithMany(client => client.Rentals)
                .HasForeignKey(rental => rental.ClientID);
            });

            modelBuilder.Entity<RentedBike>(entity => {
                entity.Ignore(bike => bike.Id);
                entity.HasKey(bike => new { bike.RentalId, bike.BikeId });
                entity.HasOne(rentedBike => rentedBike.Rental)
                .WithMany(rental => rental.RentedBikes)
                .HasForeignKey(rentedBike => rentedBike.RentalId);

                entity.HasOne(rentedBike => rentedBike.Bike)
                .WithMany(bike => bike.RentedBikes)
                .HasForeignKey(rentedBike => rentedBike.BikeId);
            });
        }
    }
}
