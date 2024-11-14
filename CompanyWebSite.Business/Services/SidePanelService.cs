using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class SidePanelService : ISidePanelService
    {
        private readonly IBaseRepository<SidePanel> _baseSidePanelRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public SidePanelService(IBaseRepository<SidePanel> baseSidePanelRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _baseSidePanelRepository = baseSidePanelRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SidePanelDto>> GetSidePanelAllAsync(string languageCode)
        {
            var sidePanels = await _baseSidePanelRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var sidePanelDtosMap = _mapper.Map<IEnumerable<SidePanelDto>>(sidePanels);
                return sidePanelDtosMap;
            }
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var sidePanelDtos = _mapper.Map<IEnumerable<SidePanelDto>>(sidePanels).ToList();

            foreach (var sidePanelDto in sidePanelDtos)
            {
                var sidePanelTranslations = await _translationService.GetTranslationAsync("SidePanel", sidePanelDto.Id, language.Code);
                foreach(var sidePanelTranslation in sidePanelTranslations)
                {
                    if (sidePanelTranslation.Key == "SidePanelMainTitle")
                    {
                        sidePanelDto.SidePanelMainTitle = sidePanelTranslation.Value;
                    }
                    if (sidePanelTranslation.Key == "SidePanelMainContent")
                    {
                        sidePanelDto.SidePanelMainContent = sidePanelTranslation.Value;
                    }
                    if (sidePanelTranslation.Key == "SidePanelContactTitle")
                    {
                        sidePanelDto.SidePanelContactTitle = sidePanelTranslation.Value;
                    }
                    if (sidePanelTranslation.Key == "SidePanelContactContent")
                    {
                        sidePanelDto.SidePanelContactContent = sidePanelTranslation.Value;
                    }
                }
            }
            return sidePanelDtos;
        }
    }
}
