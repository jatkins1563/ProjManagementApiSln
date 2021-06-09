using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjManagementApi.Migrations
{
    public partial class pluralfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Developer_DeveloperId",
                table: "Assignment");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Project_ProjectId",
                table: "Assignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developer",
                table: "Developer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Developer",
                newName: "Developers");

            migrationBuilder.RenameTable(
                name: "Assignment",
                newName: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_ProjectId",
                table: "Assignments",
                newName: "IX_Assignments_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_DeveloperId",
                table: "Assignments",
                newName: "IX_Assignments_DeveloperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Developers_DeveloperId",
                table: "Assignments",
                column: "DeveloperId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Developers_DeveloperId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Developers",
                newName: "Developer");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "Assignment");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignment",
                newName: "IX_Assignment_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_DeveloperId",
                table: "Assignment",
                newName: "IX_Assignment_DeveloperId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developer",
                table: "Developer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Developer_DeveloperId",
                table: "Assignment",
                column: "DeveloperId",
                principalTable: "Developer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Project_ProjectId",
                table: "Assignment",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
