using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class changeGroupTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_StudentGroups_StudentGroupId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_StudentGroupId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "StudentGroupId",
                table: "Teachers");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentGroups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_TeacherId",
                table: "StudentGroups",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Teachers_TeacherId",
                table: "StudentGroups",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Teachers_TeacherId",
                table: "StudentGroups");

            migrationBuilder.DropIndex(
                name: "IX_StudentGroups_TeacherId",
                table: "StudentGroups");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentGroups");

            migrationBuilder.AddColumn<int>(
                name: "StudentGroupId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_StudentGroupId",
                table: "Teachers",
                column: "StudentGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_StudentGroups_StudentGroupId",
                table: "Teachers",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "ID");
        }
    }
}
