using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services;

public class NewsletterService : INewsletterService
{
    private readonly IBaseRepository<Newsletter> _baseNewsletterRepository;
    private readonly ILanguageRepository _languageRepository;
    private readonly ITranslationService _translationService;
    private readonly IMapper _mapper;

    public NewsletterService(IBaseRepository<Newsletter> baseNewsletterRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
    {
        _baseNewsletterRepository = baseNewsletterRepository;
        _languageRepository = languageRepository;
        _translationService = translationService;
        _mapper = mapper;
    }
    public async Task<IEnumerable<NewsletterDto>> GetNewsletterAllAsync(string languageCode)
    {
        var newsletters = await _baseNewsletterRepository.GetAllAsync();
        var newsletterDtos = _mapper.Map<IEnumerable<NewsletterDto>>(newsletters);
        return newsletterDtos;
    }

    public async Task<NewsletterDto> GetNewsletterByIdAsync(int id)
    {
        var newsletter = await _baseNewsletterRepository.GetByIdAsync(id);
        var newsletterDto = _mapper.Map<NewsletterDto>(newsletter);
        return newsletterDto;
    }

    public async Task AddNewsletterAsync(NewsletterDto newsletterDto)
    {
        var newsletter = _mapper.Map<Newsletter>(newsletterDto);
        await _baseNewsletterRepository.AddAsync(newsletter);
    }

    public async Task UpdateNewsletterAsync(NewsletterDto newsletterDto)
    {
        var newsletter = _mapper.Map<Newsletter>(newsletterDto);
        await _baseNewsletterRepository.UpdateAsync(newsletter);
    }

    public async Task DeleteNewsletterAsync(int id)
    {
        await _baseNewsletterRepository.DeleteAsync(id);
    }
}
