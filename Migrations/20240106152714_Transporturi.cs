using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class Transporturi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Angajat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Angajare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Angajat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartenerID = table.Column<int>(type: "int", nullable: true),
                    AngajatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transport_Angajat_AngajatID",
                        column: x => x.AngajatID,
                        principalTable: "Angajat",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Transport_Partener_PartenerID",
                        column: x => x.PartenerID,
                        principalTable: "Partener",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transport_AngajatID",
                table: "Transport",
                column: "AngajatID");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_PartenerID",
                table: "Transport",
                column: "PartenerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "Angajat");
        }
    }
}
