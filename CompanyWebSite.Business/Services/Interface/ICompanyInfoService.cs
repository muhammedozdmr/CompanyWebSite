using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface ICompanyInfoService
    {
        Task<IEnumerable<CompanyInfoDto>> GetCompanyInfoAllAsync(string languageCode);
        Task<CompanyInfoDto> GetCompanyInfoByIdAsync(int id);
        Task AddCompanyInfoAsync(CompanyInfoDto companyInfoDto);
        Task UpdateCompanyInfoAsync(CompanyInfoDto companyInfoDto);
        Task DeleteCompanyInfoAsync(int id);
    }
}
