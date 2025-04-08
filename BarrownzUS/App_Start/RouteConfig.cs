using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BarrownzUS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //SEO Routing start Here

            //Main Page
            routes.MapRoute(
               name: "seo-company-in-usa_genrl",
               url: "Home/SEO_In_US",
               defaults: new { controller = "Home", action = "RedirectToSEO_In_US" }
           );

            routes.MapRoute(
              name: "seo-company-in-usa_defalult",
              url: "seo-company-in-usa",
              defaults: new { controller = "Home", action = "SEO_In_US" }
          );
            //South carolina
            routes.MapRoute(
                name: "seo-service-in-south-carolina_genrl",
                url: "Home/SEO_In_SouthCarolina",
                defaults: new { controller = "Home", action = "RedirectToSEO_In_SouthCarolina" }
            );

            routes.MapRoute(
              name: "seo-service-in-south-carolina_defalult",
              url: "seo-service-in-south-carolina",
              defaults: new { controller = "Home", action = "SEO_In_SouthCarolina" }
          );
            //California
            routes.MapRoute(
             name: "seo-service-in-california_genrl",
             url: "Home/SEO_In_California",
             defaults: new { controller = "Home", action = "RedirectToSEO_In_California" }
         );

            routes.MapRoute(
              name: "seo-service-in-california_defalult",
              url: "seo-service-in-california",
              defaults: new { controller = "Home", action = "SEO_In_California" }
          );
            //Florida
            routes.MapRoute(
             name: "seo-service-in-florida_genrl",
             url: "Home/SEO_In_Florida",
             defaults: new { controller = "Home", action = "RedirectToSEO_In_Florida" }
         );

            routes.MapRoute(
              name: "seo-service-in-florida_defalult",
              url: "seo-service-in-florida",
              defaults: new { controller = "Home", action = "SEO_In_Florida" }
          );
            //Taxes 
            routes.MapRoute(
           name: "seo-service-in-taxes_genrl",
           url: "Home/SEO_In_Taxes",
           defaults: new { controller = "Home", action = "RedirectToSEO_In_Taxes" }
       );

            routes.MapRoute(
              name: "seo-service-in-taxes_defalult",
              url: "seo-service-in-taxes",
              defaults: new { controller = "Home", action = "SEO_In_Taxes" }
          );

            //KansasCity
            routes.MapRoute(
            name: "seo-service-in-kansas-city_genrl",
            url: "Home/SEO_In_KansasCity",
            defaults: new { controller = "Home", action = "RedirectToSEO_In_KansasCity" }
        );

            routes.MapRoute(
              name: "seo-service-in-kansas-city_defalult",
              url: "seo-service-in-kansas-city",
              defaults: new { controller = "Home", action = "SEO_In_KansasCity" }
          );

            //LosAngeles
            routes.MapRoute(
            name: "seo-service-in-los-angeles_genrl",
            url: "Home/SEO_In_LosAngeles",
            defaults: new { controller = "Home", action = "RedirectToSEO_In_LosAngeles" }
        );

            routes.MapRoute(
              name: "seo-service-in-los-angeles_defalult",
              url: "seo-service-in-los-angeles",
              defaults: new { controller = "Home", action = "SEO_In_LosAngeles" }
          );
            //NewJersey
            routes.MapRoute(
            name: "seo-service-in-new-jersey_genrl",
            url: "Home/SEO_In_NewJersey",
            defaults: new { controller = "Home", action = "RedirectToSEO_In_NewJersey" }
        );

            routes.MapRoute(
              name: "seo-service-in-new-jersey_defalult",
              url: "seo-service-in-new-jersey",
              defaults: new { controller = "Home", action = "SEO_In_NewJersey" }
          );
            //Arizona 
            routes.MapRoute(
            name: "seo-service-in-arizona_genrl",
            url: "Home/SEO_In_Arizona",
            defaults: new { controller = "Home", action = "RedirectToSEO_In_Arizona" }
        );

            routes.MapRoute(
              name: "seo-service-in-arizona_defalult",
              url: "seo-service-in-arizona",
              defaults: new { controller = "Home", action = "SEO_In_Arizona" }
          );
            //NewYork
             routes.MapRoute(
             name: "seo-service-in-new-york_genrl",
             url: "Home/SEO_In_NewYork",
             defaults: new { controller = "Home", action = "RedirectToSEO_In_NewYork" }
            );

            routes.MapRoute(
              name: "seo-service-in-new-york_defalult",
              url: "seo-service-in-new-york",
              defaults: new { controller = "Home", action = "SEO_In_NewYork" }
          );
            //Pennsylvania 
            routes.MapRoute(
            name: "seo-service-in-pennsylvania_genrl",
            url: "Home/SEO_In_Pennsylvania",
            defaults: new { controller = "Home", action = "RedirectToSEO_In_Pennsylvania" }
            );

            routes.MapRoute(
              name: "seo-service-in-pennsylvania_defalult",
              url: "seo-service-in-pennsylvania",
              defaults: new { controller = "Home", action = "SEO_In_Pennsylvania" }
          );

            //SEO Routing start Here

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
