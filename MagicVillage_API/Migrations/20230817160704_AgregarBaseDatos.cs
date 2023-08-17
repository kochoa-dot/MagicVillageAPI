using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillageAPI.Migrations
{
    /// <inheritdoc />
    public partial class AgregarBaseDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarifa = table.Column<double>(type: "float", nullable: false),
                    ocupantes = table.Column<int>(type: "int", nullable: false),
                    metrosCuadrados = table.Column<double>(type: "float", nullable: false),
                    imagenUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amenidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
