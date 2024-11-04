using AutoMapper;
using CompanyWebSite.Business.Helpers;
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
    public class AboutService : IAboutService
    {
        private readonly IBaseRepository<About> _baseAboutRepository;
        private readonly IBaseRepository<History> _baseHistoryRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public AboutService(IBaseRepository<About> baseAboutRepository,IBaseRepository<History> baseHistoryRepository,ILanguageRepository languageRepository,ITranslationService translationService, IMapper mapper)
        {
            _mapper = mapper;
            _baseAboutRepository = baseAboutRepository;
            _baseHistoryRepository = baseHistoryRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
        }
        public async Task AddAboutAsync(AboutDto aboutDto)
        {
            var about = _mapper.Map<About>(aboutDto);
            about.Slug = SlugHelper.GenerateSlug(aboutDto.DefaultTitleAbout);
            await _baseAboutRepository.AddAsync(about);
        }

        public async Task DeleteAboutAsync(int id)
        {
            await _baseAboutRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<AboutDto>> GetAboutAllAsync(string languageCode)
        {
            var abouts = await _baseAboutRepository.GetAllAsync();
            var histories = await _baseHistoryRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var aboutDtosMap = _mapper.Map<IEnumerable<AboutDto>>(abouts).ToList();
                foreach (var aboutDto in aboutDtosMap)
                {
                    var history=histories.FirstOrDefault(x => x.AboutId == aboutDto.Id);
                    if (history != null)
                    {
                        aboutDto.DefaultTitleHistory = history.DefaultTitle;
                        aboutDto.DefaultContentHistory = history.DefaultContent;
                        aboutDto.YearDescription = history.YearDescription;
                    }
                }
                return aboutDtosMap;

            }
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if(language == null)
            {
                throw new Exception("Language not found");
            }
            var aboutDtos = _mapper.Map<IEnumerable<AboutDto>>(abouts);
            foreach (var aboutDto in aboutDtos)
            {
                var aboutTranslations = await _translationService.GetTranslationAsync("About", aboutDto.Id, language.Code);
                foreach (var aboutTranslation in aboutTranslations)
                {
                    if (aboutTranslation.Key == "DefaultTitle")
                    {
                        aboutDto.DefaultTitleAbout = aboutTranslation.Value;
                    }
                    else if (aboutTranslation.Value == "DefaultContent")
                    {
                        aboutDto.DefaultContentAbout = aboutTranslation.Value;
                    }
                }
                var historyTranslations = await _translationService.GetTranslationAsync("History", aboutDto.Id, language.Code);
                foreach (var historyTranslation in historyTranslations)
                {
                    if(historyTranslation.Key == "DefaultTitle")
                    {
                        aboutDto.DefaultTitleHistory = historyTranslation.Value;
                    }
                    else if (historyTranslation.Key == "DefaultContent")
                    {
                        aboutDto.DefaultContentHistory = historyTranslation.Value;
                    }
                    else if(historyTranslation.Key == "YearDescription")
                    {
                        aboutDto.YearDescription = historyTranslation.Value;
                    }
                }
            }
            return aboutDtos;
        }

        public async Task<AboutDto> GetAboutByIdAsync(int id)
        {
            var about = await _baseAboutRepository.GetByIdAsync(id);
            return _mapper.Map<AboutDto>(about);
        }

        public async Task UpdateAboutAsync(AboutDto aboutDto)
        {
           var about = await _baseAboutRepository.GetByIdAsync(aboutDto.Id);
            if (about != null)
            {
               _mapper.Map(aboutDto, about);
                await _baseAboutRepository.UpdateAsync(about);
            }
        }
    }
}
