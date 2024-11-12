using CompanyWebSite.Dto;

namespace CompanyWebSite.Business.Services.Interface;

public interface IContactFormService
{
    Task<IEnumerable<ContactFormDto>> GetContactFormAllAsync(string languageCode);
    Task<ContactFormDto> GetContactFormByIdAsync(int id);
    Task AddContactFormAsync(ContactFormDto contactFormDto);
    Task UpdateContactFormAsync(ContactFormDto contactFormDto);
    Task DeleteContactFormAsync(int id);
}
