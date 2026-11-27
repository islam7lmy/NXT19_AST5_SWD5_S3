using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                          create view EmployeeDepartmentView
                          with encryption
                          as
                          	select E.Id 'EmpId', 
                                                               E.Name 'EmpName', 
                                                               D.DeptId 'DepartmentId',                         
                                                               D.DepartmentName 'DepartmentName'
                          	                          	from Employees E
                                                        left outer join DepartmentInfo D
                          	                          	on D.DeptId = E.DepartmentDeptId
                          ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View EmployeeDepartmentView");
        }
    }
}
