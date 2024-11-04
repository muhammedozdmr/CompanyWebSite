using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IAboutService
    {
        Task<IEnumerable<AboutDto>> GetAboutAllAsync(string languageCode);
        Task<AboutDto> GetAboutByIdAsync(int id);
        Task AddAboutAsync(AboutDto aboutDto);
        Task UpdateAboutAsync(AboutDto aboutDto);
        Task DeleteAboutAsync(int id);
    }
}
