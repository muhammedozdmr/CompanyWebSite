using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{

    //TODO: Tamamlamayı unutma 
    public class CompanyInfoService : ICompanyInfoService
    {
        public Task AddCompanyInfoAsync(CompanyInfoDto companyInfoDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCompanyInfoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyInfoDto>> GetCompanyInfoAllAsync(string languageCode)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyInfoDto> GetCompanyInfoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompanyInfoAsync(CompanyInfoDto companyInfoDto)
        {
            throw new NotImplementedException();
        }
    }
}
