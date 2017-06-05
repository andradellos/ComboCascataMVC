﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ComboCascata.MVC.Models;

namespace ComboCascata.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			// Nossos Métodos aqui
			ModelBinders.Binders.Add(typeof(double), new DoubleModelBinder());
			ModelBinders.Binders.Add(typeof(double?), new DoubleModelBinder());
			ModelBinders.Binders.Add(typeof(int), new Int32ModelBinder());
			ModelBinders.Binders.Add(typeof(int?), new Int32ModelBinder());
			ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
			ModelBinders.Binders.Add(typeof(decimal?), new DecimalModelBinder());
		}
    }
}
