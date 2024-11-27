﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Dto
{
    public class PageDto
    {
        public int Id { get; set; }
        public string? PageContentTitle { get; set; }
        public string? PageHeaderTitle { get; set; }
        public string? PageHeaderSubtitle { get; set; }
        public string? PageMainSlogan { get; set; }
        public string? PageSubSlogan { get; set; }

    }
}