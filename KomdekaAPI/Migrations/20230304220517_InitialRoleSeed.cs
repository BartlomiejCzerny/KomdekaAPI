using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KomdekaAPI.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c6107f3-9393-4ab0-8132-07928772176b", "69a0e5b2-a397-42de-bf32-5e1cbb4f8eb0", "Pracownik", "PRACOWNIK" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "713ce6eb-110e-4411-a54e-eed51a0205d8", "c72d6916-5fde-40e2-9716-05c0084d4495", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c6107f3-9393-4ab0-8132-07928772176b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "713ce6eb-110e-4411-a54e-eed51a0205d8");
        }
    }
}
