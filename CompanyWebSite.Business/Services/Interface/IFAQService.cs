using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IFAQService
    {
        Task<IEnumerable<FAQDto>> GetFAQAllAsync(string languageCode);
        Task<FAQDto> GetFAQByIdAsync(int id);
        Task AddFAQAsync(FAQDto fAQDto);
        Task UpdateFAQAsync(FAQDto fAQDto);
        Task DeleteFAQAsync(int id);
    }
}
