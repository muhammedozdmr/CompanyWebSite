using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IHeaderSidePanelComponentService
    {
        Task<IEnumerable<HeaderSidePanelComponentDto>> GetHeaderSidePanelComponentAllAsync(string languageCode);
    }
}
