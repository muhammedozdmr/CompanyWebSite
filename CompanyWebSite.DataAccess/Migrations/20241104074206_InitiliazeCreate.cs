using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyWebSite.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitiliazeCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyLogoUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyArea = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Residence = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LinkedIn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAQ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DefaultTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DefaultContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    YearDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DefaultTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DefaultContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgageUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AuthorImageUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AuthorTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DefaultTitle = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DefaultContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blog_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceSummary = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DefaultTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DefaultContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Service_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CompanyInfoId = table.Column<int>(type: "int", nullable: false),
                    DefaultTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DefaultContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.Id);
                    table.ForeignKey(
                        name: "FK_About_CompanyInfo_CompanyInfoId",
                        column: x => x.CompanyInfoId,
                        principalTable: "CompanyInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategoryMapping",
                columns: table => new
                {
                    BlogCategoriesId = table.Column<int>(type: "int", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategoryMapping", x => new { x.BlogCategoriesId, x.BlogId });
                    table.ForeignKey(
                        name: "FK_BlogCategoryMapping_BlogCategory_BlogCategoriesId",
                        column: x => x.BlogCategoriesId,
                        principalTable: "BlogCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategoryMapping_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Highlight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Highlight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Highlight_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MediaType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategoryMapping",
                columns: table => new
                {
                    ServiceCategoryId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategoryMapping", x => new { x.ServiceCategoryId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_ServiceCategoryMapping_ServiceCategory_ServiceCategoryId",
                        column: x => x.ServiceCategoryId,
                        principalTable: "ServiceCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceCategoryMapping_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: true),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: true),
                    FAQId = table.Column<int>(type: "int", nullable: true),
                    HistoryId = table.Column<int>(type: "int", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translation_About_AboutId",
                        column: x => x.AboutId,
                        principalTable: "About",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translation_Blog_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blog",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translation_FAQ_FAQId",
                        column: x => x.FAQId,
                        principalTable: "FAQ",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translation_History_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "History",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translation_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Translation_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Author", "AuthorImageUrl", "AuthorTitle", "CategoryId", "DefaultContent", "DefaultTitle", "ImgageUrl", "IsActive", "PublishDate", "Slug" },
                values: new object[,]
                {
                    { 1, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "Yazılım geliştirme, bir problemin çözümünü sağlayan programları yaratma sürecidir. Teknolojik yenilikler, yazılım geliştirme süreçlerinde köklü değişiklikler yaratmıştır. Günümüzde, yazılım geliştiriciler kullanıcı dostu arayüzler tasarlamak, verimli algoritmalar oluşturmak ve güvenli veri yönetimi sağlamak için çeşitli araçlar kullanmaktadır. Yazılım geliştirme aşamaları, analiz, tasarım, kodlama, test ve bakım süreçlerinden oluşur. Analiz sürecinde, problemin tanımlanması ve çözüm yöntemlerinin belirlenmesi sağlanır. Tasarım aşamasında, kullanıcı ihtiyaçlarına uygun bir yapı oluşturulur. Kodlama ise yazılımın 'görünmeyen' kısmıdır ve mantık burada yazılır. Test süreci, yazılımın doğru çalışıp çalışmadığını kontrol ederken, bakım süreci yazılımın güncellenmesi ve sorunların çözülmesi için gereklidir. Bu süreçlerin her biri, başarılı bir yazılım geliştirme projesinin temel taşlarını oluşturur.", "Yazılım Geliştirmenin Temelleri", "images/blog1.jpg", true, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "foundations-of-software-development" },
                    { 2, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "Mobil uygulama geliştirme süreci, tasarımdan kullanıcı deneyimine kadar birçok aşamadan oluşur. Başarılı bir mobil uygulama geliştirmek için, kullanıcıların ihtiyaçlarını anlamak ve onlara değer katacak çözümler sunmak gereklidir. Kullanıcı deneyimi, uygulamanın başarısında kritik bir rol oynar. Ayrıca, uygulamanın platform bağımsız çalışabilmesi ve yüksek performans göstermesi önemlidir. Mobil uygulama geliştirme araçları sayesinde, geliştiriciler hızlı ve etkili bir şekilde uygulamalar yaratabilmektedir. Örneğin, Flutter, React Native gibi araçlar hem iOS hem de Android için uyumlu uygulamalar geliştirmenizi sağlar. Güvenlik de mobil uygulamalar için önemli bir faktördür. Kullanıcı verilerinin güvenliğini sağlamak için gerekli önlemleri almak, uygulamanın uzun vadeli başarısına katkı sağlar. Tüm bu aşamalar, kaliteli bir mobil uygulamanın temel taşlarını oluşturur.", "Mobil Uygulama Geliştirirken Dikkat Edilmesi Gerekenler", "images/blog2.jpg", true, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "important-tips-for-mobile-app-development" },
                    { 3, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "API entegrasyonu, farklı yazılım sistemlerinin birbirleriyle etkileşime geçmesini sağlar. Bu süreç, veri güvenliğini ve işlevselliği koruyarak veri paylaşımını mümkün kılar. Günümüz teknolojisinde, uygulamalar arası veri alışverişi büyük önem taşır. API'ler sayesinde, bir uygulama başka bir uygulamanın verilerine erişebilir, ancak bu erişimin güvenli olması büyük önem taşır. Özellikle hassas verilerle çalışan uygulamalar, veri güvenliğini sağlamak için gelişmiş şifreleme teknikleri kullanır. Bu süreçte, API anahtarları ve şifreleme algoritmaları kullanılarak veriler güvenli bir şekilde paylaşılır. Ayrıca, API entegrasyonlarının doğru yapılandırılması, performans ve verimlilik açısından kritik bir rol oynar. Yanlış yapılandırmalar veri sızıntılarına ve performans sorunlarına yol açabilir. API entegrasyonları ile veri güvenliği konuları, başarılı bir yazılım geliştirme sürecinin önemli bir parçasını oluşturur.", "API Entegrasyonu ve Veri Güvenliği", "images/blog3.jpg", true, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "api-integration-and-data-security" },
                    { 4, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "ERP sistemleri, işletmelerin operasyonlarını daha verimli bir şekilde yönetmelerine olanak tanır. Bu sistemler, finans, insan kaynakları, tedarik zinciri gibi farklı departmanları tek bir platformda birleştirir. ERP sayesinde, işletmeler verilerini merkezi bir noktadan yönetebilir ve tüm iş süreçlerini optimize edebilir. Ayrıca, ERP sistemleri işletmelere maliyet avantajı sunar ve karar alma süreçlerini hızlandırır. Tüm departmanlar arasında anlık veri paylaşımı sağlanır, bu da işletmenin çevik ve esnek bir yapıya kavuşmasına yardımcı olur. Günümüzde birçok şirket, rekabet avantajı sağlamak için ERP sistemlerini tercih etmektedir. ERP, iş süreçlerini dijitalleştirerek verimliliği artıran önemli bir araçtır.", "ERP Sistemlerinin İşletmelere Sağladığı Avantajlar", "images/blog4.jpg", true, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "benefits-of-erp-systems-for-businesses" },
                    { 5, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "Oyun geliştirme dünyasında kullanılan teknolojiler hızla gelişmekte ve yeni fırsatlar sunmaktadır. Özellikle Unity ve Unreal Engine gibi oyun motorları, geliştiricilere üstün performans ve görsellik sunar. Bununla birlikte, oyunların çapraz platform uyumluluğu da önem kazanmıştır; aynı oyunun birden fazla platformda sorunsuz çalışabilmesi gerekmektedir. Ayrıca, yapay zeka (AI) ve sanal gerçeklik (VR) gibi teknolojiler, oyunlara yenilikçi özellikler katmaktadır. Yapay zeka, oyunlarda dinamik karakter davranışlarını mümkün kılarken, VR oyunculara gerçek bir deneyim sunar. Tüm bu gelişmeler, oyun geliştirme sürecini daha da heyecan verici hale getirmektedir.", "Oyun Geliştirme Sürecinde Öne Çıkan Teknolojiler", "images/blog5.jpg", true, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "leading-technologies-in-game-development" },
                    { 6, "Muhammed Özdemir", "images/author.jpg", "Yazılım Geliştirici", null, "Progressive Web Apps (PWA), kullanıcı deneyimini geliştiren bir web uygulama türüdür. PWA'lar, mobil cihazlarda yerel uygulamalar gibi çalışabilen web uygulamalarıdır. Bu teknoloji, hızlı yükleme süreleri, çevrimdışı erişim ve push bildirim desteği gibi özellikler sunarak kullanıcı deneyimini artırır. Ayrıca, PWA'lar herhangi bir uygulama mağazasına ihtiyaç duymadan cihazlara yüklenebilir. Bu, işletmelere daha düşük maliyetlerle geniş bir kullanıcı kitlesine ulaşma fırsatı sunar. Google, Twitter gibi büyük şirketler de PWA teknolojisini benimseyerek kullanıcı deneyimini geliştirmektedir. PWA'lar, web geliştirme alanında geleceğin trendi olarak görülmektedir.", "Web Geliştirme Trendi: Progressive Web Apps", "images/blog6.jpg", true, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "web-development-trend-progressive-web-apps" }
                });

            migrationBuilder.InsertData(
                table: "BlogCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yazılım" },
                    { 2, "Geliştirme" },
                    { 3, "Mobil Uygulama" },
                    { 4, "API" },
                    { 5, "Veri Güvenliği" },
                    { 6, "ERP" },
                    { 7, "İşletme Yönetimi" },
                    { 8, "Oyun Geliştirme" },
                    { 9, "Teknoloji" },
                    { 10, "Web Geliştirme" },
                    { 11, "PWA" }
                });

            migrationBuilder.InsertData(
                table: "CompanyInfo",
                columns: new[] { "Id", "Address", "CompanyArea", "CompanyLogoUrl", "CompanyName", "CreateDate", "Email", "Facebook", "Instagram", "LinkedIn", "Phone", "Residence", "Twitter" },
                values: new object[] { 1, "Küplüce Mahallesi 5. Zeytinlik Sokak No:13/A", "Sağlık ve Teknoloji Hizmetleri Limited Şirketi", "images/company_logo.jpg", "TechLiberty", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@techliberty.co", "https://facebook.com/techlibertyco", "https://instagram.com/techlibertyco", "https://linkedin.com/company/techlibertyco", "+90 (543) 233 33 32", "İstanbul / Türkiye", "https://twitter.com/techlibertyco" });

            migrationBuilder.InsertData(
                table: "FAQ",
                columns: new[] { "Id", "Answer", "DefaultContent", "DefaultTitle", "IsActive", "Question", "Slug" },
                values: new object[,]
                {
                    { 1, "TechLiberty, yazılım çözümleri sunan ve dijital dönüşüm süreçlerinde işletmelere destek veren bir teknoloji firmasıdır.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "TechLiberty nedir?", "what-is-techliberty" },
                    { 2, "Mobil ve web uygulama geliştirme, oyun geliştirme, API entegrasyonu, CRM ve ERP çözümleri, veri tabanı yönetimi ve sistem analizi hizmetleri sunuyoruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Hangi hizmetleri sunuyorsunuz?", "which-services-do-you-offer" },
                    { 3, "Bize e-posta (info@techliberty.co) veya telefon (+90 (543) 233 33 32) üzerinden ulaşabilirsiniz. Ayrıca sosyal medya hesaplarımız üzerinden de iletişime geçebilirsiniz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Sizinle nasıl iletişime geçebilirim?", "how-can-i-contact-you" },
                    { 4, "Projelerimiz analiz, tasarım, geliştirme, test ve teslim aşamalarından oluşur. Her aşamada müşteriyle yakın iletişim halinde oluruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Bir proje süreci nasıl ilerliyor?", "what-is-the-process-of-a-project" },
                    { 5, "Evet, projelerimiz teslim edildikten sonra bakım ve destek hizmetleri sunmaktayız. Projenizin başarılı bir şekilde devam etmesi için her türlü yardımı sağlıyoruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Proje tesliminden sonra destek sağlıyor musunuz?", "do-you-offer-support-after-delivery" },
                    { 6, "Finans, sağlık, eğitim, perakende, üretim ve lojistik gibi birçok sektöre yönelik yazılım çözümleri sunuyoruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Hangi sektörlere hizmet veriyorsunuz?", "what-industries-do-you-serve" },
                    { 7, "Proje süresi, projenin karmaşıklığına ve gereksinimlerine bağlı olarak değişir. Genellikle bir proje birkaç hafta ila birkaç ay sürebilir.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Bir proje ne kadar sürer?", "how-long-does-a-project-take" },
                    { 8, "Evet, yurt dışındaki birçok müşteriyle projeler gerçekleştirdik ve uluslararası iş süreçlerine aşinayız.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Uluslararası projelerde deneyiminiz var mı?", "do-you-have-international-experience" },
                    { 9, "Proje gereksinimlerine bağlı olarak .NET, Java, Python, React, Angular, Flutter gibi çeşitli yazılım dillerini ve araçlarını kullanıyoruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Hangi teknolojileri kullanıyorsunuz?", "what-technologies-do-you-use" },
                    { 10, "Güvenlik protokolleri ve en iyi uygulamalar ile veri güvenliğini sağlıyoruz. Veri şifreleme, güvenli API ve erişim kontrolleri gibi önlemler alıyoruz.", "Hizmetlerimiz ve şirketimiz hakkında sıkça sorulan soruların yanıtlarını burada bulabilirsiniz.", "Sıkça Sorulan Sorular", true, "Veri güvenliğini nasıl sağlıyorsunuz?", "how-do-you-ensure-data-security" }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "DefaultContent", "DefaultTitle", "IsActive", "Slug", "Year", "YearDescription" },
                values: new object[,]
                {
                    { 1, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, "our-history", 2023, "TechLiberty Software Solutions, 29 Ekim 2023 tarihinde, özel sektördeki ERP çözümlerinin eksikliklerini gidermek amacıyla kuruldu. Kurucumuz, sektördeki firmaların verimliliğini artırmak ve dijital dönüşümlerine katkıda bulunmak için yeni nesil yazılım çözümleri geliştirme hedefiyle yola çıktı." },
                    { 2, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, "expanding-our-vision", 2024, "TechLiberty, kurucusunun sevgili köpeği Gofret’ten ilham alınarak geliştirdiği 'Gof Games' projesini duyurdu. Bu oyun, oyunculara hem eğlenceli hem de duygusal bir deneyim sunmayı hedefliyor. Aynı zamanda, ERP çözümleri alanında sektördeki işletmelere değer katan yazılımlar geliştirme sürecine hız verdik. Mevcut ERP sistemlerindeki eksiklikleri gidermek için daha esnek, kullanımı kolay ve güçlü bir çözüm üzerinde çalışıyoruz." },
                    { 3, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, "ongoing-innovation", 2024, "TechLiberty olarak teknoloji ve inovasyonu işimizin merkezine koyduk. Şirketlerin dijital dönüşümlerine destek olmak, süreçlerini optimize etmek ve onlara değer katmak için sürekli yenilikçi çözümler sunuyoruz. Mevcut projelerimize ek olarak, küçük ve orta ölçekli işletmelere yönelik veri odaklı ERP çözümleri ile sektörün ihtiyaçlarını karşılamaya devam ediyoruz." }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "tr", "Turkish" },
                    { 2, "en", "English" },
                    { 3, "de", "German" },
                    { 4, "ru", "Russian" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "CategoryId", "DefaultContent", "DefaultTitle", "IsActive", "ServiceSummary", "Slug" },
                values: new object[,]
                {
                    { 1, null, "Web geliştirme, işletmelerin dijital varlığını güçlendirmek için stratejik bir süreçtir. İhtiyaçlarınızı ve hedeflerinizi analiz ederek kullanıcı dostu, modern ve ölçeklenebilir web çözümleri sunuyoruz. Tasarım ve kullanıcı deneyiminden performansa kadar tüm aşamalarda yanınızdayız. Kod kalitesi, SEO uyumu ve güvenlik önceliklerimiz arasında yer alır. Profesyonel ekibimiz, işletmenizin çevrimiçi ortamda başarıya ulaşması için en uygun çözümleri sunmaya hazırdır.", "Web Geliştirme", true, "Profesyonel web geliştirme ile modern, kullanıcı dostu ve ölçeklenebilir web siteleri sunuyoruz.", "web-development" },
                    { 2, null, "Mobil cihazlar günümüzde kullanıcı deneyiminin merkezi haline gelmiştir. İOS ve Android platformlarında yüksek performanslı, kullanıcı dostu uygulamalar geliştiriyoruz. Kullanıcı alışkanlıklarını analiz ederek, etkileşimi artıracak ve kullanıcıyı çeken tasarımlar sunuyoruz. Uygulamalarımız, güvenlik ve hız odaklı geliştirilirken, kolay güncellenebilir ve ölçeklenebilir yapısıyla da uzun vadeli bir çözüm sağlar. Dijital dünyada işinizi büyütmeniz için yanınızdayız.", "Mobil Uygulama Geliştirme", true, "iOS ve Android platformlarına uygun, kullanıcı odaklı mobil uygulama geliştirme hizmetleri sağlıyoruz.", "mobile-app-development" },
                    { 3, null, "Oyun geliştirme, hem teknik hem de yaratıcı bir süreçtir. Eğlenceli, etkileyici ve yüksek performanslı oyunlar yaratmak için gelişmiş teknolojilerden yararlanıyoruz. Unity ve Unreal Engine gibi güçlü araçlarla çalışarak, hedef kitlenizin beklentilerini karşılayacak grafik kalitesine ve akıcı oynanışa sahip oyunlar geliştiriyoruz. Oyuncuların ilgisini çeken, duygusal bağ kurabilecekleri ve tekrar oynama isteği uyandıran oyunlar yaratma sürecinde her aşamada yanınızdayız.", "Oyun Geliştirme", true, "İleri teknolojilerle oyun tasarımı yaparak eğlenceli ve etkileşimli oyun deneyimleri sunuyoruz.", "game-development" },
                    { 4, null, "API entegrasyonu, farklı sistemlerin birbiriyle güvenli ve verimli bir şekilde iletişim kurmasını sağlar. İşletmenizdeki veri akışını optimize ederek süreçleri daha etkin hale getirmek için API geliştirme ve entegrasyon hizmetleri sunuyoruz. Kapsamlı güvenlik önlemleri ile hassas verilerinizi koruyarak verimli bir altyapı oluşturuyoruz. Tüm sistemlerinizin uyum içinde çalışmasını sağlayarak iş akışlarınızı hızlandırıyor ve maliyetlerinizi düşürüyoruz.", "API Entegrasyonu", true, "API entegrasyonu ile veri akışını optimize ediyor, sistemler arası bağlantıları güvenli hale getiriyoruz.", "api-integration" },
                    { 5, null, "Müşteri ilişkileri yönetimi, başarılı bir işin temelidir. Müşterilerinizle güçlü ve uzun vadeli ilişkiler kurmanıza yardımcı olan CRM çözümlerimiz, müşteri memnuniyetini artırarak işinizi büyütür. Satış, pazarlama ve müşteri hizmetleri süreçlerinizi optimize eden, tüm müşteri verilerini tek bir platformda toplayan ve analiz eden bir sistem sunuyoruz. İşinizi daha iyi tanımanızı ve hedeflerinize daha hızlı ulaşmanızı sağlamak için buradayız.", "CRM Çözümleri", true, "Müşteri ilişkilerini yönetmek için kapsamlı ve kullanımı kolay CRM çözümleri sunuyoruz.", "crm-solutions" },
                    { 6, null, "İş süreçlerinizi dijitalleştirerek yönetiminizi kolaylaştıran ERP çözümlerimizle işletmenizin verimliliğini artırıyoruz. Finans, insan kaynakları, tedarik zinciri gibi departmanları tek bir sistemde birleştirerek iş süreçlerinizi optimize ediyoruz. ERP çözümlerimiz sayesinde maliyetleri düşürürken, karar alma sürecinizi hızlandırıyor ve departmanlar arasında anlık veri paylaşımını mümkün kılıyoruz. Sürdürülebilir büyüme için ideal bir çözüm sunuyoruz.", "ERP Çözümleri", true, "Verimliliği artıran ve iş süreçlerini optimize eden, esnek ve güçlü ERP çözümleri sunuyoruz.", "erp-solutions" },
                    { 7, null, "Verilerin güvenliği ve erişilebilirliği her işletme için kritik öneme sahiptir. Güçlü, güvenli ve ölçeklenebilir veritabanı çözümlerimizle verilerinizi etkin bir şekilde yönetmenize yardımcı oluyoruz. Veritabanı yapılarınızı optimize ederek performansı artırırken, verilerinizi sürekli erişilebilir ve güvenli tutmak için gelişmiş güvenlik protokollerini kullanıyoruz. İşletmenizin büyümesi ve karar süreçlerini hızlandırması için verilerinizi en iyi şekilde yönetiyoruz.", "Veritabanı Yönetim Sistemleri", true, "Güvenli ve ölçeklenebilir veritabanı çözümlerimizle verilerinizi etkin şekilde yönetmenize yardımcı oluyoruz.", "database-management" },
                    { 8, null, "İşletmenizin ihtiyaçlarına uygun sistemler tasarlamak için kapsamlı bir analiz süreci yürütüyoruz. Mevcut süreçlerinizi değerlendirerek iş akışınızı optimize edecek sistem çözümleri sunuyoruz. İhtiyaçlarınıza göre özel olarak tasarlanmış, kullanımı kolay ve sürdürülebilir sistemler geliştiriyoruz. Sistem tasarımı sırasında performans, güvenlik ve ölçeklenebilirlik gibi unsurları önceliklendirerek, işletmenizin dijital dönüşüm sürecine katkıda bulunuyoruz.", "Sistem Analizi ve Tasarımı", true, "İş süreçlerinize uygun sistem tasarımı yaparak, etkin ve ölçeklenebilir çözümler sunuyoruz.", "system-analysis" },
                    { 9, null, "Projelerinizi başarıyla tamamlamanızı sağlayacak stratejik proje yönetim çözümlerimizle, kaynaklarınızı etkin bir şekilde kullanmanızı sağlıyoruz. Planlama, izleme, kontrol ve kapanış süreçlerinde size destek olarak hedeflerinize ulaşmanıza yardımcı oluyoruz. Ekibinizle yakın çalışarak zamanında ve bütçe dahilinde projeler tamamlamanızı sağlarken, kaliteyi de garanti ediyoruz. Başarılı projeler için tüm adımlarda yanınızdayız.", "Proje Yönetimi", true, "Projelerinizi planlamak, takip etmek ve başarıya ulaştırmak için profesyonel yönetim çözümleri sağlıyoruz.", "project-management" },
                    { 10, null, "Dijital veri depolama ve yönetimi için güvenli ve ölçeklenebilir bulut çözümleri sunuyoruz. Verilerinize her yerden kolayca erişim sağlarken, güvenlik ve maliyet avantajı sunan bulut altyapılarımızla işinizi büyütmenize destek oluyoruz. İş yükünüzü hafifletmek ve esneklik sağlamak için bulut çözümlerimizde en son teknolojileri kullanıyoruz. Bulut altyapımız sayesinde verilerinizi güvenle saklayın ve işletmenizi daha çevik hale getirin.", "Bulut Çözümleri", true, "Güvenilir, esnek ve ölçeklenebilir bulut çözümlerimizle verilerinizi güvenle yönetmenizi sağlıyoruz.", "cloud-solutions" }
                });

            migrationBuilder.InsertData(
                table: "ServiceCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Web Geliştirme" },
                    { 2, "Mobil Geliştirme" },
                    { 3, "Oyun Geliştirme" },
                    { 4, "API Entegrasyonu" },
                    { 5, "CRM Çözümleri" },
                    { 6, "ERP Çözümleri" },
                    { 7, "Veritabanı Yönetimi" },
                    { 8, "Sistem Analizi" },
                    { 9, "Proje Yönetimi" },
                    { 10, "Bulut Çözümleri" }
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "CompanyInfoId", "DefaultContent", "DefaultTitle", "IsActive", "Slug", "Summary" },
                values: new object[] { 1, 1, "TechLiberty Software Solutions olarak, 29 Ekim 2023 tarihinde kurulan şirketimiz, müşterilerine teknolojik çözümler sunma misyonunu benimsemiştir. Dijital çağın gereksinimlerine uygun olarak mobil uygulamalar, web projeleri, oyun geliştirme, proje yönetimi, SEO optimizasyonu, API servisleri, CRM ve ERP hizmetleri, veri tabanı yönetim sistemleri ve sistem analizi gibi geniş bir yelpazede profesyonel çözümler sunmaktayız. Deneyimli ve yenilikçi ekibimizle, işletmelerin dijital dönüşüm yolculuğunda güvenilir bir iş ortağı olarak yer alıyoruz. Amacımız, müşterilerimize sürdürülebilir başarıyı getirecek, verimli ve ölçeklenebilir çözümler sunarak değer katmaktır.", "Hakkımızda", true, "about-us", "TechLiberty Software Solutions, mobil uygulamalar, web projeleri, oyun geliştirme ve kurumsal çözümler sunarak işletmelerin dijital dönüşüm süreçlerinde güvenilir bir iş ortağıdır." });

            migrationBuilder.InsertData(
                table: "BlogCategoryMapping",
                columns: new[] { "BlogCategoriesId", "BlogId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 4 },
                    { 7, 4 },
                    { 8, 5 },
                    { 9, 5 },
                    { 10, 6 },
                    { 11, 6 }
                });

            migrationBuilder.InsertData(
                table: "Highlight",
                columns: new[] { "Id", "Content", "ServiceId" },
                values: new object[,]
                {
                    { 1, "Modern ve kullanıcı dostu web çözümleri", 1 },
                    { 2, "SEO uyumlu web geliştirme", 1 },
                    { 3, "Yüksek performans ve güvenlik odaklı", 1 },
                    { 4, "iOS ve Android platformları için geliştirme", 2 },
                    { 5, "Kullanıcı dostu ve etkileşimli tasarım", 2 },
                    { 6, "Kolay güncellenebilir ve ölçeklenebilir yapı", 2 },
                    { 7, "Eğlenceli ve yüksek performanslı oyunlar", 3 },
                    { 8, "Unity ve Unreal Engine gibi araçlarla geliştirme", 3 },
                    { 9, "Tekrar oynanabilirlik sağlayan oyun tasarımı", 3 },
                    { 10, "Verimli ve güvenli veri akışı sağlama", 4 },
                    { 11, "Farklı sistemler arası uyum", 4 },
                    { 12, "Güvenlik odaklı entegrasyon", 4 },
                    { 13, "Müşteri ilişkilerini güçlendiren çözümler", 5 },
                    { 14, "Satış, pazarlama ve hizmetleri optimize etme", 5 },
                    { 15, "Tüm müşteri verilerinin analiz edilmesi", 5 },
                    { 16, "Departmanlar arası veri entegrasyonu", 6 },
                    { 17, "İş süreçlerini optimize eden yapı", 6 },
                    { 18, "Karar alma süreçlerini hızlandırma", 6 },
                    { 19, "Güçlü ve güvenli veritabanı altyapısı", 7 },
                    { 20, "Yüksek performans için optimize edilmiş", 7 },
                    { 21, "Verilerin sürekli erişilebilirliği", 7 },
                    { 22, "İş süreçlerinize özel tasarım", 8 },
                    { 23, "Kapsamlı analiz ve performans optimizasyonu", 8 },
                    { 24, "Ölçeklenebilir ve güvenilir çözümler", 8 },
                    { 25, "Projeler için stratejik yönetim çözümleri", 9 },
                    { 26, "Zamanında ve bütçe dahilinde teslim", 9 },
                    { 27, "Kaliteyi ön planda tutan yönetim", 9 },
                    { 28, "Güvenli ve esnek bulut altyapısı", 10 },
                    { 29, "Her yerden erişim ve veri güvenliği", 10 },
                    { 30, "İş yükünü hafifletmek için ölçeklenebilir çözümler", 10 }
                });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "FilePath", "MediaType", "ServiceId" },
                values: new object[,]
                {
                    { 1, "images/web-dev-icon.jpg", "icon", 1 },
                    { 2, "images/web-dev-image.jpg", "image", 1 },
                    { 3, "images/mobile-dev-icon.jpg", "icon", 2 },
                    { 4, "images/mobile-dev-image.jpg", "image", 2 },
                    { 5, "images/game-dev-icon.jpg", "icon", 3 },
                    { 6, "images/game-dev-image.jpg", "image", 3 },
                    { 7, "images/api-icon.jpg", "icon", 4 },
                    { 8, "images/api-image.jpg", "image", 4 },
                    { 9, "images/crm-icon.jpg", "icon", 5 },
                    { 10, "images/crm-image.jpg", "image", 5 },
                    { 11, "images/erp-icon.jpg", "icon", 6 },
                    { 12, "images/erp-image.jpg", "image", 6 },
                    { 13, "images/db-icon.jpg", "icon", 7 },
                    { 14, "images/db-image.jpg", "image", 7 },
                    { 15, "images/system-analysis-icon.jpg", "icon", 8 },
                    { 16, "images/system-analysis-image.jpg", "image", 8 },
                    { 17, "images/project-management-icon.jpg", "icon", 9 },
                    { 18, "images/project-management-image.jpg", "image", 9 },
                    { 19, "images/cloud-icon.jpg", "icon", 10 },
                    { 20, "images/cloud-image.jpg", "image", 10 }
                });

            migrationBuilder.InsertData(
                table: "ServiceCategoryMapping",
                columns: new[] { "ServiceCategoryId", "ServiceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 }
                });

            migrationBuilder.InsertData(
                table: "Translation",
                columns: new[] { "Id", "AboutId", "BlogId", "EntityId", "EntityName", "FAQId", "HistoryId", "Key", "LanguageId", "ServiceId", "Value" },
                values: new object[,]
                {
                    { 1, null, null, 1, "About", null, null, "DefaultTitle", 2, null, "About Us" },
                    { 2, null, null, 1, "About", null, null, "DefaultTitle", 3, null, "Über uns" },
                    { 3, null, null, 1, "About", null, null, "DefaultTitle", 4, null, "О нас" },
                    { 4, null, null, 1, "About", null, null, "DefaultContent", 2, null, "As TechLiberty Software Solutions, our company, founded on October 29, 2023, has adopted the mission of providing technological solutions to its clients. In line with the requirements of the digital age, we offer professional solutions in a wide range such as mobile applications, web projects, game development, project management, SEO optimization, API services, CRM and ERP services, database management systems, and system analysis. With our experienced and innovative team, we are a reliable business partner in the digital transformation journey of businesses. Our goal is to add value by providing sustainable success through efficient and scalable solutions to our clients." },
                    { 5, null, null, 1, "About", null, null, "DefaultContent", 3, null, "Als TechLiberty Software Solutions hat unser am 29. Oktober 2023 gegründetes Unternehmen die Mission übernommen, seinen Kunden technologische Lösungen bereitzustellen. Im Einklang mit den Anforderungen des digitalen Zeitalters bieten wir professionelle Lösungen in einer breiten Palette wie mobile Anwendungen, Webprojekte, Spieleentwicklung, Projektmanagement, SEO-Optimierung, API-Dienste, CRM- und ERP-Dienste, Datenbankverwaltungssysteme und Systemanalyse. Mit unserem erfahrenen und innovativen Team sind wir ein zuverlässiger Geschäftspartner auf dem Weg der digitalen Transformation von Unternehmen. Unser Ziel ist es, unseren Kunden durch effiziente und skalierbare Lösungen nachhaltigen Erfolg zu bieten und Mehrwert zu schaffen." },
                    { 6, null, null, 1, "About", null, null, "DefaultContent", 4, null, "Компания TechLiberty Software Solutions, основанная 29 октября 2023 года, взяла на себя миссию по предоставлению технологических решений своим клиентам. В соответствии с требованиями цифровой эпохи мы предлагаем профессиональные решения в широком диапазоне, включая мобильные приложения, веб-проекты, разработку игр, управление проектами, оптимизацию SEO, API-сервисы, услуги CRM и ERP, системы управления базами данных и анализ систем. Наша опытная и новаторская команда является надежным партнером в процессе цифровой трансформации бизнеса. Наша цель - создать ценность, предлагая клиентам устойчивый успех через эффективные и масштабируемые решения." },
                    { 7, null, null, 1, "About", null, null, "Summary", 2, null, "TechLiberty Software Solutions is a reliable business partner in the digital transformation processes of businesses, offering mobile applications, web projects, game development, and corporate solutions." },
                    { 8, null, null, 1, "About", null, null, "Summary", 3, null, "TechLiberty Software Solutions ist ein zuverlässiger Geschäftspartner in den digitalen Transformationsprozessen von Unternehmen und bietet mobile Anwendungen, Webprojekte, Spieleentwicklung und Unternehmenslösungen." },
                    { 9, null, null, 1, "About", null, null, "Summary", 4, null, "TechLiberty Software Solutions - надежный партнер в процессах цифровой трансформации бизнеса, предлагающий мобильные приложения, веб-проекты, разработку игр и корпоративные решения." },
                    { 10, null, null, 1, "Blog", null, null, "DefaultTitle", 2, null, "Fundamentals of Software Development" },
                    { 11, null, null, 1, "Blog", null, null, "DefaultTitle", 3, null, "Grundlagen der Softwareentwicklung" },
                    { 12, null, null, 1, "Blog", null, null, "DefaultTitle", 4, null, "Основы разработки программного обеспечения" },
                    { 13, null, null, 1, "Blog", null, null, "DefaultContent", 2, null, "Software development is the process of creating programs that provide a solution to a problem. Technological advancements have brought significant changes in software development processes..." },
                    { 14, null, null, 1, "Blog", null, null, "DefaultContent", 3, null, "Softwareentwicklung ist der Prozess der Erstellung von Programmen, die eine Lösung für ein Problem bieten. Technologische Fortschritte haben bedeutende Veränderungen in den Softwareentwicklungsprozessen mit sich gebracht..." },
                    { 15, null, null, 1, "Blog", null, null, "DefaultContent", 4, null, "Разработка программного обеспечения - это процесс создания программ, обеспечивающих решение проблемы. Технологические достижения внесли значительные изменения в процессы разработки программного обеспечения..." },
                    { 16, null, null, 2, "Blog", null, null, "DefaultTitle", 2, null, "Important Tips for Mobile App Development" },
                    { 17, null, null, 2, "Blog", null, null, "DefaultTitle", 3, null, "Wichtige Tipps für die Entwicklung mobiler Apps" },
                    { 18, null, null, 2, "Blog", null, null, "DefaultTitle", 4, null, "Важные советы по разработке мобильных приложений" },
                    { 19, null, null, 2, "Blog", null, null, "DefaultContent", 2, null, "The process of developing a mobile application includes various stages from design to user experience. To create a successful mobile app, it is essential to understand user needs and offer solutions..." },
                    { 20, null, null, 2, "Blog", null, null, "DefaultContent", 3, null, "Der Prozess der Entwicklung einer mobilen Anwendung umfasst verschiedene Phasen vom Design bis zur Benutzererfahrung. Um eine erfolgreiche mobile App zu erstellen, ist es wichtig, die Bedürfnisse der Benutzer zu verstehen..." },
                    { 21, null, null, 2, "Blog", null, null, "DefaultContent", 4, null, "Процесс разработки мобильного приложения включает в себя различные этапы, от дизайна до пользовательского опыта. Чтобы создать успешное мобильное приложение, важно понимать потребности пользователей..." },
                    { 22, null, null, 3, "Blog", null, null, "DefaultTitle", 2, null, "API Integration and Data Security" },
                    { 23, null, null, 3, "Blog", null, null, "DefaultTitle", 3, null, "API-Integration und Datensicherheit" },
                    { 24, null, null, 3, "Blog", null, null, "DefaultTitle", 4, null, "Интеграция API и безопасность данных" },
                    { 25, null, null, 3, "Blog", null, null, "DefaultContent", 2, null, "API integration enables different software systems to interact with each other, maintaining data security and functionality during data sharing..." },
                    { 26, null, null, 3, "Blog", null, null, "DefaultContent", 3, null, "Die API-Integration ermöglicht es verschiedenen Softwaresystemen, miteinander zu interagieren, wobei die Datensicherheit und Funktionalität beim Datenaustausch gewährleistet wird..." },
                    { 27, null, null, 3, "Blog", null, null, "DefaultContent", 4, null, "Интеграция API позволяет различным программным системам взаимодействовать друг с другом, поддерживая безопасность данных и функциональность при обмене данными..." },
                    { 28, null, null, 4, "Blog", null, null, "DefaultTitle", 2, null, "Benefits of ERP Systems for Businesses" },
                    { 29, null, null, 4, "Blog", null, null, "DefaultTitle", 3, null, "Vorteile von ERP-Systemen für Unternehmen" },
                    { 30, null, null, 4, "Blog", null, null, "DefaultTitle", 4, null, "Преимущества ERP-систем для бизнеса" },
                    { 31, null, null, 4, "Blog", null, null, "DefaultContent", 2, null, "ERP systems allow businesses to manage their operations more efficiently. These systems integrate various departments such as finance, human resources, and supply chain into one platform..." },
                    { 32, null, null, 4, "Blog", null, null, "DefaultContent", 3, null, "ERP-Systeme ermöglichen es Unternehmen, ihre Abläufe effizienter zu verwalten. Diese Systeme integrieren verschiedene Abteilungen wie Finanzen, Personalwesen und Lieferkette in eine Plattform..." },
                    { 33, null, null, 4, "Blog", null, null, "DefaultContent", 4, null, "ERP-системы позволяют компаниям более эффективно управлять своими операциями. Эти системы интегрируют различные отделы, такие как финансы, кадры и цепочка поставок, в одну платформу..." },
                    { 34, null, null, 5, "Blog", null, null, "DefaultTitle", 2, null, "Leading Technologies in Game Development" },
                    { 35, null, null, 5, "Blog", null, null, "DefaultTitle", 3, null, "Führende Technologien in der Spieleentwicklung" },
                    { 36, null, null, 5, "Blog", null, null, "DefaultTitle", 4, null, "Передовые технологии в разработке игр" },
                    { 37, null, null, 5, "Blog", null, null, "DefaultContent", 2, null, "Technologies used in the game development world are rapidly evolving, presenting new opportunities. Unity and Unreal Engine game engines provide developers with superior performance..." },
                    { 38, null, null, 5, "Blog", null, null, "DefaultContent", 3, null, "Die in der Spieleentwicklungswelt verwendeten Technologien entwickeln sich rasant weiter und bieten neue Möglichkeiten. Unity- und Unreal Engine-Spiel-Engines bieten Entwicklern überlegene Leistung..." },
                    { 39, null, null, 5, "Blog", null, null, "DefaultContent", 4, null, "Технологии, используемые в мире разработки игр, быстро развиваются, представляя новые возможности. Игровые движки Unity и Unreal Engine обеспечивают разработчикам высокую производительность..." },
                    { 40, null, null, 6, "Blog", null, null, "DefaultTitle", 2, null, "Web Development Trend: Progressive Web Apps" },
                    { 41, null, null, 6, "Blog", null, null, "DefaultTitle", 3, null, "Web-Entwicklungstrend: Progressive Web Apps" },
                    { 42, null, null, 6, "Blog", null, null, "DefaultTitle", 4, null, "Тренд веб-разработки: Прогрессивные веб-приложения" },
                    { 43, null, null, 6, "Blog", null, null, "DefaultContent", 2, null, "Progressive Web Apps (PWA) are a type of web application that enhances the user experience. PWAs work like native apps on mobile devices, offering fast loading times, offline access..." },
                    { 44, null, null, 6, "Blog", null, null, "DefaultContent", 3, null, "Progressive Web Apps (PWA) sind eine Art von Webanwendung, die das Benutzererlebnis verbessert. PWAs funktionieren wie native Apps auf mobilen Geräten und bieten schnelle Ladezeiten..." },
                    { 45, null, null, 6, "Blog", null, null, "DefaultContent", 4, null, "Прогрессивные веб-приложения (PWA) - это тип веб-приложений, улучшающих пользовательский опыт. PWA работают как родные приложения на мобильных устройствах, обеспечивая быстрое время загрузки..." },
                    { 46, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 2, null, "Health and Technology Services Limited Company" },
                    { 47, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 3, null, "Gesundheits- und Technologiedienstleistungen GmbH" },
                    { 48, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 4, null, "Компания по предоставлению услуг в области здравоохранения и технологий" },
                    { 49, null, null, 1, "CompanyInfo", null, null, "Residence", 2, null, "Istanbul, Turkey" },
                    { 50, null, null, 1, "CompanyInfo", null, null, "Residence", 3, null, "Istanbul, Türkei" },
                    { 51, null, null, 1, "CompanyInfo", null, null, "Residence", 4, null, "Стамбул, Турция" },
                    { 52, null, null, 1, "CompanyInfo", null, null, "Address", 2, null, "Küplüce Mahallesi 5. Zeytinlik Sokak No:13/A" },
                    { 53, null, null, 1, "CompanyInfo", null, null, "Address", 3, null, "Küplüce Mahallesi 5. Zeytinlik Straße Nr.13/A" },
                    { 54, null, null, 1, "CompanyInfo", null, null, "Address", 4, null, "Кюплюдже Махаллеси 5. Зейтинлик Сокак No:13/A" },
                    { 55, null, null, 1, "FAQ", null, null, "DefaultTitle", 2, null, "Frequently Asked Questions" },
                    { 56, null, null, 1, "FAQ", null, null, "DefaultTitle", 3, null, "Häufig gestellte Fragen" },
                    { 57, null, null, 1, "FAQ", null, null, "DefaultTitle", 4, null, "Часто задаваемые вопросы" },
                    { 58, null, null, 1, "FAQ", null, null, "DefaultContent", 2, null, "Here you can find answers to frequently asked questions about our services and company." },
                    { 59, null, null, 1, "FAQ", null, null, "DefaultContent", 3, null, "Hier finden Sie Antworten auf häufig gestellte Fragen zu unseren Dienstleistungen und unserem Unternehmen." },
                    { 60, null, null, 1, "FAQ", null, null, "DefaultContent", 4, null, "Здесь вы можете найти ответы на часто задаваемые вопросы о наших услугах и компании." },
                    { 61, null, null, 1, "FAQ", null, null, "Question", 2, null, "What is TechLiberty?" },
                    { 62, null, null, 1, "FAQ", null, null, "Question", 3, null, "Was ist TechLiberty?" },
                    { 63, null, null, 1, "FAQ", null, null, "Question", 4, null, "Что такое TechLiberty?" },
                    { 64, null, null, 1, "FAQ", null, null, "Answer", 2, null, "TechLiberty is a technology company providing software solutions and supporting businesses in digital transformation processes." },
                    { 65, null, null, 1, "FAQ", null, null, "Answer", 3, null, "TechLiberty ist ein Technologieunternehmen, das Softwarelösungen anbietet und Unternehmen bei der digitalen Transformation unterstützt." },
                    { 66, null, null, 1, "FAQ", null, null, "Answer", 4, null, "TechLiberty — это технологическая компания, предоставляющая программные решения и поддерживающая компании в процессе цифровой трансформации." },
                    { 67, null, null, 2, "FAQ", null, null, "Question", 2, null, "Which services do you offer?" },
                    { 68, null, null, 2, "FAQ", null, null, "Question", 3, null, "Welche Dienstleistungen bieten Sie an?" },
                    { 69, null, null, 2, "FAQ", null, null, "Question", 4, null, "Какие услуги вы предлагаете?" },
                    { 70, null, null, 2, "FAQ", null, null, "Answer", 2, null, "We offer mobile and web application development, game development, API integration, CRM and ERP solutions, database management, and system analysis services." },
                    { 71, null, null, 2, "FAQ", null, null, "Answer", 3, null, "Wir bieten mobile und Webanwendungsentwicklung, Spieleentwicklung, API-Integration, CRM- und ERP-Lösungen, Datenbankmanagement und Systemanalyse an." },
                    { 72, null, null, 2, "FAQ", null, null, "Answer", 4, null, "Мы предлагаем разработку мобильных и веб-приложений, разработку игр, интеграцию API, решения CRM и ERP, управление базами данных и анализ систем." },
                    { 73, null, null, 3, "FAQ", null, null, "Question", 2, null, "How can I contact you?" },
                    { 74, null, null, 3, "FAQ", null, null, "Question", 3, null, "Wie kann ich Sie kontaktieren?" },
                    { 75, null, null, 3, "FAQ", null, null, "Question", 4, null, "Как я могу с вами связаться?" },
                    { 76, null, null, 3, "FAQ", null, null, "Answer", 2, null, "You can reach us by email (info@techliberty.co) or phone (+90 (543) 233 33 32). You can also contact us through our social media accounts." },
                    { 77, null, null, 3, "FAQ", null, null, "Answer", 3, null, "Sie können uns per E-Mail (info@techliberty.co) oder telefonisch (+90 (543) 233 33 32) erreichen. Sie können uns auch über unsere Social-Media-Konten kontaktieren." },
                    { 78, null, null, 3, "FAQ", null, null, "Answer", 4, null, "Вы можете связаться с нами по электронной почте (info@techliberty.co) или по телефону (+90 (543) 233 33 32). Также вы можете связаться с нами через наши аккаунты в социальных сетях." },
                    { 79, null, null, 4, "FAQ", null, null, "Question", 2, null, "What is the process of a project?" },
                    { 80, null, null, 4, "FAQ", null, null, "Question", 3, null, "Wie verläuft ein Projektprozess?" },
                    { 81, null, null, 4, "FAQ", null, null, "Question", 4, null, "Как происходит процесс проекта?" },
                    { 82, null, null, 4, "FAQ", null, null, "Answer", 2, null, "Our projects consist of analysis, design, development, testing, and delivery stages. We maintain close communication with the client at each stage." },
                    { 83, null, null, 4, "FAQ", null, null, "Answer", 3, null, "Unsere Projekte bestehen aus den Phasen Analyse, Design, Entwicklung, Test und Lieferung. In jeder Phase stehen wir in engem Kontakt mit dem Kunden." },
                    { 84, null, null, 4, "FAQ", null, null, "Answer", 4, null, "Наши проекты состоят из этапов анализа, проектирования, разработки, тестирования и доставки. На каждом этапе мы поддерживаем тесную связь с клиентом." },
                    { 85, null, null, 5, "FAQ", null, null, "Question", 2, null, "Do you offer support after delivery?" },
                    { 86, null, null, 5, "FAQ", null, null, "Question", 3, null, "Bieten Sie nach der Lieferung Unterstützung an?" },
                    { 87, null, null, 5, "FAQ", null, null, "Question", 4, null, "Вы оказываете поддержку после доставки?" },
                    { 88, null, null, 5, "FAQ", null, null, "Answer", 2, null, "Yes, we provide maintenance and support services after project delivery. We offer all the assistance needed to ensure the successful continuation of your project." },
                    { 89, null, null, 5, "FAQ", null, null, "Answer", 3, null, "Ja, wir bieten Wartungs- und Unterstützungsdienste nach der Projektauslieferung an. Wir bieten alle erforderliche Unterstützung, um den erfolgreichen Fortbestand Ihres Projekts zu gewährleisten." },
                    { 90, null, null, 5, "FAQ", null, null, "Answer", 4, null, "Да, мы предоставляем услуги по техническому обслуживанию и поддержке после завершения проекта. Мы предоставляем всю необходимую помощь для успешного продолжения вашего проекта." },
                    { 91, null, null, 6, "FAQ", null, null, "Question", 2, null, "What industries do you serve?" },
                    { 92, null, null, 6, "FAQ", null, null, "Question", 3, null, "Welche Branchen bedienen Sie?" },
                    { 93, null, null, 6, "FAQ", null, null, "Question", 4, null, "Какие отрасли вы обслуживаете?" },
                    { 94, null, null, 6, "FAQ", null, null, "Answer", 2, null, "We offer software solutions for various sectors including finance, healthcare, education, retail, manufacturing, and logistics." },
                    { 95, null, null, 6, "FAQ", null, null, "Answer", 3, null, "Wir bieten Softwarelösungen für verschiedene Branchen, darunter Finanzen, Gesundheitswesen, Bildung, Einzelhandel, Produktion und Logistik." },
                    { 96, null, null, 6, "FAQ", null, null, "Answer", 4, null, "Мы предлагаем программные решения для различных отраслей, включая финансы, здравоохранение, образование, розничную торговлю, производство и логистику." },
                    { 97, null, null, 7, "FAQ", null, null, "Question", 2, null, "How long does a project take?" },
                    { 98, null, null, 7, "FAQ", null, null, "Question", 3, null, "Wie lange dauert ein Projekt?" },
                    { 99, null, null, 7, "FAQ", null, null, "Question", 4, null, "Сколько времени занимает проект?" },
                    { 100, null, null, 7, "FAQ", null, null, "Answer", 2, null, "The project duration varies depending on the complexity and requirements. Generally, a project can take several weeks to several months." },
                    { 101, null, null, 7, "FAQ", null, null, "Answer", 3, null, "Die Projektdauer variiert je nach Komplexität und Anforderungen. In der Regel dauert ein Projekt mehrere Wochen bis mehrere Monate." },
                    { 102, null, null, 7, "FAQ", null, null, "Answer", 4, null, "Продолжительность проекта зависит от сложности и требований. Обычно проект может занять от нескольких недель до нескольких месяцев." },
                    { 103, null, null, 8, "FAQ", null, null, "Question", 2, null, "Do you have international experience?" },
                    { 104, null, null, 8, "FAQ", null, null, "Question", 3, null, "Haben Sie internationale Erfahrung?" },
                    { 105, null, null, 8, "FAQ", null, null, "Question", 4, null, "У вас есть международный опыт?" },
                    { 106, null, null, 8, "FAQ", null, null, "Answer", 2, null, "Yes, we have worked with many clients abroad and are familiar with international business processes." },
                    { 107, null, null, 8, "FAQ", null, null, "Answer", 3, null, "Ja, wir haben mit vielen Kunden im Ausland zusammengearbeitet und sind mit internationalen Geschäftsprozessen vertraut." },
                    { 108, null, null, 8, "FAQ", null, null, "Answer", 4, null, "Да, мы работали со многими клиентами за рубежом и знакомы с международными бизнес-процессами." },
                    { 109, null, null, 9, "FAQ", null, null, "Question", 2, null, "What technologies do you use?" },
                    { 110, null, null, 9, "FAQ", null, null, "Question", 3, null, "Welche Technologien verwenden Sie?" },
                    { 111, null, null, 9, "FAQ", null, null, "Question", 4, null, "Какие технологии вы используете?" },
                    { 112, null, null, 9, "FAQ", null, null, "Answer", 2, null, "Depending on project requirements, we use various programming languages and tools like .NET, Java, Python, React, Angular, and Flutter." },
                    { 113, null, null, 9, "FAQ", null, null, "Answer", 3, null, "Je nach Projektanforderungen verwenden wir verschiedene Programmiersprachen und Tools wie .NET, Java, Python, React, Angular und Flutter." },
                    { 114, null, null, 9, "FAQ", null, null, "Answer", 4, null, "В зависимости от требований проекта мы используем различные языки программирования и инструменты, такие как .NET, Java, Python, React, Angular и Flutter." },
                    { 115, null, null, 10, "FAQ", null, null, "Question", 2, null, "How do you ensure data security?" },
                    { 116, null, null, 10, "FAQ", null, null, "Question", 3, null, "Wie gewährleisten Sie die Datensicherheit?" },
                    { 117, null, null, 10, "FAQ", null, null, "Question", 4, null, "Как вы обеспечиваете безопасность данных?" },
                    { 118, null, null, 10, "FAQ", null, null, "Answer", 2, null, "We ensure data security through security protocols and best practices. We take measures such as data encryption, secure APIs, and access controls." },
                    { 119, null, null, 10, "FAQ", null, null, "Answer", 3, null, "Wir gewährleisten die Datensicherheit durch Sicherheitsprotokolle und bewährte Verfahren. Wir treffen Maßnahmen wie Datenverschlüsselung, sichere APIs und Zugangskontrollen." },
                    { 120, null, null, 10, "FAQ", null, null, "Answer", 4, null, "Мы обеспечиваем безопасность данных с помощью протоколов безопасности и передовых методов. Мы принимаем такие меры, как шифрование данных, безопасные API и контроль доступа." },
                    { 121, null, null, 1, "History", null, null, "DefaultTitle", 2, null, "Our Company History" },
                    { 122, null, null, 1, "History", null, null, "DefaultTitle", 3, null, "Die Geschichte unseres Unternehmens" },
                    { 123, null, null, 1, "History", null, null, "DefaultTitle", 4, null, "История нашей компании" },
                    { 124, null, null, 1, "History", null, null, "DefaultContent", 2, null, "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding." },
                    { 125, null, null, 1, "History", null, null, "DefaultContent", 3, null, "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung." },
                    { 126, null, null, 1, "History", null, null, "DefaultContent", 4, null, "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания." },
                    { 127, null, null, 1, "History", null, null, "YearDescription", 2, null, "TechLiberty Software Solutions was founded on October 29, 2023, with the aim of addressing shortcomings in ERP solutions in the private sector. Our founder set out with the goal of developing next-generation software solutions to increase the efficiency of industry companies and contribute to their digital transformation." },
                    { 128, null, null, 1, "History", null, null, "YearDescription", 3, null, "TechLiberty Software Solutions wurde am 29. Oktober 2023 mit dem Ziel gegründet, die Mängel der ERP-Lösungen im privaten Sektor zu beheben. Unser Gründer verfolgte das Ziel, die Effizienz der Unternehmen in der Branche zu steigern und deren digitale Transformation durch die Entwicklung von Softwarelösungen der nächsten Generation zu unterstützen." },
                    { 129, null, null, 1, "History", null, null, "YearDescription", 4, null, "TechLiberty Software Solutions была основана 29 октября 2023 года с целью устранения недостатков ERP-решений в частном секторе. Наш основатель стремился повысить эффективность компаний отрасли и способствовать их цифровой трансформации, разрабатывая программные решения нового поколения." },
                    { 130, null, null, 2, "History", null, null, "DefaultTitle", 2, null, "Our Company History" },
                    { 131, null, null, 2, "History", null, null, "DefaultTitle", 3, null, "Die Geschichte unseres Unternehmens" },
                    { 132, null, null, 2, "History", null, null, "DefaultTitle", 4, null, "История нашей компании" },
                    { 133, null, null, 2, "History", null, null, "DefaultContent", 2, null, "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding." },
                    { 134, null, null, 2, "History", null, null, "DefaultContent", 3, null, "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung." },
                    { 135, null, null, 2, "History", null, null, "DefaultContent", 4, null, "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания." },
                    { 136, null, null, 2, "History", null, null, "YearDescription", 2, null, "TechLiberty announced the 'Gof Games' project, inspired by the founder's beloved dog, Gofret, aiming to offer both fun and emotional experiences. We also accelerated our work on developing flexible and powerful ERP solutions." },
                    { 137, null, null, 2, "History", null, null, "YearDescription", 3, null, "TechLiberty kündigte das Projekt 'Gof Games' an, inspiriert vom geliebten Hund des Gründers, Gofret, und bot den Spielern sowohl Spaß als auch emotionale Erlebnisse. Wir haben auch unsere Arbeit an der Entwicklung flexibler und leistungsstarker ERP-Lösungen beschleunigt." },
                    { 138, null, null, 2, "History", null, null, "YearDescription", 4, null, "TechLiberty анонсировала проект 'Gof Games', вдохновленный любимой собакой основателя Гофрет, с целью предложить игрокам как веселые, так и эмоциональные переживания. Мы также ускорили работу над созданием гибких и мощных ERP-решений." },
                    { 139, null, null, 3, "History", null, null, "DefaultTitle", 2, null, "Our Company History" },
                    { 140, null, null, 3, "History", null, null, "DefaultTitle", 3, null, "Die Geschichte unseres Unternehmens" },
                    { 141, null, null, 3, "History", null, null, "DefaultTitle", 4, null, "История нашей компании" },
                    { 142, null, null, 3, "History", null, null, "DefaultContent", 2, null, "Here you can find details about the growth of TechLiberty, our vision, and projects since our founding." },
                    { 143, null, null, 3, "History", null, null, "DefaultContent", 3, null, "Hier finden Sie Details über das Wachstum von TechLiberty, unsere Vision und Projekte seit unserer Gründung." },
                    { 144, null, null, 3, "History", null, null, "DefaultContent", 4, null, "Здесь вы найдете подробности о росте TechLiberty, нашем видении и проектах с момента основания." },
                    { 145, null, null, 3, "History", null, null, "YearDescription", 2, null, "At TechLiberty, we focus on placing technology and innovation at the center of our business. We offer innovative solutions to support the digital transformation of companies and optimize their processes." },
                    { 146, null, null, 3, "History", null, null, "YearDescription", 3, null, "Bei TechLiberty legen wir den Schwerpunkt auf Technologie und Innovation im Zentrum unseres Geschäfts. Wir bieten innovative Lösungen zur Unterstützung der digitalen Transformation von Unternehmen und zur Optimierung ihrer Prozesse." },
                    { 147, null, null, 3, "History", null, null, "YearDescription", 4, null, "В компании TechLiberty мы делаем акцент на технологии и инновации в центре нашего бизнеса. Мы предлагаем инновационные решения для поддержки цифровой трансформации компаний и оптимизации их процессов." },
                    { 148, null, null, 1, "Service", null, null, "DefaultTitle", 2, null, "Web Development" },
                    { 149, null, null, 1, "Service", null, null, "DefaultTitle", 3, null, "Webentwicklung" },
                    { 150, null, null, 1, "Service", null, null, "DefaultTitle", 4, null, "Веб-разработка" },
                    { 151, null, null, 1, "Service", null, null, "DefaultContent", 2, null, "We offer professional web development services to help you plan, create, manage, and market your web project." },
                    { 152, null, null, 1, "Service", null, null, "DefaultContent", 3, null, "Wir bieten professionelle Webentwicklungsdienste an, um Ihnen bei der Planung, Erstellung, Verwaltung und Vermarktung Ihres Webprojekts zu helfen." },
                    { 153, null, null, 1, "Service", null, null, "DefaultContent", 4, null, "Мы предлагаем профессиональные услуги веб-разработки, чтобы помочь вам спланировать, создать, управлять и продвигать ваш веб-проект." },
                    { 154, null, null, 1, "Service", null, null, "ServiceSummary", 2, null, "We offer professional web development services for web projects." },
                    { 155, null, null, 1, "Service", null, null, "ServiceSummary", 3, null, "Wir bieten professionelle Webentwicklungsdienste für Webprojekte an." },
                    { 156, null, null, 1, "Service", null, null, "ServiceSummary", 4, null, "Мы предлагаем профессиональные услуги веб-разработки для веб-проектов." },
                    { 157, null, null, 2, "Service", null, null, "DefaultTitle", 2, null, "Mobile App Development" },
                    { 158, null, null, 2, "Service", null, null, "DefaultTitle", 3, null, "Mobile App Entwicklung" },
                    { 159, null, null, 2, "Service", null, null, "DefaultTitle", 4, null, "Разработка мобильных приложений" },
                    { 160, null, null, 2, "Service", null, null, "DefaultContent", 2, null, "We offer comprehensive services to support mobile app development for iOS and Android platforms." },
                    { 161, null, null, 2, "Service", null, null, "DefaultContent", 3, null, "Wir bieten umfassende Dienstleistungen zur Unterstützung der mobilen App-Entwicklung für iOS- und Android-Plattformen an." },
                    { 162, null, null, 2, "Service", null, null, "DefaultContent", 4, null, "Мы предлагаем комплексные услуги по поддержке разработки мобильных приложений для платформ iOS и Android." },
                    { 163, null, null, 2, "Service", null, null, "ServiceSummary", 2, null, "We provide user-friendly mobile app development services." },
                    { 164, null, null, 2, "Service", null, null, "ServiceSummary", 3, null, "Wir bieten benutzerfreundliche mobile App-Entwicklungsdienste an." },
                    { 165, null, null, 2, "Service", null, null, "ServiceSummary", 4, null, "Мы предоставляем удобные услуги по разработке мобильных приложений." },
                    { 166, null, null, 3, "Service", null, null, "DefaultTitle", 2, null, "Game Development" },
                    { 167, null, null, 3, "Service", null, null, "DefaultTitle", 3, null, "Spieleentwicklung" },
                    { 168, null, null, 3, "Service", null, null, "DefaultTitle", 4, null, "Разработка игр" },
                    { 169, null, null, 3, "Service", null, null, "DefaultContent", 2, null, "We provide game development services using advanced technologies to help you create fun and interactive games." },
                    { 170, null, null, 3, "Service", null, null, "DefaultContent", 3, null, "Wir bieten Spieleentwicklungsdienste mit fortschrittlichen Technologien an, um Ihnen bei der Erstellung von lustigen und interaktiven Spielen zu helfen." },
                    { 171, null, null, 3, "Service", null, null, "DefaultContent", 4, null, "Мы предоставляем услуги по разработке игр с использованием передовых технологий, чтобы помочь вам создать веселые и интерактивные игры." },
                    { 172, null, null, 3, "Service", null, null, "ServiceSummary", 2, null, "We offer interactive game development services." },
                    { 173, null, null, 3, "Service", null, null, "ServiceSummary", 3, null, "Wir bieten interaktive Spieleentwicklungsdienste an." },
                    { 174, null, null, 3, "Service", null, null, "ServiceSummary", 4, null, "Мы предлагаем услуги по разработке интерактивных игр." },
                    { 175, null, null, 4, "Service", null, null, "DefaultTitle", 2, null, "API Integration" },
                    { 176, null, null, 4, "Service", null, null, "DefaultTitle", 3, null, "API-Integration" },
                    { 177, null, null, 4, "Service", null, null, "DefaultTitle", 4, null, "Интеграция API" },
                    { 178, null, null, 4, "Service", null, null, "DefaultContent", 2, null, "We provide API development and integration services to optimize data flow between different systems." },
                    { 179, null, null, 4, "Service", null, null, "DefaultContent", 3, null, "Wir bieten API-Entwicklungs- und Integrationsdienste an, um den Datenfluss zwischen verschiedenen Systemen zu optimieren." },
                    { 180, null, null, 4, "Service", null, null, "DefaultContent", 4, null, "Мы предоставляем услуги по разработке и интеграции API для оптимизации потоков данных между различными системами." },
                    { 181, null, null, 4, "Service", null, null, "ServiceSummary", 2, null, "Data flow optimization with API integration services." },
                    { 182, null, null, 4, "Service", null, null, "ServiceSummary", 3, null, "Datenflussoptimierung mit API-Integrationsdiensten." },
                    { 183, null, null, 4, "Service", null, null, "ServiceSummary", 4, null, "Оптимизация потоков данных с помощью услуг по интеграции API." },
                    { 184, null, null, 5, "Service", null, null, "DefaultTitle", 2, null, "CRM Solutions" },
                    { 185, null, null, 5, "Service", null, null, "DefaultTitle", 3, null, "CRM-Lösungen" },
                    { 186, null, null, 5, "Service", null, null, "DefaultTitle", 4, null, "CRM-решения" },
                    { 187, null, null, 5, "Service", null, null, "DefaultContent", 2, null, "We offer comprehensive CRM solutions to improve customer relationships and manage processes." },
                    { 188, null, null, 5, "Service", null, null, "DefaultContent", 3, null, "Wir bieten umfassende CRM-Lösungen zur Verbesserung der Kundenbeziehungen und zur Prozessverwaltung." },
                    { 189, null, null, 5, "Service", null, null, "DefaultContent", 4, null, "Мы предлагаем комплексные CRM-решения для улучшения отношений с клиентами и управления процессами." },
                    { 190, null, null, 5, "Service", null, null, "ServiceSummary", 2, null, "Comprehensive CRM solutions for managing customer relationships." },
                    { 191, null, null, 5, "Service", null, null, "ServiceSummary", 3, null, "Umfassende CRM-Lösungen zur Verwaltung von Kundenbeziehungen." },
                    { 192, null, null, 5, "Service", null, null, "ServiceSummary", 4, null, "Комплексные CRM-решения для управления отношениями с клиентами." },
                    { 193, null, null, 6, "Service", null, null, "DefaultTitle", 2, null, "ERP Solutions" },
                    { 194, null, null, 6, "Service", null, null, "DefaultTitle", 3, null, "ERP-Lösungen" },
                    { 195, null, null, 6, "Service", null, null, "DefaultTitle", 4, null, "ERP-решения" },
                    { 196, null, null, 6, "Service", null, null, "DefaultContent", 2, null, "We offer advanced ERP solutions to manage business processes and increase efficiency." },
                    { 197, null, null, 6, "Service", null, null, "DefaultContent", 3, null, "Wir bieten fortschrittliche ERP-Lösungen zur Verwaltung von Geschäftsprozessen und zur Steigerung der Effizienz." },
                    { 198, null, null, 6, "Service", null, null, "DefaultContent", 4, null, "Мы предлагаем современные ERP-решения для управления бизнес-процессами и повышения эффективности." },
                    { 199, null, null, 6, "Service", null, null, "ServiceSummary", 2, null, "Advanced ERP solutions for managing business processes." },
                    { 200, null, null, 6, "Service", null, null, "ServiceSummary", 3, null, "Fortschrittliche ERP-Lösungen zur Verwaltung von Geschäftsprozessen." },
                    { 201, null, null, 6, "Service", null, null, "ServiceSummary", 4, null, "Современные ERP-решения для управления бизнес-процессами." },
                    { 202, null, null, 7, "Service", null, null, "DefaultTitle", 2, null, "Database Management Systems" },
                    { 203, null, null, 7, "Service", null, null, "DefaultTitle", 3, null, "Datenbankverwaltungssysteme" },
                    { 204, null, null, 7, "Service", null, null, "DefaultTitle", 4, null, "Системы управления базами данных" },
                    { 205, null, null, 7, "Service", null, null, "DefaultContent", 2, null, "Manage your data efficiently with secure and scalable database management systems." },
                    { 206, null, null, 7, "Service", null, null, "DefaultContent", 3, null, "Verwalten Sie Ihre Daten effizient mit sicheren und skalierbaren Datenbankverwaltungssystemen." },
                    { 207, null, null, 7, "Service", null, null, "DefaultContent", 4, null, "Управляйте своими данными эффективно с помощью безопасных и масштабируемых систем управления базами данных." },
                    { 208, null, null, 7, "Service", null, null, "ServiceSummary", 2, null, "Database solutions for effective data management." },
                    { 209, null, null, 7, "Service", null, null, "ServiceSummary", 3, null, "Datenbanklösungen für eine effektive Datenverwaltung." },
                    { 210, null, null, 7, "Service", null, null, "ServiceSummary", 4, null, "Решения для эффективного управления данными." },
                    { 211, null, null, 8, "Service", null, null, "DefaultTitle", 2, null, "System Analysis and Design" },
                    { 212, null, null, 8, "Service", null, null, "DefaultTitle", 3, null, "Systemanalyse und -design" },
                    { 213, null, null, 8, "Service", null, null, "DefaultTitle", 4, null, "Анализ и проектирование систем" },
                    { 214, null, null, 8, "Service", null, null, "DefaultContent", 2, null, "We analyze your business processes and provide system designs tailored to your needs." },
                    { 215, null, null, 8, "Service", null, null, "DefaultContent", 3, null, "Wir analysieren Ihre Geschäftsprozesse und bieten maßgeschneiderte Systemdesigns." },
                    { 216, null, null, 8, "Service", null, null, "DefaultContent", 4, null, "Мы анализируем ваши бизнес-процессы и предоставляем системы, адаптированные к вашим потребностям." },
                    { 217, null, null, 8, "Service", null, null, "ServiceSummary", 2, null, "Customized system analysis and design services." },
                    { 218, null, null, 8, "Service", null, null, "ServiceSummary", 3, null, "Individuelle Systemanalyse- und Design-Dienstleistungen." },
                    { 219, null, null, 8, "Service", null, null, "ServiceSummary", 4, null, "Услуги по анализу и проектированию систем, адаптированные к вашим потребностям." },
                    { 220, null, null, 9, "Service", null, null, "DefaultTitle", 2, null, "Project Management" },
                    { 221, null, null, 9, "Service", null, null, "DefaultTitle", 3, null, "Projektmanagement" },
                    { 222, null, null, 9, "Service", null, null, "DefaultTitle", 4, null, "Управление проектами" },
                    { 223, null, null, 9, "Service", null, null, "DefaultContent", 2, null, "We provide professional project management solutions to help you manage your projects effectively." },
                    { 224, null, null, 9, "Service", null, null, "DefaultContent", 3, null, "Wir bieten professionelle Projektmanagement-Lösungen an, um Ihnen zu helfen, Ihre Projekte effektiv zu verwalten." },
                    { 225, null, null, 9, "Service", null, null, "DefaultContent", 4, null, "Мы предоставляем профессиональные решения для эффективного управления проектами." },
                    { 226, null, null, 9, "Service", null, null, "ServiceSummary", 2, null, "Project management solutions for successful project delivery." },
                    { 227, null, null, 9, "Service", null, null, "ServiceSummary", 3, null, "Projektmanagementlösungen für eine erfolgreiche Projektabwicklung." },
                    { 228, null, null, 9, "Service", null, null, "ServiceSummary", 4, null, "Решения для успешного управления проектами." },
                    { 229, null, null, 10, "Service", null, null, "DefaultTitle", 2, null, "Cloud Solutions" },
                    { 230, null, null, 10, "Service", null, null, "DefaultTitle", 3, null, "Cloud-Lösungen" },
                    { 231, null, null, 10, "Service", null, null, "DefaultTitle", 4, null, "Облачные решения" },
                    { 232, null, null, 10, "Service", null, null, "DefaultContent", 2, null, "We provide scalable and reliable cloud solutions for data storage and management." },
                    { 233, null, null, 10, "Service", null, null, "DefaultContent", 3, null, "Wir bieten skalierbare und zuverlässige Cloud-Lösungen zur Datenspeicherung und -verwaltung." },
                    { 234, null, null, 10, "Service", null, null, "DefaultContent", 4, null, "Мы предоставляем масштабируемые и надежные облачные решения для хранения и управления данными." },
                    { 235, null, null, 10, "Service", null, null, "ServiceSummary", 2, null, "Reliable and scalable cloud solutions for data management." },
                    { 236, null, null, 10, "Service", null, null, "ServiceSummary", 3, null, "Zuverlässige und skalierbare Cloud-Lösungen zur Datenverwaltung." },
                    { 237, null, null, 10, "Service", null, null, "ServiceSummary", 4, null, "Надежные и масштабируемые облачные решения для управления данными." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_About_CompanyInfoId",
                table: "About",
                column: "CompanyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryId",
                table: "Blog",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategoryMapping_BlogId",
                table: "BlogCategoryMapping",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Highlight_ServiceId",
                table: "Highlight",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ServiceId",
                table: "Media",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Service_CategoryId",
                table: "Service",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCategoryMapping_ServiceId",
                table: "ServiceCategoryMapping",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_AboutId",
                table: "Translation",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_BlogId",
                table: "Translation",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_FAQId",
                table: "Translation",
                column: "FAQId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_HistoryId",
                table: "Translation",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_LanguageId",
                table: "Translation",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Translation_ServiceId",
                table: "Translation",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCategoryMapping");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Highlight");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "ServiceCategoryMapping");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "ServiceCategory");

            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "FAQ");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "CompanyInfo");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
