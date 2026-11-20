using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RealationShipMappingClassConfiguration01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "DepartmentInfo",
                schema: "dbo",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DepartmentName = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateOnly>(type: "Date", nullable: false, computedColumnSql: "GETDATE()"),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInfo", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentDeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_DepartmentInfo_DepartmentDeptId",
                        column: x => x.DepartmentDeptId,
                        principalSchema: "dbo",
                        principalTable: "DepartmentInfo",
                        principalColumn: "DeptId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentInfo_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentInfo");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "DepartmentInfo",
                schema: "dbo");
        }
    }
}
