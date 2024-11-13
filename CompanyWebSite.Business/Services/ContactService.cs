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
            return contactDto;
        }

        public async Task AddContactAsync(ContactFormDto contactFormDto)
        {
            await _contactFormService.AddContactFormAsync(contactFormDto);
        }
    }
}
