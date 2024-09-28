using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace co2unter.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "service_emissions",
                columns: table => new
                {
                    service_type = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false),
                    total_co2emissions_kg = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_service_emissions", x => new { x.service_type, x.year });
                });

            migrationBuilder.CreateTable(
                name: "transport_emissions",
                columns: table => new
                {
                    transport_type = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false),
                    total_co2emissions_kg = table.Column<double>(type: "double precision", nullable: false),
                    total_distance_km = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_transport_emissions", x => new { x.transport_type, x.year });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "service_emissions");

            migrationBuilder.DropTable(
                name: "transport_emissions");
        }
    }
}
