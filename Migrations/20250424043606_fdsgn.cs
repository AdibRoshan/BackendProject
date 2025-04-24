using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendProject.Migrations
{
    /// <inheritdoc />
    public partial class fdsgn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 2, "Matchbox" },
                    { 3, "LEGO Cars" },
                    { 4, "Die-Cast Classics" },
                    { 5, "JDM Legends" },
                    { 6, "Supercars" },
                    { 7, "Muscle Cars" },
                    { 8, "Vintage Cars" }
                });

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "The Hot Wheels Nissan GT-R R34 is a detailed 1:64 scale die-cast model", "https://example.com/gtr.jpg" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Image", "Price", "Title", "stock" },
                values: new object[,]
                {
                    { 9, 1, "A sleek blue Bugatti die-cast toy from Hot Wheels.", "https://example.com/bugatti.jpg", 750m, "Hot Wheels Bugatti Chiron", 20 },
                    { 17, 1, "Electric performance in die-cast form.", "https://example.com/tesla.jpg", 680m, "Hot Wheels Tesla Roadster", 20 }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Email", "Password", "Role", "UserName" },
                values: new object[] { 2, "roshan@gmail.com", "$2a$12$VPH.AgRYn10oZFsyAELKLuLs5tmO6ju3W0zWdizRqU7hnJESFtNWG", "Admin", "Roshan" });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "ProductId", "CategoryId", "Description", "Image", "Price", "Title", "stock" },
                values: new object[,]
                {
                    { 2, 2, "A rugged 4x4 model great for all terrains, with a realistic design.", "https://example.com/jeep4x4.jpg", 250m, "Matchbox Jeep 4x4", 50 },
                    { 3, 3, "LEGO model of the Ferrari F8 with buildable parts.", "https://example.com/lego-f8.jpg", 1200m, "LEGO Ferrari F8", 10 },
                    { 4, 4, "Classic die-cast model of the '67 Impala.", "https://example.com/chevy67.jpg", 850m, "1967 Chevy Impala", 25 },
                    { 5, 5, "JDM icon with detailed paint and decals.", "https://example.com/silvia-s15.jpg", 950m, "Nissan Silvia S15", 18 },
                    { 6, 6, "Supercar model in stunning yellow finish.", "https://example.com/lamborghini.jpg", 1300m, "Lamborghini Aventador", 14 },
                    { 7, 7, "Muscle car legend, bulky and powerful.", "https://example.com/dodge.jpg", 890m, "Dodge Challenger SRT", 30 },
                    { 8, 8, "Vintage charm with realistic curves and wheels.", "https://example.com/beetle.jpg", 600m, "Volkswagen Beetle 1960", 40 },
                    { 10, 2, "Fire & rescue truck with moveable parts.", "https://example.com/rescue.jpg", 300m, "Matchbox Rescue Truck", 35 },
                    { 11, 3, "A complex build of the McLaren racing car.", "https://example.com/mclaren.jpg", 1500m, "LEGO Technic McLaren", 8 },
                    { 12, 4, "Classic Mustang GT in matte black.", "https://example.com/mustang69.jpg", 1000m, "Ford Mustang GT 1969", 22 },
                    { 13, 5, "Detailed JDM favorite in orange.", "https://example.com/supra.jpg", 980m, "Toyota Supra MK4", 15 },
                    { 14, 6, "Super detailed supercar model.", "https://example.com/pagani.jpg", 1400m, "Pagani Huayra", 12 },
                    { 15, 7, "Bright orange muscle car with black stripes.", "https://example.com/camaro.jpg", 820m, "Chevrolet Camaro ZL1", 28 },
                    { 16, 8, "Vintage Mini Cooper with UK flag top.", "https://example.com/mini.jpg", 700m, "Mini Cooper Classic", 19 },
                    { 18, 2, "Detailed black-and-white police car.", "https://example.com/police.jpg", 320m, "Matchbox Police Cruiser", 40 },
                    { 19, 3, "Iconic Porsche built from LEGO bricks.", "https://example.com/porsche-lego.jpg", 1350m, "LEGO Porsche 911 RSR", 9 },
                    { 20, 4, "Vintage fins and chrome in this die-cast classic.", "https://example.com/eldorado.jpg", 950m, "Cadillac Eldorado 1959", 16 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Image" },
                values: new object[] { "he Hot Wheels Nissan GT-R R34 is a detailed 1:64 scale die-cast model, capturing the iconic design and performance of the legendary Japanese sports car. It features aggressive styling, signature features like quad headlights and a rear spoiler, often in various color schemes and special editions", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.in%2FHot-Wheels-Nissan-Skyline-Imports%2Fdp%2FB0DDHLX5B3&psig=AOvVaw3EoMvC6pCTZDa6eXw2gY_8&ust=1734499339117000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCKC409uHrooDFQAAAAAdAAAAABAE" });
        }
    }
}
