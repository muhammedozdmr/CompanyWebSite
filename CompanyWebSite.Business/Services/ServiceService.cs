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
    public class ServiceService : IServiceService
    {
        private readonly IBaseRepository<Service> _baseServiceRepository;
        private readonly IBaseRepository<ServiceCategory> _baseServiceCategoryRepository;
        private readonly IBaseRepository<Media> _baseMediaRepository;
        private readonly IBaseRepository<Highlight> _baseHighlightRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public ServiceService(IBaseRepository<Service> baseServiceRepository, IBaseRepository<ServiceCategory> baseServiceCategoryRepository, IBaseRepository<Media> baseMediaRepository, IBaseRepository<Highlight> baseHighlightRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _mapper = mapper;
            _baseServiceRepository = baseServiceRepository;
            _baseServiceCategoryRepository = baseServiceCategoryRepository;
            _baseMediaRepository = baseMediaRepository;
            _baseHighlightRepository = baseHighlightRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
        }
        public async Task AddServiceAsync(ServiceDto serviceDto)
        {
            var service = _mapper.Map<Service>(serviceDto);
            service.Slug = SlugHelper.GenerateSlug(serviceDto.DefaultTitle);
            await _baseServiceRepository.AddAsync(service);
        }

        public async Task DeleteServiceAsync(int id)
        {
            await _baseServiceRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ServiceDto>> GetServiceAllAsync(string languageCode)
        {
            var services = await _baseServiceRepository.GetAllAsync();
            var serviceCategories = await _baseServiceCategoryRepository.GetAllAsync();
            var medias = await _baseMediaRepository.GetAllAsync();
            var highlights = await _baseHighlightRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var serviceDtosMap = _mapper.Map<IEnumerable<ServiceDto>>(services);
                var serviceCategoryMap = _mapper.Map<IEnumerable<ServiceCategoryDto>>(serviceCategories);
                var mediaMap = _mapper.Map<IEnumerable<MediaDto>>(medias);
                var highlightMap = _mapper.Map<IEnumerable<HighlightDto>>(highlights);
                foreach (var serviceDto in serviceDtosMap)
                {
                    serviceDto.ServiceCategories = serviceCategoryMap;
                    serviceDto.ServiceMediaItems = mediaMap;
                    serviceDto.ServiceHighlights = highlightMap;
                }
                return serviceDtosMap;
            }

            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var serviceDtos = _mapper.Map<IEnumerable<ServiceDto>>(services).ToList();
            var serviceCategoryDtos = _mapper.Map<IEnumerable<ServiceCategoryDto>>(serviceCategories).ToList();
            var mediaDtos = _mapper.Map<IEnumerable<MediaDto>>(medias).ToList();
            var highlightDtos = _mapper.Map<IEnumerable<HighlightDto>>(highlights).ToList();
            foreach (var serviceDto in serviceDtos)
            {
                var serviceTranslations = await _translationService.GetTranslationAsync("Service", serviceDto.Id, language.Code);
                foreach (var serviceTranslation in serviceTranslations)
                {
                    if (serviceTranslation.Key == "DefaultTitle")
                    {
                        serviceDto.DefaultTitle = serviceTranslation.Value;
                    }
                    else if (serviceTranslation.Value == "DefaultContent")
                    {
                        serviceDto.DefaultContent = serviceTranslation.Value;
                    }
                    else if (serviceTranslation.Value == "Summary")
                    {
                        serviceDto.Summary = serviceTranslation.Value;
                    }
                }

                var translatedServiceCategories = new List<ServiceCategoryDto>();
                var traslatedHighlights = new List<HighlightDto>();
                foreach (var serviceCategoryDto in serviceCategoryDtos)
                {
                    var serviceCategoryTranslations = await _translationService.GetTranslationAsync("ServiceCategory", serviceCategoryDto.Id, language.Code);
                    foreach (var serviceCategoryTranslation in serviceCategoryTranslations)
                    {
                        if (serviceCategoryTranslation.Key == "Name")
                        {
                            serviceCategoryDto.Name = serviceCategoryTranslation.Value;
                        }
                    }
                    translatedServiceCategories.Add(serviceCategoryDto);
                }
                foreach(var highlightDto in highlightDtos)
                {
                    var highlightTranslations = await _translationService.GetTranslationAsync("Highlight", highlightDto.Id, language.Code);
                    foreach (var highlightTranslation in highlightTranslations)
                    {
                        if (highlightTranslation.Key == "Content")
                        {
                            highlightDto.Content = highlightTranslation.Value;
                        }
                    }
                    traslatedHighlights.Add(highlightDto);
                }
                serviceDto.ServiceCategories = translatedServiceCategories;
                serviceDto.ServiceHighlights = traslatedHighlights;
            }
            return serviceDtos;
        }


        //TODO: Devam et
        public Task<ServiceDto> GetServiceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(ServiceDto serviceDto)
        {
            throw new NotImplementedException();
        }
    }
}
