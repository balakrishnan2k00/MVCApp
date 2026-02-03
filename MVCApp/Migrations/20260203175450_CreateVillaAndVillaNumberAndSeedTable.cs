using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateVillaAndVillaNumberAndSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "villaAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_villaAmenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_villaAmenities_villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Casagrand", 300.0 },
                    { 2, "RainbowVistas", 200.0 },
                    { 3, "MarinaSkies", 400.0 }
                });

            migrationBuilder.InsertData(
                table: "villaAmenities",
                columns: new[] { "Id", "Name", "VillaId" },
                values: new object[,]
                {
                    { 1, "Pool", 1 },
                    { 2, "Gameboy", 1 },
                    { 3, "Gym", 2 },
                    { 4, "PlayCourt", 2 },
                    { 5, "Security", 3 },
                    { 6, "Shop", 3 },
                    { 7, "Jacuzzi", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_villaAmenities_VillaId",
                table: "villaAmenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "villaAmenities");

            migrationBuilder.DropTable(
                name: "villas");
        }
    }
}
