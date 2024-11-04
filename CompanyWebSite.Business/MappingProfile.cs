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
            .ForMember(dest => dest.DefaultTitleAbout, opt => opt.MapFrom(src => src.DefaultTitle))
            .ForMember(dest => dest.DefaultContentAbout, opt => opt.MapFrom(src => src.DefaultContent))
            .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
            .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Slug))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary))
            .ForMember(dest => dest.ButtonName, opt => opt.Ignore()) // ButtonName dışarıdan atanabilir
            .ForMember(dest => dest.CustomerCount, opt => opt.Ignore()) // Varsayılan olarak 15 olacak
            .ForMember(dest => dest.CustomerSatisfaction, opt => opt.Ignore()); // Varsayılan olarak 100 olacakReverseMap();

            CreateMap<History, AboutDto>()
                .ForMember(dest => dest.DefaultTitleHistory, opt => opt.MapFrom(src => src.DefaultTitle))
                .ForMember(dest => dest.DefaultContentHistory, opt => opt.MapFrom(src => src.DefaultContent))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.Year))
                .ForMember(dest => dest.YearDescription, opt => opt.MapFrom(src => src.YearDescription))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

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
