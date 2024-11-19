using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto.LayoutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class HeaderSidePanelComponentService : IHeaderSidePanelComponentService
    {
        private readonly ISidePanelService _sidePanelService;
        private readonly ICompanyInfoService _companyService;
        public HeaderSidePanelComponentService(ISidePanelService sidePanelService, ICompanyInfoService companyInfoService)
        {
            _companyService = companyInfoService;
            _sidePanelService = sidePanelService;
        }
        public async Task<IEnumerable<HeaderSidePanelComponentDto>> GetHeaderSidePanelComponentAllAsync(string languageCode)
        {
            var sidePanel = _sidePanelService.GetSidePanelAllAsync(languageCode);
            var companyInfo = _companyService.GetCompanyInfoAllAsync(languageCode);

            var headerSidePanelItems = new List<HeaderSidePanelComponentDto>
            {
                new HeaderSidePanelComponentDto
                {
                    CompanyInfos = companyInfo.Result,
                    SidePanels = sidePanel.Result
                }
            };
            return headerSidePanelItems;
        }
    }
}
