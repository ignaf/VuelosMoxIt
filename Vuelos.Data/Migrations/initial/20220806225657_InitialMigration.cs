using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vuelos.Data.Migrations.initial
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeVuelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorarioDeLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LineaAerea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Demorado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vuelos");
        }
    }
}
