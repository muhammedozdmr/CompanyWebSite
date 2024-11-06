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
    public class FAQService : IFAQService
    {
        private readonly IBaseRepository<FAQ> _baseFAQRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public FAQService(IBaseRepository<FAQ> baseFAQRepository,ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _baseFAQRepository = baseFAQRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
        }
        public async Task AddFAQAsync(FAQDto faqDto)
        {
            var faq = _mapper.Map<FAQ>(faqDto);
            faq.Slug = SlugHelper.GenerateSlug(faqDto.Question);
            await _baseFAQRepository.AddAsync(faq);
        }

        public async Task DeleteFAQAsync(int id)
        {
            await _baseFAQRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<FAQDto>> GetFAQAllAsync(string languageCode)
        {
            var faqs = await _baseFAQRepository.GetAllAsync();
            if (languageCode == "tr")
            {
               var faqDtosMap = _mapper.Map<IEnumerable<FAQDto>>(faqs);
               return faqDtosMap;
            }
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var faqDtos = _mapper.Map<IEnumerable<FAQDto>>(faqs);
            foreach (var faqDto in faqDtos)
            {
                var faqTranslations = await _translationService.GetTranslationAsync("FAQ",faqDto.Id, language.Code);
                foreach(var faqTranslation in faqTranslations)
                {
                    if(faqTranslation.Key == "Question")
                    {
                        faqDto.Question = faqTranslation.Value;
                    }
                    else if(faqTranslation.Value == "Answer")
                    {
                        faqDto.Answer = faqTranslation.Value;
                    }
                }
            }
            return faqDtos;
        }

        public async Task<FAQDto> GetFAQByIdAsync(int id)
        {
            var faq = await _baseFAQRepository.GetByIdAsync(id);
            return _mapper.Map<FAQDto>(faq);
        }

        public async Task UpdateFAQAsync(FAQDto fAQDto)
        {
            var faq = await _baseFAQRepository.GetByIdAsync(fAQDto.Id);
            if (faq != null)
            {
                _mapper.Map(fAQDto, faq);
                await _baseFAQRepository.UpdateAsync(faq);
            }
            else
            {
                throw new Exception("FAQ not found");
            }
        }
    }
}
