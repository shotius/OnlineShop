using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dictionaries",
                columns: new[] { "Id", "HasBrand", "HasType", "Title" },
                values: new object[,]
                {
                    { 1, false, true, "Sneakers" },
                    { 2, false, true, "Sandals" },
                    { 3, false, true, "Boots" },
                    { 4, false, true, "Monsters" },
                    { 5, true, false, "Nike" },
                    { 6, true, false, "Adidas" },
                    { 7, true, false, "Puma" },
                    { 8, true, false, "Saukoni" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Color", "Picture", "Price", "ProductionCountry", "TypeId" },
                values: new object[] { 1, 6, "blue", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/i1-9cfea66d-b519-4b29-8e43-ce4164e8c558/adapt-bb-2-tie-dye-basketball-shoe-vdFwKS.jpg", 100m, "Georgia", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dictionaries",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
