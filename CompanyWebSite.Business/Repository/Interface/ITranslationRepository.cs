using CompanyWebSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Repository.Interface
{
    public interface ITranslationRepository
    {
        Task<IEnumerable<Translation>> GetTranslationsAsync(string entityName, int entityId, string languageCode);
    }
}
