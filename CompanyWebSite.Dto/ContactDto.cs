using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class ContactDto
    {
        public int Id { get; set; }
        public IEnumerable<CompanyInfoDto>? CompanyInfos { get; set; }
        public IEnumerable<ContactFormDto>? ContactForms { get; set; }
        public List<PageDto>? Pages { get; set; }
    }
}
