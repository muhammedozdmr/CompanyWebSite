using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyWebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FooterSeedInTranslationDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Footers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyInfoTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsletterTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsletterPlaceholder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuickLinksTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Footers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Footers");
        }
    }
}
