using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListWeb.Migrations
{
    public partial class BookDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Book",
                type: "varchar(2000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Edition",
                table: "Book",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Book",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageCount",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "Book",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(9, 2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "Book",
                type: "varchar(55)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Book",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Book",
                type: "varchar(200)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Edition",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PageCount",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Book");
        }
    }
}
