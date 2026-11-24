using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.MigrationsForInheritanceDbContext
{
    /// <inheritdoc />
    public partial class TPCInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "FullTimeSequence");

            migrationBuilder.CreateSequence(
                name: "PartTimeSequence");

            migrationBuilder.CreateTable(
                name: "FullTimePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [FullTimeSequence]"),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HiringDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimePerson", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartTimePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [PartTimeSequence]"),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoursCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimePerson", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimePerson");

            migrationBuilder.DropTable(
                name: "PartTimePerson");

            migrationBuilder.DropSequence(
                name: "FullTimeSequence");

            migrationBuilder.DropSequence(
                name: "PartTimeSequence");
        }
    }
}
