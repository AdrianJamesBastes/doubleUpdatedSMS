using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMS.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3603d4de-43c5-49c6-af80-4a76aed6a286", 0, "19119508-1e34-48c6-96fd-106f2ce882d2", null, false, false, null, null, null, "AQAAAAIAAYagAAAAEAwhu3QupsVF2ibRoX/TM1y3Wbvj1CavGVCjQxDOlq+ivdHqMSY40ySDAv4w1rpPKQ==", null, false, "4113daf5-2586-4406-8455-299d883382ff", false, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3603d4de-43c5-49c6-af80-4a76aed6a286");
        }
    }
}
