using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListWeb.Migrations
{
    public partial class genreassociatewithbook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookGenreId",
                table: "Book",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookGenreId",
                table: "Book",
                column: "BookGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book",
                column: "BookGenreId",
                principalTable: "BookGenre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookGenre_BookGenreId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_BookGenreId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "BookGenreId",
                table: "Book");
        }
    }
}
