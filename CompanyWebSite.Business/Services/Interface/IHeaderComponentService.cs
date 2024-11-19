using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IHeaderComponentService
    {
        Task<IEnumerable<HeaderComponentDto>> GetHeaderComponentAllAsync(string languageCode);
    }
}
