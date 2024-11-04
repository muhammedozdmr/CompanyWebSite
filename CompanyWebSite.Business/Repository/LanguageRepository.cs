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
    public class LanguageRepository : ILanguageRepository
    {
        private readonly CompanyWebSiteContext _context;
        public LanguageRepository(CompanyWebSiteContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Language>> GetAllAsync()
        {
            return await _context.Languages.ToListAsync();
        }

        public async Task<Language> GetByCodeAsync(string code)
        {
            return await _context.Languages.SingleOrDefaultAsync(x=>x.Code == code);
        }
    }
}
