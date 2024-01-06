using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class Partener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartenerID",
                table: "Produse",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Partener",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partener", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produse_PartenerID",
                table: "Produse",
                column: "PartenerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produse_Partener_PartenerID",
                table: "Produse",
                column: "PartenerID",
                principalTable: "Partener",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produse_Partener_PartenerID",
                table: "Produse");

            migrationBuilder.DropTable(
                name: "Partener");

            migrationBuilder.DropIndex(
                name: "IX_Produse_PartenerID",
                table: "Produse");

            migrationBuilder.DropColumn(
                name: "PartenerID",
                table: "Produse");
        }
    }
}
