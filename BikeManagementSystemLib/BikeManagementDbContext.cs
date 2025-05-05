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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>(entity =>
            {
                entity.HasOne(bike => bike.Type)
                .WithMany(type => type.Bikes)
                .HasForeignKey(bike => bike.TypeId);

                entity.HasOne(bike => bike.Vendor)
                .WithMany(vendor => vendor.Bikes)
                .HasForeignKey(bike => bike.VendorId);

                entity.HasOne(bike => bike.Image)
                .WithMany(image => image.Bikes)
                .HasForeignKey(bike => bike.ImageId);
            });
        }
    }
}
