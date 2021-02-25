﻿using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.LanguageId;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}