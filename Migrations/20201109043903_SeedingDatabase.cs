using Microsoft.EntityFrameworkCore.Migrations;

namespace Stores.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Eat more Healthy Fruit Pies for your Healthy", "Fruit Pies" },
                    { 2, "Eat more Healthy Fruit Pies for your Healthy", "Slab Pies" },
                    { 3, "Eat more Healthy Fruit Pies for your Healthy", "Pumpkin Pies" },
                    { 4, "Eat more Healthy Fruit Pies for your Healthy", "Bite-Sized Pies" },
                    { 5, "Eat more Healthy Chocolate Pies for your Healthy", "Chocolate Pies" },
                    { 6, "Eat more Nutty Fruit Pies for your Healthy", "Nutty Pies" },
                    { 7, "Eat more Nutty Fruit Pies for your Healthy", "Pie Crust Pies" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "Imgurl", "LongDescription", "Name", "Price", "ShortDescription", "ThumbNail" },
                values: new object[,]
                {
                    { 1, 1, "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tellus ex, consequat semper quam vel, imperdiet eleifend enim. Nam at efficitur nisi. Suspendisse egestas nulla orci, sed luctus ante scelerisque in. Mauris blandit ligula ac massa sagittis, eget facilisis sapien maximus. Curabitur mauris nisl, gravida eu pretium et, scelerisque nec ex. Fusce et faucibus nisi. Integer egestas arcu eleifend, euismod velit eget, mattis orci. Phasellus rhoncus, ligula et iaculis tempus, odio enim tempus odio, quis malesuada lectus mauris et lacus. Duis justo est, dignissim ac scelerisque vel, congue vitae nisi.", "Easy Blueberry", 23.8m, "Lorem ipsum dollor", "https://i.pinimg.com/564x/70/19/40/701940ff8f32af9f5f6d4787fbafb0c5.jpg" },
                    { 4, 7, "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Cherry Pie", 20.44m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/3K8rjwNK22DKVDZ3u4w7jHiGQpxJ/671x671_Cherry_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 3, 7, "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Key Lime Pie", 77.7m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/MAEqSGQhwmuZ7RsUXWdKF49prF9/671x671_Key_Lime_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 14, 6, "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Sweet Potato Pie type 4", 44.5m, "Lorem ipsum dollor", "https://images.pexels.com/photos/1634062/pexels-photo-1634062.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 11, 6, "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Coconut Cream Pie", 56.78m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/39wuSffRhMq7iood1y7Mn2DEx3yu/671x671_Coconut_Cream_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 2, 6, "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg", "Morbi accumsan, ipsum non laoreet molestie, sem ligula suscipit nunc, sit amet vestibulum est enim eu elit. Nam quis ligula nisi. Vestibulum imperdiet rhoncus sapien et viverra. Maecenas tempor, diam a porta laoreet, dolor eros pulvinar justo, ac sodales tortor leo a metus. Aenean lectus neque, mollis malesuada mattis nec, cursus at quam. Curabitur vulputate porttitor tincidunt. Cras pellentesque non velit quis pharetra.", "Classic Blueberry Pie", 25.78m, "Lorem ipsum dollor", "https://i.pinimg.com/564x/03/76/e0/0376e0f624326e4aaebc4092039c2230.jpg" },
                    { 15, 4, "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Banoffee type 2", 87.87m, "Lorem ipsum dollor", "https://images.pexels.com/photos/905835/pexels-photo-905835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 7, 4, "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Apple Crisp", 35.44m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 17, 3, "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Mississippi Mud Pie", 34.2m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/3zay8r1nSz4Fun8X2vyywvcMVFn4/671x671_Mississippi_Mud_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 10, 3, "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Banoffee", 67.87m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/W7UMCtWuaC48JXawXhMTeY4rxgJ/671x671_French_Silk_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 5, 3, "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Lemon Meringue Pie", 34.55m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/2mDcvU9LW2DbBuzT1nnTJ1Php6ag/671x671_Lemon_Meringue_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 20, 2, "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Lemon Meringue Pie type 2", 89.20m, "Lorem ipsum dollor", "https://images.pexels.com/photos/2928378/pexels-photo-2928378.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 19, 2, "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Egg White Baked", 76.78m, "Lorem ipsum dollor", "https://images.pexels.com/photos/1346217/pexels-photo-1346217.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 18, 2, "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", " Baked Banoffee type ", 97.87m, "Lorem ipsum dollor", "https://images.pexels.com/photos/6277/food-sweet-christmas-xmas.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 9, 2, "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Sweet Potato Pie", 44.5m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/3xoCQpoQkEbKbHjNpH5vTgPHK7np/671x671_Sweet_Potato_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 16, 1, "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Sweet Potato Pie", 56.78m, "Lorem ipsum dollor", "https://images.pexels.com/photos/1639567/pexels-photo-1639567.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" },
                    { 12, 1, "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Perfect Blueberry Pie", 34.2m, "Lorem ipsum dollor", "https://i.pinimg.com/564x/92/68/ad/9268ada511b93b0895d21984a675284b.jpg" },
                    { 6, 1, "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "French Silk Pie", 56.55m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/2nfr9xWRPv7VhgDzBQRqe2k5fWkK/671x671_Cheesecake_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 8, 7, "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Rhubarb Pie", 56.4m, "Lorem ipsum dollor", "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671" },
                    { 13, 7, "https://img.grouponcdn.com/seocms/3bMub5EFvv4UxLpZTuTYLaCi8Wea/671x671_Rhubarb_Pie_BUYING_GUIDE_DIFFERENT_TYPES_OF_PIE_012319_ak_jpg-671x671", "Donec porttitor enim ac arcu aliquet, vel cursus metus dapibus. Sed arcu dolor, sollicitudin sed pharetra vel, porta a dui. Integer rutrum faucibus tempor. Aenean nec odio nulla. Maecenas placerat aliquam ex, sed interdum mi placerat sit amet. Vivamus auctor tortor at leo molestie aliquam. Nunc condimentum non lacus quis dignissim. Suspendisse sit amet enim mi. Nulla pellentesque blandit mauris. Phasellus pretium, orci id mollis faucibus, erat risus interdum libero, et consectetur leo libero non ex. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean in porta felis. Phasellus purus sem, mollis sit amet malesuada vitae, porta at ante.", "Sliced Carrot Pie", 56.4m, "Lorem ipsum dollor", "https://images.pexels.com/photos/709835/pexels-photo-709835.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 7);
        }
    }
}
