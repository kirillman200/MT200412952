using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT200412952.Data.Migrations
{
    public partial class NewMirgation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MidTerm",
                columns: new[] { "Id", "Date", "Message", "Name" },
                values: new object[] { 1, new DateTime(9, 2, 2001, 6, 6, 6, 6, DateTimeKind.Unspecified), "Midterm Test", "Kiril" });

            migrationBuilder.InsertData(
                table: "MidTerm",
                columns: new[] { "Id", "Date", "Message", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Local), "New Message", "Kiril" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MidTerm",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MidTerm",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
