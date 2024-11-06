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
        private readonly ITranslationService _translationService;
        private readonly ILanguageRepository _languageRepository;
        private IMapper _mapper;
        public BlogService(IBaseRepository<Blog> baseBlogRepository, IBaseRepository<BlogCategory> baseBlogCategoryRepository, ITranslationService translationService, ILanguageRepository languageRepository, IMapper mapper)
        {
            _baseBlogRepository = baseBlogRepository;
            _baseBlogCategoryRepository = baseBlogCategoryRepository;
            _translationService = translationService;
            _languageRepository = languageRepository;
            _mapper = mapper;
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
            if (languageCode == "tr")
            {
                var blogDtosMap = _mapper.Map<IEnumerable<BlogDto>>(blogs);
                var blogCategoryMap = _mapper.Map<IEnumerable<BlogCategoryDto>>(blogCategories);
                foreach (var blogDto in blogDtosMap)
                {
                    blogDto.Categories = blogCategoryMap;
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
                    if (blogTranslation.Key == "DefaultTitle")
                    {
                        blogDto.DefaultTitle = blogTranslation.Value;
                    }
                    else if (blogTranslation.Value == "Default Content")
                    {
                        blogDto.DefaultContent = blogTranslation.Value;
                    }
                }
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

        public async Task<BlogDto> GetBlogByIdAsync(int id)
        {
            var blog = await _baseBlogRepository.GetByIdAsync(id);
            return _mapper.Map<BlogDto>(blog);
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
