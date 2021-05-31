using Microsoft.EntityFrameworkCore.Migrations;

namespace App_consulta.Migrations
{
    public partial class modelobase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ambulante",
                table: "Persona",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Confianza",
                table: "Persona",
                type: "longtext",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ambulante",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Confianza",
                table: "Persona");
        }
    }
}
