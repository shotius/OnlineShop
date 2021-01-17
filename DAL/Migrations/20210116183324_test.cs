using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasType = table.Column<bool>(type: "bit", nullable: false),
                    HasBrand = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManyShoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyShoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManyShoes_Dictionaries_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Dictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManyShoes_Dictionaries_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Dictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "ManyShoes",
                columns: new[] { "Id", "BrandId", "Color", "Picture", "Price", "ProductionCountry", "TypeId" },
                values: new object[,]
                {
                    { 5, 4, "red", "https://d11lddvh7wcsbc.cloudfront.net/images/thumbnails/423/635/detailed/66/TB2jVBbapXXXXXaXpXXXXXXXXXX-1642940732_03.jpg?t=1445233181", 90m, "Vietnam", 2 },
                    { 2, 5, "gray", "https://images-na.ssl-images-amazon.com/images/I/61utX8kBDlL._UL1100_.jpg", 200m, "USA", 1 },
                    { 4, 5, "white", "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/12786380/2020/10/20/57e4ead2-0e80-48b4-bee0-cece0f1c68c61603176607927mrwonkerMenMulticolouredSneakers1.jpg", 50m, "England", 2 },
                    { 1, 6, "blue", "https://images.pexels.com/photos/19090/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=1&w=500", 100m, "Georgia", 4 },
                    { 3, 6, "white", "https://images.pexels.com/photos/2529148/pexels-photo-2529148.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", 20m, "Chine", 2 },
                    { 6, 6, "white", "https://cdn.shopify.com/s/files/1/0008/8116/4339/products/TLP-whiteblackgum-1b_f7bf4f70-1360-42ca-b8f1-01635ba74be2.jpg?v=1592607370", 20m, "China", 2 },
                    { 7, 7, "gray", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/shoes-1-1594143237.jpg?crop=0.502xw:1.00xh;0.250xw,0&resize=640:*", 190m, "USA", 3 },
                    { 9, 7, "pink", "https://i.pinimg.com/236x/4c/98/67/4c98674974e248680fb500c84215f2c1.jpg", 20m, "China", 3 },
                    { 10, 7, "pink", "https://assets.ajio.com/medias/sys_master/root/20200824/mHh2/5f438ad5f997dd2277a73477/-288Wx360H-461370283-brown-MODEL.jpg", 20m, "China", 3 },
                    { 11, 7, "pink", "https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/96b006c4-bc46-4a04-a48c-cc1039329d54/renew-run-womens-running-shoe-9CrB26.jpg", 20m, "China", 3 },
                    { 12, 7, "pink", "https://rukminim1.flixcart.com/image/714/857/k391w280/shoe/m/n/c/irsoe-9905-shoes-40-cassiey-white-original-imafmf9dyfzghms2.jpeg?q=50", 20m, "China", 3 },
                    { 8, 8, "white", "https://assets.myntassets.com/dpr_1.5,q_60,w_400,c_limit,fl_progressive/assets/images/productimage/2019/12/31/167d5528-d459-4139-bc8e-2c8f88b6eb361577741582295-1.jpg", 200m, "Germany", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManyShoes_BrandId",
                table: "ManyShoes",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ManyShoes_TypeId",
                table: "ManyShoes",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManyShoes");

            migrationBuilder.DropTable(
                name: "Dictionaries");
        }
    }
}
