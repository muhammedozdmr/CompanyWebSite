using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services;

public class NavbarItemService : INavbarItemService
{
    private readonly IBaseRepository<NavbarItem> _baseNavbarItemRepository;
    private readonly ILanguageRepository _languageRepository;
    private readonly ITranslationService _translationService;
    private readonly IMapper _mapper;

    public NavbarItemService
    (
        IBaseRepository<NavbarItem> baseNavbarItemRepository
        , ILanguageRepository languageRepository
        , ITranslationService translationService
        , IMapper mapper
    )
    {
        _mapper = mapper;
        _baseNavbarItemRepository = baseNavbarItemRepository;
        _languageRepository = languageRepository;
        _translationService = translationService;
    }  
    public async Task<IEnumerable<NavbarItemDto>> GetNavbarItemAllAsync(string languageCode)
    {
        var navbarItems = await _baseNavbarItemRepository.GetAllAsync();
        if(languageCode == "tr")
        {
            var navbarItemDtos = _mapper.Map<IEnumerable<NavbarItemDto>>(navbarItems);
            return navbarItemDtos;
        }
        
        var language = await _languageRepository.GetByCodeAsync(languageCode);
        if(language == null)
        {
            throw new Exception("Language not found");
        }
        
        var navbarItemDtosMap = _mapper.Map<IEnumerable<NavbarItemDto>>(navbarItems);
        foreach (var navbarItemDto in navbarItemDtosMap)
        {
            var navbarItemTranslation = await _translationService.GetTranslationAsync("NavbarItem", navbarItemDto.Id, language.Code);
            foreach (var translation in navbarItemTranslation)
            {
                if (translation.Key == "Name")
                {
                    navbarItemDto.Name = translation.Value;
                }
            }
        }
        return navbarItemDtosMap;
    }

    public async Task<NavbarItemDto> GetNavbarItemByIdAsync(int id)
    {
        var navbarItem = await _baseNavbarItemRepository.GetByIdAsync(id);
        var navbarItemDto = _mapper.Map<NavbarItemDto>(navbarItem);
        return navbarItemDto;
    }

    public async Task AddNavbarItemAsync(NavbarItemDto navbarItemDto)
    {
        var navbarItem = _mapper.Map<NavbarItem>(navbarItemDto);
        await _baseNavbarItemRepository.AddAsync(navbarItem);
    }

    public async Task UpdateNavbarItemAsync(NavbarItemDto navbarItemDto)
    {
        var navbarItem = _mapper.Map<NavbarItem>(navbarItemDto);
        await _baseNavbarItemRepository.UpdateAsync(navbarItem);
    }

    public async Task DeleteNavbarItemAsync(int id)
    {
        await _baseNavbarItemRepository.DeleteAsync(id);
    }
}
