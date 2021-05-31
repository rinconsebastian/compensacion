using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App_consulta.Migrations
{
    public partial class modelobase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Actividad_IdLugar",
                table: "Persona");

            migrationBuilder.DropTable(
                name: "Lugar");

            migrationBuilder.RenameColumn(
                name: "IdLugar",
                table: "Persona",
                newName: "IdPlaya");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_IdLugar",
                table: "Persona",
                newName: "IX_Persona_IdPlaya");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Playa_IdPlaya",
                table: "Persona",
                column: "IdPlaya",
                principalTable: "Playa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Playa_IdPlaya",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "IdPlaya",
                table: "Persona",
                newName: "IdLugar");

            migrationBuilder.RenameIndex(
                name: "IX_Persona_IdPlaya",
                table: "Persona",
                newName: "IX_Persona_IdLugar");

            migrationBuilder.CreateTable(
                name: "Lugar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPlaya = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lugar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lugar_Actividad_IdPlaya",
                        column: x => x.IdPlaya,
                        principalTable: "Actividad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lugar_IdPlaya",
                table: "Lugar",
                column: "IdPlaya");

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Actividad_IdLugar",
                table: "Persona",
                column: "IdLugar",
                principalTable: "Actividad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
