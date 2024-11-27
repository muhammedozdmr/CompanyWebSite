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
    public class BlogService : IBlogService
    {
        private readonly IBaseRepository<Blog> _baseBlogRepository;
        public readonly IBaseRepository<BlogCategory> _baseBlogCategoryRepository;
        private readonly IBaseRepository<Page> _basePageRepository;
        private readonly ITranslationService _translationService;
        private readonly ILanguageRepository _languageRepository;
        private IMapper _mapper;
        public BlogService(IBaseRepository<Blog> baseBlogRepository, IBaseRepository<BlogCategory> baseBlogCategoryRepository, ITranslationService translationService, ILanguageRepository languageRepository, IMapper mapper, IBaseRepository<Page> basePageRepository)
        {
            _baseBlogRepository = baseBlogRepository;
            _baseBlogCategoryRepository = baseBlogCategoryRepository;
            _translationService = translationService;
            _languageRepository = languageRepository;
            _mapper = mapper;
            _basePageRepository = basePageRepository;
        }
        public async Task AddBlogAsync(BlogDto blogDto)
        {
            var blog = _mapper.Map<Blog>(blogDto);
            blog.Slug = SlugHelper.GenerateSlug(blogDto.DefaultTitle);
            await _baseBlogRepository.AddAsync(blog);

        }

        public async Task DeleteBlogAsync(int id)
        {
            await _baseBlogRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<BlogDto>> GetBlogAllAsync(string languageCode)
        {
            var blogs = await _baseBlogRepository.GetAllAsync();
            var blogCategories = await _baseBlogCategoryRepository.GetAllAsync();
            var pagesAll = await _basePageRepository.GetAllAsync();
            if (languageCode == "tr")
            {
                var blogDtosMap = _mapper.Map<IEnumerable<BlogDto>>(blogs);
                var blogCategoryMap = _mapper.Map<IEnumerable<BlogCategoryDto>>(blogCategories);
                var pageMap = _mapper.Map<IEnumerable<PageDto>>(pagesAll);
                foreach (var blogDto in blogDtosMap)
                {
                    blogDto.Categories = blogCategoryMap;
                    blogDto.Pages = pageMap.Where(x => x.Id == 3).ToList();
                }
                return blogDtosMap;
            }
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }
            var blogDtos = _mapper.Map<IEnumerable<BlogDto>>(blogs).ToList();
            var blogCategoryDtos = _mapper.Map<IEnumerable<BlogCategoryDto>>(blogCategories).ToList();
            foreach (var blogDto in blogDtos)
            {
                var blogTranslations = await _translationService.GetTranslationAsync("Blog", blogDto.Id, language.Code);
                foreach (var blogTranslation in blogTranslations)
                {
                    switch (blogTranslation.Key)
                    {
                        case "DefaultTitle":
                            blogDto.DefaultTitle = blogTranslation.Value;
                            break;
                        case "DefaultContent":
                            blogDto.DefaultContent = blogTranslation.Value;
                            break;
                    }
                }

                //Page çevirileri
                var pageTranslations = await _translationService.GetTranslationAsync("Page", 3, language.Code);
                var pageDto = new PageDto
                {
                    Id = 3
                };
                foreach (var pageTranslation in pageTranslations)
                {


                    switch (pageTranslation.Key)
                    {
                        case "PageContentTitle":
                            pageDto.PageContentTitle = pageTranslation.Value;
                            break;
                        case "PageHeaderTitle":
                            pageDto.PageHeaderTitle = pageTranslation.Value;
                            break;
                        case "PageHeaderSubtitle":
                            pageDto.PageHeaderSubtitle = pageTranslation.Value;
                            break;
                    }
                }
                blogDto.Pages = new List<PageDto> { pageDto };

                var translatedBlogCategories = new List<BlogCategoryDto>();
                foreach (var blogCategoryDto in blogCategoryDtos)
                {
                    var blogCategoryTranslations = await _translationService.GetTranslationAsync("BlogCategory", blogCategoryDto.Id, language.Code);
                    foreach (var blogCategoryTranslation in blogCategoryTranslations)
                    {
                        if (blogCategoryTranslation.Key == "Name")
                        {
                            blogCategoryDto.Name = blogCategoryTranslation.Value;
                        }
                    }
                    translatedBlogCategories.Add(blogCategoryDto);
                }
                blogDto.Categories = translatedBlogCategories;
            }
            return blogDtos;
        }

        public async Task<BlogDto> GetBlogByIdAsync(string languageCode, int id)
        {
            // Blog nesnesini veri tabanından al
            var blog = await _baseBlogRepository.GetByIdAsync(id);
            var pagesAll = await _basePageRepository.GetAllAsync();
            var blogPages = pagesAll.Where(x => x.Id == 4).ToList();
            // Eğer dil Türkçe ise, doğrudan mapper ile dön
            if (languageCode == "tr")
            {
                var blogDtoMap = _mapper.Map<BlogDto>(blog);
                blogDtoMap.Pages = _mapper.Map<List<PageDto>>(blogPages);
                return blogDtoMap;
            }

            // İlgili dil kodunu kontrol et
            var language = await _languageRepository.GetByCodeAsync(languageCode);
            if (language == null)
            {
                throw new Exception("Language not found");
            }

            // Blog nesnesini DTO'ya map et
            var blogDto = _mapper.Map<BlogDto>(blog);

            // Çeviriler için TranslationService'i kullan
            var blogTranslations = await _translationService.GetTranslationAsync("Blog", blogDto.Id, language.Code);
            foreach (var blogTranslation in blogTranslations)
            {
                if (blogTranslation.Key == "DefaultTitle")
                {
                    blogDto.DefaultTitle = blogTranslation.Value;
                }
                else if (blogTranslation.Key == "DefaultContent")
                {
                    blogDto.DefaultContent = blogTranslation.Value;
                }
            }
            var pageTranslations = await _translationService.GetTranslationAsync("Page", 4, language.Code);
            var pageDto = new PageDto
            {
                Id = 4
            };
            foreach (var pageTranslation in pageTranslations)
            {
                
                switch (pageTranslation.Key)
                {
                    case "PageContentTitle":
                        pageDto.PageContentTitle = pageTranslation.Value;
                        break;
                    case "PageHeaderTitle":
                        pageDto.PageHeaderTitle = pageTranslation.Value;
                        break;
                    case "PageHeaderSubtitle":
                        pageDto.PageHeaderSubtitle = pageTranslation.Value;
                        break;
                }
            }
            blogDto.Pages = new List<PageDto> { pageDto };

            return blogDto;
        }


        public async Task UpdateBlogAsync(BlogDto blogDto)
        {
            var blog = await _baseBlogRepository.GetByIdAsync(blogDto.Id);
            if (blog != null)
            {
                _mapper.Map(blogDto, blog);
                await _baseBlogRepository.UpdateAsync(blog);

                foreach (var blogCategory in blogDto.Categories)
                {
                    var blogCategoryEntity = await _baseBlogCategoryRepository.GetByIdAsync(blogCategory.Id);
                    if (blogCategoryEntity != null)
                    {
                        _mapper.Map(blogCategory, blogCategoryEntity);
                        await _baseBlogCategoryRepository.UpdateAsync(blogCategoryEntity);
                    }
                    else
                    {
                        var newCategory = _mapper.Map<BlogCategory>(blogCategory);
                        await _baseBlogCategoryRepository.AddAsync(newCategory);
                    }
                }
            }
        }
    }
}
