using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAccountant.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KTSCColumns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KTSCColumns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserKTSCColumns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    KTSCColumnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserKTSCColumns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserKTSCColumns_KTSCColumns_KTSCColumnId",
                        column: x => x.KTSCColumnId,
                        principalTable: "KTSCColumns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserKTSCColumns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserKTSCColumns_KTSCColumnId",
                table: "UserKTSCColumns",
                column: "KTSCColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_UserKTSCColumns_UserId",
                table: "UserKTSCColumns",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserKTSCColumns");

            migrationBuilder.DropTable(
                name: "KTSCColumns");
        }
    }
}
