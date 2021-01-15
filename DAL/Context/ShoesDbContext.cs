using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public  class ShoesDbContext : DbContext
    {
        public ShoesDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Shoes> ManyShoes { get; set; }
        public DbSet<Dictionary> Dictionaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Shoes>()
                .Property(e => e.Color)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Shoes>()
                .HasOne(e => e.Type)
                .WithMany(e => e.ShoesTypes)
                .HasForeignKey(e => e.TypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Shoes>()
                .HasOne(e => e.Brand)
                .WithMany(e => e.ShoesBrands)
                .HasForeignKey(e => e.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Seed();
        }
    }
}
