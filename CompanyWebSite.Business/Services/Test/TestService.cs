using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Test;

public class TestService : ITestService
{
    private readonly IAboutService _aboutService;
    private readonly IBlogService _blogService;
    private readonly ICompanyInfoService _companyInfoService;
    private readonly IContactService _contactService;
    private readonly IFAQService _fAQService;
    private readonly IHomeService _homeService;
    private readonly INavbarFooterSidePanelService _navbarAndFooterService;
    private readonly INavbarItemService _navbarItemService;
    private readonly INewsletterService _newsletterService;
    private readonly IServiceService _serviceService;
    private readonly IContactFormService _contactFormService;

    public TestService
    (
        IAboutService aboutService
        , IBlogService blogService
        , ICompanyInfoService companyInfoService
        , IContactService contactService
        , IFAQService fAqService 
        , IHomeService homeService
        , INavbarFooterSidePanelService navbarAndFooterService
        , INavbarItemService navbarItemService
        , INewsletterService newsletterService 
        , IServiceService serviceService 
        , IContactFormService contactFormService
    )
    {
        _aboutService = aboutService;
        _blogService = blogService;
        _companyInfoService = companyInfoService;
        _contactService = contactService;
        _fAQService = fAqService;
        _homeService = homeService;
        _navbarAndFooterService = navbarAndFooterService;
        _navbarItemService = navbarItemService;
        _newsletterService = newsletterService;
        _serviceService = serviceService;
        _contactFormService = contactFormService;
    }

    public async Task<IEnumerable<AboutDto>> GetAboutAllAsync(string languageCode)
    {
        return await _aboutService.GetAboutAllAsync(languageCode);
    }

    public async Task<AboutDto> GetAboutByIdAsync(int id)
    {
        return await _aboutService.GetAboutByIdAsync(id);
    }

    public async Task AddAboutAsync(AboutDto aboutDto)
    {
        await _aboutService.AddAboutAsync(aboutDto);
    }

    public async Task UpdateAboutAsync(AboutDto aboutDto)
    {
        await _aboutService.UpdateAboutAsync(aboutDto);
    }

    public async Task DeleteAboutAsync(int id)
    {
        await _aboutService.DeleteAboutAsync(id);
    }

    public async Task<IEnumerable<BlogDto>> GetBlogAllAsync(string languageCode)
    {
        return await _blogService.GetBlogAllAsync(languageCode);
    }

    public async Task<BlogDto> GetBlogByIdAsync(string language,int id)
    {
        return await _blogService.GetBlogByIdAsync(language, id);
    }

    public async Task AddBlogAsync(BlogDto blogDto)
    {
        await _blogService.AddBlogAsync(blogDto);
    }

    public async Task UpdateBlogAsync(BlogDto blogDto)
    {
        await _blogService.UpdateBlogAsync(blogDto);
    }

    public async Task DeleteBlogAsync(int id)
    {
        await _blogService.DeleteBlogAsync(id);
    }

    public async Task<IEnumerable<CompanyInfoDto>> GetCompanyInfoAllAsync(string languageCode)
    {
        return await _companyInfoService.GetCompanyInfoAllAsync(languageCode);
    }

    public async Task<CompanyInfoDto> GetCompanyInfoByIdAsync(int id)
    {
        return await _companyInfoService.GetCompanyInfoByIdAsync(id);
    }

    public async Task AddCompanyInfoAsync(CompanyInfoDto companyInfoDto)
    {
        await _companyInfoService.AddCompanyInfoAsync(companyInfoDto);
    }

    public async Task UpdateCompanyInfoAsync(CompanyInfoDto companyInfoDto)
    {
        await _companyInfoService.UpdateCompanyInfoAsync(companyInfoDto);
    }

    public async Task DeleteCompanyInfoAsync(int id)
    {
        await _companyInfoService.DeleteCompanyInfoAsync(id);
    }

    public async Task<IEnumerable<ContactDto>> GetContactAllAsync(string languageCode)
    {
        return await _contactService.GetContactAllAsync(languageCode);
    }

    public async Task AddContactAsync(ContactFormDto contactDto)
    {
        await _contactService.AddContactAsync(contactDto);
    }

    public async Task<IEnumerable<FAQDto>> GetFAQAllAsync(string languageCode)
    {
        return await _fAQService.GetFAQAllAsync(languageCode);
    }

