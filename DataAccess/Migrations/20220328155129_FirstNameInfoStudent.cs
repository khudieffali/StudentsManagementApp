using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FirstNameInfoStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Firstame",
                table: "InformationStudents",
                newName: "FirstName");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "InformationStudents",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "InformationStudents");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "InformationStudents",
                newName: "Firstame");
        }
    }
}
