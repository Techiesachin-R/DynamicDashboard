using Microsoft.EntityFrameworkCore.Migrations;

namespace DynamicDashboard.Migrations
{
    public partial class addedforigenKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_Info_TemplateId",
                schema: "Dashboard_Tutorial",
                table: "Dashboards_Info",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardLinkedElements_DashboardId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements",
                column: "DashboardId");

            migrationBuilder.CreateIndex(
                name: "IX_DashboardLinkedElements_ElementId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements",
                column: "ElementId");

            migrationBuilder.AddForeignKey(
                name: "FK_DashboardLinkedElements_Dashboards_Info_DashboardId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements",
                column: "DashboardId",
                principalSchema: "Dashboard_Tutorial",
                principalTable: "Dashboards_Info",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DashboardLinkedElements_Elements_ElementId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements",
                column: "ElementId",
                principalSchema: "Dashboard_Tutorial",
                principalTable: "Elements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_Info_Templates_TemplateId",
                schema: "Dashboard_Tutorial",
                table: "Dashboards_Info",
                column: "TemplateId",
                principalSchema: "Dashboard_Tutorial",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DashboardLinkedElements_Dashboards_Info_DashboardId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements");

            migrationBuilder.DropForeignKey(
                name: "FK_DashboardLinkedElements_Elements_ElementId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements");

            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_Info_Templates_TemplateId",
                schema: "Dashboard_Tutorial",
                table: "Dashboards_Info");

            migrationBuilder.DropIndex(
                name: "IX_Dashboards_Info_TemplateId",
                schema: "Dashboard_Tutorial",
                table: "Dashboards_Info");

            migrationBuilder.DropIndex(
                name: "IX_DashboardLinkedElements_DashboardId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements");

            migrationBuilder.DropIndex(
                name: "IX_DashboardLinkedElements_ElementId",
                schema: "Dashboard_Tutorial",
                table: "DashboardLinkedElements");
        }
    }
}
