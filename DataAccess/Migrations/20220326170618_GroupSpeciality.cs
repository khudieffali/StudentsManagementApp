using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class GroupSpeciality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specialities_StudentGroups_StudentGroupId",
                table: "Specialities");

            migrationBuilder.DropIndex(
                name: "IX_Specialities_StudentGroupId",
                table: "Specialities");

            migrationBuilder.DropColumn(
                name: "StudentGroupId",
                table: "Specialities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "StudentGroups",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "SpecialityId",
                table: "StudentGroups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentGroups_SpecialityId",
                table: "StudentGroups",
                column: "SpecialityId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentGroups_Specialities_SpecialityId",
                table: "StudentGroups",
                column: "SpecialityId",
                principalTable: "Specialities",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentGroups_Specialities_SpecialityId",
                table: "StudentGroups");

            migrationBuilder.DropIndex(
                name: "IX_StudentGroups_SpecialityId",
                table: "StudentGroups");

            migrationBuilder.DropColumn(
                name: "SpecialityId",
                table: "StudentGroups");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "StudentGroups",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGroupId",
                table: "Specialities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Specialities_StudentGroupId",
                table: "Specialities",
                column: "StudentGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specialities_StudentGroups_StudentGroupId",
                table: "Specialities",
                column: "StudentGroupId",
                principalTable: "StudentGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
