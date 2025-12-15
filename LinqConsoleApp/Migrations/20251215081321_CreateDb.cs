using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinqConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voorbeelden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voorbeelden", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uitwerkingen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tries = table.Column<int>(type: "int", nullable: false),
                    VoorbeeldId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uitwerkingen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uitwerkingen_Voorbeelden_VoorbeeldId",
                        column: x => x.VoorbeeldId,
                        principalTable: "Voorbeelden",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uitwerkingen_VoorbeeldId",
                table: "Uitwerkingen",
                column: "VoorbeeldId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uitwerkingen");

            migrationBuilder.DropTable(
                name: "Voorbeelden");
        }
    }
}
