using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IContactService
    {
        Task<IEnumerable<ContactDto>> GetContactAllAsync(string languageCode);
        Task AddContactAsync(ContactFormDto contactDto);
    }
}
