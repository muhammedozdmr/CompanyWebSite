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
    public class FooterService : IFooterService
    {
        private readonly IBaseRepository<Footer> _baseFooterRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public FooterService(IBaseRepository<Footer> baseFooterRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _baseFooterRepository = baseFooterRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<FooterDto>> GetFooterAllAsync(string languageCode)
        {

            var footers = await _baseFooterRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var footerDtosMap = _mapper.Map<IEnumerable<FooterDto>>(footers);
                return footerDtosMap;
            }

            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var footerDtos = _mapper.Map<IEnumerable<FooterDto>>(footers).ToList();
            foreach (var footerDto in footerDtos)
            {
                var footerTranslations = await _translationService.GetTranslationAsync("Footer", footerDto.Id, language.Code);
                foreach (var footerTranslation in footerTranslations)
                {
                    if (footerTranslation.Key == "CompanyInfoTitle")
                    {
                        footerDto.CompanyInfoTitle = footerTranslation.Value;
                    }
                    else if (footerTranslation.Key == "NewsletterTitle")
                    {
                        footerDto.NewsletterTitle = footerTranslation.Value;
                    }
                    else if (footerTranslation.Key == "NewsletterPlaceholder")
                    {
                        footerDto.NewsletterPlaceholder = footerTranslation.Value;
                    }
                    else if (footerTranslation.Key == "QuickLinksTitle")
                    {
                        footerDto.QuickLinksTitle = footerTranslation.Value;
                    }
                }
            }
            return footerDtos;
        }
    }
}
