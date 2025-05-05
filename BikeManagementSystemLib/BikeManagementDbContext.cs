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

                entity.HasMany(bike => bike.Maintenances)
                .WithOne(Maintenance => Maintenance.Bike)
                .HasForeignKey(bike => bike.BikeId);
            });

            modelBuilder.Entity<Rental>(entity => {
                entity.Property(rental => rental.Id)
                .ValueGeneratedOnAdd();

                entity.HasOne(rental => rental.Client)
                .WithMany(client => client.Rentals)
                .HasForeignKey(rental => rental.ClientID);
            });

            modelBuilder.Entity<RentedBike>(entity => {
                entity.HasOne(rentedBike => rentedBike.Rental)
                .WithMany(rental => rental.RentedBikes)
                .HasForeignKey(rentedBike => rentedBike.Id.RentalId);

                entity.HasOne(rentedBike => rentedBike.Bike)
                .WithMany(bike => bike.RentedBikes)
                .HasForeignKey(rentedBike => rentedBike.Id.BikeId);
            });
        }
    }
}
