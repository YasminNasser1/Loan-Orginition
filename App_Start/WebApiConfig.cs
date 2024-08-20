using CorporateOnboardingAPIs.CRMWrapper;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.WebApi;

namespace Loan_Orginition
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Create the Unity container
            var container = new UnityContainer();

            container.RegisterType<CRMWrapper>(new InjectionConstructor(
                ConfigurationManager.AppSettings["CRMServiceUri"],
                ConfigurationManager.AppSettings["CRMUsername"],
                ConfigurationManager.AppSettings["CRMPassword"]

                
            ));
            config.DependencyResolver = new UnityDependencyResolver(container);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
