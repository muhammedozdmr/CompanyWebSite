using AutoMapper;
using Azure;
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
                // About çevirileri
                var aboutTranslations = await _translationService.GetTranslationAsync("About", aboutDto.Id, language.Code);
                foreach (var translation in aboutTranslations)
                {
                    switch (translation.Key)
                    {
                        case "DefaultTitle":
                            aboutDto.DefaultTitle = translation.Value;
                            break;
                        case "DefaultContent":
                            aboutDto.DefaultContent = translation.Value;
                            break;
                        case "Summary":
                            aboutDto.Summary = translation.Value;
                            break;
                        case "AboutSlogan":
                            aboutDto.AboutSlogan = translation.Value;
                            break;
                    }
                }

                // Page çevirileri
                var pages = await _translationService.GetTranslationAsync("Page", 1, language.Code);
                var pageDto = new PageDto
                {
                    Id = 1 // Her page için ID'yi belirtin
                };
                foreach (var pageTranslation in pages)
                {


                    switch (pageTranslation.Key)
                    {
                        case "PageHeaderTitle":
                            pageDto.PageHeaderTitle = pageTranslation.Value;
                            break;
                        case "PageHeaderSubtitle":
                            pageDto.PageHeaderSubtitle = pageTranslation.Value;
                            break;
                        case "PageMainSlogan":
                            pageDto.PageMainSlogan = pageTranslation.Value;
                            break;
                        case "PageSubSlogan":
                            pageDto.PageSubSlogan = pageTranslation.Value;
                            break;
                    }

                }
                aboutDto.Pages = new List<PageDto> { pageDto };

                // History çevirileri
                var translatedHistories = new List<HistoryDto>();
                foreach (var historyDto in historyDtos)
                {
                    var historyTranslations = await _translationService.GetTranslationAsync("History", aboutDto.Id, language.Code);

                    foreach (var translation in historyTranslations)
                    {
                        switch (translation.Key)
                        {
                            case "DefaultTitle":
                                historyDto.DefaultTitle = translation.Value;
                                break;
                            case "DefaultContent":
                                historyDto.DefaultContent = translation.Value;
                                break;
                            case "YearDescription":
                                historyDto.YearDescription = translation.Value;
                                break;
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
