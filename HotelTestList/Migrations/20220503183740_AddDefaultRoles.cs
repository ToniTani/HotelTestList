using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelTestList.Migrations
{
    public partial class AddDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88eb8e5e-aaa3-4598-9150-3df7aaaae11e", "ba7a73c7-1787-4236-bd57-6517e76bedad", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "294aa013-987d-4034-b9b2-9ea05d2361a3", "a09bb1f1-79ee-4196-9537-ae2e37532eed", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "294aa013-987d-4034-b9b2-9ea05d2361a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88eb8e5e-aaa3-4598-9150-3df7aaaae11e");
        }
    }
}
