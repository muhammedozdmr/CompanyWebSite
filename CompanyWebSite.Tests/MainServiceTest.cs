using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Business.Services.Test;
using CompanyWebSite.Dto;
using Moq;

namespace CompanyWebSite.Tests
{
    public class MainServiceTest
    {
        private MainTestService _mainTestService;
        private Mock<IAboutService> _aboutService;
        private Mock<IBlogService> _blogService;
        private Mock<ICompanyInfoService> _companyInfoService;
        private Mock<IContactFormService> _contactFormService;
        private Mock<IContactService> _contactService;
        private Mock<IFAQService> _fAQService;
        private Mock<IHomeService> _homeService;
        private Mock<INavbarAndFooterService> _navbarAndFooterService;
        private Mock<INavbarItemService> _navbarItemService;
        private Mock<INewsletterService> _newsletterService;
        private Mock<IServiceService> _serviceService;

        public MainServiceTest()
        {
            _aboutService = new Mock<IAboutService>();
            _blogService = new Mock<IBlogService>();
            _companyInfoService = new Mock<ICompanyInfoService>();
            _contactFormService = new Mock<IContactFormService>();
            _contactService = new Mock<IContactService>();
            _fAQService = new Mock<IFAQService>();
            _homeService = new Mock<IHomeService>();
            _navbarAndFooterService = new Mock<INavbarAndFooterService>();
            _navbarItemService = new Mock<INavbarItemService>();
            _newsletterService = new Mock<INewsletterService>();
            _serviceService = new Mock<IServiceService>();

            _mainTestService = new MainTestService(
                _aboutService.Object,
                _blogService.Object,
                _companyInfoService.Object,
                _contactService.Object,
                _fAQService.Object,
                _homeService.Object,
                _navbarAndFooterService.Object,
                _navbarItemService.Object,
                _newsletterService.Object,
                _serviceService.Object
            );
        }

