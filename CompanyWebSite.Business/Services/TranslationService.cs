using CompanyWebSite.Business.Repository.Interface;
using CompanyWebSite.Business.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services
{
    public class TranslationService : ITranslationService
    {
        private readonly ITranslationRepository _translationRepository;
        public TranslationService(ITranslationRepository translationRepository)
        {
            _translationRepository = translationRepository;
        }
        public async Task<Dictionary<string, string>> GetTranslationAsync(string entityName, int entityId, string languageCode)
        {
            var translations = await _translationRepository.GetTranslationsAsync(entityName, entityId, languageCode);
            return translations.ToDictionary(t => t.Key, t => t.Value);
        }
    }
}
