using CompanyWebSite.Business.Services.Interface;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Domain.Entities;

namespace CompanyWebSite.Business.Services
{

    //TODO: Tamamlamayı unutma 
    public class CompanyInfoService : ICompanyInfoService
    {
        private readonly IBaseRepository<CompanyInfo> _baseCompanyInfoRepository;
        private readonly ILanguageRepository _languageRepository;
        private readonly ITranslationService _translationService;
        private readonly IMapper _mapper;

        public CompanyInfoService(IBaseRepository<CompanyInfo> baseCompanyInfoRepository, ILanguageRepository languageRepository, ITranslationService translationService, IMapper mapper)
        {
            _baseCompanyInfoRepository = baseCompanyInfoRepository;
            _languageRepository = languageRepository;
            _translationService = translationService;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CompanyInfoDto>> GetCompanyInfoAllAsync(string languageCode)
        {
            var companyInfos = await _baseCompanyInfoRepository.GetAllAsync();
            if(languageCode == "tr")
            {
                var companyInfoDtoMap = _mapper.Map<IEnumerable<CompanyInfoDto>>(companyInfos);
                return companyInfoDtoMap;
            }
            
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if(language == null)
            {
                throw new Exception("Language not found");
            }
            var companyInfoDtos = _mapper.Map<IEnumerable<CompanyInfoDto>>(companyInfos);
            foreach(var companyInfoDto in companyInfoDtos)
            {
                var companyInfoTranslations = await _translationService.GetTranslationAsync("CompanyInfo", companyInfoDto.Id, language.Code);
                foreach(var companyInfoTranslation in companyInfoTranslations)
                {
                    if (companyInfoTranslation.Key == "CompanyArea")
                    {
                        companyInfoDto.CompanyArea = companyInfoTranslation.Value;
                    }
                    else if (companyInfoTranslation.Key == "Residence")
                    {
                        companyInfoDto.Residence = companyInfoTranslation.Value;
                    }
                    else if (companyInfoTranslation.Key == "Address")
                    {
                        companyInfoDto.Address = companyInfoTranslation.Value;
                    }
                    else if(companyInfoTranslation.Key == "WorkingHours")
                    {
                        companyInfoDto.WorkingHours = companyInfoTranslation.Value;
                    }
                }
            }
            return companyInfoDtos;
        }

        public async Task<CompanyInfoDto> GetCompanyInfoByIdAsync(int id)
        {
            var companyInfo = await _baseCompanyInfoRepository.GetByIdAsync(id);
            var companyInfoDto = _mapper.Map<CompanyInfoDto>(companyInfo);
            return companyInfoDto;
        }

        public async Task AddCompanyInfoAsync(CompanyInfoDto companyInfoDto)
        {
            var companyInfo = _mapper.Map<CompanyInfo>(companyInfoDto);
            await _baseCompanyInfoRepository.AddAsync(companyInfo);
        }

        public async Task UpdateCompanyInfoAsync(CompanyInfoDto companyInfoDto)
        {
            var companyInfo = _mapper.Map<CompanyInfo>(companyInfoDto);
            await _baseCompanyInfoRepository.UpdateAsync(companyInfo);
        }

        public async Task DeleteCompanyInfoAsync(int id)
        {
            await _baseCompanyInfoRepository.DeleteAsync(id);
        }
    }
}
