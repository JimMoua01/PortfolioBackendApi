using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "portfolio");

            migrationBuilder.CreateTable(
                name: "Contacts",
                schema: "portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Company = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Zip = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "portfolio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "Contacts",
                columns: new[] { "Id", "City", "Comment", "Company", "Email", "FirstName", "LastName", "PhoneNumber", "State", "Zip" },
                values: new object[] { 1, "Wausau", "Hello Jim.", "Test", "hello@gmail.com", "Jim", "Moua", "715-517-3421", "WI", "54401" });

            migrationBuilder.InsertData(
                schema: "portfolio",
                table: "Projects",
                columns: new[] { "Id", "Description", "Image", "Link", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "For my Data Concepts class, I used SQL to create a database around my hobby of Gunpla. Initially, I made a data dictionary and crow’s foot diagram to establish its structure. Then I went into SQL Server to create the database and the entities/tables within, along with adding in the necessary data. This project was a culmination of everything I learned in Data Concepts A-C regarding database design and entity relationships.", "/images/project1_DataConcepts.png", "", "Create Your Own Database", "Data Concepts" },
                    { 2, "For College 101, I created a visual of what I thought were the most important qualities to succeed. During the course, I was to read an online book, with each chapter detailing a specific quality needed to succeed. Out of the total eight, I chose ‘Emotional Intelligence’, ‘Lifelong Learning’, and ‘Greater Personal Responsibility’ as the most vital. These three qualities would be the most important in achieving my personal form of success.", "/images/project2_College101.png", "", "Success PAT", "Other" },
                    { 3, "For my Web Design class, I was to finish this website by handling its interactivity and animation. Using HTML and CSS, I gave each of the headings (DOWNLOAD, SCREENSHOTS, etc.) visual changes and inserted three animals that could move on the screen. This was probably the most difficult assignment for me as I had to use tools like F12 to fix some of the issues with the animals not loading in correctly.", "/images/project3_WebDesign.png", "", "Pixel Arcade", "Web Design" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts",
                schema: "portfolio");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "portfolio");
        }
    }
}
