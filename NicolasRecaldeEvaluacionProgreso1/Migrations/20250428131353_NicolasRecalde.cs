using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NicolasRecaldeEvaluacionProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class NicolasRecalde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Salario = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EsMayorEdad = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entrada = table.Column<DateOnly>(type: "date", nullable: false),
                    Salida = table.Column<DateOnly>(type: "date", nullable: false),
                    Precio = table.Column<float>(type: "real", nullable: false),
                    Informacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Clientes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Clientes_Clientes",
                        column: x => x.Clientes,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plan_de_recompensas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    PuntosAcumulados = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    ReservaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plan_de_recompensas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plan_de_recompensas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plan_de_recompensas_Reserva_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reserva",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plan_de_recompensas_ClienteId",
                table: "Plan_de_recompensas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Plan_de_recompensas_ReservaId",
                table: "Plan_de_recompensas",
                column: "ReservaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_Clientes",
                table: "Reserva",
                column: "Clientes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plan_de_recompensas");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
