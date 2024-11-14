using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Business.Services.Test;
using CompanyWebSite.Dto;
using Moq;

namespace CompanyWebSite.Tests
{
    public class ServiceTest
    {
        private TestService _testService;
        private Mock<IAboutService> _aboutService;
        private Mock<IBlogService> _blogService;
        private Mock<ICompanyInfoService> _companyInfoService;
        private Mock<IContactFormService> _contactFormService;
        private Mock<IContactService> _contactService;
        private Mock<IFAQService> _fAQService;
        private Mock<IHomeService> _homeService;
        private Mock<INavbarFooterSidePanelService> _navbarAndFooterService;
        private Mock<INavbarItemService> _navbarItemService;
        private Mock<INewsletterService> _newsletterService;
        private Mock<IServiceService> _serviceService;

        public ServiceTest()
        {
            _aboutService = new Mock<IAboutService>();
            _blogService = new Mock<IBlogService>();
            _companyInfoService = new Mock<ICompanyInfoService>();
            _contactFormService = new Mock<IContactFormService>();
            _contactService = new Mock<IContactService>();
            _fAQService = new Mock<IFAQService>();
            _homeService = new Mock<IHomeService>();
            _navbarAndFooterService = new Mock<INavbarFooterSidePanelService>();
            _navbarItemService = new Mock<INavbarItemService>();
            _newsletterService = new Mock<INewsletterService>();
            _serviceService = new Mock<IServiceService>();

            _testService = new TestService(
                _aboutService.Object,
                _blogService.Object,
                _companyInfoService.Object,
                _contactService.Object,
                _fAQService.Object,
                _homeService.Object,
                _navbarAndFooterService.Object,
                _navbarItemService.Object,
                _newsletterService.Object,
                _serviceService.Object,
                _contactFormService.Object
            );
        }

        #region About Test

        //About Test
        [Fact]
        public async Task AddAboutAsync_Should_Call_AboutService_AddAboutAsync()
        {
            // Arrange
            var aboutDto = new AboutDto();
            _aboutService.Setup(x => x.AddAboutAsync(aboutDto)).Returns(Task.CompletedTask);

            // Act
            await _testService.AddAboutAsync(aboutDto);

            // Assert
            _aboutService.Verify(x => x.AddAboutAsync(aboutDto), Times.Once);
        }

        private List<AboutDto> GetMockAboutData() => new List<AboutDto>
        {
            new AboutDto { Id = 1, DefaultTitle = "Hakkımızda", DefaultContent = "Örnek içerik 1", Summary = "Özet 1" },
            new AboutDto { Id = 2, DefaultTitle = "About Us", DefaultContent = "Örnek içerik 2", Summary = "Özet 2" },
            new AboutDto { Id = 3, DefaultTitle = "Über uns", DefaultContent = "Örnek içerik 3", Summary = "Özet 3" },
            new AboutDto { Id = 4, DefaultTitle = "О нас", DefaultContent = "Örnek içerik 4", Summary = "Özet 4" }
        };

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetAboutAllAsync_Should_Return_Abouts_For_MultipleLanguages
            (string languageCode)
        {
            // Arrange
            var mockAbouts = GetMockAboutData();

            _aboutService.Setup(x => x.GetAboutAllAsync(languageCode)).ReturnsAsync(mockAbouts);

            // Act
            var result = await _testService.GetAboutAllAsync(languageCode);

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
            var mockAbout = GetMockAboutData().FirstOrDefault(x => x.Id == id);
            _aboutService.Setup(x => x.GetAboutByIdAsync(id)).ReturnsAsync(mockAbout);

            // Act
            var result = await _testService.GetAboutByIdAsync(id);

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
            await _testService.UpdateAboutAsync(aboutDto);

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
            await _testService.DeleteAboutAsync(id);

            // Assert
            _aboutService.Verify(x => x.DeleteAboutAsync(id), Times.Once);
        }
        #endregion

        #region Blog Test
        //Blog Test

