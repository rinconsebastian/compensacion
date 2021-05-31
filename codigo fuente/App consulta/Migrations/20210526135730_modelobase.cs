using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App_consulta.Migrations
{
    public partial class modelobase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actividad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Poligono = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lugar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    IdPlaya = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "longtext", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: true),
                    Telefono = table.Column<string>(type: "longtext", nullable: true),
                    IdActividad = table.Column<int>(type: "int", nullable: false),
                    IdLugar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Actividad_IdActividad",
                        column: x => x.IdActividad,
                        principalTable: "Actividad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Actividad_IdLugar",
                        column: x => x.IdLugar,
                        principalTable: "Actividad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<string>(type: "longtext", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdUsuario = table.Column<string>(type: "longtext", nullable: true),
                    Nombreusuario = table.Column<string>(type: "longtext", nullable: true),
                    Soporte1 = table.Column<string>(type: "longtext", nullable: true),
                    Soporte2 = table.Column<string>(type: "longtext", nullable: true),
                    Soporte3 = table.Column<string>(type: "longtext", nullable: true),
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pago_Persona_IdPersona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lugar_IdPlaya",
                table: "Lugar",
                column: "IdPlaya");

            migrationBuilder.CreateIndex(
                name: "IX_Pago_IdPersona",
                table: "Pago",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdActividad",
                table: "Persona",
                column: "IdActividad");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdLugar",
                table: "Persona",
                column: "IdLugar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lugar");

            migrationBuilder.DropTable(
                name: "Pago");

            migrationBuilder.DropTable(
                name: "Playa");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Actividad");
        }
    }
}
