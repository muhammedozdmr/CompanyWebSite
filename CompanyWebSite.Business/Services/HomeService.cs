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
    public class HomeService : IHomeService
    {
        private readonly IAboutService _homeAboutService;
        private readonly IServiceService _homeServiceService;
        private readonly IFAQService _homeFaqService;
        public HomeService(ILanguageRepository languageRepository, IAboutService homeAboutService, IServiceService homeServiceService, IFAQService homeFaqService, ITranslationService translationService)
        {
            _homeAboutService = homeAboutService;
            _homeServiceService = homeServiceService;
            _homeFaqService = homeFaqService;
        }
        public async Task<IEnumerable<HomeDto>> GetHomeAllAsync(string languageCode)
        {
            var homeAbouts = await _homeAboutService.GetAboutAllAsync(languageCode);
            var homeServices = await _homeServiceService.GetServiceAllAsync(languageCode);
            var homeFAQs = await _homeFaqService.GetFAQAllAsync(languageCode);
            var homeItems = new List<HomeDto>
            {
                new HomeDto
                {
                About = homeAbouts,
                Services = homeServices,
                FQ = homeFAQs,
                ButtonName = homeAbouts.FirstOrDefault()?.DefaultTitle ?? "About Us",
                CustomerCount = 100,
                CustomerSatisfaction = 100
                }
            };
            return homeItems;
        }
    }
}
