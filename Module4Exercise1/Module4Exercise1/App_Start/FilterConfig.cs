﻿using System.Web;
using System.Web.Mvc;

namespace Module4Exercise1 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
