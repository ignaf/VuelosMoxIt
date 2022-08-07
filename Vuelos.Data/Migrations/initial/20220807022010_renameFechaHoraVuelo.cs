using Microsoft.EntityFrameworkCore.Migrations;

namespace Vuelos.Data.Migrations.initial
{
    public partial class renameFechaHoraVuelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HorarioDeLlegada",
                table: "Vuelos",
                newName: "FechaYHorarioDeLlegada");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaYHorarioDeLlegada",
                table: "Vuelos",
                newName: "HorarioDeLlegada");
        }
    }
}