        private List<BlogDto> GetMockBlogData() => new List<BlogDto>
        {
            new BlogDto { Id = 1, DefaultTitle = "Tech Blog", DefaultContent = "Örnek blog içeriği 1"},
            new BlogDto { Id = 2, DefaultTitle = "Fundamentals of Software Development", DefaultContent = "Örnek blog içeriği 2"},
            new BlogDto { Id = 3, DefaultTitle = "Grundlagen der Softwareentwicklung", DefaultContent = "Örnek blog içeriği 3"},
            new BlogDto { Id = 4, DefaultTitle = "Основы разработки программного обеспечения", DefaultContent = "Örnek blog içeriği 4"}
        };

        [Fact]
        public async Task AddBlogAsync_Should_Call_BlogService_AddBlogAsync()
        {
            // Arrange
            var blogDto = new BlogDto();
            _blogService.Setup(x => x.AddBlogAsync(blogDto)).Returns(Task.CompletedTask);

            // Act
            await _testService.AddBlogAsync(blogDto);

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
            // Arrange
            var mockBlogs = GetMockBlogData();


            _blogService.Setup(x => x.GetBlogAllAsync(languageCode)).ReturnsAsync(mockBlogs);

            // Act
            var result = await _testService.GetBlogAllAsync(languageCode);

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
            var mockBlog = GetMockBlogData().FirstOrDefault(x => x.Id == id);
            _blogService.Setup(x => x.GetBlogByIdAsync(id)).ReturnsAsync(mockBlog);

            // Act
            var result = await _testService.GetBlogByIdAsync(id);

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
            await _testService.UpdateBlogAsync(blogDto);

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
            await _testService.DeleteBlogAsync(id);

            // Assert
            _blogService.Verify(x => x.DeleteBlogAsync(id), Times.Once);
        }
        #endregion

        #region Company Info Test
        //Company Info Test

        private List<CompanyInfoDto> GetMockCompanyInfoData() => new List<CompanyInfoDto>
{
    new CompanyInfoDto { Id = 1, CompanyArea = "Yazılım Çözümleri", Residence = "İstanbul", Address = "Adres 1" },
    new CompanyInfoDto { Id = 2, CompanyArea = "Health and Technology Services Limited Company", Residence = "Istanbul", Address = "Adres 2" },
    new CompanyInfoDto { Id = 3, CompanyArea = "Gesundheits- und Technologiedienstleistungen GmbH", Residence = "Istanbul", Address = "Adres 3" },
    new CompanyInfoDto { Id = 4, CompanyArea = "Услуги в области здравоохранения и технологий", Residence = "Istanbul", Address = "Adres 4" }
};

