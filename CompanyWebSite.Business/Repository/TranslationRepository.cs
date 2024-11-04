using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.DataAccess;
using CompanyWebSite.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Repository
{
    public class TranslationRepository : ITranslationRepository
    {
        private readonly CompanyWebSiteContext _context;
        public TranslationRepository(CompanyWebSiteContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Translation>> GetTranslationsAsync(string entityName, int entityId, string languageCode)
        {
            return await _context.Translations.Include(t => t.Language).Where(x => x.EntityName == entityName && x.EntityId == entityId && x.Language.Code == languageCode).ToListAsync();
        }
    }
}
