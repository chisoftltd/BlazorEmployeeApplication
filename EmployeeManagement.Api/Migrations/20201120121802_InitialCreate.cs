using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" },
                    { 5, "Sales" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "benjamin.uchenna@chisoftmedia.com", "Benjamin", 0, "Uchenna", "images/benjamin.png" },
                    { 2, new DateTime(1984, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "joy.obiageri@chisoftmedia.com", "Joy", 1, "Obiageri", "images/joy.png" },
                    { 3, new DateTime(2002, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "emma.echerem@chisoftmedia.com", "Emmanuel", 0, "Chinaecherem", "images/emma.png" },
                    { 4, new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "shepherd.ebuka@chisoftmedia.com", "Shepherd", 0, "Chukwebuka", "images/shepherd.png" },
                    { 5, new DateTime(2017, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "tobechukwu.mikael@chisoftmedia.com", "Tobechukwu", 0, "Mikael", "images/tobechukwu.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
