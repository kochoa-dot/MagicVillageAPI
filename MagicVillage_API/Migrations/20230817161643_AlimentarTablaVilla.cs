using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillageAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Nombre", "amenidad", "detalle", "fechaActualizacion", "fechaCreacion", "imagenUrl", "metrosCuadrados", "ocupantes", "tarifa" },
                values: new object[,]
                {
                    { 1, "Villa real", "", "Detalle de la villa ", new DateTime(2023, 8, 17, 10, 16, 43, 260, DateTimeKind.Local).AddTicks(1268), new DateTime(2023, 8, 17, 10, 16, 43, 260, DateTimeKind.Local).AddTicks(1258), "", 5.0, 5, 150.0 },
                    { 2, "Premium vista a la piscina", "", "Detalle de la villa ", new DateTime(2023, 8, 17, 10, 16, 43, 260, DateTimeKind.Local).AddTicks(1270), new DateTime(2023, 8, 17, 10, 16, 43, 260, DateTimeKind.Local).AddTicks(1270), "", 40.0, 4, 150.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
