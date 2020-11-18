using Microsoft.EntityFrameworkCore;
using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Data
{
    public class StoresContext : DbContext
    {
        public StoresContext(DbContextOptions<StoresContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Product>().HasData(
            new Product()
            {
                Name = "Easy Blueberry",
                Id = 1,
                Price = 23.8M,
                Ratings = { },
                CategoryID = 1,
                ThumbNail = "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg",
                Imgurl = "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg",
                ShortDescription = "Lorem ipsum dollor",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tellus ex, consequat semper quam vel, imperdiet eleifend enim. Nam at efficitur nisi. Suspendisse egestas nulla orci, sed luctus ante scelerisque in. Mauris blandit ligula ac massa sagittis, eget facilisis sapien maximus. Curabitur mauris nisl, gravida eu pretium et, scelerisque nec ex. Fusce et faucibus nisi. Integer egestas arcu eleifend, euismod velit eget, mattis orci. Phasellus rhoncus, ligula et iaculis tempus, odio enim tempus odio, quis malesuada lectus mauris et lacus. Duis justo est, dignissim ac scelerisque vel, congue vitae nisi."
            },

            new Product()
            {
                Id = 2,
                Name = "Classic Blueberry Pie",
                Price = 25.78M,
                CategoryID = 6,
                Ratings = { },

                ThumbNail = "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg",
                Imgurl = "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg",
                ShortDescription = "Lorem ipsum dollor",
                LongDescription = "Morbi accumsan, ipsum non laoreet molestie, sem ligula suscipit nunc, sit amet vestibulum est enim eu elit. Nam quis ligula nisi. Vestibulum imperdiet rhoncus sapien et viverra. Maecenas tempor, diam a porta laoreet, dolor eros pulvinar justo, ac sodales tortor leo a metus. Aenean lectus neque, mollis malesuada mattis nec, cursus at quam. Curabitur vulputate porttitor tincidunt. Cras pellentesque non velit quis pharetra.",
            },
            new Product()
            {
                Id = 3,
                Name = "Key Lime Pie",
                Price = 77.7M,
                CategoryID = 7,
                Ratings = { },

                ThumbNail = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                Imgurl = "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                ShortDescription = "Lorem ipsum dollor",
                LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
            },
                new Product()
                {
                    Id = 4,
                    Name = "Cherry Pie",
                    Price = 20.44M,
                    CategoryID = 7,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 5,
                    Name = "Lemon Meringue Pie",
                    Price = 34.55M,
                    CategoryID = 3,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 6,
                    Name = "French Silk Pie",
                    Price = 56.55M,
                    CategoryID = 1,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 7,
                    Name = "Apple Crisp",
                    Price = 35.44M,
                    CategoryID = 4,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 8,
                    Name = "Rhubarb Pie",
                    Price = 56.4M,
                    CategoryID = 7,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 9,
                    Name = "Sweet Potato Pie",
                    Price = 44.5M,
                    CategoryID = 2,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 10,
                    Name = "Banoffee",
                    Price = 67.87M,
                    CategoryID = 3,
                    Ratings = {},
                    ThumbNail = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 11,
                    Name = "Coconut Cream Pie",
                    Price = 56.78M,
                    CategoryID = 6,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 12,
                    CategoryID = 1,
                    Ratings = { },

                    Name = "Perfect Blueberry Pie",
                    Price = 34.2M,
                    ThumbNail = "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg",
                    Imgurl = "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                // Dont Mix these

                new Product()
                {
                    Id = 13,
                    Name = "Sliced Carrot Pie",
                    Price = 56.4M,
                    CategoryID = 7,
                    Ratings = { },
                    ThumbNail = "https://images.pexels.com/photos/709835/pexels-photo-709835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 14,
                    CategoryID = 6,

                    Name = "Sweet Potato Pie type 4",
                    Price = 44.5M,
                    Ratings = { },
                    ThumbNail = "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 15,
                    Name = "Banoffee type 2",
                    Price = 87.87M,
                    CategoryID = 4,
                    Ratings = { },

                    ThumbNail = "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 16,
                    CategoryID = 1,
                    Name = "Sweet Potato Pie",
                    Price = 56.78M,
                    Ratings = { },

                    ThumbNail = "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 17,
                    Name = "Mississippi Mud Pie",
                    Price = 34.2M,
                    CategoryID = 3,
                    Ratings = { },

                    ThumbNail = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    Imgurl = "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },

                // there more 
                new Product()
                {
                    Id = 18,
                    Name = " Baked Banoffee type ",
                    Price = 97.87M,
                    CategoryID = 2,
                    Ratings = { },

                    ThumbNail = "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 19,
                    Name = "Egg White Baked",
                    Price = 76.78M,
                    CategoryID = 2,
                    Ratings = { },

                    ThumbNail = "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                },
                new Product()
                {
                    Id = 20,
                    Name = "Lemon Meringue Pie type 2",
                    Price = 89.20M,
                    CategoryID = 2,
                    Ratings = { },

                    ThumbNail = "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    Imgurl = "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                    ShortDescription = "Lorem ipsum dollor",
                    LongDescription = "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.",
                });

            modelBuilder.Entity<Category>().HasData(
               new Category()
               {
                   CategoryID = 1,
                   Name = "Fruit Pies",
                   Description = "Eat more Healthy Fruit Pies for your Healthy"
               },

               new Category()
               {
                   CategoryID = 2,
                   Name = "Slab Pies",
                   Description = "Eat more Healthy Fruit Pies for your Healthy"
               },

               new Category()
               {
                   CategoryID = 3,
                   Name = "Pumpkin Pies",
                   Description = "Eat more Healthy Fruit Pies for your Healthy"
               },
               new Category()
               {
                   CategoryID = 4,
                   Name = "Bite-Sized Pies",
                   Description = "Eat more Healthy Fruit Pies for your Healthy"
               },
               new Category()
               {

                   CategoryID = 5,
                   Name = "Chocolate Pies",
                   Description = "Eat more Healthy Chocolate Pies for your Healthy"
               },
               new Category()
               {
                   CategoryID = 6,
                   Name = "Nutty Pies",
                   Description = "Eat more Nutty Fruit Pies for your Healthy"
               },

                new Category()
                {
                    CategoryID = 7,
                    Name = "Pie Crust Pies",
                    Description = "Eat more Nutty Fruit Pies for your Healthy"
                }
               );
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Stores.Models.ShoppingCart> ShoppingCart { get; set; }
    }
}
