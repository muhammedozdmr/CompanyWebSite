using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IFooterComponentService
    {
        Task<IEnumerable<FooterComponentDto>> GetFooterComponentAllAsync(string languageCode);
    }
}
