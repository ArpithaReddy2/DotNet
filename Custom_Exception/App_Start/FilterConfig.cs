using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights.DataContracts;
using MvcCustomExceptionFilter.CustomFilter;

namespace MvcCustomExceptionFilter.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilter(GlobalFilterCollection filters)
        {
            filters.Add(new CustomExceptionHandlerFilter());
        }
    }
}