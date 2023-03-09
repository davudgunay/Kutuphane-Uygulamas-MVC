using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMVC.Migrations
{
    public partial class libbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibraryBook",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nchar(13)", maxLength: 13, nullable: false),
                    LibraryId = table.Column<int>(type: "int", nullable: false),
                    Cabinet = table.Column<string>(type: "nchar(5)", maxLength: 5, nullable: false),
                    Shelf = table.Column<string>(type: "nchar(5)", maxLength: 5, nullable: false),
                    Amount = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBook", x => new { x.ISBN, x.LibraryId });
                    table.ForeignKey(
                        name: "FK_LibraryBook_Book_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Book",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryBook_Library_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Library",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBook_LibraryId",
                table: "LibraryBook",
                column: "LibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryBook");
        }
    }
}
