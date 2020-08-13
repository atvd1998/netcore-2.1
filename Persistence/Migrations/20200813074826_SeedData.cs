using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Number", "RoomName" },
                values: new object[] { 1, 1, "Room1" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomId", "Number", "RoomName" },
                values: new object[] { 2, 2, "Room2" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthOfDate", "RoomId", "StudentName" },
                values: new object[] { 1, new DateTime(2020, 8, 13, 14, 48, 24, 776, DateTimeKind.Local), 1, "Student1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthOfDate", "RoomId", "StudentName" },
                values: new object[] { 2, new DateTime(1998, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Student2" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "BirthOfDate", "RoomId", "StudentName" },
                values: new object[] { 3, new DateTime(1998, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Student3" });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Rooms_RoomId",
                table: "Students",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
