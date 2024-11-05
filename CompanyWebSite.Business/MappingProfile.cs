using AutoMapper;
using CompanyWebSite.Domain.Entities;
using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<About, AboutDto>()
            .ForMember(dest => dest.DefaultTitle, opt => opt.MapFrom(src => src.DefaultTitle))
            .ForMember(dest => dest.DefaultContent, opt => opt.MapFrom(src => src.DefaultContent))
            .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.IsActive))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary))
            .ForMember(dest => dest.ButtonName, opt => opt.Ignore()) // ButtonName dışarıdan atanabilir
            .ForMember(dest => dest.CustomerCount, opt => opt.Ignore()) // Varsayılan olarak 15 olacak
            .ForMember(dest => dest.CustomerSatisfaction, opt => opt.Ignore())// Varsayılan olarak 100 olacak
            .ForMember(dest => dest.CompanyInfoId, opt => opt.MapFrom(src => src.CompanyInfoId)).ReverseMap();
            CreateMap<History, HistoryDto>().ReverseMap();
            CreateMap<Blog, BlogDto>().ReverseMap();
            CreateMap<BlogCategory, BlogCategoryDto>().ReverseMap();
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<ServiceCategory, ServiceCategoryDto>().ReverseMap();
            CreateMap<Media, MediaDto>().ReverseMap();
            CreateMap<Highlight, HighlightDto>().ReverseMap();
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<FAQ, FAQDto>().ReverseMap();
            CreateMap<Language, LanguageDto>().ReverseMap();
            CreateMap<Translation, TranslationDto>().ReverseMap();
        }
    }
}
