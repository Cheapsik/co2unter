using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace co2unter.API.Migrations
{
    /// <inheritdoc />
    public partial class MassEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mass_events",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    place = table.Column<string>(type: "text", nullable: false),
                    event_date = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    emmission_t = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_mass_events", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mass_events");
        }
    }
}
