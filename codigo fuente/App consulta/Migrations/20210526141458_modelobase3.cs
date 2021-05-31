using Microsoft.EntityFrameworkCore.Migrations;

namespace App_consulta.Migrations
{
    public partial class modelobase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Actividad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Actividad",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
