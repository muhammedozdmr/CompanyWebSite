﻿using CompanyWebSite.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWebSite.Business.Services.Interface
{
    public interface IFooterService
    {
        Task<IEnumerable<FooterDto>> GetFooterAllAsync(string languageCode);
    }
}