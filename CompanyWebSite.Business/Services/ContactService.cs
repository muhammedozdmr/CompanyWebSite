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
        private readonly IBaseRepository<Page> _basePageRepository;

        public ContactService
        (
            IContactFormService contactFormService
            , ICompanyInfoService companyInfoService
            , ILanguageRepository languageRepository
            , ITranslationService translationService
            , IMapper mapper
            , IBaseRepository<Page> basePageRepository
        )
        {
            _contactFormService = contactFormService;
            _companyInfoService = companyInfoService;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
            _basePageRepository = basePageRepository;
        }


        public async Task<IEnumerable<ContactDto>> GetContactAllAsync(string languageCode)
        {
            var companyInfo = await _companyInfoService.GetCompanyInfoAllAsync(languageCode);
            var contactForm = await _contactFormService.GetContactFormAllAsync(languageCode);
            var pagesAll = await _basePageRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var pageMap = _mapper.Map<List<PageDto>>(pagesAll);
                var contactDtoTR = new List<ContactDto>
                {
                    new ContactDto
                    {
                        CompanyInfos = companyInfo, 
                        ContactForms = contactForm
                        , Pages = pageMap.Where(x => x.Id == 6 || x.Id == 8).ToList()
                    }
                };
                return contactDtoTR;
            }
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
                    case "PageContentTitle":
                        pageDto.PageContentTitle = pagesTranslation.Value;
                        break;
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

            var pagesForm = await _translationService.GetTranslationAsync("Page", 8, language.Code);
            var pageFormDto = new PageDto
            {
                Id = 8
            };
            foreach (var pagesTranslation in pagesForm)
            {
                switch (pagesTranslation.Key)
                {
                    case "PageContentTitle":
                        pageDto.PageContentTitle = pagesTranslation.Value;
                        break;
                    case "PageMainSlogan":
                        pageDto.PageMainSlogan = pagesTranslation.Value;
                        break;
                    case "PageSubSlogan":
                        pageDto.PageSubSlogan = pagesTranslation.Value;
                        break;
                }
            }

            contactDto[1].Pages = new List<PageDto> { pageFormDto };
            return contactDto;
        }


        public async Task AddContactAsync(ContactFormDto contactFormDto)
        {
            await _contactFormService.AddContactFormAsync(contactFormDto);
        }
    }
}
