using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Helpers
{
    public static class SlugHelper
    {
        public static string GenerateSlug(string input)
        {
            string slug = input.ToLowerInvariant();

            // Türkçe karakterleri İngilizce karakterlere çevir
            slug = slug.Replace('ü', 'u')
                       .Replace('ö', 'o')
                       .Replace('ş', 's')
                       .Replace('ı', 'i')
                       .Replace('ç', 'c')
                       .Replace('ğ', 'g');

            // Boşlukları tire ile değiştir
            slug = slug.Replace(" ", "-");

            // Geçersiz karakterleri temizle
            slug = Regex.Replace(slug, @"[^a-z0-9\-]", "");

            // Birden fazla tire varsa onları teke indir
            slug = Regex.Replace(slug, @"-+", "-");

            return slug;
        }
    }
}
