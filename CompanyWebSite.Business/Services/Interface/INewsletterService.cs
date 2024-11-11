using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Interface;

public interface INewsletterService
{
    Task<IEnumerable<NewsletterDto>> GetNewsletterAllAsync(string languageCode);
    Task<NewsletterDto> GetNewsletterByIdAsync(int id);
    Task AddNewsletterAsync(NewsletterDto newsletterDto);
    Task UpdateNewsletterAsync(NewsletterDto newsletterDto);
    Task DeleteNewsletterAsync(int id);
}
