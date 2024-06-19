using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAccountant.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KTDMColumns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KTDMColumns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserKTDMColumns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    KTDMColumnId = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserKTDMColumns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserKTDMColumns_KTDMColumns_KTDMColumnId",
                        column: x => x.KTDMColumnId,
                        principalTable: "KTDMColumns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserKTDMColumns_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserKTDMColumns_KTDMColumnId",
                table: "UserKTDMColumns",
                column: "KTDMColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_UserKTDMColumns_UserId",
                table: "UserKTDMColumns",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserKTDMColumns");

            migrationBuilder.DropTable(
                name: "KTDMColumns");
        }
    }
}
