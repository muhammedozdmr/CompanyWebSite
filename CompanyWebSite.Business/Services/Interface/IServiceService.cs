using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDto>> GetServiceAllAsync(string languageCode);
        Task<ServiceDto> GetServiceByIdAsync(int id);
        Task AddServiceAsync(ServiceDto serviceDto);
        Task UpdateServiceAsync(ServiceDto serviceDto);
        Task DeleteServiceAsync(int id);
    }
}
