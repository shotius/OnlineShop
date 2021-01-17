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
                     Picture = "https://images.pexels.com/photos/19090/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                     ProductionCountry = "Georgia",
                     Price = 100,
                     TypeId=4,
                     BrandId=6
                     
                 },
                 new Shoes()
                 {
                     Id = 2,
                     Color = "gray",
                     Picture = "https://images-na.ssl-images-amazon.com/images/I/61utX8kBDlL._UL1100_.jpg",
                     ProductionCountry = "USA",
                     Price =200,
                     TypeId = 1,
                     BrandId = 5
                 },
                 new Shoes()
                 {
                     Id = 3,
                     Color = "white",
                     Picture = "https://images.pexels.com/photos/2529148/pexels-photo-2529148.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                     ProductionCountry = "Chine",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 4,
                     Color = "white",
                     Picture = "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/12786380/2020/10/20/57e4ead2-0e80-48b4-bee0-cece0f1c68c61603176607927mrwonkerMenMulticolouredSneakers1.jpg",
                     ProductionCountry = "England",
                     Price = 50,
                     TypeId = 2,
                     BrandId = 5
                 },
                 new Shoes()
                 {
                     Id = 5,
                     Color = "red",
                     Picture = "https://d11lddvh7wcsbc.cloudfront.net/images/thumbnails/423/635/detailed/66/TB2jVBbapXXXXXaXpXXXXXXXXXX-1642940732_03.jpg?t=1445233181",
                     ProductionCountry = "Vietnam",
                     Price = 90,
                     TypeId = 2,
                     BrandId = 4
                 },
                 new Shoes()
                 {
                     Id = 6,
                     Color = "white",
                     Picture = "https://cdn.shopify.com/s/files/1/0008/8116/4339/products/TLP-whiteblackgum-1b_f7bf4f70-1360-42ca-b8f1-01635ba74be2.jpg?v=1592607370",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 2,
                     BrandId = 6
                 },
                 new Shoes()
                 {
                     Id = 7,
                     Color = "gray",
                     Picture = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/shoes-1-1594143237.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=640:*",
                     ProductionCountry = "USA",
                     Price = 190,
                     TypeId = 3,
                     BrandId = 7
                 },
                 new Shoes()
                 {
                     Id = 8,
                     Color = "white",
                     Picture = "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/productimage/2019/12/31/167d5528-d459-4139-bc8e-2c8f88b6eb361577741582295-1.jpg",
                     ProductionCountry = "Germany",
                     Price = 200,
                     TypeId = 4,
                     BrandId = 8
                 },
                 new Shoes()
                 {
                     Id = 9,
                     Color = "pink",
                     Picture = "https://i.pinimg.com/236x/4c/98/67/4c98674974e248680fb500c84215f2c1.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 3,
                     BrandId = 7
                 },
                 new Shoes()
                 {
                     Id = 10,
                     Color = "pink",
                     Picture = "https://assets.ajio.com/medias/sys_master/root/20200824/mHh2/5f438ad5f997dd2277a73477/-288Wx360H-461370283-brown-MODEL.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 3,
                     BrandId = 7
                 },
                 new Shoes()
                 {
                     Id = 11,
                     Color = "pink",
                     Picture = "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/96b006c4-bc46-4a04-a48c-cc1039329d54/renew-run-womens-running-shoe-9CrB26.jpg",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 3,
                     BrandId = 7
                 },
                 new Shoes()
                 {
                     Id = 12,
                     Color = "pink",
                     Picture = "https://rukminim1.flixcart.com/image/714/857/k391w280/shoe/m/n/c/irsoe-9905-shoes-40-cassiey-white-original-imafmf9dyfzghms2.jpeg?q=50",
                     ProductionCountry = "China",
                     Price = 20,
                     TypeId = 3,
                     BrandId = 7
                 });

        }
    }
}