    public async Task<FAQDto> GetFAQByIdAsync(int id)
    {
        return await _fAQService.GetFAQByIdAsync(id);
    }

    public async Task AddFAQAsync(FAQDto fAQDto)
    {
        await _fAQService.AddFAQAsync(fAQDto);
    }

    public async Task UpdateFAQAsync(FAQDto fAQDto)
    {
        await _fAQService.UpdateFAQAsync(fAQDto);
    }

    public async Task DeleteFAQAsync(int id)
    {
        await _fAQService.DeleteFAQAsync(id);
    }

    public async Task<IEnumerable<HomeDto>> GetHomeAllAsync(string languageCode)
    {
        return await _homeService.GetHomeAllAsync(languageCode);
    }

    public async Task<IEnumerable<NavbarFooterSidePanelDto>> GetNavbarFooterSidePanelAllAsync(string languageCode)
    {
        return await _navbarAndFooterService.GetNavbarFooterSidePanelAllAsync(languageCode);
    }

    public async Task<IEnumerable<NavbarItemDto>> GetNavbarItemAllAsync(string languageCode)
    {
        return await _navbarItemService.GetNavbarItemAllAsync(languageCode);
    }

    public async Task<NavbarItemDto> GetNavbarItemByIdAsync(int id)
    {
        return await _navbarItemService.GetNavbarItemByIdAsync(id);
    }

    public async Task AddNavbarItemAsync(NavbarItemDto navbarItemDto)
    {
        await _navbarItemService.AddNavbarItemAsync(navbarItemDto);
    }

    public async Task UpdateNavbarItemAsync(NavbarItemDto navbarItemDto)
    {
        await _navbarItemService.UpdateNavbarItemAsync(navbarItemDto);
    }

    public async Task DeleteNavbarItemAsync(int id)
    {
        await _navbarItemService.DeleteNavbarItemAsync(id);
    }

    public async Task<IEnumerable<NewsletterDto>> GetNewsletterAllAsync(string languageCode)
    {
        return await _newsletterService.GetNewsletterAllAsync(languageCode);
    }

    public async Task<NewsletterDto> GetNewsletterByIdAsync(int id)
    {
        return await _newsletterService.GetNewsletterByIdAsync(id);
    }

    public async Task AddNewsletterAsync(NewsletterDto newsletterDto)
    {
        await _newsletterService.AddNewsletterAsync(newsletterDto);
    }

    public async Task UpdateNewsletterAsync(NewsletterDto newsletterDto)
    {
        await _newsletterService.UpdateNewsletterAsync(newsletterDto);
    }

    public async Task DeleteNewsletterAsync(int id)
    {
        await _newsletterService.DeleteNewsletterAsync(id);
    }

    public async Task<IEnumerable<ServiceDto>> GetServiceAllAsync(string languageCode)
    {
        return await _serviceService.GetServiceAllAsync(languageCode);
    }

    public async Task<ServiceDto> GetServiceByIdAsync(string languageCode, int id)
    {
        return await _serviceService.GetServiceByIdAsync(languageCode,id);
    }

    public async Task AddServiceAsync(ServiceDto serviceDto)
    {
        await _serviceService.AddServiceAsync(serviceDto);
    }

    public async Task UpdateServiceAsync(ServiceDto serviceDto)
    {
        await _serviceService.UpdateServiceAsync(serviceDto);
    }

    public async Task DeleteServiceAsync(int id)
    {
        await _serviceService.DeleteServiceAsync(id);
    }

    public async Task<IEnumerable<ContactFormDto>> GetContactFormAllAsync(string languageCode)
    {
        return await _contactFormService.GetContactFormAllAsync(languageCode);
    }

    public async Task<ContactFormDto> GetContactFormByIdAsync(int id)
    {
        return await _contactFormService.GetContactFormByIdAsync(id);
    }

    public async Task AddContactFormAsync(ContactFormDto contactFormDto)
    {
        await _contactFormService.AddContactFormAsync(contactFormDto);
    }

    public async Task UpdateContactFormAsync(ContactFormDto contactFormDto)
    {
        await _contactFormService.UpdateContactFormAsync(contactFormDto);
    }

    public async Task DeleteContactFormAsync(int id)
    {
        await _contactFormService.DeleteContactFormAsync(id);
    }
}
