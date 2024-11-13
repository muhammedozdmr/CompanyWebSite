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
                    WorkingHours = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "NavbarItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavbarItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscribedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Id);
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
                    ImageUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
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
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    YearDescription = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ProjectUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutId = table.Column<int>(type: "int", nullable: true),
                    DefaultTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DefaultContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_About_AboutId",
                        column: x => x.AboutId,
                        principalTable: "About",
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
                    NavbarItemId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Translation_NavbarItem_NavbarItemId",
                        column: x => x.NavbarItemId,
                        principalTable: "NavbarItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Translation_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "Author", "AuthorImageUrl", "AuthorTitle", "CategoryId", "DefaultContent", "DefaultTitle", "ImageUrl", "IsActive", "PublishDate", "Slug" },
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
                columns: new[] { "Id", "Address", "CompanyArea", "CompanyLogoUrl", "CompanyName", "CreateDate", "Email", "Facebook", "Instagram", "LinkedIn", "Phone", "Residence", "Twitter", "WorkingHours" },
                values: new object[] { 1, "Küplüce Mahallesi 5. Zeytinlik Sokak No:13/A 34676 Üsküdar", "Sağlık ve Teknoloji Hizmetleri Limited Şirketi", "images/company_logo.jpg", "TechLiberty", new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@techliberty.co", "https://facebook.com/techlibertyco", "https://instagram.com/techlibertyco", "https://linkedin.com/company/techlibertyco", "+90 (543) 233 33 32", "İstanbul / Türkiye", "https://twitter.com/techlibertyco", "Pazartesi - Cuma: 09:00 - 18:00" });

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
                table: "NavbarItem",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Ana Sayfa", "home" },
                    { 2, "Hakkımızda", "about" },
                    { 3, "Hizmetler", "services" },
                    { 4, "Blog", "blog" },
                    { 5, "İletişim", "contact" },
                    { 6, "SSS", "faq" }
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
                columns: new[] { "Id", "AboutId", "BlogId", "EntityId", "EntityName", "FAQId", "HistoryId", "Key", "LanguageId", "NavbarItemId", "ServiceId", "Value" },
                values: new object[,]
                {
                    { 1, null, null, 1, "About", null, null, "DefaultTitle", 2, null, null, "About Us" },
                    { 2, null, null, 1, "About", null, null, "DefaultTitle", 3, null, null, "Über uns" },
                    { 3, null, null, 1, "About", null, null, "DefaultTitle", 4, null, null, "О нас" },
                    { 4, null, null, 1, "About", null, null, "DefaultContent", 2, null, null, "As TechLiberty Software Solutions, our company, founded on October 29, 2023, has adopted the mission of providing technological solutions to its clients. In line with the requirements of the digital age, we offer professional solutions in a wide range such as mobile applications, web projects, game development, project management, SEO optimization, API services, CRM and ERP services, database management systems, and system analysis. With our experienced and innovative team, we are a reliable business partner in the digital transformation journey of businesses. Our goal is to add value by providing sustainable success through efficient and scalable solutions to our clients." },
                    { 5, null, null, 1, "About", null, null, "DefaultContent", 3, null, null, "Als TechLiberty Software Solutions hat unser am 29. Oktober 2023 gegründetes Unternehmen die Mission übernommen, seinen Kunden technologische Lösungen bereitzustellen. Im Einklang mit den Anforderungen des digitalen Zeitalters bieten wir professionelle Lösungen in einer breiten Palette wie mobile Anwendungen, Webprojekte, Spieleentwicklung, Projektmanagement, SEO-Optimierung, API-Dienste, CRM- und ERP-Dienste, Datenbankverwaltungssysteme und Systemanalyse. Mit unserem erfahrenen und innovativen Team sind wir ein zuverlässiger Geschäftspartner auf dem Weg der digitalen Transformation von Unternehmen. Unser Ziel ist es, unseren Kunden durch effiziente und skalierbare Lösungen nachhaltigen Erfolg zu bieten und Mehrwert zu schaffen." },
                    { 6, null, null, 1, "About", null, null, "DefaultContent", 4, null, null, "Компания TechLiberty Software Solutions, основанная 29 октября 2023 года, взяла на себя миссию по предоставлению технологических решений своим клиентам. В соответствии с требованиями цифровой эпохи мы предлагаем профессиональные решения в широком диапазоне, включая мобильные приложения, веб-проекты, разработку игр, управление проектами, оптимизацию SEO, API-сервисы, услуги CRM и ERP, системы управления базами данных и анализ систем. Наша опытная и новаторская команда является надежным партнером в процессе цифровой трансформации бизнеса. Наша цель - создать ценность, предлагая клиентам устойчивый успех через эффективные и масштабируемые решения." },
                    { 7, null, null, 1, "About", null, null, "Summary", 2, null, null, "TechLiberty Software Solutions is a reliable business partner in the digital transformation processes of businesses, offering mobile applications, web projects, game development, and corporate solutions." },
                    { 8, null, null, 1, "About", null, null, "Summary", 3, null, null, "TechLiberty Software Solutions ist ein zuverlässiger Geschäftspartner in den digitalen Transformationsprozessen von Unternehmen und bietet mobile Anwendungen, Webprojekte, Spieleentwicklung und Unternehmenslösungen." },
                    { 9, null, null, 1, "About", null, null, "Summary", 4, null, null, "TechLiberty Software Solutions - надежный партнер в процессах цифровой трансформации бизнеса, предлагающий мобильные приложения, веб-проекты, разработку игр и корпоративные решения." },
                    { 10, null, null, 1, "Blog", null, null, "DefaultTitle", 2, null, null, "Fundamentals of Software Development" },
                    { 11, null, null, 1, "Blog", null, null, "DefaultTitle", 3, null, null, "Grundlagen der Softwareentwicklung" },
                    { 12, null, null, 1, "Blog", null, null, "DefaultTitle", 4, null, null, "Основы разработки программного обеспечения" },
                    { 13, null, null, 1, "Blog", null, null, "DefaultContent", 2, null, null, "Software development is the process of creating programs that provide a solution to a problem. Technological advancements have brought significant changes in software development processes, enabling developers to design user-friendly interfaces, build efficient algorithms, and ensure secure data management." },
                    { 14, null, null, 1, "Blog", null, null, "DefaultContent", 3, null, null, "Softwareentwicklung ist der Prozess der Erstellung von Programmen, die eine Lösung für ein Problem bieten. Technologische Fortschritte haben bedeutende Veränderungen in den Softwareentwicklungsprozessen mit sich gebracht, die es Entwicklern ermöglichen, benutzerfreundliche Schnittstellen zu entwerfen, effiziente Algorithmen zu erstellen und eine sichere Datenverwaltung zu gewährleisten." },
                    { 15, null, null, 1, "Blog", null, null, "DefaultContent", 4, null, null, "Разработка программного обеспечения - это процесс создания программ, обеспечивающих решение проблемы. Технологический прогресс внес значительные изменения в процессы разработки ПО, позволяя разработчикам создавать удобные интерфейсы, разрабатывать эффективные алгоритмы и обеспечивать безопасное управление данными." },
                    { 16, null, null, 2, "Blog", null, null, "DefaultTitle", 2, null, null, "Important Tips for Mobile App Development" },
                    { 17, null, null, 2, "Blog", null, null, "DefaultTitle", 3, null, null, "Wichtige Tipps für die Entwicklung mobiler Apps" },
                    { 18, null, null, 2, "Blog", null, null, "DefaultTitle", 4, null, null, "Важные советы по разработке мобильных приложений" },
                    { 19, null, null, 2, "Blog", null, null, "DefaultContent", 2, null, null, "Developing a mobile application involves several stages, from design to user experience. Understanding user needs and delivering value-driven solutions are crucial for creating a successful app. Security and cross-platform compatibility are also vital factors for long-term success." },
                    { 20, null, null, 2, "Blog", null, null, "DefaultContent", 3, null, null, "Die Entwicklung einer mobilen Anwendung umfasst mehrere Phasen, vom Design bis zur Benutzererfahrung. Das Verständnis der Benutzerbedürfnisse und das Anbieten wertschöpfender Lösungen sind entscheidend für die erfolgreiche Entwicklung einer App. Sicherheit und plattformübergreifende Kompatibilität sind ebenfalls wichtige Faktoren für den langfristigen Erfolg." },
                    { 21, null, null, 2, "Blog", null, null, "DefaultContent", 4, null, null, "Разработка мобильного приложения включает в себя несколько этапов, от дизайна до пользовательского опыта. Понимание потребностей пользователей и предоставление решений, ориентированных на ценность, имеют решающее значение для создания успешного приложения. Безопасность и кроссплатформенная совместимость также являются важными факторами для долгосрочного успеха." },
                    { 22, null, null, 3, "Blog", null, null, "DefaultTitle", 2, null, null, "API Integration and Data Security" },
                    { 23, null, null, 3, "Blog", null, null, "DefaultTitle", 3, null, null, "API-Integration und Datensicherheit" },
                    { 24, null, null, 3, "Blog", null, null, "DefaultTitle", 4, null, null, "Интеграция API и безопасность данных" },
                    { 25, null, null, 3, "Blog", null, null, "DefaultContent", 2, null, null, "API integration facilitates data sharing between different systems, ensuring both functionality and data security. Sensitive data must be protected with encryption and secure APIs to prevent data leaks and performance issues." },
                    { 26, null, null, 3, "Blog", null, null, "DefaultContent", 3, null, null, "Die API-Integration ermöglicht den Datenaustausch zwischen verschiedenen Systemen und gewährleistet sowohl Funktionalität als auch Datensicherheit. Sensible Daten müssen mit Verschlüsselung und sicheren APIs geschützt werden, um Datenlecks und Leistungsprobleme zu vermeiden." },
                    { 27, null, null, 3, "Blog", null, null, "DefaultContent", 4, null, null, "Интеграция API облегчает обмен данными между различными системами, обеспечивая как функциональность, так и безопасность данных. Конфиденциальные данные должны защищаться с помощью шифрования и безопасных API, чтобы предотвратить утечки данных и проблемы с производительностью." },
                    { 28, null, null, 4, "Blog", null, null, "DefaultTitle", 2, null, null, "Benefits of ERP Systems for Businesses" },
                    { 29, null, null, 4, "Blog", null, null, "DefaultTitle", 3, null, null, "Vorteile von ERP-Systemen für Unternehmen" },
                    { 30, null, null, 4, "Blog", null, null, "DefaultTitle", 4, null, null, "Преимущества ERP-систем для бизнеса" },
                    { 31, null, null, 4, "Blog", null, null, "DefaultContent", 2, null, null, "ERP systems allow businesses to manage their operations more efficiently. By integrating departments like finance, human resources, and supply chain, businesses can centralize their data management." },
                    { 32, null, null, 4, "Blog", null, null, "DefaultContent", 3, null, null, "ERP-Systeme ermöglichen es Unternehmen, ihre Abläufe effizienter zu verwalten. Durch die Integration von Abteilungen wie Finanzen, Personalwesen und Lieferkette können Unternehmen ihre Datenverwaltung zentralisieren." },
                    { 33, null, null, 4, "Blog", null, null, "DefaultContent", 4, null, null, "ERP-системы позволяют компаниям более эффективно управлять своими операциями. Интеграция таких отделов, как финансы, кадры и цепочка поставок, позволяет компаниям централизовать управление данными." },
                    { 34, null, null, 5, "Blog", null, null, "DefaultTitle", 2, null, null, "Leading Technologies in Game Development" },
                    { 35, null, null, 5, "Blog", null, null, "DefaultTitle", 3, null, null, "Führende Technologien in der Spieleentwicklung" },
                    { 36, null, null, 5, "Blog", null, null, "DefaultTitle", 4, null, null, "Передовые технологии в разработке игр" },
                    { 37, null, null, 5, "Blog", null, null, "DefaultContent", 2, null, null, "Game development technologies are advancing rapidly, providing new opportunities. Engines like Unity and Unreal Engine offer high performance and visuals." },
                    { 38, null, null, 5, "Blog", null, null, "DefaultContent", 3, null, null, "Die Technologien in der Spieleentwicklung schreiten schnell voran und bieten neue Möglichkeiten. Engines wie Unity und Unreal Engine bieten hohe Leistung und visuelle Qualität." },
                    { 39, null, null, 5, "Blog", null, null, "DefaultContent", 4, null, null, "Технологии разработки игр быстро развиваются, предоставляя новые возможности. Движки, такие как Unity и Unreal Engine, предлагают высокую производительность и визуальные эффекты." },
                    { 40, null, null, 6, "Blog", null, null, "DefaultTitle", 2, null, null, "Web Development Trend: Progressive Web Apps" },
                    { 41, null, null, 6, "Blog", null, null, "DefaultTitle", 3, null, null, "Web-Entwicklungstrend: Progressive Web Apps" },
                    { 42, null, null, 6, "Blog", null, null, "DefaultTitle", 4, null, null, "Тренд веб-разработки: Прогрессивные веб-приложения" },
                    { 43, null, null, 6, "Blog", null, null, "DefaultContent", 2, null, null, "Progressive Web Apps (PWA) are web applications that enhance user experience with fast load times, offline access, and push notifications." },
                    { 44, null, null, 6, "Blog", null, null, "DefaultContent", 3, null, null, "Progressive Web Apps (PWA) sind Webanwendungen, die das Benutzererlebnis mit schnellen Ladezeiten, Offline-Zugang und Push-Benachrichtigungen verbessern." },
                    { 45, null, null, 6, "Blog", null, null, "DefaultContent", 4, null, null, "Прогрессивные веб-приложения (PWA) - это веб-приложения, которые улучшают пользовательский опыт благодаря быстрой загрузке, офлайн-доступу и push-уведомлениям." },
                    { 46, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 2, null, null, "Health and Technology Services Limited Company" },
                    { 47, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 3, null, null, "Gesundheits- und Technologiedienstleistungen GmbH" },
                    { 48, null, null, 1, "CompanyInfo", null, null, "CompanyArea", 4, null, null, "Компания по предоставлению услуг в области здравоохранения и технологий" },
                    { 49, null, null, 1, "CompanyInfo", null, null, "Residence", 2, null, null, "Istanbul, Turkey" },
                    { 50, null, null, 1, "CompanyInfo", null, null, "Residence", 3, null, null, "Istanbul, Türkei" },
                    { 51, null, null, 1, "CompanyInfo", null, null, "Residence", 4, null, null, "Стамбул, Турция" },
                    { 52, null, null, 1, "CompanyInfo", null, null, "Address", 2, null, null, "5th Zeytinlik Street No:13/A, 34676 Küplüce Neighborhood, Üsküdar" },
                    { 53, null, null, 1, "CompanyInfo", null, null, "Address", 3, null, null, "5. Zeytinlik Straße Nr.13/A, 34676 Küplüce Viertel, Üsküdar" },
                    { 54, null, null, 1, "CompanyInfo", null, null, "Address", 4, null, null, "Улица 5-я Зейтинлик, дом 13/A, 34676, район Кюплюдже, Ускюдар" },
                    { 55, null, null, 1, "FAQ", null, null, "DefaultTitle", 2, null, null, "Frequently Asked Questions" },
                    { 56, null, null, 1, "FAQ", null, null, "DefaultTitle", 3, null, null, "Häufig gestellte Fragen" },
                    { 57, null, null, 1, "FAQ", null, null, "DefaultTitle", 4, null, null, "Часто задаваемые вопросы" },
                    { 58, null, null, 1, "FAQ", null, null, "DefaultContent", 2, null, null, "Here you can find answers to frequently asked questions about our services and company." },
                    { 59, null, null, 1, "FAQ", null, null, "DefaultContent", 3, null, null, "Hier finden Sie Antworten auf häufig gestellte Fragen zu unseren Dienstleistungen und unserem Unternehmen." },
                    { 60, null, null, 1, "FAQ", null, null, "DefaultContent", 4, null, null, "Здесь вы можете найти ответы на часто задаваемые вопросы о наших услугах и компании." },
                    { 61, null, null, 1, "FAQ", null, null, "Question", 2, null, null, "What is TechLiberty?" },
                    { 62, null, null, 1, "FAQ", null, null, "Question", 3, null, null, "Was ist TechLiberty?" },
                    { 63, null, null, 1, "FAQ", null, null, "Question", 4, null, null, "Что такое TechLiberty?" },
                    { 64, null, null, 1, "FAQ", null, null, "Answer", 2, null, null, "TechLiberty is a technology company providing software solutions and supporting businesses in digital transformation processes." },
                    { 65, null, null, 1, "FAQ", null, null, "Answer", 3, null, null, "TechLiberty ist ein Technologieunternehmen, das Softwarelösungen anbietet und Unternehmen bei der digitalen Transformation unterstützt." },
                    { 66, null, null, 1, "FAQ", null, null, "Answer", 4, null, null, "TechLiberty — это технологическая компания, предоставляющая программные решения и поддерживающая компании в процессе цифровой трансформации." },
                    { 67, null, null, 2, "FAQ", null, null, "Question", 2, null, null, "Which services do you offer?" },
                    { 68, null, null, 2, "FAQ", null, null, "Question", 3, null, null, "Welche Dienstleistungen bieten Sie an?" },
                    { 69, null, null, 2, "FAQ", null, null, "Question", 4, null, null, "Какие услуги вы предлагаете?" },
                    { 70, null, null, 2, "FAQ", null, null, "Answer", 2, null, null, "We offer mobile and web application development, game development, API integration, CRM and ERP solutions, database management, and system analysis services." },
                    { 71, null, null, 2, "FAQ", null, null, "Answer", 3, null, null, "Wir bieten mobile und Webanwendungsentwicklung, Spieleentwicklung, API-Integration, CRM- und ERP-Lösungen, Datenbankmanagement und Systemanalyse an." },
                    { 72, null, null, 2, "FAQ", null, null, "Answer", 4, null, null, "Мы предлагаем разработку мобильных и веб-приложений, разработку игр, интеграцию API, решения CRM и ERP, управление базами данных и анализ систем." },
                    { 73, null, null, 3, "FAQ", null, null, "Question", 2, null, null, "How can I contact you?" },
                    { 74, null, null, 3, "FAQ", null, null, "Question", 3, null, null, "Wie kann ich Sie kontaktieren?" },
                    { 75, null, null, 3, "FAQ", null, null, "Question", 4, null, null, "Как я могу с вами связаться?" },
                    { 76, null, null, 3, "FAQ", null, null, "Answer", 2, null, null, "You can reach us by email (info@techliberty.co) or phone (+90 (543) 233 33 32). You can also c us through our social media accounts." },
                    { 77, null, null, 3, "FAQ", null, null, "Answer", 3, null, null, "Sie können uns per E-Mail (info@techliberty.co) oder telefonisch (+90 (543) 233 33 32) erreichen. Sie können uns auch über unsere Social-Media-Konten kontaktieren." },
                    { 78, null, null, 3, "FAQ", null, null, "Answer", 4, null, null, "Вы можете связаться с нами по электронной почте (info@techliberty.co) или по телефону (+90 (543) 233 33 32). Также вы можете связаться с нами через наши аккаунты в социальных сетях." },
                    { 79, null, null, 4, "FAQ", null, null, "Question", 2, null, null, "What is the process of a project?" },
                    { 80, null, null, 4, "FAQ", null, null, "Question", 3, null, null, "Wie verläuft ein Projektprozess?" },
                    { 81, null, null, 4, "FAQ", null, null, "Question", 4, null, null, "Как происходит процесс проекта?" },
                    { 82, null, null, 4, "FAQ", null, null, "Answer", 2, null, null, "Our projects consist of analysis, design, development, testing, and delivery stages. We maintain close communication with the client at each stage." },
                    { 83, null, null, 4, "FAQ", null, null, "Answer", 3, null, null, "Unsere Projekte bestehen aus den Phasen Analyse, Design, Entwicklung, Test und Lieferung. In jeder Phase stehen wir in engem Kontakt mit dem Kunden." },
                    { 84, null, null, 4, "FAQ", null, null, "Answer", 4, null, null, "Наши проекты состоят из этапов анализа, проектирования, разработки, тестирования и доставки. На каждом этапе мы поддерживаем тесную связь с клиентом." },
                    { 85, null, null, 5, "FAQ", null, null, "Question", 2, null, null, "Do you offer support after delivery?" },
                    { 86, null, null, 5, "FAQ", null, null, "Question", 3, null, null, "Bieten Sie nach der Lieferung Unterstützung an?" },
                    { 87, null, null, 5, "FAQ", null, null, "Question", 4, null, null, "Вы оказываете поддержку после доставки?" },
                    { 88, null, null, 5, "FAQ", null, null, "Answer", 2, null, null, "Yes, we provide maintenance and support services after project delivery. We offer all the assistance needed to ensure the successful continuation of your project." },
                    { 89, null, null, 5, "FAQ", null, null, "Answer", 3, null, null, "Ja, wir bieten Wartungs- und Unterstützungsdienste nach der Projektauslieferung an. Wir bieten alle erforderliche Unterstützung, um den erfolgreichen Fortbestand Ihres Projekts zu gewährleisten." },
                    { 90, null, null, 5, "FAQ", null, null, "Answer", 4, null, null, "Да, мы предоставляем услуги по техническому обслуживанию и поддержке после завершения проекта. Мы предоставляем всю необходимую помощь для успешного продолжения вашего проекта." },
                    { 91, null, null, 6, "FAQ", null, null, "Question", 2, null, null, "What industries do you serve?" },
                    { 92, null, null, 6, "FAQ", null, null, "Question", 3, null, null, "Welche Branchen bedienen Sie?" },
                    { 93, null, null, 6, "FAQ", null, null, "Question", 4, null, null, "Какие отрасли вы обслуживаете?" },
                    { 94, null, null, 6, "FAQ", null, null, "Answer", 2, null, null, "We offer software solutions for various sectors including finance, healthcare, education, retail, manufacturing, and logistics." },
                    { 95, null, null, 6, "FAQ", null, null, "Answer", 3, null, null, "Wir bieten Softwarelösungen für verschiedene Branchen, darunter Finanzen, Gesundheitswesen, Bildung, Einzelhandel, Produktion und Logistik." },
                    { 96, null, null, 6, "FAQ", null, null, "Answer", 4, null, null, "Мы предлагаем программные решения для различных отраслей, включая финансы, здравоохранение, образование, розничную торговлю, производство и логистику." },
                    { 97, null, null, 7, "FAQ", null, null, "Question", 2, null, null, "How long does a project take?" },
                    { 98, null, null, 7, "FAQ", null, null, "Question", 3, null, null, "Wie lange dauert ein Projekt?" },
                    { 99, null, null, 7, "FAQ", null, null, "Question", 4, null, null, "Сколько времени занимает проект?" },
                    { 100, null, null, 7, "FAQ", null, null, "Answer", 2, null, null, "The project duration varies depending on the complexity and requirements. Generally, a project can take several weeks to several months." },
                    { 101, null, null, 7, "FAQ", null, null, "Answer", 3, null, null, "Die Projektdauer variiert je nach Komplexität und Anforderungen. In der Regel dauert ein Projekt mehrere Wochen bis mehrere Monate." },
                    { 102, null, null, 7, "FAQ", null, null, "Answer", 4, null, null, "Продолжительность проекта зависит от сложности и требований. Обычно проект может занять от нескольких недель до нескольких месяцев." },
                    { 103, null, null, 8, "FAQ", null, null, "Question", 2, null, null, "Do you have international experience?" },
                    { 104, null, null, 8, "FAQ", null, null, "Question", 3, null, null, "Haben Sie internationale Erfahrung?" },
                    { 105, null, null, 8, "FAQ", null, null, "Question", 4, null, null, "У вас есть международный опыт?" },
                    { 106, null, null, 8, "FAQ", null, null, "Answer", 2, null, null, "Yes, we have worked with many clients abroad and are familiar with international business processes." },
                    { 107, null, null, 8, "FAQ", null, null, "Answer", 3, null, null, "Ja, wir haben mit vielen Kunden im Ausland zusammengearbeitet und sind mit internationalen Geschäftsprozessen vertraut." },
                    { 108, null, null, 8, "FAQ", null, null, "Answer", 4, null, null, "Да, мы работали со многими клиентами за рубежом и знакомы с международными бизнес-процессами." },
                    { 109, null, null, 9, "FAQ", null, null, "Question", 2, null, null, "What technologies do you use?" },
                    { 110, null, null, 9, "FAQ", null, null, "Question", 3, null, null, "Welche Technologien verwenden Sie?" },
                    { 111, null, null, 9, "FAQ", null, null, "Question", 4, null, null, "Какие технологии вы используете?" },
                    { 112, null, null, 9, "FAQ", null, null, "Answer", 2, null, null, "Depending on project requirements, we use various programming languages and tools like .NET, Java, Python, React, Angular, and Flutter." },
                    { 113, null, null, 9, "FAQ", null, null, "Answer", 3, null, null, "Je nach Projektanforderungen verwenden wir verschiedene Programmiersprachen und Tools wie .NET, Java, Python, React, Angular und Flutter." },
                    { 114, null, null, 9, "FAQ", null, null, "Answer", 4, null, null, "В зависимости от требований проекта мы используем различные языки программирования и инструменты, такие как .NET, Java, Python, React, Angular и Flutter." },
                    { 115, null, null, 10, "FAQ", null, null, "Question", 2, null, null, "How do you ensure data security?" },
                    { 116, null, null, 10, "FAQ", null, null, "Question", 3, null, null, "Wie gewährleisten Sie die Datensicherheit?" },
                    { 117, null, null, 10, "FAQ", null, null, "Question", 4, null, null, "Как вы обеспечиваете безопасность данных?" },
                    { 118, null, null, 10, "FAQ", null, null, "Answer", 2, null, null, "We ensure data security through security protocols and best practices. We take measures such as data encryption, secure APIs, and access controls." },
                    { 119, null, null, 10, "FAQ", null, null, "Answer", 3, null, null, "Wir gewährleisten die Datensicherheit durch Sicherheitsprotokolle und bewährte Verfahren. Wir treffen Maßnahmen wie Datenverschlüsselung, sichere APIs und Zugangskontrollen." },
                    { 120, null, null, 10, "FAQ", null, null, "Answer", 4, null, null, "Мы обеспечиваем безопасность данных с помощью протоколов безопасности и передовых методов. Мы принимаем такие меры, как шифрование данных, безопасные API и контроль доступа." },
                    { 121, null, null, 1, "History", null, null, "DefaultTitle", 2, null, null, "Our Company History" },
                    { 122, null, null, 1, "History", null, null, "DefaultTitle", 3, null, null, "Die Geschichte unseres Unternehmens" },
                    { 123, null, null, 1, "History", null, null, "DefaultTitle", 4, null, null, "История нашей компании" },
                    { 124, null, null, 1, "History", null, null, "DefaultContent", 2, null, null, "Discover TechLiberty's growth, vision, and key projects from our inception to now." },
                    { 125, null, null, 1, "History", null, null, "DefaultContent", 3, null, null, "Entdecken Sie TechLibertys Wachstum, Vision und wichtige Projekte von Anfang an bis heute." },
                    { 126, null, null, 1, "History", null, null, "DefaultContent", 4, null, null, "Узнайте о росте, видении и ключевых проектах компании TechLiberty с момента основания." },
                    { 127, null, null, 1, "History", null, null, "YearDescription", 2, null, null, "TechLiberty Software Solutions was founded on October 29, 2023, to address ERP shortcomings in the private sector, aiming for digital transformation." },
                    { 128, null, null, 1, "History", null, null, "YearDescription", 3, null, null, "TechLiberty Software Solutions wurde am 29. Oktober 2023 gegründet, um ERP-Lücken im privaten Sektor zu schließen und die digitale Transformation zu fördern." },
                    { 129, null, null, 1, "History", null, null, "YearDescription", 4, null, null, "TechLiberty Software Solutions основана 29 октября 2023 года для устранения недостатков ERP в частном секторе, нацеленного на цифровую трансформацию." },
                    { 130, null, null, 2, "History", null, null, "DefaultTitle", 2, null, null, "Expanding Our Vision" },
                    { 131, null, null, 2, "History", null, null, "DefaultTitle", 3, null, null, "Unsere Vision erweitern" },
                    { 132, null, null, 2, "History", null, null, "DefaultTitle", 4, null, null, "Расширение нашего видения" },
                    { 133, null, null, 2, "History", null, null, "DefaultContent", 2, null, null, "Explore the journey of TechLiberty's growth, vision, and achievements since the foundation." },
                    { 134, null, null, 2, "History", null, null, "DefaultContent", 3, null, null, "Erfahren Sie mehr über TechLibertys Wachstum, Vision und Erfolge seit der Gründung." },
                    { 135, null, null, 2, "History", null, null, "DefaultContent", 4, null, null, "Узнайте о пути роста, видении и достижениях TechLiberty с момента основания." },
                    { 136, null, null, 2, "History", null, null, "YearDescription", 2, null, null, "In 2024, 'Gof Games' was launched, inspired by the founder's dog Gofret, aiming for fun and emotion in gaming." },
                    { 137, null, null, 2, "History", null, null, "YearDescription", 3, null, null, "2024 wurde 'Gof Games' inspiriert vom Hund des Gründers Gofret ins Leben gerufen und strebt nach Spaß und Emotion im Gaming." },
                    { 138, null, null, 2, "History", null, null, "YearDescription", 4, null, null, "В 2024 году был запущен 'Gof Games', вдохновленный собакой основателя Гофрет, для веселья и эмоций в играх." },
                    { 139, null, null, 3, "History", null, null, "DefaultTitle", 2, null, null, "Ongoing Innovation" },
                    { 140, null, null, 3, "History", null, null, "DefaultTitle", 3, null, null, "Laufende Innovation" },
                    { 141, null, null, 3, "History", null, null, "DefaultTitle", 4, null, null, "Непрерывные инновации" },
                    { 142, null, null, 3, "History", null, null, "DefaultContent", 2, null, null, "Explore TechLiberty's journey in offering innovative solutions for digital transformation." },
                    { 143, null, null, 3, "History", null, null, "DefaultContent", 3, null, null, "Erkunden Sie TechLibertys Reise bei der Bereitstellung innovativer Lösungen für die digitale Transformation." },
                    { 144, null, null, 3, "History", null, null, "DefaultContent", 4, null, null, "Исследуйте путь TechLiberty в предоставлении инновационных решений для цифровой трансформации." },
                    { 145, null, null, 3, "History", null, null, "YearDescription", 2, null, null, "TechLiberty focuses on innovation and technology at its core, aiming to support companies’ digital transformations." },
                    { 146, null, null, 3, "History", null, null, "YearDescription", 3, null, null, "TechLiberty konzentriert sich auf Innovation und Technologie und unterstützt die digitale Transformation von Unternehmen." },
                    { 147, null, null, 3, "History", null, null, "YearDescription", 4, null, null, "TechLiberty сосредотачивается на инновациях и технологиях, поддерживая цифровую трансформацию компаний." },
                    { 148, null, null, 1, "Service", null, null, "DefaultTitle", 2, null, null, "Web Development" },
                    { 149, null, null, 1, "Service", null, null, "DefaultTitle", 3, null, null, "Webentwicklung" },
                    { 150, null, null, 1, "Service", null, null, "DefaultTitle", 4, null, null, "Веб-разработка" },
                    { 151, null, null, 1, "Service", null, null, "DefaultContent", 2, null, null, "Web development is a strategic process to strengthen your digital presence. We analyze your needs and goals to offer user-friendly, modern, and scalable web solutions. Our professional team supports you at every stage, from design and user experience to performance, prioritizing code quality, SEO compliance, and security to help your business succeed online." },
                    { 152, null, null, 1, "Service", null, null, "DefaultContent", 3, null, null, "Webentwicklung ist ein strategischer Prozess zur Stärkung Ihrer digitalen Präsenz. Wir analysieren Ihre Bedürfnisse und Ziele, um benutzerfreundliche, moderne und skalierbare Weblösungen anzubieten. Unser professionelles Team unterstützt Sie in jeder Phase, von Design und Benutzererfahrung bis zur Leistung, wobei wir Codequalität, SEO-Konformität und Sicherheit priorisieren, um Ihrem Unternehmen online zum Erfolg zu verhelfen." },
                    { 153, null, null, 1, "Service", null, null, "DefaultContent", 4, null, null, "Веб-разработка - это стратегический процесс, направленный на укрепление вашего цифрового присутствия. Мы анализируем ваши потребности и цели, чтобы предложить удобные, современные и масштабируемые веб-решения. Наша профессиональная команда поддерживает вас на каждом этапе, от проектирования и пользовательского опыта до производительности, уделяя первоочередное внимание качеству кода, соответствию SEO и безопасности, чтобы помочь вашему бизнесу добиться успеха в Интернете." },
                    { 154, null, null, 1, "Service", null, null, "ServiceSummary", 2, null, null, "We offer professional web development to deliver modern, user-friendly, and scalable websites." },
                    { 155, null, null, 1, "Service", null, null, "ServiceSummary", 3, null, null, "Wir bieten professionelle Webentwicklung, um moderne, benutzerfreundliche und skalierbare Websites bereitzustellen." },
                    { 156, null, null, 1, "Service", null, null, "ServiceSummary", 4, null, null, "Мы предлагаем профессиональную веб-разработку для создания современных, удобных и масштабируемых веб-сайтов." },
                    { 157, null, null, 2, "Service", null, null, "DefaultTitle", 2, null, null, "Mobile App Development" },
                    { 158, null, null, 2, "Service", null, null, "DefaultTitle", 3, null, null, "Mobile App Entwicklung" },
                    { 159, null, null, 2, "Service", null, null, "DefaultTitle", 4, null, null, "Разработка мобильных приложений" },
                    { 160, null, null, 2, "Service", null, null, "DefaultContent", 2, null, null, "Mobile app development has become central to user experience today. We develop high-performance, user-friendly applications on iOS and Android. By analyzing user habits, we deliver designs that enhance engagement and capture attention. Our applications focus on security, speed, and are built for easy updates and scalability, offering a long-term solution for growth in the digital world." },
                    { 161, null, null, 2, "Service", null, null, "DefaultContent", 3, null, null, "Die Entwicklung mobiler Apps ist heute zentral für das Benutzererlebnis. Wir entwickeln leistungsstarke, benutzerfreundliche Anwendungen für iOS und Android. Durch die Analyse der Benutzergewohnheiten bieten wir Designs, die das Engagement steigern und die Aufmerksamkeit fesseln. Unsere Anwendungen sind sicher, schnell und bieten einfache Updates und Skalierbarkeit als langfristige Lösung für das Wachstum in der digitalen Welt." },
                    { 162, null, null, 2, "Service", null, null, "DefaultContent", 4, null, null, "Разработка мобильных приложений стала центральным элементом пользовательского опыта сегодня. Мы разрабатываем высокопроизводительные, удобные приложения для iOS и Android. Анализируя привычки пользователей, мы создаем дизайны, которые повышают вовлеченность и привлекают внимание. Наши приложения сосредоточены на безопасности, скорости и имеют легкую масштабируемость и обновления, предлагая долгосрочное решение для роста в цифровом мире." },
                    { 163, null, null, 2, "Service", null, null, "ServiceSummary", 2, null, null, "User-centered mobile app development for iOS and Android." },
                    { 164, null, null, 2, "Service", null, null, "ServiceSummary", 3, null, null, "Benutzerzentrierte mobile App-Entwicklung für iOS und Android." },
                    { 165, null, null, 2, "Service", null, null, "ServiceSummary", 4, null, null, "Разработка мобильных приложений для iOS и Android, ориентированная на пользователя." },
                    { 166, null, null, 3, "Service", null, null, "DefaultTitle", 2, null, null, "Game Development" },
                    { 167, null, null, 3, "Service", null, null, "DefaultTitle", 3, null, null, "Spieleentwicklung" },
                    { 168, null, null, 3, "Service", null, null, "DefaultTitle", 4, null, null, "Разработка игр" },
                    { 169, null, null, 3, "Service", null, null, "DefaultContent", 2, null, null, "Game development is both a technical and creative process. We leverage advanced technologies to create fun, immersive, and high-performance games. Working with powerful tools like Unity and Unreal Engine, we develop games that meet your target audience's expectations with quality graphics and smooth gameplay. We focus on creating games that captivate players, foster emotional connections, and encourage repeated play." },
                    { 170, null, null, 3, "Service", null, null, "DefaultContent", 3, null, null, "Die Spieleentwicklung ist sowohl ein technischer als auch ein kreativer Prozess. Wir nutzen fortschrittliche Technologien, um unterhaltsame, immersive und leistungsstarke Spiele zu entwickeln. Mit leistungsstarken Tools wie Unity und Unreal Engine erstellen wir Spiele, die den Erwartungen Ihrer Zielgruppe mit hochwertiger Grafik und reibungslosem Gameplay gerecht werden. Wir konzentrieren uns darauf, Spiele zu entwickeln, die Spieler fesseln, emotionale Verbindungen fördern und zum erneuten Spielen anregen." },
                    { 171, null, null, 3, "Service", null, null, "DefaultContent", 4, null, null, "Разработка игр - это одновременно технический и творческий процесс. Мы используем передовые технологии для создания увлекательных, захватывающих и высокопроизводительных игр. Работая с такими мощными инструментами, как Unity и Unreal Engine, мы разрабатываем игры, которые соответствуют ожиданиям вашей целевой аудитории благодаря качественной графике и плавному игровому процессу. Мы сосредоточены на создании игр, которые привлекают игроков, способствуют эмоциональной связи и побуждают к повторной игре." },
                    { 172, null, null, 3, "Service", null, null, "ServiceSummary", 2, null, null, "Engaging game development using advanced technologies." },
                    { 173, null, null, 3, "Service", null, null, "ServiceSummary", 3, null, null, "Fesselnde Spieleentwicklung mit fortschrittlichen Technologien." },
                    { 174, null, null, 3, "Service", null, null, "ServiceSummary", 4, null, null, "Увлекательная разработка игр с использованием передовых технологий." },
                    { 175, null, null, 4, "Service", null, null, "DefaultTitle", 2, null, null, "API Integration" },
                    { 176, null, null, 4, "Service", null, null, "DefaultTitle", 3, null, null, "API-Integration" },
                    { 177, null, null, 4, "Service", null, null, "DefaultTitle", 4, null, null, "Интеграция API" },
                    { 178, null, null, 4, "Service", null, null, "DefaultContent", 2, null, null, "API integration allows different systems to communicate securely and efficiently. We offer API development and integration services to streamline data flow and enhance process efficiency in your business, prioritizing security for sensitive data and building a stable infrastructure." },
                    { 179, null, null, 4, "Service", null, null, "DefaultContent", 3, null, null, "Die API-Integration ermöglicht es verschiedenen Systemen, sicher und effizient zu kommunizieren. Wir bieten API-Entwicklungs- und Integrationsdienste zur Optimierung des Datenflusses und zur Verbesserung der Prozesseffizienz in Ihrem Unternehmen an, wobei die Sicherheit sensibler Daten und eine stabile Infrastruktur im Vordergrund stehen." },
                    { 180, null, null, 4, "Service", null, null, "DefaultContent", 4, null, null, "Интеграция API позволяет различным системам безопасно и эффективно взаимодействовать. Мы предлагаем услуги по разработке и интеграции API для оптимизации потоков данных и повышения эффективности процессов в вашем бизнесе, уделяя приоритетное внимание безопасности конфиденциальных данных и созданию стабильной инфраструктуры." },
                    { 181, null, null, 4, "Service", null, null, "ServiceSummary", 2, null, null, "API integration for secure and optimized data flow." },
                    { 182, null, null, 4, "Service", null, null, "ServiceSummary", 3, null, null, "API-Integration für sicheren und optimierten Datenfluss." },
                    { 183, null, null, 4, "Service", null, null, "ServiceSummary", 4, null, null, "Интеграция API для безопасного и оптимизированного потока данных." },
                    { 184, null, null, 5, "Service", null, null, "DefaultTitle", 2, null, null, "CRM Solutions" },
                    { 185, null, null, 5, "Service", null, null, "DefaultTitle", 3, null, null, "CRM-Lösungen" },
                    { 186, null, null, 5, "Service", null, null, "DefaultTitle", 4, null, null, "CRM-решения" },
                    { 187, null, null, 5, "Service", null, null, "DefaultContent", 2, null, null, "CRM is essential for building strong, lasting relationships with your customers. Our CRM solutions enhance customer satisfaction and optimize your sales, marketing, and service processes. We offer a system that consolidates all customer data in one platform, helping you to grow your business and reach your goals faster." },
                    { 188, null, null, 5, "Service", null, null, "DefaultContent", 3, null, null, "CRM ist entscheidend für den Aufbau starker, dauerhafter Beziehungen zu Ihren Kunden. Unsere CRM-Lösungen steigern die Kundenzufriedenheit und optimieren Ihre Verkaufs-, Marketing- und Serviceprozesse. Wir bieten ein System, das alle Kundendaten auf einer Plattform konsolidiert und Ihnen hilft, Ihr Geschäft auszubauen und Ihre Ziele schneller zu erreichen." },
                    { 189, null, null, 5, "Service", null, null, "DefaultContent", 4, null, null, "CRM играет ключевую роль в построении прочных и долгосрочных отношений с клиентами. Наши CRM-решения повышают удовлетворенность клиентов и оптимизируют ваши процессы продаж, маркетинга и обслуживания. Мы предлагаем систему, которая объединяет все данные о клиентах на одной платформе, помогая вам развивать бизнес и быстрее достигать целей." },
                    { 190, null, null, 5, "Service", null, null, "ServiceSummary", 2, null, null, "Comprehensive CRM solutions for managing customer relationships." },
                    { 191, null, null, 5, "Service", null, null, "ServiceSummary", 3, null, null, "Umfassende CRM-Lösungen für das Kundenmanagement." },
                    { 192, null, null, 5, "Service", null, null, "ServiceSummary", 4, null, null, "Комплексные CRM-решения для управления отношениями с клиентами." },
                    { 193, null, null, 6, "Service", null, null, "DefaultTitle", 2, null, null, "ERP Solutions" },
                    { 194, null, null, 6, "Service", null, null, "DefaultTitle", 3, null, null, "ERP-Lösungen" },
                    { 195, null, null, 6, "Service", null, null, "DefaultTitle", 4, null, null, "ERP-решения" },
                    { 196, null, null, 6, "Service", null, null, "DefaultContent", 2, null, null, "Our ERP solutions help to digitize and streamline your business processes for greater efficiency. By integrating finance, HR, and supply chain functions in a single system, we enhance your operational workflow, reduce costs, and speed up decision-making. ERP is an ideal solution for sustainable growth." },
                    { 197, null, null, 6, "Service", null, null, "DefaultContent", 3, null, null, "Unsere ERP-Lösungen helfen, Ihre Geschäftsprozesse für mehr Effizienz zu digitalisieren und zu optimieren. Durch die Integration von Finanz-, HR- und Lieferkettenfunktionen in einem einzigen System verbessern wir Ihren operativen Workflow, senken die Kosten und beschleunigen die Entscheidungsfindung. ERP ist eine ideale Lösung für nachhaltiges Wachstum." },
                    { 198, null, null, 6, "Service", null, null, "DefaultContent", 4, null, null, "Наши ERP-решения помогают оцифровать и оптимизировать ваши бизнес-процессы для повышения эффективности. Интегрируя финансы, HR и цепочку поставок в одну систему, мы улучшаем рабочий процесс, сокращаем расходы и ускоряем принятие решений. ERP - это идеальное решение для устойчивого роста." },
                    { 199, null, null, 6, "Service", null, null, "ServiceSummary", 2, null, null, "Efficient ERP solutions for sustainable business growth." },
                    { 200, null, null, 6, "Service", null, null, "ServiceSummary", 3, null, null, "Effiziente ERP-Lösungen für nachhaltiges Unternehmenswachstum." },
                    { 201, null, null, 6, "Service", null, null, "ServiceSummary", 4, null, null, "Эффективные ERP-решения для устойчивого роста бизнеса." },
                    { 202, null, null, 7, "Service", null, null, "DefaultTitle", 2, null, null, "Database Management Systems" },
                    { 203, null, null, 7, "Service", null, null, "DefaultTitle", 3, null, null, "Datenbankverwaltungssysteme" },
                    { 204, null, null, 7, "Service", null, null, "DefaultTitle", 4, null, null, "Системы управления базами данных" },
                    { 205, null, null, 7, "Service", null, null, "DefaultContent", 2, null, null, "Data security and accessibility are critical for every business. Our database management systems help you efficiently manage your data with secure, scalable solutions, ensuring performance optimization and continuous data availability." },
                    { 206, null, null, 7, "Service", null, null, "DefaultContent", 3, null, null, "Datensicherheit und Zugänglichkeit sind für jedes Unternehmen von entscheidender Bedeutung. Unsere Datenbankverwaltungssysteme helfen Ihnen, Ihre Daten effizient mit sicheren, skalierbaren Lösungen zu verwalten, die Leistungsoptimierung und kontinuierliche Datenverfügbarkeit gewährleisten." },
                    { 207, null, null, 7, "Service", null, null, "DefaultContent", 4, null, null, "Безопасность и доступность данных критически важны для любого бизнеса. Наши системы управления базами данных помогают эффективно управлять вашими данными с помощью безопасных, масштабируемых решений, обеспечивая оптимизацию производительности и непрерывную доступность данных." },
                    { 208, null, null, 7, "Service", null, null, "ServiceSummary", 2, null, null, "Secure and scalable database solutions for effective data management." },
                    { 209, null, null, 7, "Service", null, null, "ServiceSummary", 3, null, null, "Sichere und skalierbare Datenbanklösungen für ein effektives Datenmanagement." },
                    { 210, null, null, 7, "Service", null, null, "ServiceSummary", 4, null, null, "Безопасные и масштабируемые решения для эффективного управления данными." },
                    { 211, null, null, 8, "Service", null, null, "DefaultTitle", 2, null, null, "System Analysis and Design" },
                    { 212, null, null, 8, "Service", null, null, "DefaultTitle", 3, null, null, "Systemanalyse und -design" },
                    { 213, null, null, 8, "Service", null, null, "DefaultTitle", 4, null, null, "Анализ и проектирование систем" },
                    { 214, null, null, 8, "Service", null, null, "DefaultContent", 2, null, null, "We conduct a comprehensive analysis to create systems tailored to your business needs. Our solutions prioritize performance, security, and scalability, supporting your digital transformation goals." },
                    { 215, null, null, 8, "Service", null, null, "DefaultContent", 3, null, null, "Wir führen eine umfassende Analyse durch, um Systeme zu erstellen, die auf die Bedürfnisse Ihres Unternehmens zugeschnitten sind. Unsere Lösungen priorisieren Leistung, Sicherheit und Skalierbarkeit und unterstützen Ihre digitalen Transformationsziele." },
                    { 216, null, null, 8, "Service", null, null, "DefaultContent", 4, null, null, "Мы проводим всесторонний анализ для создания систем, адаптированных к потребностям вашего бизнеса. Наши решения уделяют приоритетное внимание производительности, безопасности и масштабируемости, поддерживая цели вашей цифровой трансформации." },
                    { 217, null, null, 8, "Service", null, null, "ServiceSummary", 2, null, null, "Customized system analysis and design for digital transformation." },
                    { 218, null, null, 8, "Service", null, null, "ServiceSummary", 3, null, null, "Individuelle Systemanalyse und -design für die digitale Transformation." },
                    { 219, null, null, 8, "Service", null, null, "ServiceSummary", 4, null, null, "Индивидуальный анализ и проектирование систем для цифровой трансформации." },
                    { 220, null, null, 9, "Service", null, null, "DefaultTitle", 2, null, null, "Project Management" },
                    { 221, null, null, 9, "Service", null, null, "DefaultTitle", 3, null, null, "Projektmanagement" },
                    { 222, null, null, 9, "Service", null, null, "DefaultTitle", 4, null, null, "Управление проектами" },
                    { 223, null, null, 9, "Service", null, null, "DefaultContent", 2, null, null, "Our project management solutions ensure effective use of resources and on-time delivery within budget, focusing on quality at every stage for successful project completion." },
                    { 224, null, null, 9, "Service", null, null, "DefaultContent", 3, null, null, "Unsere Projektmanagementlösungen gewährleisten eine effektive Ressourcennutzung und pünktliche Lieferung innerhalb des Budgets, wobei in jeder Phase auf Qualität geachtet wird, um eine erfolgreiche Projektdurchführung sicherzustellen." },
                    { 225, null, null, 9, "Service", null, null, "DefaultContent", 4, null, null, "Наши решения для управления проектами обеспечивают эффективное использование ресурсов и своевременную доставку в рамках бюджета, уделяя внимание качеству на каждом этапе для успешного завершения проекта." },
                    { 226, null, null, 9, "Service", null, null, "ServiceSummary", 2, null, null, "Strategic project management solutions for quality delivery." },
                    { 227, null, null, 9, "Service", null, null, "ServiceSummary", 3, null, null, "Strategische Projektmanagementlösungen für hochwertige Lieferung." },
                    { 228, null, null, 9, "Service", null, null, "ServiceSummary", 4, null, null, "Стратегические решения для управления проектами с акцентом на качество." },
                    { 229, null, null, 10, "Service", null, null, "DefaultTitle", 2, null, null, "Cloud Solutions" },
                    { 230, null, null, 10, "Service", null, null, "DefaultTitle", 3, null, null, "Cloud-Lösungen" },
                    { 231, null, null, 10, "Service", null, null, "DefaultTitle", 4, null, null, "Облачные решения" },
                    { 232, null, null, 10, "Service", null, null, "DefaultContent", 2, null, null, "We provide secure and scalable cloud solutions for data storage and management, offering flexibility and ease of access from anywhere while ensuring data security." },
                    { 233, null, null, 10, "Service", null, null, "DefaultContent", 3, null, null, "Wir bieten sichere und skalierbare Cloud-Lösungen zur Datenspeicherung und -verwaltung und bieten Flexibilität und einfachen Zugriff von überall, während die Datensicherheit gewährleistet wird." },
                    { 234, null, null, 10, "Service", null, null, "DefaultContent", 4, null, null, "Мы предоставляем безопасные и масштабируемые облачные решения для хранения и управления данными, обеспечивая гибкость и доступ из любого места при сохранении безопасности данных." },
                    { 235, null, null, 10, "Service", null, null, "ServiceSummary", 2, null, null, "Flexible and secure cloud solutions for data management." },
                    { 236, null, null, 10, "Service", null, null, "ServiceSummary", 3, null, null, "Flexible und sichere Cloud-Lösungen für das Datenmanagement." },
                    { 237, null, null, 10, "Service", null, null, "ServiceSummary", 4, null, null, "Гибкие и безопасные облачные решения для управления данными." },
                    { 238, null, null, 1, "ServiceCategory", null, null, "Name", 2, null, null, "Web Development" },
                    { 239, null, null, 1, "ServiceCategory", null, null, "Name", 3, null, null, "Webentwicklung" },
                    { 240, null, null, 1, "ServiceCategory", null, null, "Name", 4, null, null, "Веб-разработка" },
                    { 241, null, null, 2, "ServiceCategory", null, null, "Name", 2, null, null, "Mobile Development" },
                    { 242, null, null, 2, "ServiceCategory", null, null, "Name", 3, null, null, "Mobile Entwicklung" },
                    { 243, null, null, 2, "ServiceCategory", null, null, "Name", 4, null, null, "Разработка мобильных приложений" },
                    { 244, null, null, 3, "ServiceCategory", null, null, "Name", 2, null, null, "Game Development" },
                    { 245, null, null, 3, "ServiceCategory", null, null, "Name", 3, null, null, "Spieleentwicklung" },
                    { 246, null, null, 3, "ServiceCategory", null, null, "Name", 4, null, null, "Разработка игр" },
                    { 247, null, null, 4, "ServiceCategory", null, null, "Name", 2, null, null, "API Integration" },
                    { 248, null, null, 4, "ServiceCategory", null, null, "Name", 3, null, null, "API-Integration" },
                    { 249, null, null, 4, "ServiceCategory", null, null, "Name", 4, null, null, "Интеграция API" },
                    { 250, null, null, 5, "ServiceCategory", null, null, "Name", 2, null, null, "CRM Solutions" },
                    { 251, null, null, 5, "ServiceCategory", null, null, "Name", 3, null, null, "CRM-Lösungen" },
                    { 252, null, null, 5, "ServiceCategory", null, null, "Name", 4, null, null, "CRM-решения" },
                    { 253, null, null, 6, "ServiceCategory", null, null, "Name", 2, null, null, "ERP Solutions" },
                    { 254, null, null, 6, "ServiceCategory", null, null, "Name", 3, null, null, "ERP-Lösungen" },
                    { 255, null, null, 6, "ServiceCategory", null, null, "Name", 4, null, null, "ERP-решения" },
                    { 256, null, null, 7, "ServiceCategory", null, null, "Name", 2, null, null, "Database Management" },
                    { 257, null, null, 7, "ServiceCategory", null, null, "Name", 3, null, null, "Datenbankverwaltung" },
                    { 258, null, null, 7, "ServiceCategory", null, null, "Name", 4, null, null, "Управление базами данных" },
                    { 259, null, null, 8, "ServiceCategory", null, null, "Name", 2, null, null, "System Analysis" },
                    { 260, null, null, 8, "ServiceCategory", null, null, "Name", 3, null, null, "Systemanalyse" },
                    { 261, null, null, 8, "ServiceCategory", null, null, "Name", 4, null, null, "Анализ систем" },
                    { 262, null, null, 9, "ServiceCategory", null, null, "Name", 2, null, null, "Project Management" },
                    { 263, null, null, 9, "ServiceCategory", null, null, "Name", 3, null, null, "Projektmanagement" },
                    { 264, null, null, 9, "ServiceCategory", null, null, "Name", 4, null, null, "Управление проектами" },
                    { 265, null, null, 10, "ServiceCategory", null, null, "Name", 2, null, null, "Cloud Solutions" },
                    { 266, null, null, 10, "ServiceCategory", null, null, "Name", 3, null, null, "Cloud-Lösungen" },
                    { 267, null, null, 10, "ServiceCategory", null, null, "Name", 4, null, null, "Облачные решения" },
                    { 268, null, null, 1, "BlogCategory", null, null, "Name", 2, null, null, "Software" },
                    { 269, null, null, 1, "BlogCategory", null, null, "Name", 3, null, null, "Software" },
                    { 270, null, null, 1, "BlogCategory", null, null, "Name", 4, null, null, "Программное обеспечение" },
                    { 271, null, null, 2, "BlogCategory", null, null, "Name", 2, null, null, "Development" },
                    { 272, null, null, 2, "BlogCategory", null, null, "Name", 3, null, null, "Entwicklung" },
                    { 273, null, null, 2, "BlogCategory", null, null, "Name", 4, null, null, "Разработка" },
                    { 274, null, null, 3, "BlogCategory", null, null, "Name", 2, null, null, "Mobile Application" },
                    { 275, null, null, 3, "BlogCategory", null, null, "Name", 3, null, null, "Mobile Anwendung" },
                    { 276, null, null, 3, "BlogCategory", null, null, "Name", 4, null, null, "Мобильное приложение" },
                    { 277, null, null, 4, "BlogCategory", null, null, "Name", 2, null, null, "API" },
                    { 278, null, null, 4, "BlogCategory", null, null, "Name", 3, null, null, "API" },
                    { 279, null, null, 4, "BlogCategory", null, null, "Name", 4, null, null, "API" },
                    { 280, null, null, 5, "BlogCategory", null, null, "Name", 2, null, null, "Data Security" },
                    { 281, null, null, 5, "BlogCategory", null, null, "Name", 3, null, null, "Datensicherheit" },
                    { 282, null, null, 5, "BlogCategory", null, null, "Name", 4, null, null, "Безопасность данных" },
                    { 283, null, null, 6, "BlogCategory", null, null, "Name", 2, null, null, "ERP" },
                    { 284, null, null, 6, "BlogCategory", null, null, "Name", 3, null, null, "ERP" },
                    { 285, null, null, 6, "BlogCategory", null, null, "Name", 4, null, null, "ERP" },
                    { 286, null, null, 7, "BlogCategory", null, null, "Name", 2, null, null, "Business Management" },
                    { 287, null, null, 7, "BlogCategory", null, null, "Name", 3, null, null, "Geschäftsführung" },
                    { 288, null, null, 7, "BlogCategory", null, null, "Name", 4, null, null, "Управление бизнесом" },
                    { 289, null, null, 8, "BlogCategory", null, null, "Name", 2, null, null, "Game Development" },
                    { 290, null, null, 8, "BlogCategory", null, null, "Name", 3, null, null, "Spieleentwicklung" },
                    { 291, null, null, 8, "BlogCategory", null, null, "Name", 4, null, null, "Разработка игр" },
                    { 292, null, null, 9, "BlogCategory", null, null, "Name", 2, null, null, "Technology" },
                    { 293, null, null, 9, "BlogCategory", null, null, "Name", 3, null, null, "Technologie" },
                    { 294, null, null, 9, "BlogCategory", null, null, "Name", 4, null, null, "Технология" },
                    { 295, null, null, 10, "BlogCategory", null, null, "Name", 2, null, null, "Web Development" },
                    { 296, null, null, 10, "BlogCategory", null, null, "Name", 3, null, null, "Webentwicklung" },
                    { 297, null, null, 10, "BlogCategory", null, null, "Name", 4, null, null, "Веб-разработка" },
                    { 298, null, null, 11, "BlogCategory", null, null, "Name", 2, null, null, "PWA" },
                    { 299, null, null, 11, "BlogCategory", null, null, "Name", 3, null, null, "PWA" },
                    { 300, null, null, 11, "BlogCategory", null, null, "Name", 4, null, null, "PWA" },
                    { 301, null, null, 1, "Highlight", null, null, "Content", 2, null, null, "Modern and user-friendly web solutions" },
                    { 302, null, null, 1, "Highlight", null, null, "Content", 3, null, null, "Moderne und benutzerfreundliche Weblösungen" },
                    { 303, null, null, 1, "Highlight", null, null, "Content", 4, null, null, "Современные и удобные веб-решения" },
                    { 304, null, null, 2, "Highlight", null, null, "Content", 2, null, null, "SEO-compliant web development" },
                    { 305, null, null, 2, "Highlight", null, null, "Content", 3, null, null, "SEO-konforme Webentwicklung" },
                    { 306, null, null, 2, "Highlight", null, null, "Content", 4, null, null, "Веб-разработка, соответствующая требованиям SEO" },
                    { 307, null, null, 3, "Highlight", null, null, "Content", 2, null, null, "High-performance and security-focused" },
                    { 308, null, null, 3, "Highlight", null, null, "Content", 3, null, null, "Leistungsstark und sicherheitsorientiert" },
                    { 309, null, null, 3, "Highlight", null, null, "Content", 4, null, null, "Ориентированность на высокую производительность и безопасность" },
                    { 310, null, null, 4, "Highlight", null, null, "Content", 2, null, null, "Development for iOS and Android platforms" },
                    { 311, null, null, 4, "Highlight", null, null, "Content", 3, null, null, "Entwicklung für iOS- und Android-Plattformen" },
                    { 312, null, null, 4, "Highlight", null, null, "Content", 4, null, null, "Разработка для платформ iOS и Android" },
                    { 313, null, null, 5, "Highlight", null, null, "Content", 2, null, null, "User-friendly and interactive design" },
                    { 314, null, null, 5, "Highlight", null, null, "Content", 3, null, null, "Benutzerfreundliches und interaktives Design" },
                    { 315, null, null, 5, "Highlight", null, null, "Content", 4, null, null, "Удобный и интерактивный дизайн" },
                    { 316, null, null, 6, "Highlight", null, null, "Content", 2, null, null, "Easily updatable and scalable structure" },
                    { 317, null, null, 6, "Highlight", null, null, "Content", 3, null, null, "Leicht aktualisierbare und skalierbare Struktur" },
                    { 318, null, null, 6, "Highlight", null, null, "Content", 4, null, null, "Легко обновляемая и масштабируемая структура" },
                    { 319, null, null, 7, "Highlight", null, null, "Content", 2, null, null, "Fun and high-performance games" },
                    { 320, null, null, 7, "Highlight", null, null, "Content", 3, null, null, "Spaßige und leistungsstarke Spiele" },
                    { 321, null, null, 7, "Highlight", null, null, "Content", 4, null, null, "Веселые и высокопроизводительные игры" },
                    { 322, null, null, 8, "Highlight", null, null, "Content", 2, null, null, "Development with tools like Unity and Unreal Engine" },
                    { 323, null, null, 8, "Highlight", null, null, "Content", 3, null, null, "Entwicklung mit Werkzeugen wie Unity und Unreal Engine" },
                    { 324, null, null, 8, "Highlight", null, null, "Content", 4, null, null, "Разработка с использованием Unity и Unreal Engine" },
                    { 325, null, null, 9, "Highlight", null, null, "Content", 2, null, null, "Game design ensuring replayability" },
                    { 326, null, null, 9, "Highlight", null, null, "Content", 3, null, null, "Spieldesign, das die Wiederspielbarkeit sicherstellt" },
                    { 327, null, null, 9, "Highlight", null, null, "Content", 4, null, null, "Дизайн игры, обеспечивающий повторное прохождение" },
                    { 328, null, null, 10, "Highlight", null, null, "Content", 2, null, null, "Efficient and secure data flow" },
                    { 329, null, null, 10, "Highlight", null, null, "Content", 3, null, null, "Effizienter und sicherer Datenfluss" },
                    { 330, null, null, 10, "Highlight", null, null, "Content", 4, null, null, "Эффективный и безопасный поток данных" },
                    { 331, null, null, 11, "Highlight", null, null, "Content", 2, null, null, "Compatibility across different systems" },
                    { 332, null, null, 11, "Highlight", null, null, "Content", 3, null, null, "Kompatibilität zwischen verschiedenen Systemen" },
                    { 333, null, null, 11, "Highlight", null, null, "Content", 4, null, null, "Совместимость между различными системами" },
                    { 334, null, null, 12, "Highlight", null, null, "Content", 2, null, null, "Security-focused integration" },
                    { 335, null, null, 12, "Highlight", null, null, "Content", 3, null, null, "Sicherheitsorientierte Integration" },
                    { 336, null, null, 12, "Highlight", null, null, "Content", 4, null, null, "Интеграция с фокусом на безопасность" },
                    { 337, null, null, 13, "Highlight", null, null, "Content", 2, null, null, "Solutions that strengthen customer relationships" },
                    { 338, null, null, 13, "Highlight", null, null, "Content", 3, null, null, "Lösungen, die Kundenbeziehungen stärken" },
                    { 339, null, null, 13, "Highlight", null, null, "Content", 4, null, null, "Решения для укрепления отношений с клиентами" },
                    { 340, null, null, 14, "Highlight", null, null, "Content", 2, null, null, "Optimization of sales, marketing, and services" },
                    { 341, null, null, 14, "Highlight", null, null, "Content", 3, null, null, "Optimierung von Vertrieb, Marketing und Dienstleistungen" },
                    { 342, null, null, 14, "Highlight", null, null, "Content", 4, null, null, "Оптимизация продаж, маркетинга и услуг" },
                    { 343, null, null, 15, "Highlight", null, null, "Content", 2, null, null, "Analysis of all customer data" },
                    { 344, null, null, 15, "Highlight", null, null, "Content", 3, null, null, "Analyse aller Kundendaten" },
                    { 345, null, null, 15, "Highlight", null, null, "Content", 4, null, null, "Анализ всех данных о клиентах" },
                    { 346, null, null, 16, "Highlight", null, null, "Content", 2, null, null, "Inter-departmental data integration" },
                    { 347, null, null, 16, "Highlight", null, null, "Content", 3, null, null, "Abteilungsübergreifende Datenintegration" },
                    { 348, null, null, 16, "Highlight", null, null, "Content", 4, null, null, "Интеграция данных между отделами" },
                    { 349, null, null, 17, "Highlight", null, null, "Content", 2, null, null, "Structure optimizing business processes" },
                    { 350, null, null, 17, "Highlight", null, null, "Content", 3, null, null, "Struktur zur Optimierung von Geschäftsprozessen" },
                    { 351, null, null, 17, "Highlight", null, null, "Content", 4, null, null, "Структура, оптимизирующая бизнес-процессы" },
                    { 352, null, null, 18, "Highlight", null, null, "Content", 2, null, null, "Accelerating decision-making processes" },
                    { 353, null, null, 18, "Highlight", null, null, "Content", 3, null, null, "Beschleunigung von Entscheidungsprozessen" },
                    { 354, null, null, 18, "Highlight", null, null, "Content", 4, null, null, "Ускорение процесса принятия решений" },
                    { 355, null, null, 19, "Highlight", null, null, "Content", 2, null, null, "Robust and secure database infrastructure" },
                    { 356, null, null, 19, "Highlight", null, null, "Content", 3, null, null, "Robuste und sichere Datenbankinfrastruktur" },
                    { 357, null, null, 19, "Highlight", null, null, "Content", 4, null, null, "Надежная и безопасная инфраструктура базы данных" },
                    { 358, null, null, 20, "Highlight", null, null, "Content", 2, null, null, "Optimized for high performance" },
                    { 359, null, null, 20, "Highlight", null, null, "Content", 3, null, null, "Optimiert für hohe Leistung" },
                    { 360, null, null, 20, "Highlight", null, null, "Content", 4, null, null, "Оптимизировано для высокой производительности" },
                    { 361, null, null, 21, "Highlight", null, null, "Content", 2, null, null, "Continuous accessibility of data" },
                    { 362, null, null, 21, "Highlight", null, null, "Content", 3, null, null, "Kontinuierliche Datenzugänglichkeit" },
                    { 363, null, null, 21, "Highlight", null, null, "Content", 4, null, null, "Непрерывная доступность данных" },
                    { 364, null, null, 22, "Highlight", null, null, "Content", 2, null, null, "Custom design tailored to business processes" },
                    { 365, null, null, 22, "Highlight", null, null, "Content", 3, null, null, "Maßgeschneidertes Design für Geschäftsprozesse" },
                    { 366, null, null, 22, "Highlight", null, null, "Content", 4, null, null, "Индивидуальный дизайн, адаптированный к бизнес-процессам" },
                    { 367, null, null, 23, "Highlight", null, null, "Content", 2, null, null, "Comprehensive analysis and performance optimization" },
                    { 368, null, null, 23, "Highlight", null, null, "Content", 3, null, null, "Umfassende Analyse und Leistungsoptimierung" },
                    { 369, null, null, 23, "Highlight", null, null, "Content", 4, null, null, "Комплексный анализ и оптимизация производительности" },
                    { 370, null, null, 24, "Highlight", null, null, "Content", 2, null, null, "Scalable and reliable solutions" },
                    { 371, null, null, 24, "Highlight", null, null, "Content", 3, null, null, "Skalierbare und zuverlässige Lösungen" },
                    { 372, null, null, 24, "Highlight", null, null, "Content", 4, null, null, "Масштабируемые и надежные решения" },
                    { 373, null, null, 25, "Highlight", null, null, "Content", 2, null, null, "Strategic management solutions for projects" },
                    { 374, null, null, 25, "Highlight", null, null, "Content", 3, null, null, "Strategische Managementlösungen für Projekte" },
                    { 375, null, null, 25, "Highlight", null, null, "Content", 4, null, null, "Стратегические решения для управления проектами" },
                    { 376, null, null, 26, "Highlight", null, null, "Content", 2, null, null, "Timely and on-budget delivery" },
                    { 377, null, null, 26, "Highlight", null, null, "Content", 3, null, null, "Rechtzeitige und budgetgerechte Lieferung" },
                    { 378, null, null, 26, "Highlight", null, null, "Content", 4, null, null, "Своевременная доставка в рамках бюджета" },
                    { 379, null, null, 27, "Highlight", null, null, "Content", 2, null, null, "Management with a focus on quality" },
                    { 380, null, null, 27, "Highlight", null, null, "Content", 3, null, null, "Management mit Fokus auf Qualität" },
                    { 381, null, null, 27, "Highlight", null, null, "Content", 4, null, null, "Управление с акцентом на качество" },
                    { 382, null, null, 28, "Highlight", null, null, "Content", 2, null, null, "Secure and flexible cloud infrastructure" },
                    { 383, null, null, 28, "Highlight", null, null, "Content", 3, null, null, "Sichere und flexible Cloud-Infrastruktur" },
                    { 384, null, null, 28, "Highlight", null, null, "Content", 4, null, null, "Безопасная и гибкая облачная инфраструктура" },
                    { 385, null, null, 29, "Highlight", null, null, "Content", 2, null, null, "Access from anywhere with data security" },
                    { 386, null, null, 29, "Highlight", null, null, "Content", 3, null, null, "Zugang von überall mit Datensicherheit" },
                    { 387, null, null, 29, "Highlight", null, null, "Content", 4, null, null, "Доступ отовсюду с безопасностью данных" },
                    { 388, null, null, 30, "Highlight", null, null, "Content", 2, null, null, "Scalable solutions to lighten workload" },
                    { 389, null, null, 30, "Highlight", null, null, "Content", 3, null, null, "Skalierbare Lösungen zur Entlastung der Arbeitslast" },
                    { 390, null, null, 30, "Highlight", null, null, "Content", 4, null, null, "Масштабируемые решения для уменьшения рабочей нагрузки" },
                    { 391, null, null, 4, "History", null, null, "YearDescription", 2, null, null, "The Şantiye Bul project is an innovative initiative aimed at connecting small and medium-sized enterprises (SMEs) with large construction sites and projects. This project seeks to maximize the efficiency of state control mechanisms, support the development of SMEs, and ensure the construction of safer and higher quality buildings nationwide. Through Şantiye Bul, it is possible to reduce earthquake risks, prevent illegal construction, minimize the risks associated with cheap labor, and control the use of low-quality materials. As a result, industry standards will improve, and more solid, reliable, and sustainable buildings will be established across the country. This initiative is an important step towards enhancing quality and safety in Turkey's construction sector." },
                    { 392, null, null, 4, "History", null, null, "YearDescription", 3, null, null, "Das Projekt Şantiye Bul ist eine innovative Initiative, die darauf abzielt, kleine und mittlere Unternehmen (KMU) mit großen Baustellen und Bauprojekten zu verbinden. Dieses Projekt strebt an, die Effizienz der staatlichen Kontrollmechanismen zu maximieren, die Entwicklung von KMU zu unterstützen und den Bau sichererer und hochwertigerer Gebäude im ganzen Land zu gewährleisten. Durch Şantiye Bul wird es möglich, Erdbebenrisiken zu verringern, illegale Bebauung zu verhindern, die mit billiger Arbeit verbundenen Risiken zu minimieren und die Verwendung minderwertiger Materialien zu kontrollieren. Dadurch werden die Branchenstandards verbessert, und es entstehen landesweit solidere, zuverlässigere und nachhaltigere Gebäude. Diese Initiative ist ein wichtiger Schritt zur Verbesserung der Qualität und Sicherheit im türkischen Bausektor." },
                    { 393, null, null, 4, "History", null, null, "YearDescription", 4, null, null, "Проект Şantiye Bul — это инновационная инициатива, направленная на объединение малых и средних предприятий (МСП) с крупными строительными объектами и проектами. Этот проект направлен на максимальное повышение эффективности государственных контрольных механизмов, поддержку развития МСП и обеспечение строительства более безопасных и качественных зданий по всей стране. Благодаря Şantiye Bul станет возможным уменьшение рисков землетрясений, предотвращение незаконного строительства, минимизация рисков, связанных с дешевой рабочей силой, и контроль за использованием некачественных материалов. В результате стандарты в отрасли будут улучшены, и по всей стране появятся более прочные, надежные и устойчивые здания. Эта инициатива является важным шагом к повышению качества и безопасности в строительной отрасли Турции." },
                    { 394, null, null, 4, "History", null, null, "DefaultTitle", 2, null, null, "Our Company History" },
                    { 395, null, null, 4, "History", null, null, "DefaultTitle", 3, null, null, "Die Geschichte unseres Unternehmens" },
                    { 396, null, null, 4, "History", null, null, "DefaultTitle", 4, null, null, "История нашей компании" },
                    { 397, null, null, 4, "History", null, null, "DefaultContent", 2, null, null, "Discover details about our growth, vision, and projects at TechLiberty since our foundation." },
                    { 398, null, null, 4, "History", null, null, "DefaultContent", 3, null, null, "Entdecken Sie Details über unser Wachstum, unsere Vision und Projekte bei TechLiberty seit unserer Gründung." },
                    { 399, null, null, 4, "History", null, null, "DefaultContent", 4, null, null, "Узнайте подробнее о нашем росте, видении и проектах в TechLiberty с момента основания." },
                    { 400, null, null, 1, "NavbarItem", null, null, "Name", 2, null, null, "Home" },
                    { 401, null, null, 1, "NavbarItem", null, null, "Name", 3, null, null, "Startseite" },
                    { 402, null, null, 1, "NavbarItem", null, null, "Name", 4, null, null, "Главная" },
                    { 403, null, null, 2, "NavbarItem", null, null, "Name", 2, null, null, "About Us" },
                    { 404, null, null, 2, "NavbarItem", null, null, "Name", 3, null, null, "Über uns" },
                    { 405, null, null, 2, "NavbarItem", null, null, "Name", 4, null, null, "О нас" },
                    { 406, null, null, 3, "NavbarItem", null, null, "Name", 2, null, null, "Services" },
                    { 407, null, null, 3, "NavbarItem", null, null, "Name", 3, null, null, "Dienstleistungen" },
                    { 408, null, null, 3, "NavbarItem", null, null, "Name", 4, null, null, "Услуги" },
                    { 409, null, null, 4, "NavbarItem", null, null, "Name", 2, null, null, "Blog" },
                    { 410, null, null, 4, "NavbarItem", null, null, "Name", 3, null, null, "Blog" },
                    { 411, null, null, 4, "NavbarItem", null, null, "Name", 4, null, null, "Блог" },
                    { 412, null, null, 5, "NavbarItem", null, null, "Name", 2, null, null, "ContactForm" },
                    { 413, null, null, 5, "NavbarItem", null, null, "Name", 3, null, null, "Kontakt" },
                    { 414, null, null, 5, "NavbarItem", null, null, "Name", 4, null, null, "Контакт" },
                    { 415, null, null, 6, "NavbarItem", null, null, "Name", 2, null, null, "FAQ" },
                    { 416, null, null, 6, "NavbarItem", null, null, "Name", 3, null, null, "FAQ" },
                    { 417, null, null, 6, "NavbarItem", null, null, "Name", 4, null, null, "Вопросы и ответы" },
                    { 418, null, null, 1, "CompanyInfo", null, null, "WorkingHours", 2, null, null, "Monday - Friday: 9:00 AM - 6:00 PM" },
                    { 419, null, null, 1, "CompanyInfo", null, null, "WorkingHours", 3, null, null, "Montag - Freitag: 9:00 - 18:00 Uhr" },
                    { 420, null, null, 1, "CompanyInfo", null, null, "WorkingHours", 4, null, null, "Понедельник - Пятница: 9:00 - 18:00" },
                    { 421, null, null, 1, "ContactForm", null, null, "FullNamePlaceholder", 2, null, null, "Your Full Name" },
                    { 422, null, null, 1, "ContactForm", null, null, "FullNamePlaceholder", 3, null, null, "Ihr vollständiger Name" },
                    { 423, null, null, 1, "ContactForm", null, null, "FullNamePlaceholder", 4, null, null, "Ваше полное имя" },
                    { 424, null, null, 1, "ContactForm", null, null, "EmailPlaceholder", 2, null, null, "Your Email Address" },
                    { 425, null, null, 1, "ContactForm", null, null, "EmailPlaceholder", 3, null, null, "Ihre E-Mail-Adresse" },
                    { 426, null, null, 1, "ContactForm", null, null, "EmailPlaceholder", 4, null, null, "Ваш адрес электронной почты" },
                    { 427, null, null, 1, "ContactForm", null, null, "PhonePlaceholder", 2, null, null, "Your Phone Number" },
                    { 428, null, null, 1, "ContactForm", null, null, "PhonePlaceholder", 3, null, null, "Ihre Telefonnummer" },
                    { 429, null, null, 1, "ContactForm", null, null, "PhonePlaceholder", 4, null, null, "Ваш номер телефона" },
                    { 430, null, null, 1, "ContactForm", null, null, "SubjectPlaceholder", 2, null, null, "Subject" },
                    { 431, null, null, 1, "ContactForm", null, null, "SubjectPlaceholder", 3, null, null, "Betreff" },
                    { 432, null, null, 1, "ContactForm", null, null, "SubjectPlaceholder", 4, null, null, "Тема" },
                    { 433, null, null, 1, "ContactForm", null, null, "MessagePlaceholder", 2, null, null, "Your Message" },
                    { 434, null, null, 1, "ContactForm", null, null, "MessagePlaceholder", 3, null, null, "Ihre Nachricht" },
                    { 435, null, null, 1, "ContactForm", null, null, "MessagePlaceholder", 4, null, null, "Ваше сообщение" },
                    { 436, null, null, 1, "ContactForm", null, null, "SendButton", 2, null, null, "Send Message" },
                    { 437, null, null, 1, "ContactForm", null, null, "SendButton", 3, null, null, "Nachricht senden" },
                    { 438, null, null, 1, "ContactForm", null, null, "SendButton", 4, null, null, "Отправить сообщение" }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "AboutId", "DefaultContent", "DefaultTitle", "IsActive", "ProjectUrl", "Slug", "Year", "YearDescription" },
                values: new object[,]
                {
                    { 1, 1, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, null, "our-history", 2023, "TechLiberty Software Solutions, 29 Ekim 2023 tarihinde, özel sektördeki ERP çözümlerinin eksikliklerini gidermek amacıyla kuruldu. Kurucumuz, sektördeki firmaların verimliliğini artırmak ve dijital dönüşümlerine katkıda bulunmak için yeni nesil yazılım çözümleri geliştirme hedefiyle yola çıktı." },
                    { 2, 1, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, "https://www.gofgames.com.tr", "expanding-our-vision", 2024, "TechLiberty, kurucusunun sevgili köpeği Gofret’ten ilham alınarak geliştirdiği 'Gof Games' projesini duyurdu. Bu oyun, oyunculara hem eğlenceli hem de duygusal bir deneyim sunmayı hedefliyor. Aynı zamanda, ERP çözümleri alanında sektördeki işletmelere değer katan yazılımlar geliştirme sürecine hız verdik. Mevcut ERP sistemlerindeki eksiklikleri gidermek için daha esnek, kullanımı kolay ve güçlü bir çözüm üzerinde çalışıyoruz." },
                    { 3, 1, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, null, "ongoing-innovation", 2024, "TechLiberty olarak teknoloji ve inovasyonu işimizin merkezine koyduk. Şirketlerin dijital dönüşümlerine destek olmak, süreçlerini optimize etmek ve onlara değer katmak için sürekli yenilikçi çözümler sunuyoruz. Mevcut projelerimize ek olarak, küçük ve orta ölçekli işletmelere yönelik veri odaklı ERP çözümleri ile sektörün ihtiyaçlarını karşılamaya devam ediyoruz." },
                    { 4, 1, "TechLiberty'nin kuruluşundan bu yana hedeflediğimiz vizyon ve projelerle büyümemize dair detayları burada bulabilirsiniz.", "Şirketimizin Tarihi", true, "https://www.santiyebul.com", "construction-innovation", 2024, "Şantiye Bul projesi, küçük ve orta ölçekli işletmeleri (KOBİ) büyük şantiyeler ve inşaat projeleriyle bir araya getirmeyi hedefleyen yenilikçi bir girişimdir. Bu proje, devlet kontrol mekanizmalarının etkinliğini en üst seviyeye çıkararak, KOBİ'lerin kalkınmasını desteklemeyi ve ülke genelinde daha güvenli ve kaliteli yapılar inşa edilmesini sağlamayı amaçlamaktadır. Şantiye Bul projesi ile birlikte, deprem risklerini azaltmak, kaçak yapılaşmayı önlemek, ucuz işçilikle oluşan riskleri minimuma indirmek ve düşük kaliteli malzeme kullanımını kontrol altına almak mümkün hale gelecektir. Böylece, hem sektör standartları yükselecek hem de ülke çapında daha sağlam, güvenilir ve sürdürülebilir yapılar ortaya çıkacaktır. Bu girişim, Türkiye’nin inşaat sektöründe kaliteyi ve güvenliği artırmak adına atılan önemli bir adımdır." }
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
                name: "IX_History_AboutId",
                table: "History",
                column: "AboutId");

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
                name: "IX_Translation_NavbarItemId",
                table: "Translation",
                column: "NavbarItemId");

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
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "ServiceCategoryMapping");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropTable(
                name: "ServiceCategory");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "FAQ");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "NavbarItem");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CompanyInfo");
        }
    }
}
