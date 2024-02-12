using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMS_Phase3__FinalProject01.Migrations
{
    public partial class rendomigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 1,
                column: "DeptName",
                value: "CSE");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 2,
                column: "DeptName",
                value: "MPC");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 3,
                column: "DeptName",
                value: "MECH");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 4,
                column: "DeptName",
                value: "ECE");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 5,
                column: "DeptName",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 101,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(2004, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "RamaaLoadethalra@gmail.com", "Ramana" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 102,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1678, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "vickyjain@outlook.com", "Vikas" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 103,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(2008, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "vikramrathore@yahoo.com", "Vikram Rathore" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 104,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1999, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "loveyou3000@gmail.com", "Pepper pots" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 105,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(2006, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "captainamerica@heroo.com", "chris Hemsworth" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 1,
                column: "DeptName",
                value: "Human Resources");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 2,
                column: "DeptName",
                value: "Finance");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 3,
                column: "DeptName",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 4,
                column: "DeptName",
                value: "Marketing");

            migrationBuilder.UpdateData(
                table: "DeptMaster",
                keyColumn: "DeptCode",
                keyValue: 5,
                column: "DeptName",
                value: "Sales");

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 101,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", "John Doe" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 102,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1990, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "janedoe@example.com", "Jane Doe" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 103,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1988, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "jimbeam@example.com", "Jim Beam" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 104,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1992, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jackdaniels@example.com", "Jack Daniels" });

            migrationBuilder.UpdateData(
                table: "EmpProfile",
                keyColumn: "EmpCode",
                keyValue: 105,
                columns: new[] { "DateOfBirth", "Email", "EmpName" },
                values: new object[] { new DateTime(1986, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "josecuervo@example.com", "Jose Cuervo" });
        }
    }
}
