﻿using System.Web;
using System.Web.Mvc;

namespace _2011062066_letranbaoduy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