        [Fact]
        public async Task AddAboutAsync_Should_Call_AboutService_AddAboutAsync()
        {
            // Arrange
            var aboutDto = new AboutDto();
            _aboutService.Setup(x => x.AddAboutAsync(aboutDto)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.AddAboutAsync(aboutDto);

            // Assert
            _aboutService.Verify(x => x.AddAboutAsync(aboutDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetAboutAllAsync_Should_Return_Abouts_For_MultipleLanguages
            (string languageCode)
        {
            // Arrange
            var mockAbouts = new List<AboutDto>
            {
                new AboutDto { Id = 1, DefaultTitle = "Hakkımızda", DefaultContent = "TechLiberty Software Solutions olarak, 29 Ekim 2023 tarihinde kurulan şirketimiz, müşterilerine teknolojik çözümler sunma misyonunu benimsemiştir. Dijital çağın gereksinimlerine uygun olarak mobil uygulamalar, web projeleri, oyun geliştirme, proje yönetimi, SEO optimizasyonu, API servisleri, CRM ve ERP hizmetleri, veri tabanı yönetim sistemleri ve sistem analizi gibi geniş bir yelpazede profesyonel çözümler sunmaktayız. Deneyimli ve yenilikçi ekibimizle, işletmelerin dijital dönüşüm yolculuğunda güvenilir bir iş ortağı olarak yer alıyoruz. Amacımız, müşterilerimize sürdürülebilir başarıyı getirecek, verimli ve ölçeklenebilir çözümler sunarak değer katmaktır.", Summary = "TechLiberty Software Solutions, mobil uygulamalar, web projeleri, oyun geliştirme ve kurumsal çözümler sunarak işletmelerin dijital dönüşüm süreçlerinde güvenilir bir iş ortağıdır." },
                new AboutDto { Id = 2, DefaultTitle = "About Us", DefaultContent = "As TechLiberty Software Solutions, our company, founded on October 29, 2023, has adopted the mission of providing technological solutions to its clients. In line with the requirements of the digital age, we offer professional solutions in a wide range such as mobile applications, web projects, game development, project management, SEO optimization, API services, CRM and ERP services, database management systems, and system analysis. With our experienced and innovative team, we are a reliable business partner in the digital transformation journey of businesses. Our goal is to add value by providing sustainable success through efficient and scalable solutions to our clients.", Summary = "TechLiberty Software Solutions is a reliable business partner in the digital transformation processes of businesses, offering mobile applications, web projects, game development, and corporate solutions." },
                new AboutDto { Id = 3, DefaultTitle = "Über uns", DefaultContent = "Als TechLiberty Software Solutions hat unser am 29. Oktober 2023 gegründetes Unternehmen die Mission übernommen, seinen Kunden technologische Lösungen bereitzustellen. Im Einklang mit den Anforderungen des digitalen Zeitalters bieten wir professionelle Lösungen in einer breiten Palette wie mobile Anwendungen, Webprojekte, Spieleentwicklung, Projektmanagement, SEO-Optimierung, API-Dienste, CRM- und ERP-Dienste, Datenbankverwaltungssysteme und Systemanalyse. Mit unserem erfahrenen und innovativen Team sind wir ein zuverlässiger Geschäftspartner auf dem Weg der digitalen Transformation von Unternehmen. Unser Ziel ist es, unseren Kunden durch effiziente und skalierbare Lösungen nachhaltigen Erfolg zu bieten und Mehrwert zu schaffen.", Summary = "TechLiberty Software Solutions ist ein zuverlässiger Geschäftspartner in den digitalen Transformationsprozessen von Unternehmen und bietet mobile Anwendungen, Webprojekte, Spieleentwicklung und Unternehmenslösungen." },
                new AboutDto { Id = 4, DefaultTitle = "О нас", DefaultContent = "Компания TechLiberty Software Solutions, основанная 29 октября 2023 года, взяла на себя миссию по предоставлению технологических решений своим клиентам. В соответствии с требованиями цифровой эпохи мы предлагаем профессиональные решения в широком диапазоне, включая мобильные приложения, веб-проекты, разработку игр, управление проектами, оптимизацию SEO, API-сервисы, услуги CRM и ERP, системы управления базами данных и анализ систем. Наша опытная и новаторская команда является надежным партнером в процессе цифровой трансформации бизнеса. Наша цель - создать ценность, предлагая клиентам устойчивый успех через эффективные и масштабируемые решения.", Summary = "TechLiberty Software Solutions - надежный партнер в процессах цифровой трансформации бизнеса, предлагающий мобильные приложения, веб-проекты, разработку игр и корпоративные решения." }
            };

            _aboutService.Setup(x => x.GetAboutAllAsync(languageCode)).ReturnsAsync(mockAbouts);

            // Act
            var result = await _mainTestService.GetAboutAllAsync(languageCode);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula
            Assert.All(result, item => Assert.NotNull(item.DefaultTitle)); // Her bir öğede bir başlık olduğunu doğrula

            _aboutService.Verify(x => x.GetAboutAllAsync(languageCode), Times.Once); // GetAboutAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetAboutByIdAsync_Should_Return_About()
        {
            // Arrange
            var id = 1;
            var mockAbout = new AboutDto
            {
                Id = 1, DefaultTitle = "Hakkımızda"
                , DefaultContent =
                    "TechLiberty Software Solutions olarak, 29 Ekim 2023 tarihinde kurulan şirketimiz, müşterilerine teknolojik çözümler sunma misyonunu benimsemiştir. Dijital çağın gereksinimlerine uygun olarak mobil uygulamalar, web projeleri, oyun geliştirme, proje yönetimi, SEO optimizasyonu, API servisleri, CRM ve ERP hizmetleri, veri tabanı yönetim sistemleri ve sistem analizi gibi geniş bir yelpazede profesyonel çözümler sunmaktayız. Deneyimli ve yenilikçi ekibimizle, işletmelerin dijital dönüşüm yolculuğunda güvenilir bir iş ortağı olarak yer alıyoruz. Amacımız, müşterilerimize sürdürülebilir başarıyı getirecek, verimli ve ölçeklenebilir çözümler sunarak değer katmaktır."
                , Summary =
                    "TechLiberty Software Solutions, mobil uygulamalar, web projeleri, oyun geliştirme ve kurumsal çözümler sunarak işletmelerin dijital dönüşüm süreçlerinde güvenilir bir iş ortağıdır."
            };
            _aboutService.Setup(x => x.GetAboutByIdAsync(id)).ReturnsAsync(mockAbout);

            // Act
            var result = await _mainTestService.GetAboutByIdAsync(id);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
            Assert.Equal(mockAbout.DefaultTitle, result.DefaultTitle); // Sonucun doğru başlığa sahip olduğunu doğrula
            Assert.Equal(mockAbout.DefaultContent, result.DefaultContent); // Sonuc
        }
        
        [Fact]
        public async Task UpdateAboutAsync_Should_Call_AboutService_UpdateAboutAsync()
        {
            // Arrange
            var aboutDto = new AboutDto();
            _aboutService.Setup(x => x.UpdateAboutAsync(aboutDto)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.UpdateAboutAsync(aboutDto);

            // Assert
            _aboutService.Verify(x => x.UpdateAboutAsync(aboutDto), Times.Once);
        }
        
        [Fact]
        public async Task DeleteAboutAsync_Should_Call_AboutService_DeleteAboutAsync()
        {
            // Arrange
            var id = 1;
            _aboutService.Setup(x => x.DeleteAboutAsync(id)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.DeleteAboutAsync(id);

            // Assert
            _aboutService.Verify(x => x.DeleteAboutAsync(id), Times.Once);
        }
        
        [Fact]
        public async Task AddBlogAsync_Should_Call_BlogService_AddBlogAsync()
        {
            // Arrange
            var blogDto = new BlogDto();
            _blogService.Setup(x => x.AddBlogAsync(blogDto)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.AddBlogAsync(blogDto);

            // Assert
            _blogService.Verify(x => x.AddBlogAsync(blogDto), Times.Once);
        }
        
        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetBlogAllAsync_Should_Return_Blogs_For_MultipleLanguages
            (string languageCode)
        {
            
            //TODO: Mock datayı ayarla
            // Arrange
            var mockBlogs = new List<BlogDto>();
          

            _blogService.Setup(x => x.GetBlogAllAsync(languageCode)).ReturnsAsync(mockBlogs);

            // Act
            var result = await _mainTestService.GetBlogAllAsync(languageCode);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula
            Assert.All(result, item => Assert.NotNull(item.DefaultTitle)); // Her bir öğede bir başlık olduğunu doğrula

            _blogService.Verify(x => x.GetBlogAllAsync(languageCode), Times.Once); // GetBlogAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }
        
        [Fact]
        public async Task GetBlogByIdAsync_Should_Return_Blog()
        {
            // Arrange
            var id = 1;
            var mockBlog = new BlogDto();
            _blogService.Setup(x => x.GetBlogByIdAsync(id)).ReturnsAsync(mockBlog);

            // Act
            var result = await _mainTestService.GetBlogByIdAsync(id);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }
        
        [Fact]
        public async Task UpdateBlogAsync_Should_Call_BlogService_UpdateBlogAsync()
        {
            // Arrange
            var blogDto = new BlogDto();
            _blogService.Setup(x => x.UpdateBlogAsync(blogDto)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.UpdateBlogAsync(blogDto);

            // Assert
            _blogService.Verify(x => x.UpdateBlogAsync(blogDto), Times.Once);
        }
        
        [Fact]
        public async Task DeleteBlogAsync_Should_Call_BlogService_DeleteBlogAsync()
        {
            // Arrange
            var id = 1;
            _blogService.Setup(x => x.DeleteBlogAsync(id)).Returns(Task.CompletedTask);

            // Act
            await _mainTestService.DeleteBlogAsync(id);

            // Assert
            _blogService.Verify(x => x.DeleteBlogAsync(id), Times.Once);
        }
    }
}