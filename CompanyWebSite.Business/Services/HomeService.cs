using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class HomeService : IHomeService
    {
        private readonly IBaseRepository<HomeDto> _homeRepository;
        public Task<IEnumerable<HomeDto>> GetHomeAllAsync(string languageCode)
        {
            throw new NotImplementedException();
        }
    }
}
