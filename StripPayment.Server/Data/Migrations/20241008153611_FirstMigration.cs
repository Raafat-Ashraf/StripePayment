using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripPayment.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "11dee476-6420-4f55-aed8-5783c6ccff89", "Description of product 15, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/15/500", 1015m, "Product 15" },
                    { "25146bd4-7ffb-4b0b-a232-42c12a78562f", "Description of product 0, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/0/500", 1000m, "Product 0" },
                    { "3e3f7647-5afc-4d8e-9fdc-642c255ab369", "Description of product 14, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/14/500", 1014m, "Product 14" },
                    { "43fa810a-f848-4a3a-9685-ca253e7c45c3", "Description of product 19, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/19/500", 1019m, "Product 19" },
                    { "5ab96d0a-eda4-46ca-981e-8747ce7fabdd", "Description of product 3, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/3/500", 1003m, "Product 3" },
                    { "625bfbc4-c392-46d2-bb23-5a779d364ca0", "Description of product 6, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/6/500", 1006m, "Product 6" },
                    { "638aeca8-cad2-4bc5-8a6e-dad58035b34d", "Description of product 17, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/17/500", 1017m, "Product 17" },
                    { "733157a0-9a0e-44a2-86b9-126f6a0ba951", "Description of product 1, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/1/500", 1001m, "Product 1" },
                    { "8611fa38-85c7-4d32-bd63-e23168930b94", "Description of product 18, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/18/500", 1018m, "Product 18" },
                    { "929fb89d-3d74-421a-bc4e-6e0ff6509f2b", "Description of product 10, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/10/500", 1010m, "Product 10" },
                    { "a7ba0fac-df5a-434a-9bdc-fca0fa25d1d1", "Description of product 9, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/9/500", 1009m, "Product 9" },
                    { "ab20b53f-0f69-4a5d-a560-7d05bd4e8dda", "Description of product 16, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/16/500", 1016m, "Product 16" },
                    { "ae4888c6-4dad-424f-8330-82c9abdfdc95", "Description of product 2, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/2/500", 1002m, "Product 2" },
                    { "b57a4be2-7190-407c-bc8a-ade622695e9b", "Description of product 4, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/4/500", 1004m, "Product 4" },
                    { "bc3b2681-985e-4539-804f-21eee1db0b90", "Description of product 8, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/8/500", 1008m, "Product 8" },
                    { "db0cf9d9-7571-4aee-8dfc-faeba947997f", "Description of product 12, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/12/500", 1012m, "Product 12" },
                    { "e8f720b4-537b-4019-b733-4907fed72368", "Description of product 11, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/11/500", 1011m, "Product 11" },
                    { "e9e346fa-d83b-4dde-bb0c-37681585c43e", "Description of product 13, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/13/500", 1013m, "Product 13" },
                    { "ec075572-8e3b-4352-9168-44f5f43bd8df", "Description of product 7, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/7/500", 1007m, "Product 7" },
                    { "ff02cebd-a8d9-4097-844a-f61b8652bcca", "Description of product 5, This is an amazing product with a price-quality balance you won't find anywhere else.", "https://picsum.photos/id/5/500", 1005m, "Product 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
