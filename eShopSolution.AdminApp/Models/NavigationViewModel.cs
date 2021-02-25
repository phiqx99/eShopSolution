﻿using eShopSolution.ViewModels.System.LanguageId;
using System.Collections.Generic;

namespace eShopSolution.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }

        public string ReturnUrl { get; set; }
    }
}