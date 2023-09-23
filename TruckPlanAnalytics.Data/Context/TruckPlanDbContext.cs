using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TruckPlanAnalytics.Core.Models;

namespace TruckPlanAnalytics.Data.Context
{
    public class TruckPlanDbContext : DbContext
    {
        public DbSet<TruckPlan> TruckPlans { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<GpsCoordinate> GpsCoordinates { get; set; }
        public DbSet<DistancePerCountry> DistancesPerCountry { get; set; }

        // Configure your connection string here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=TruckAnalyticsTest;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TruckPlan>()
                .HasOne(tp => tp.Truck)
                .WithMany(t => t.TruckPlans)
                .HasForeignKey(tp => tp.TruckId);

            // TruckPlan to Driver
            modelBuilder.Entity<TruckPlan>()
                .HasOne(tp => tp.Driver)
                .WithMany(d => d.TruckPlans)
                .HasForeignKey(tp => tp.DriverId);

            // TruckPlan to GpsCoordinate
            modelBuilder.Entity<GpsCoordinate>()
                .HasOne(gc => gc.TruckPlan)
                .WithMany(tp => tp.GpsCoordinates)
                .HasForeignKey(gc => gc.TruckPlanId);

            // TruckPlan to DistancePerCountry
            modelBuilder.Entity<DistancePerCountry>()
                .HasOne(dpc => dpc.TruckPlan)
                .WithMany(tp => tp.DistancesPerCountry)
                .HasForeignKey(dpc => dpc.TruckPlanId);



            // Driver Configuration
            modelBuilder.Entity<Driver>()
                .Property(d => d.Name)
                .IsRequired();

            modelBuilder.Entity<Driver>()
                .Property(d => d.Birthdate)
                .IsRequired();

            modelBuilder.Entity<Driver>()
                .Property(d => d.Licenses)
                .IsRequired();

            // Truck Configuration
            modelBuilder.Entity<Truck>()
                .Property(t => t.RegistrationNumber)
                .IsRequired();
            modelBuilder.Entity<Truck>()
                .Property(t => t.RequiredLicense)
                .IsRequired();



            // GpsCoordinate Configuration
            modelBuilder.Entity<GpsCoordinate>()
                .Property(g => g.Coordinate)
                .IsRequired();

            
            modelBuilder.Entity<GpsCoordinate>()
                .Property(g => g.Timestamp)
                .IsRequired();

            // TruckPlan Configuration
            modelBuilder.Entity<TruckPlan>()
                .Property(tp => tp.Status)
                .IsRequired(); 

            // DistancePerCountry Configuration
            modelBuilder.Entity<DistancePerCountry>()
                .Property(dp => dp.CountryCode)
                .IsRequired();

            modelBuilder.Entity<DistancePerCountry>()
                .Property(dp => dp.Distance)
                .IsRequired();

        }
    }
}
