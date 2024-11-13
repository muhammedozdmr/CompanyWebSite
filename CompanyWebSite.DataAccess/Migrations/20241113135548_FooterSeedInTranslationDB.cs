using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyWebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FooterSeedInTranslationDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Newsletters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "AboutId", "BlogId", "EntityId", "EntityName", "FAQId", "HistoryId", "Key", "LanguageId", "NavbarItemId", "ServiceId", "Value" },
                values: new object[,]
                {
                    { 439, null, null, 1, "Footer", null, null, "CompanyInfoTitle", 2, null, null, "Where Can You Find Us?" },
                    { 440, null, null, 1, "Footer", null, null, "NewsletterTitle", 2, null, null, "Subscribe to Our Newsletter" },
                    { 441, null, null, 1, "Footer", null, null, "NewsletterPlaceholder", 2, null, null, "Enter your email address" },
                    { 442, null, null, 1, "Footer", null, null, "QuickLinksTitle", 2, null, null, "Quick Links" },
                    { 443, null, null, 1, "Footer", null, null, "CompanyInfoTitle", 3, null, null, "Wo Sie uns finden können?" },
                    { 444, null, null, 1, "Footer", null, null, "NewsletterTitle", 3, null, null, "Abonnieren Sie unseren Newsletter" },
                    { 445, null, null, 1, "Footer", null, null, "NewsletterPlaceholder", 3, null, null, "Geben Sie Ihre E-Mail-Adresse ein" },
                    { 446, null, null, 1, "Footer", null, null, "QuickLinksTitle", 3, null, null, "Schnellzugriff" },
                    { 447, null, null, 1, "Footer", null, null, "CompanyInfoTitle", 4, null, null, "Где нас найти?" },
                    { 448, null, null, 1, "Footer", null, null, "NewsletterTitle", 4, null, null, "Подписаться на нашу рассылку" },
                    { 449, null, null, 1, "Footer", null, null, "NewsletterPlaceholder", 4, null, null, "Введите ваш адрес электронной почты" },
                    { 450, null, null, 1, "Footer", null, null, "QuickLinksTitle", 4, null, null, "Быстрые ссылки" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Newsletters");
        }
    }
}
