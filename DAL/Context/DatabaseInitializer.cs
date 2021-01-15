using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dictionary>().HasData(
                //types
                new Dictionary()
                {
                    Id = 1,
                    Title="Sneakers",
                    HasType=true
                },
                new Dictionary()
                {
                    Id = 2,
                    Title = "Sandals",
                    HasType = true
                },
                new Dictionary()
                {
                    Id = 3,
                    Title = "Boots",
                    HasType = true
                },
                new Dictionary()
                {
                    Id = 4,
                    Title = "Monsters",
                    HasType = true
                },

                // brands
                new Dictionary()
                {
                    Id = 5,
                    Title = "Nike",
                    HasBrand = true
                },
                new Dictionary()
                {
                    Id = 6,
                    Title = "Adidas",
                    HasBrand = true
                },
                new Dictionary()
                {
                    Id = 7,
                    Title = "Puma",
                    HasBrand = true
                },
                new Dictionary()
                {
                    Id = 8,
                    Title = "Saukoni",
                    HasBrand = true
                });

           modelBuilder.Entity<Shoes>().HasData(
                 new Shoes()
                 {
                     Id = 1,
                     Color = "blue",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "Georgia",
                     Price = 100,
                     TypeId=4,
                     BrandId=6
                     
                 },
                 new Shoes()
                 {
                     Id = 2,
                     Color = "gray",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "USA",
                     Price =200,
                     TypeId = 1,
                     BrandId = 5
                 },
                 new Shoes()
                 {
                     Id = 3,
                     Color = "white",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "Chine",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 4,
                     Color = "white",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 5,
                     Color = "white",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 6,
                     Color = "black",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 7,
                     Color = "pink",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 3,
                     BrandId = 7
                 },
                 new Shoes()
                 {
                     Id = 8,
                     Color = "white",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg",
                     ProductionCountry = "Germany",
                     Price = 200,
                     TypeId = 4,
                     BrandId = 8
                 });
        }
    }
}
