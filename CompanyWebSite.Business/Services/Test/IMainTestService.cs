using CompanyWebSite.Business.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Test
{
    public interface IMainTestService : IHomeService,IAboutService,IServiceService,IBlogService, IContactService,IFAQService
    {
    }
}
