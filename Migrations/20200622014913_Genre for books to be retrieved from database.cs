using Microsoft.EntityFrameworkCore.Migrations;

namespace BookListWeb.Migrations
{
    public partial class Genreforbookstoberetrievedfromdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "GenreName" },
                values: new object[,]
                {
                    { 100, "Sql Server" },
                    { 3100, "Octopus" },
                    { 3000, "Jira" },
                    { 2900, "React" },
                    { 2800, "Git" },
                    { 2700, "Docker" },
                    { 2600, "Vue" },
                    { 2500, "Angular" },
                    { 2400, "DB2" },
                    { 2300, "Splunk" },
                    { 2200, "Excel" },
                    { 2100, "Cobol" },
                    { 2000, "SAS" },
                    { 1900, "Objective C" },
                    { 1800, "C++" },
                    { 3200, "ECMAScript" },
                    { 1700, "SqlLite" },
                    { 1500, "Design Patterns" },
                    { 1400, "PowerBI" },
                    { 1300, "Pearl" },
                    { 1200, "Javascript" },
                    { 1100, "Networking" },
                    { 1000, "Linux" },
                    { 900, "Oracle" },
                    { 800, "Python" },
                    { 700, "PhP" },
                    { 600, "Java" },
                    { 500, "jQuery" },
                    { 400, "Bootstrap" },
                    { 300, "Salesforce" },
                    { 200, ".NET Core" },
                    { 1600, "VB.Net" },
                    { 3300, "Kubernetes" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGenre");
        }
    }
}
