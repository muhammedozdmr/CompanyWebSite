using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface ITranslationService
    {
        Task<Dictionary<string,string>> GetTranslationAsync(string entityName, int entityId, string languageCode);
    }
}
