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
    public class ContactService : IContactService
    {
        private readonly IContactFormService _contactFormService;
        private readonly ICompanyInfoService _companyInfoService;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public ContactService(IContactFormService contactFormService, ICompanyInfoService companyInfoService, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _contactFormService = contactFormService;
            _companyInfoService = companyInfoService;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ContactDto>> GetContactAllAsync(string languageCode)
        {
            var companyInfo = await _companyInfoService.GetCompanyInfoAllAsync(languageCode);
            var contactForm = await _contactFormService.GetContactFormAllAsync(languageCode);

            var contactDto = new List<ContactDto>
    {
        new ContactDto
        {
            CompanyInfos = companyInfo,
            ContactForms = contactForm
        }
    };

            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var pages = await _translationService.GetTranslationAsync("Page", 5, language.Code);
            var pageDto = new PageDto
            {
                Id = 5
            };
            foreach (var pagesTranslation in pages)
            {
                
                switch (pagesTranslation.Key)
                {
                    case "PageHeaderTitle":
                        pageDto.PageHeaderTitle = pagesTranslation.Value;
                        break;
                    case "PageHeaderSubtitle":
                        pageDto.PageHeaderSubtitle = pagesTranslation.Value;
                        break;
                    case "PageMainSlogan":
                        pageDto.PageMainSlogan = pagesTranslation.Value;
                        break;
                    case "PageSubSlogan":
                        pageDto.PageSubSlogan = pagesTranslation.Value;
                        break;
                }
            }
            contactDto[0].Pages = new List<PageDto> { pageDto};
            return contactDto;
        }


        public async Task AddContactAsync(ContactFormDto contactFormDto)
        {
            await _contactFormService.AddContactFormAsync(contactFormDto);
        }
    }
}
