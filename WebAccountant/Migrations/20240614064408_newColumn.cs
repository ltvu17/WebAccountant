using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAccountant.Migrations
{
    public partial class newColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "KTSCColumns");

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "UserKTSCColumns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Width",
                table: "UserKTSCColumns");

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "KTSCColumns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
