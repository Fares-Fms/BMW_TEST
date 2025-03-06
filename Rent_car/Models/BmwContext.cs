using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Rent_car.Models;

public partial class BmwContext : DbContext
{
    public BmwContext()
    {
    }

    public BmwContext(DbContextOptions<BmwContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbCar> TbCars { get; set; }

 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbCar>(entity =>
        {
            entity.HasKey(e => e.CarId);

            entity.Property(e => e.CarId).ValueGeneratedNever();
            entity.Property(e => e.CarName)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.Engine)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fuel)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Hp).HasColumnName("HP");
            entity.Property(e => e.ImageName).HasMaxLength(50);
            entity.Property(e => e.Model)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Weight)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("weight");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
