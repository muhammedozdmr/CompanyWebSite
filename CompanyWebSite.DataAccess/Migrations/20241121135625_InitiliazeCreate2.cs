using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyWebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitiliazeCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NavbarId = table.Column<int>(type: "int", nullable: true),
                    PageHeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageHeaderSubtitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageMainSlogan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageSubSlogan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NavbarItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Page_NavbarItem_NavbarItemsId",
                        column: x => x.NavbarItemsId,
                        principalTable: "NavbarItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 463,
                column: "Key",
                value: "CompanySlogan");

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 464,
                column: "Key",
                value: "CompanySlogan");

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 465,
                column: "Key",
                value: "CompanySlogan");

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "AboutId", "BlogId", "EntityId", "EntityName", "FAQId", "HistoryId", "Key", "LanguageId", "NavbarItemId", "ServiceId", "Value" },
                values: new object[,]
                {
                    { 478, null, null, 1, "Page", null, null, "PageHeaderTitle", 2, null, null, "About Us" },
                    { 479, null, null, 1, "Page", null, null, "PageHeaderTitle", 3, null, null, "Über uns" },
                    { 480, null, null, 1, "Page", null, null, "PageHeaderTitle", 4, null, null, "О нас" },
                    { 481, null, null, 1, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "Discover our expertise. Explore our success stories." },
                    { 482, null, null, 1, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Entdecken Sie unsere Expertise. Erforschen Sie unsere Erfolgsgeschichten." },
                    { 483, null, null, 1, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Откройте для себя наш опыт. Изучите наши истории успеха." },
                    { 484, null, null, 2, "Page", null, null, "PageHeaderTitle", 2, null, null, "Services" },
                    { 485, null, null, 2, "Page", null, null, "PageHeaderTitle", 3, null, null, "Dienstleistungen" },
                    { 486, null, null, 2, "Page", null, null, "PageHeaderTitle", 4, null, null, "Услуги" },
                    { 487, null, null, 2, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "Creative services to bring your digital vision to life." },
                    { 488, null, null, 2, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Kreative Dienstleistungen, um Ihre digitale Vision zu verwirklichen." },
                    { 489, null, null, 2, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Креативные услуги для воплощения вашей цифровой мечты." },
                    { 490, null, null, 3, "Page", null, null, "PageHeaderTitle", 2, null, null, "Blog" },
                    { 491, null, null, 3, "Page", null, null, "PageHeaderTitle", 3, null, null, "Blog" },
                    { 492, null, null, 3, "Page", null, null, "PageHeaderTitle", 4, null, null, "Блог" },
                    { 493, null, null, 3, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "Inspiring stories and expert insights." },
                    { 494, null, null, 3, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Inspirierende Geschichten und Experteneinblicke." },
                    { 495, null, null, 3, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Вдохновляющие истории и экспертные мнения." },
                    { 496, null, null, 4, "Page", null, null, "PageHeaderTitle", 2, null, null, "Blog" },
                    { 497, null, null, 4, "Page", null, null, "PageHeaderTitle", 3, null, null, "Blog" },
                    { 498, null, null, 4, "Page", null, null, "PageHeaderTitle", 4, null, null, "Блог" },
                    { 499, null, null, 4, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "Discover the details behind the story." },
                    { 500, null, null, 4, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Entdecken Sie die Details hinter der Geschichte." },
                    { 501, null, null, 4, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Узнайте подробности за историей." },
                    { 502, null, null, 5, "Page", null, null, "PageHeaderTitle", 2, null, null, "Contact" },
                    { 503, null, null, 5, "Page", null, null, "PageHeaderTitle", 3, null, null, "Kontakt" },
                    { 504, null, null, 5, "Page", null, null, "PageHeaderTitle", 4, null, null, "Контакт" },
                    { 505, null, null, 5, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "We’re here to answer your questions and support you." },
                    { 506, null, null, 5, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Wir sind hier, um Ihre Fragen zu beantworten und Sie zu unterstützen." },
                    { 507, null, null, 5, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Мы здесь, чтобы ответить на ваши вопросы и поддержать вас." },
                    { 508, null, null, 5, "Page", null, null, "PageMainSlogan", 2, null, null, "Reach out to us. Let’s build the future with digital solutions." },
                    { 509, null, null, 5, "Page", null, null, "PageMainSlogan", 3, null, null, "Kontaktieren Sie uns. Lassen Sie uns die Zukunft mit digitalen Lösungen gestalten." },
                    { 510, null, null, 5, "Page", null, null, "PageMainSlogan", 4, null, null, "Свяжитесь с нами. Давайте строить будущее с цифровыми решениями." },
                    { 511, null, null, 5, "Page", null, null, "PageSubSlogan", 2, null, null, "Every great success starts with a step. Take that step now." },
                    { 512, null, null, 5, "Page", null, null, "PageSubSlogan", 3, null, null, "Jeder große Erfolg beginnt mit einem Schritt. Machen Sie diesen Schritt jetzt." },
                    { 513, null, null, 5, "Page", null, null, "PageSubSlogan", 4, null, null, "Каждый великий успех начинается с шага. Сделайте этот шаг сейчас." },
                    { 514, null, null, 6, "Page", null, null, "PageHeaderTitle", 2, null, null, "FAQ" },
                    { 515, null, null, 6, "Page", null, null, "PageHeaderTitle", 3, null, null, "FAQ" },
                    { 516, null, null, 6, "Page", null, null, "PageHeaderTitle", 4, null, null, "Часто задаваемые вопросы" },
                    { 517, null, null, 6, "Page", null, null, "PageHeaderSubtitle", 2, null, null, "You’re in the right place to find answers to your questions." },
                    { 518, null, null, 6, "Page", null, null, "PageHeaderSubtitle", 3, null, null, "Hier sind Sie richtig, um Antworten auf Ihre Fragen zu finden." },
                    { 519, null, null, 6, "Page", null, null, "PageHeaderSubtitle", 4, null, null, "Вы находитесь в правильном месте, чтобы найти ответы на свои вопросы." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Page_NavbarItemsId",
                table: "Page",
                column: "NavbarItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 463,
                column: "Key",
                value: "CompnaySlogan");

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 464,
                column: "Key",
                value: "CompnaySlogan");

            migrationBuilder.UpdateData(
                table: "Translation",
                keyColumn: "Id",
                keyValue: 465,
                column: "Key",
                value: "CompnaySlogan");
        }
    }
}
