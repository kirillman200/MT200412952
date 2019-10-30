using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MT200412952.Data.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MidTerm",
                columns: new[] { "Id", "Date", "Message", "Name" },
                values: new object[] { 3, new DateTime(2019, 10, 30, 17, 47, 28, 791, DateTimeKind.Local), "New Message", "Kiril" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MidTerm",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
