using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services;

public class ContactFormService : IContactFormService
{
    private readonly IBaseRepository<ContactForm> _baseContactFormRepository;
    private readonly ILanguageRepository _languageRepository;
    private ITranslationService _translationService;
    private readonly IMapper _mapper;

    public ContactFormService(IBaseRepository<ContactForm> baseContactFormRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
    {
        _baseContactFormRepository = baseContactFormRepository;
        _languageRepository = languageRepository;
        _translationService = translationService;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ContactFormDto>> GetContactFormAllAsync(string languageCode)
    {
        var contactForms = await _baseContactFormRepository.GetAllAsync();
        if (languageCode == "tr")
        {
            var contactFormDtosMap = _mapper.Map<IEnumerable<ContactFormDto>>(contactForms);
            return contactFormDtosMap;
        }
        
        var language = await _languageRepository.GetByCodeAsync(languageCode);
        if (language == null)
        {
            throw new Exception("Language not found");
        }
        var contactFormDtos = _mapper.Map<IEnumerable<ContactFormDto>>(contactForms);
        foreach (var contactFormDto in contactFormDtos)
        {
           var contactFormPlaceHolderTranslations = await _translationService.GetTranslationAsync("ContactForm", contactFormDto.Id, language.Code);
           foreach(var contactFormPlaceHolderTranslation in contactFormPlaceHolderTranslations)
           {
               if (contactFormPlaceHolderTranslation.Key == "FullNamePlaceHolder")
               {
                   contactFormDto.DefaultFullNamePlaceholder = contactFormPlaceHolderTranslation.Value;
               }
               else if (contactFormPlaceHolderTranslation.Key == "EmailPlaceholder")
               {
                   contactFormDto.DefaultEmailPlaceholder = contactFormPlaceHolderTranslation.Value;
               }
               else if (contactFormPlaceHolderTranslation.Key == "PhonePlaceholder")
               {
                   contactFormDto.DefaultPhonePlaceholder = contactFormPlaceHolderTranslation.Value;
               }
               else if (contactFormPlaceHolderTranslation.Key == "SubjectPlaceholder")
               {
                   contactFormDto.DefaultSubjectPlaceholder = contactFormPlaceHolderTranslation.Value;
               }
               else if (contactFormPlaceHolderTranslation.Key == "MessagePlaceholder")
               {
                   contactFormDto.DefaultMessagePlaceholder = contactFormPlaceHolderTranslation.Value;
               }
               else if (contactFormPlaceHolderTranslation.Key == "SendButton")
               {
                   contactFormDto.DefaultSendButtonText = contactFormPlaceHolderTranslation.Value;
               }
           }
        }
        return contactFormDtos;
    }

    public async Task<ContactFormDto> GetContactFormByIdAsync(int id)
    {
        var contactForm = await _baseContactFormRepository.GetByIdAsync(id);
        var contactFormDto = _mapper.Map<ContactFormDto>(contactForm);
        return contactFormDto;
    }

    public async Task AddContactFormAsync(ContactFormDto contactFormDto)
    {
        var contactForm = _mapper.Map<ContactForm>(contactFormDto);
        await _baseContactFormRepository.AddAsync(contactForm);
    }

    public async Task UpdateContactFormAsync(ContactFormDto contactFormDto)
    {
        var contactForm = await _baseContactFormRepository.GetByIdAsync(contactFormDto.Id);
        if (contactForm != null)
        {
            contactForm = _mapper.Map<ContactForm>(contactFormDto);
            await _baseContactFormRepository.UpdateAsync(contactForm);
        }
        else
        {
            throw new Exception("ContactForm not found");
        }
    }

    public async Task DeleteContactFormAsync(int id)
    {
        await _baseContactFormRepository.DeleteAsync(id);
    }
}
