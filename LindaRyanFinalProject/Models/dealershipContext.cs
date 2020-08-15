using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LindaRyanFinalProject.Models
{
    public partial class dealershipContext : DbContext
    {
        public dealershipContext()
        {
        }

        public dealershipContext(DbContextOptions<dealershipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleMake> VehicleMake { get; set; }
        public virtual DbSet<VehicleModel> VehicleModel { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=lindaryan.database.windows.net;Initial Catalog=dealership;Persist Security Info=False;User ID=comp2084;Password=Georgian2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(e => e.Colour).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.SoldStatus).IsUnicode(false);

                entity.HasOne(d => d.Make)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.MakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_MakeId");

                entity.HasOne(d => d.Model)
                    .WithMany(p => p.Vehicle)
                    .HasForeignKey(d => d.ModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_ModelId");
            });

            modelBuilder.Entity<VehicleMake>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<VehicleModel>(entity =>
            {
                entity.Property(e => e.EngineSize).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.VehicleModel)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VehicleModel_VehicleTypeId");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });
        }
    }
}
