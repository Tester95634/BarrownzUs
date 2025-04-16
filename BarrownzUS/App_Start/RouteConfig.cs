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

            routes.MapRoute(
          name: "HomeNotFound",
          url: "Home/NotFound/{*path}",
          defaults: new { controller = "Home", action = "NotFound" }
      );
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
           name: "seo-service-in-texas_genrl",
           url: "Home/SEO_In_Taxes",
           defaults: new { controller = "Home", action = "RedirectToSEO_In_Taxes" }
       );

            routes.MapRoute(
              name: "seo-service-in-texas_defalult",
              url: "seo-service-in-texas",
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

            //SEO Routing end Here

            //DigitalMarketing Routing start here

            //Main Page
            routes.MapRoute(
               name: "digital-marketing-company-usa_genrl",
               url: "Home/DigitalMarketing_In_US",
               defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_US" }
           );

            routes.MapRoute(
              name: "digital-marketing-company-usa_defalult",
              url: "digital-marketing-company-usa",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_US" }
          );

            //SouthCarolina
            routes.MapRoute(
              name: "digital-marketing-service-south-carolina_genrl",
              url: "Home/DigitalMarketing_In_SouthCarolina",
              defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_SouthCarolina" }
          );

            routes.MapRoute(
              name: "digital-marketing-service-south-carolina_defalult",
              url: "digital-marketing-service-south-carolina",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_SouthCarolina" }
          );

            //California
            routes.MapRoute(
             name: "digital-marketing-service-california_genrl",
             url: "Home/DigitalMarketing_In_California",
             defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_California" }
         );

            routes.MapRoute(
              name: "digital-marketing-service-california_defalult",
              url: "digital-marketing-service-california",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_California" }
          );
            //Florida
            routes.MapRoute(
            name: "digital-marketing-service-florida_genrl",
            url: "Home/DigitalMarketing_In_Florida",
            defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_Florida" }
        );

            routes.MapRoute(
              name: "digital-marketing-service-florida_defalult",
              url: "digital-marketing-service-florida",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_Florida" }
          );


            //Texas
            routes.MapRoute(
            name: "digital-marketing-service-texas_genrl",
            url: "Home/DigitalMarketing_In_Taxes",
            defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_Taxes" }
        );

            routes.MapRoute(
              name: "digital-marketing-service-texas_defalult",
              url: "digital-marketing-service-texas",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_Taxes" }
          );
            //Kansas city 
            routes.MapRoute(
           name: "digital-marketing-service-kansas-city_genrl",
           url: "Home/DigitalMarketing_In_KansasCity",
           defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_KansasCity" }
       );

            routes.MapRoute(
              name: "digital-marketing-service-kansas-city_defalult",
              url: "digital-marketing-service-kansas-city",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_KansasCity" }
          );

            //Los Angeles 
            routes.MapRoute(
          name: "digital-marketing-service-los-angeles_genrl",
          url: "Home/DigitalMarketing_In_LosAngeles",
          defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_LosAngeles" }
      );

            routes.MapRoute(
              name: "digital-marketing-service-los-angeles_defalult",
              url: "digital-marketing-service-los-angeles",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_LosAngeles" }
          );

            //NewJersey
            routes.MapRoute(
         name: "digital-marketing-service-new-jersey_genrl",
         url: "Home/DigitalMarketing_In_NewJersey",
         defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_NewJersey" }
     );

            routes.MapRoute(
              name: "digital-marketing-service-new-jersey_defalult",
              url: "digital-marketing-service-new-jersey",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_NewJersey" }
          );

            //Arizona 
               routes.MapRoute(
         name: "digital-marketing-service-arizona_genrl",
         url: "Home/DigitalMarketing_In_Arizona",
         defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_Arizona" }
     );

            routes.MapRoute(
              name: "digital-marketing-service-arizona_defalult",
              url: "digital-marketing-service-arizona",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_Arizona" }
          );
            //New York 
            routes.MapRoute(
      name: "digital-marketing-service-new-york_genrl",
      url: "Home/DigitalMarketing_In_NewYork",
      defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_NewYork" }
  );

            routes.MapRoute(
              name: "digital-marketing-service-new-york_defalult",
              url: "digital-marketing-service-new-york",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_NewYork" }
          );

            //Pennsylvania 
                routes.MapRoute(
      name: "digital-marketing-service-pennsylvania_genrl",
      url: "Home/DigitalMarketing_In_Pennsylvania",
      defaults: new { controller = "Home", action = "RedirectToDigitalMarketing_In_Pennsylvania" }
  );

            routes.MapRoute(
              name: "digital-marketing-service-pennsylvania_defalult",
              url: "digital-marketing-service-pennsylvania",
              defaults: new { controller = "Home", action = "DigitalMarketing_In_Pennsylvania" }
          );

            //DigitalMarketing Routing end here 


            //DigitalMarketing Routing end here 

            //WebDevelopment Routing start here

            //Main Page
            routes.MapRoute(
               name: "web-development-company-usa_genrl",
               url: "Home/WebsiteDevelopment_In_US",
               defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_US" }
           );

            routes.MapRoute(
              name: "web-development-company-usa_defalult",
              url: "web-development-company-usa",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_US" }
          );

            //SouthCarolina
            routes.MapRoute(
              name: "web-development-service-south-carolina_genrl",
              url: "Home/WebsiteDevelopment_In_SouthCarolina",
              defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_SouthCarolina" }
          );

            routes.MapRoute(
              name: "web-development-service-south-carolina_defalult",
              url: "web-development-service-south-carolina",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_SouthCarolina" }
          );

            //California
            routes.MapRoute(
             name: "web-development-service-california_genrl",
             url: "Home/WebsiteDevelopment_In_California",
             defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_California" }
         );

            routes.MapRoute(
              name: "web-development-service-california_defalult",
              url: "web-development-service-california",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_California" }
          );
            //Florida
            routes.MapRoute(
            name: "web-development-service-florida_genrl",
            url: "Home/WebsiteDevelopment_In_Florida",
            defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_Florida" }
        );

            routes.MapRoute(
              name: "web-development-service-florida_defalult",
              url: "web-development-service-florida",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_Florida" }
          );


            //Texas
            routes.MapRoute(
            name: "web-development-service-texas_genrl",
            url: "Home/WebsiteDevelopment_In_Taxes",
            defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_Taxes" }
        );

            routes.MapRoute(
              name: "web-development-service-texas_defalult",
              url: "web-development-service-texas",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_Taxes" }
          );
            //Kansas city 
            routes.MapRoute(
           name: "web-development-service-kansas-city_genrl",
           url: "Home/WebsiteDevelopment_In_KansasCity",
           defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_KansasCity" }
       );

            routes.MapRoute(
              name: "web-development-service-kansas-city_defalult",
              url: "web-development-service-kansas-city",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_KansasCity" }
          );

            //Los Angeles 
            routes.MapRoute(
          name: "web-development-service-los-angeles_genrl",
          url: "Home/WebsiteDevelopment_In_LosAngeles",
          defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_LosAngeles" }
      );

            routes.MapRoute(
              name: "web-development-service-los-angeles_defalult",
              url: "web-development-service-los-angeles",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_LosAngeles" }
          );

            //NewJersey
            routes.MapRoute(
         name: "web-development-service-new-jersey_genrl",
         url: "Home/WebsiteDevelopment_In_NewJersey",
         defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_NewJersey" }
     );

            routes.MapRoute(
              name: "web-development-service-new-jersey_defalult",
              url: "web-development-service-new-jersey",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_NewJersey" }
          );

            //Arizona 
            routes.MapRoute(
      name: "web-development-service-arizona_genrl",
      url: "Home/WebsiteDevelopment_In_Arizona",
      defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_Arizona" }
  );

            routes.MapRoute(
              name: "web-development-service-arizona_defalult",
              url: "web-development-service-arizona",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_Arizona" }
          );
            //New York 
            routes.MapRoute(
      name: "web-development-service-new-york_genrl",
      url: "Home/WebsiteDevelopment_In_NewYork",
      defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_NewYork" }
  );

            routes.MapRoute(
              name: "web-development-service-new-york_defalult",
              url: "web-development-service-new-york",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_NewYork" }
          );

            //Pennsylvania 
            routes.MapRoute(
  name: "web-development-service-pennsylvania_genrl",
  url: "Home/WebsiteDevelopment_In_Pennsylvania",
  defaults: new { controller = "Home", action = "RedirectToWebsiteDevelopment_In_Pennsylvania" }
);

            routes.MapRoute(
              name: "web-development-service-pennsylvania_defalult",
              url: "web-development-service-pennsylvania",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_Pennsylvania" }
          );

            //WebsiteDevelopment Routing end here 


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
