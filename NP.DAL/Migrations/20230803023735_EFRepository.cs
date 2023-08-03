using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NP.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EFRepository : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "СhangeSettingsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SetpointPaperWeightChange = table.Column<double>(type: "REAL", nullable: true),
                    SetpointPaperFormatChange = table.Column<double>(type: "REAL", nullable: true),
                    SetpointWireChange = table.Column<double>(type: "REAL", nullable: true),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TimeRun = table.Column<TimeSpan>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_СhangeSettingsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BreaksTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SetpointPaperWeight = table.Column<double>(type: "REAL", nullable: false),
                    ActualPaperWeight = table.Column<double>(type: "REAL", nullable: false),
                    SetpointPaperMoisture = table.Column<double>(type: "REAL", nullable: false),
                    ActualPaperMoisture = table.Column<double>(type: "REAL", nullable: false),
                    WireSpeed = table.Column<double>(type: "REAL", nullable: false),
                    ReleerSpeed = table.Column<double>(type: "REAL", nullable: false),
                    StartBreak = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndBreak = table.Column<DateTime>(type: "TEXT", nullable: true),
                    TimeBreak = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreaksTable", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "СhangeSettingsTable");

            migrationBuilder.DropTable(
                name: "BreaksTable");
        }
    }
}
