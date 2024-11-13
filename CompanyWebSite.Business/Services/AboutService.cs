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

        public AboutService(IBaseRepository<About> baseAboutRepository, IBaseRepository<History> baseHistoryRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
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
            about.Slug = SlugHelper.GenerateSlug(aboutDto.DefaultTitle);
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
                var aboutDtosMap = _mapper.Map<IEnumerable<AboutDto>>(abouts);
                var historyMap = _mapper.Map<IEnumerable<HistoryDto>>(histories);
                foreach (var aboutDto in aboutDtosMap)
                {
                    aboutDto.Histories = historyMap;
                }
                return aboutDtosMap;

            }
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var aboutDtos = _mapper.Map<IEnumerable<AboutDto>>(abouts).ToList();
            var historyDtos = _mapper.Map<IEnumerable<HistoryDto>>(histories).ToList();
            foreach (var aboutDto in aboutDtos)
            {
                var aboutTranslations = await _translationService.GetTranslationAsync("About", aboutDto.Id, language.Code);
                foreach (var aboutTranslation in aboutTranslations)
                {
                    if (aboutTranslation.Key == "DefaultTitle")
                    {
                        aboutDto.DefaultTitle = aboutTranslation.Value;
                    }
                    else if (aboutTranslation.Key == "DefaultContent")
                    {
                        aboutDto.DefaultContent = aboutTranslation.Value;
                    }
                    else if(aboutTranslation.Key == "Summary")
                    {
                        aboutDto.Summary = aboutTranslation.Value;
                    }
                }
                var translatedHistories = new List<HistoryDto>();

                foreach (var historyDto in historyDtos)
                {
                    var historyTranslations = await _translationService.GetTranslationAsync("History", aboutDto.Id, language.Code);

                    foreach (var historyTranslation in historyTranslations)
                    {
                        if (historyTranslation.Key == "DefaultTitle")
                        {
                            historyDto.DefaultTitle = historyTranslation.Value;
                        }
                        else if (historyTranslation.Key == "DefaultContent")
                        {
                            historyDto.DefaultContent = historyTranslation.Value;
                        }
                        else if (historyTranslation.Key == "YearDescription")
                        {
                            historyDto.YearDescription = historyTranslation.Value;
                        }
                    }
                    translatedHistories.Add(historyDto);
                }
                aboutDto.Histories = translatedHistories;
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
                // About'u güncelle
                _mapper.Map(aboutDto, about);
                await _baseAboutRepository.UpdateAsync(about);

                // Histories güncellemesi
                foreach (var historyDto in aboutDto.Histories)
                {
                    var history = await _baseHistoryRepository.GetByIdAsync(historyDto.Id);
                    if (history != null)
                    {
                        _mapper.Map(historyDto, history);
                        await _baseHistoryRepository.UpdateAsync(history);
                    }
                    else
                    {
                        // Yeni History ekleme işlemi
                        var newHistory = _mapper.Map<History>(historyDto);
                        await _baseHistoryRepository.AddAsync(newHistory);
                    }
                }
            }
        }

    }
}