        [Fact]
        public async Task AddCompanyInfoAsync_Should_Call_CompanyInfoService_AddCompanyInfoAsync()
        {
            // Arrange
            var companyInfoDto = new CompanyInfoDto();
            _companyInfoService.Setup(x => x.AddCompanyInfoAsync(companyInfoDto)).Returns(Task.CompletedTask);

            // Act
            await _testService.AddCompanyInfoAsync(companyInfoDto);

            // Assert
            _companyInfoService.Verify(x => x.AddCompanyInfoAsync(companyInfoDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetCompanyInfoAllAsync_Should_Return_CompanyInfos(string languageCode)
        {
            // Arrange
            var mockCompanyInfos = GetMockCompanyInfoData();
            _companyInfoService.Setup(x => x.GetCompanyInfoAllAsync(languageCode)).ReturnsAsync(mockCompanyInfos);

            // Act
            var result = await _testService.GetCompanyInfoAllAsync(languageCode);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _companyInfoService.Verify(x => x.GetCompanyInfoAllAsync(languageCode), Times.Once); // GetCompanyInfoAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }
        [Fact]
        public async Task GetCompanyInfoByIdAsync_Should_Return_CompanyInfo()
        {
            // Arrange
            var id = 1;
            var mockCompanyInfo = GetMockCompanyInfoData().FirstOrDefault(x => x.Id == id);
            _companyInfoService.Setup(x => x.GetCompanyInfoByIdAsync(id)).ReturnsAsync(mockCompanyInfo);

            // Act
            var result = await _testService.GetCompanyInfoByIdAsync(id);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }
        [Fact]
        public async Task UpdateCompanyInfoAsync_Should_Call_CompanyInfoService_UpdateCompanyInfoAsync()
        {
            // Arrange
            var companyInfoDto = new CompanyInfoDto();
            _companyInfoService.Setup(x => x.UpdateCompanyInfoAsync(companyInfoDto)).Returns(Task.CompletedTask);

            // Act
            await _testService.UpdateCompanyInfoAsync(companyInfoDto);

            // Assert
            _companyInfoService.Verify(x => x.UpdateCompanyInfoAsync(companyInfoDto), Times.Once);
        }
        [Fact]
        public async Task DeleteCompanyInfoAsync_Should_Call_CompanyInfoService_DeleteCompanyInfoAsync()
        {
            // Arrange
            var id = 1;
            _companyInfoService.Setup(x => x.DeleteCompanyInfoAsync(id)).Returns(Task.CompletedTask);

            // Act
            await _testService.DeleteCompanyInfoAsync(id);

            // Assert
            _companyInfoService.Verify(x => x.DeleteCompanyInfoAsync(id), Times.Once);
        }
        #endregion

        #region Contact Test
        //Contact Test

        private List<ContactDto> GetMockContactData() => new List<ContactDto>
        {
            new ContactDto { Id = 1, ContactForms = GetMockContactFormData(), CompanyInfos = GetMockCompanyInfoData() },
            new ContactDto { Id = 2, ContactForms = GetMockContactFormData(), CompanyInfos = GetMockCompanyInfoData() },
            new ContactDto { Id = 3, ContactForms = GetMockContactFormData(), CompanyInfos = GetMockCompanyInfoData() },
            new ContactDto { Id = 4, ContactForms = GetMockContactFormData(), CompanyInfos = GetMockCompanyInfoData() }
        };

        [Fact]
        public async Task AddContactAsync_Should_Call_ContactService_AddContactAsync()
        {
            // Arrange
            var contactFormDto = new ContactFormDto();
            _contactService.Setup(x => x.AddContactAsync(contactFormDto)).Returns(Task.CompletedTask);

            // Act
            await _testService.AddContactAsync(contactFormDto);

            // Assert
            _contactService.Verify(x => x.AddContactAsync(contactFormDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetContactAllAsync_Should_Return_Contacts_For_MultipleLanguages
            (string languageCode)
        {
            // Arrange
            var mockContacts = GetMockContactData();
            _contactService.Setup(x => x.GetContactAllAsync(languageCode)).ReturnsAsync(mockContacts);

            // Act
            var result = await _testService.GetContactAllAsync(languageCode);

            // Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _contactService.Verify(x => x.GetContactAllAsync(languageCode), Times.Once); // GetContactAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }
        #endregion

        #region FAQ Test
        //FAQ Test

        private List<FAQDto> GetMockFAQData() => new List<FAQDto>
        {
            new FAQDto { Id = 1, DefaultTitle = "Sıkça Sorulan Sorular", DefaultContent="Detay 1", Question="Soru 1", Answer="Cevap 1" },
            new FAQDto { Id = 2, DefaultTitle = "Frequently Asked Questions", DefaultContent = "Detay 2", Question="Soru 2", Answer="Cevap 2" },
            new FAQDto { Id = 3, DefaultTitle = "Häufig gestellte Fragen", DefaultContent = "Detay 3", Question="Soru 3", Answer="Cevap 3" },
            new FAQDto { Id = 4, DefaultTitle = "Часто задаваемые вопросы", DefaultContent = "Detay 4", Question="Soru 4", Answer="Cevap 4" }
        };

        [Fact]
        public async Task AddFAQAsync_Should_Call_FAQService_AddFAQAsync()
        {
            //Arrange
            var fAQDto = new FAQDto();
            _fAQService.Setup(x => x.AddFAQAsync(fAQDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.AddFAQAsync(fAQDto);

            //Assert
            _fAQService.Verify(x => x.AddFAQAsync(fAQDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetFAQAllAsync_Should_Return_FAQs_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockFAQs = GetMockFAQData();
            _fAQService.Setup(x => x.GetFAQAllAsync(languageCode)).ReturnsAsync(mockFAQs);

            //Act
            var result = await _testService.GetFAQAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _fAQService.Verify(x => x.GetFAQAllAsync(languageCode), Times.Once); // GetFAQAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetFAQByIdAsync_Should_Return_FAQ()
        {
            //Arrange
            var id = 1;
            var mockFAQ = GetMockFAQData().FirstOrDefault(x => x.Id == id);
            _fAQService.Setup(x => x.GetFAQByIdAsync(id)).ReturnsAsync(mockFAQ);

            //Act
            var result = await _testService.GetFAQByIdAsync(id);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }

        [Fact]
        public async Task UpdateFAQAsync_Should_Call_FAQService_UpdateFAQAsync()
        {
            //Arrange
            var fAQDto = new FAQDto();
            _fAQService.Setup(x => x.UpdateFAQAsync(fAQDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.UpdateFAQAsync(fAQDto);

            //Assert
            _fAQService.Verify(x => x.UpdateFAQAsync(fAQDto), Times.Once);
        }

        [Fact]
        public async Task DeleteFAQAsync_Should_Call_FAQService_DeleteFAQAsync()
        {
            //Arrange
            var id = 1;
            _fAQService.Setup(x => x.DeleteFAQAsync(id)).Returns(Task.CompletedTask);

            //Act
            await _testService.DeleteFAQAsync(id);

            //Assert
            _fAQService.Verify(x => x.DeleteFAQAsync(id), Times.Once);
        }
        #endregion

        #region Home Test
        //Home Test

        private List<HomeDto> GetMockHomeData() => new List<HomeDto>
        {
            new HomeDto { Id = 1, About = GetMockAboutData(), FQ = GetMockFAQData()},
            new HomeDto { Id = 2, About = GetMockAboutData(), FQ = GetMockFAQData()},
            new HomeDto { Id = 3, About = GetMockAboutData(), FQ = GetMockFAQData()},
            new HomeDto { Id = 4, About = GetMockAboutData(), FQ = GetMockFAQData()}
        };

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetHomeAllAsync_Should_Return_Homes_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockHomes = GetMockHomeData();
            _homeService.Setup(x => x.GetHomeAllAsync(languageCode)).ReturnsAsync(mockHomes);

            //Act
            var result = await _testService.GetHomeAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _homeService.Verify(x => x.GetHomeAllAsync(languageCode), Times.Once); // GetHomeAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }
        #endregion

        #region Navbar Item Test
        //Navbar Item Test

        private List<NavbarItemDto> GetMockNavbarItemData() => new List<NavbarItemDto>
        {
          new NavbarItemDto { Id = 1, Name = "Anasayfa", Slug = "/"},
          new NavbarItemDto { Id = 2, Name = "Home", Slug = "/en"},
          new NavbarItemDto { Id = 3, Name = "Startseite", Slug = "/de"},
          new NavbarItemDto { Id = 4, Name = "Главная", Slug = "/ru"}
        };

        [Fact]
        public async Task AddNavbarItemAsync_Should_Call_NavbarItemService_AddNavbarItemAsync()
        {
            //Arrange
            var navbarItemDto = new NavbarItemDto();
            _navbarItemService.Setup(x => x.AddNavbarItemAsync(navbarItemDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.AddNavbarItemAsync(navbarItemDto);

            //Assert
            _navbarItemService.Verify(x => x.AddNavbarItemAsync(navbarItemDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetNavbarItemAllAsync_Should_Return_NavbarItems_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockNavbarItems = GetMockNavbarItemData();
            _navbarItemService.Setup(x => x.GetNavbarItemAllAsync(languageCode)).ReturnsAsync(mockNavbarItems);

            //Act
            var result = await _testService.GetNavbarItemAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _navbarItemService.Verify(x => x.GetNavbarItemAllAsync(languageCode), Times.Once); // GetNavbarItemAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetNavbarItemByIdAsync_Should_Return_NavbarItem()
        {
            //Arrange
            var id = 1;
            var mockNavbarItem = GetMockNavbarItemData().FirstOrDefault(x => x.Id == id);
            _navbarItemService.Setup(x => x.GetNavbarItemByIdAsync(id)).ReturnsAsync(mockNavbarItem);

            //Act
            var result = await _testService.GetNavbarItemByIdAsync(id);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }

        [Fact]
        public async Task UpdateNavbarItemAsync_Should_Call_NavbarItemService_UpdateNavbarItemAsync()
        {
            //Arrange
            var navbarItemDto = new NavbarItemDto();
            _navbarItemService.Setup(x => x.UpdateNavbarItemAsync(navbarItemDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.UpdateNavbarItemAsync(navbarItemDto);

            //Assert
            _navbarItemService.Verify(x => x.UpdateNavbarItemAsync(navbarItemDto), Times.Once);
        }

        [Fact]
        public async Task DeleteNavbarItemAsync_Should_Call_NavbarItemService_DeleteNavbarItemAsync()
        {
            //Arrange
            var id = 1;
            _navbarItemService.Setup(x => x.DeleteNavbarItemAsync(id)).Returns(Task.CompletedTask);

            //Act
            await _testService.DeleteNavbarItemAsync(id);

            //Assert
            _navbarItemService.Verify(x => x.DeleteNavbarItemAsync(id), Times.Once);
        }
        #endregion

        #region Newsletter Test
        //Newsletter Test

        private List<NewsletterDto> GetMockNewsletterData() => new List<NewsletterDto>
        {
            new NewsletterDto { Id = 1, Email = "mail", SubscribedDate = DateTime.Now},
        };

        [Fact]
        public async Task AddNewsletterAsync_Should_Call_NewsletterService_AddNewsletterAsync()
        {
            //Arrange
            var newsletterDto = new NewsletterDto();
            _newsletterService.Setup(x => x.AddNewsletterAsync(newsletterDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.AddNewsletterAsync(newsletterDto);

            //Assert
            _newsletterService.Verify(x => x.AddNewsletterAsync(newsletterDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        public async Task GetNewsletterAllAsync_Should_Return_Newsletters_For_MultipleLanguages
                 (string languageCode)
        {
            //Arrange
            var mockNewsletters = GetMockNewsletterData();
            _newsletterService.Setup(x => x.GetNewsletterAllAsync(languageCode)).ReturnsAsync(mockNewsletters);

            //Act
            var result = await _testService.GetNewsletterAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _newsletterService.Verify(x => x.GetNewsletterAllAsync(languageCode), Times.Once); // GetNewsletterAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetNewsletterByIdAsync_Should_Return_Newsletter()
        {
            //Arrange
            var id = 1;
            var mockNewsletter = GetMockNewsletterData().FirstOrDefault(x => x.Id == id);
            _newsletterService.Setup(x => x.GetNewsletterByIdAsync(id)).ReturnsAsync(mockNewsletter);

            //Act
            var result = await _testService.GetNewsletterByIdAsync(id);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }

        [Fact]
        public async Task UpdateNewsletterAsync_Should_Call_NewsletterService_UpdateNewsletterAsync()
        {
            //Arrange
            var newsletterDto = new NewsletterDto();
            _newsletterService.Setup(x => x.UpdateNewsletterAsync(newsletterDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.UpdateNewsletterAsync(newsletterDto);

            //Assert
            _newsletterService.Verify(x => x.UpdateNewsletterAsync(newsletterDto), Times.Once);
        }

        [Fact]
        public async Task DeleteNewsletterAsync_Should_Call_NewsletterService_DeleteNewsletterAsync()
        {
            //Arrange
            var id = 1;
            _newsletterService.Setup(x => x.DeleteNewsletterAsync(id)).Returns(Task.CompletedTask);

            //Act
            await _testService.DeleteNewsletterAsync(id);

            //Assert
            _newsletterService.Verify(x => x.DeleteNewsletterAsync(id), Times.Once);
        }
        #endregion

        #region Service Test
        //Service Test

        private List<ServiceDto> GetMockServiceData() => new List<ServiceDto>
        {
            new ServiceDto { Id = 1, DefaultTitle = "Yazılım Çözümüz", DefaultContent = "Örnek içerik 1" },
            new ServiceDto { Id = 2, DefaultTitle = "Software Solution", DefaultContent = "Örnek içerik 2" },
            new ServiceDto { Id = 3, DefaultTitle = "Softwarelösung", DefaultContent = "Örnek içerik 3" },
            new ServiceDto { Id = 4, DefaultTitle = "Программное обеспечение", DefaultContent = "Örnek içerik 4" }
        };

        [Fact]
        public async Task AddServiceAsync_Should_Call_ServiceService_AddServiceAsync()
        {
            //Arrange
            var serviceDto = new ServiceDto();
            _serviceService.Setup(x => x.AddServiceAsync(serviceDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.AddServiceAsync(serviceDto);

            //Assert
            _serviceService.Verify(x => x.AddServiceAsync(serviceDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetServiceAllAsync_Should_Return_Services_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockServices = GetMockServiceData();
            _serviceService.Setup(x => x.GetServiceAllAsync(languageCode)).ReturnsAsync(mockServices);

            //Act
            var result = await _testService.GetServiceAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _serviceService.Verify(x => x.GetServiceAllAsync(languageCode), Times.Once); // GetServiceAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetServiceByIdAsync_Should_Return_Service()
        {
            //Arrange
            var id = 1;
            var mockService = GetMockServiceData().FirstOrDefault(x => x.Id == id);
            _serviceService.Setup(x => x.GetServiceByIdAsync(id)).ReturnsAsync(mockService);

            //Act
            var result = await _testService.GetServiceByIdAsync(id);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }

        [Fact]
        public async Task UpdateServiceAsync_Should_Call_ServiceService_UpdateServiceAsync()
        {
            //Arrange
            var serviceDto = new ServiceDto();
            _serviceService.Setup(x => x.UpdateServiceAsync(serviceDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.UpdateServiceAsync(serviceDto);

            //Assert
            _serviceService.Verify(x => x.UpdateServiceAsync(serviceDto), Times.Once);
        }

        [Fact]
        public async Task DeleteServiceAsync_Should_Call_ServiceService_DeleteServiceAsync()
        {
            //Arrange
            var id = 1;
            _serviceService.Setup(x => x.DeleteServiceAsync(id)).Returns(Task.CompletedTask);

            //Act
            await _testService.DeleteServiceAsync(id);

            //Assert
            _serviceService.Verify(x => x.DeleteServiceAsync(id), Times.Once);
        }
        #endregion

        #region Contact Form Test
        //Contact Form Test


        private List<ContactFormDto> GetMockContactFormData() => new List<ContactFormDto>
        {
            new ContactFormDto { Id = 1, DefaultEmailPlaceholder = "E-posta", DefaultMessagePlaceholder = "Mesaj", DefaultFullNamePlaceholder = "Ad", DefaultSubjectPlaceholder = "Konu" },
            new ContactFormDto { Id = 2, DefaultEmailPlaceholder = "E-mail", DefaultMessagePlaceholder = "Message", DefaultFullNamePlaceholder = "Name", DefaultSubjectPlaceholder = "Subject" },
            new ContactFormDto { Id = 3, DefaultEmailPlaceholder = "E-Mail", DefaultMessagePlaceholder = "Nachricht", DefaultFullNamePlaceholder = "Name", DefaultSubjectPlaceholder = "Betreff" },
            new ContactFormDto { Id = 4, DefaultEmailPlaceholder = "Электронная почта", DefaultMessagePlaceholder = "Сообщение", DefaultFullNamePlaceholder = "Имя", DefaultSubjectPlaceholder = "Тема" }
        };

        [Fact]
        public async Task AddContactFormAsync_Should_Call_ContactFormService_AddContactFormAsync()
        {
            //Arrange
            var contactFormDto = new ContactFormDto();
            _contactFormService.Setup(x => x.AddContactFormAsync(contactFormDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.AddContactFormAsync(contactFormDto);

            //Assert
            _contactFormService.Verify(x => x.AddContactFormAsync(contactFormDto), Times.Once);
        }

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetContactFormAllAsync_Should_Return_ContactForms_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockContactForms = GetMockContactFormData();
            _contactFormService.Setup(x => x.GetContactFormAllAsync(languageCode)).ReturnsAsync(mockContactForms);

            //Act
            var result = await _testService.GetContactFormAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _contactFormService.Verify(x => x.GetContactFormAllAsync(languageCode), Times.Once); // GetContactFormAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }

        [Fact]
        public async Task GetContactFormByIdAsync_Should_Return_ContactForm()
        {
            //Arrange
            var id = 1;
            var mockContactForm = GetMockContactFormData().FirstOrDefault(x => x.Id == id);
            _contactFormService.Setup(x => x.GetContactFormByIdAsync(id)).ReturnsAsync(mockContactForm);

            //Act
            var result = await _testService.GetContactFormByIdAsync(id);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.Equal(id, result.Id); // Sonucun doğru id'ye sahip olduğunu doğrula
        }

        [Fact]
        public async Task UpdateContactFormAsync_Should_Call_ContactFormService_UpdateContactFormAsync()
        {
            //Arrange
            var contactFormDto = new ContactFormDto();
            _contactFormService.Setup(x => x.UpdateContactFormAsync(contactFormDto)).Returns(Task.CompletedTask);

            //Act
            await _testService.UpdateContactFormAsync(contactFormDto);

            //Assert
            _contactFormService.Verify(x => x.UpdateContactFormAsync(contactFormDto), Times.Once);
        }

        [Fact]
        public async Task DeleteContactFormAsync_Should_Call_ContactFormService_DeleteContactFormAsync()
        {
            //Arrange
            var id = 1;
            _contactFormService.Setup(x => x.DeleteContactFormAsync(id)).Returns(Task.CompletedTask);

            //Act
            await _testService.DeleteContactFormAsync(id);

            //Assert
            _contactFormService.Verify(x => x.DeleteContactFormAsync(id), Times.Once);
        }
        #endregion

        #region Navbar And Footer Test
        //Navbar And Footer Test

        private List<NavbarFooterSidePanelDto> GetMockNavbarAndFooterData() => new List<NavbarFooterSidePanelDto>
        {
            new NavbarFooterSidePanelDto { Id = 1, NavbarItems = GetMockNavbarItemData(), CompanyInfos = GetMockCompanyInfoData(), Newsletters = GetMockNewsletterData() },
            new NavbarFooterSidePanelDto { Id = 2, NavbarItems = GetMockNavbarItemData(), CompanyInfos = GetMockCompanyInfoData(), Newsletters = GetMockNewsletterData() },
            new NavbarFooterSidePanelDto { Id = 3, NavbarItems = GetMockNavbarItemData(), CompanyInfos = GetMockCompanyInfoData(), Newsletters = GetMockNewsletterData() },
            new NavbarFooterSidePanelDto { Id = 4, NavbarItems = GetMockNavbarItemData(), CompanyInfos = GetMockCompanyInfoData(), Newsletters = GetMockNewsletterData() }
        };

        [Theory]
        [InlineData("tr")]
        [InlineData("en")]
        [InlineData("de")]
        [InlineData("ru")]
        public async Task GetNavbarAndFooterAllAsync_Should_Return_NavbarAndFooters_For_MultipleLanguages
            (string languageCode)
        {
            //Arrange
            var mockNavbarAndFooters = GetMockNavbarAndFooterData();
            _navbarAndFooterService.Setup(x => x.GetNavbarFooterSidePanelAllAsync(languageCode)).ReturnsAsync(mockNavbarAndFooters);

            //Act
            var result = await _testService.GetNavbarFooterSidePanelAllAsync(languageCode);

            //Assert
            Assert.NotNull(result); // Sonucun null olmadığını doğrula
            Assert.NotEmpty(result); // Listenin boş olmadığını doğrula

            _navbarAndFooterService.Verify(x => x.GetNavbarFooterSidePanelAllAsync(languageCode), Times.Once); // GetNavbarAndFooterAllAsync metodunun yalnızca bir kez çağrıldığını doğrula
        }
        #endregion
    }
}