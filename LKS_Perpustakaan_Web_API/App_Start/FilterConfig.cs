﻿using System.Web;
using System.Web.Mvc;

namespace LKS_Perpustakaan_Web_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
