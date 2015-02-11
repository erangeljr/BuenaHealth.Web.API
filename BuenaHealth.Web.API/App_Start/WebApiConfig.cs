﻿using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using BuenaHealth.Web.Common;
using BuenaHealth.Web.Common.Routing;

namespace BuenaHealth.Web.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {  
            // Web API configuration and services
            var contstraintResolver = new DefaultInlineConstraintResolver();
            contstraintResolver.ConstraintMap.Add("apiVersionContraint", typeof(ApiVersionConstraint));


            // Web API routes
            config.MapHttpAttributeRoutes(contstraintResolver);
            config.Services.Replace(typeof(IHttpControllerSelector), new NamespaceHttpControllerSelector(config));
            config.EnableSystemDiagnosticsTracing();

        }
    }
}
