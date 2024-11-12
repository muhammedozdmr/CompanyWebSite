using CompanyWebSite.Business.Services.Interface;

namespace CompanyWebSite.Business.Services.Test;

public interface IMainTestService : IAboutService, IBlogService, ICompanyInfoService, IContactService,IFAQService, IHomeService, INavbarAndFooterService, INavbarItemService, INewsletterService, IServiceService
{
    
}
