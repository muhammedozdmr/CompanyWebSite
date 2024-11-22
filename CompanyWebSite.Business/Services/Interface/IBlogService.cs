using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IBlogService
    {
        Task<IEnumerable<BlogDto>> GetBlogAllAsync(string languageCode);
        Task<BlogDto> GetBlogByIdAsync(string languageCode,int id);
        Task AddBlogAsync(BlogDto blogDto);
        Task UpdateBlogAsync(BlogDto blogDto);
        Task DeleteBlogAsync(int id);
    }
}
