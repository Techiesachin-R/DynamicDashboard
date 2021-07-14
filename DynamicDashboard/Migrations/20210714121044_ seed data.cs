using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicDashboard.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Element1" },
                    { 2, "Element2" },
                    { 3, "Element3" },
                    { 4, "Element4" },
                    { 5, "Element5" }
                });

            migrationBuilder.InsertData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                columns: new[] { "Id", "ElementsCount", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Template1" },
                    { 2, 2, "Template2" },
                    { 3, 2, "Template3" },
                    { 4, 3, "Template4" },
                    { 5, 3, "Template5" },
                    { 6, 4, "Template6" },
                    { 7, 4, "Template7" },
                    { 8, 5, "Template8" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Elements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Dashboard_Tutorial",
                table: "Templates",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
