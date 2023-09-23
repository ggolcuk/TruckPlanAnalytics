using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckPlanAnalytics.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TruckModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trucks_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TruckPlans",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TruckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckPlans", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TruckPlans_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckPlans_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DistancesPerCountry",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TruckPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCode = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DistancesPerCountry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DistancesPerCountry_TruckPlans_TruckPlanId",
                        column: x => x.TruckPlanId,
                        principalTable: "TruckPlans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GpsCoordinates",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TruckPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpsCoordinates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GpsCoordinates_TruckPlans_TruckPlanId",
                        column: x => x.TruckPlanId,
                        principalTable: "TruckPlans",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DistancesPerCountry_TruckPlanId",
                table: "DistancesPerCountry",
                column: "TruckPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_GpsCoordinates_TruckPlanId",
                table: "GpsCoordinates",
                column: "TruckPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckPlans_DriverId",
                table: "TruckPlans",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckPlans_TruckId",
                table: "TruckPlans",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_DriverID",
                table: "Trucks",
                column: "DriverID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DistancesPerCountry");

            migrationBuilder.DropTable(
                name: "GpsCoordinates");

            migrationBuilder.DropTable(
                name: "TruckPlans");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
