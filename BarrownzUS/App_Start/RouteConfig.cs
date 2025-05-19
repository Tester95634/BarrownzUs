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
              name: "seo-company-in-usa_default",
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
              name: "seo-service-in-south-carolina_default",
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
              name: "seo-service-in-california_default",
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
              name: "seo-service-in-florida_default",
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
              name: "seo-service-in-texas_default",
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
              name: "seo-service-in-kansas-city_default",
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
              name: "seo-service-in-los-angeles_default",
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
              name: "seo-service-in-new-jersey_default",
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
              name: "seo-service-in-arizona_default",
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
              name: "seo-service-in-new-york_default",
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
              name: "seo-service-in-pennsylvania_default",
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
              name: "digital-marketing-company-usa_default",
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
              name: "digital-marketing-service-south-carolina_default",
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
              name: "digital-marketing-service-california_default",
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
              name: "digital-marketing-service-florida_default",
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
              name: "digital-marketing-service-texas_default",
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
              name: "digital-marketing-service-kansas-city_default",
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
              name: "digital-marketing-service-los-angeles_default",
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
              name: "digital-marketing-service-new-jersey_default",
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
              name: "digital-marketing-service-arizona_default",
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
              name: "digital-marketing-service-new-york_default",
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
              name: "digital-marketing-service-pennsylvania_default",
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
              name: "web-development-company-usa_default",
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
              name: "web-development-service-south-carolina_default",
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
              name: "web-development-service-california_default",
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
              name: "web-development-service-florida_default",
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
              name: "web-development-service-texas_default",
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
              name: "web-development-service-kansas-city_default",
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
              name: "web-development-service-los-angeles_default",
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
              name: "web-development-service-new-jersey_default",
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
              name: "web-development-service-arizona_default",
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
              name: "web-development-service-new-york_default",
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
              name: "web-development-service-pennsylvania_default",
              url: "web-development-service-pennsylvania",
              defaults: new { controller = "Home", action = "WebsiteDevelopment_In_Pennsylvania" }
          );

            //WebsiteDevelopment Routing end here 

            //Graphic design Routing start here
            //Main Page
            routes.MapRoute(
                  name: "graphic-design-services-in-usa_genrl",
                  url: "Home/GraphicDesign_In_Us",
                 defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_Us" }
                );

            routes.MapRoute(
            name: "graphic-design-services-in-usa_default",
            url: "graphic-design-services-in-usa",
            defaults: new { controller = "Home", action = "GraphicDesign_In_Us" }
        );

            //South Carolina
            routes.MapRoute(
                 name: "graphic-design-services-in-south-carolina_genrl",
                 url: "Home/GraphicDesign_In_SouthCarolina",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_SouthCarolina" }
               );

            routes.MapRoute(
            name: "graphic-design-services-in-south-carolina_default",
            url: "graphic-design-services-in-south-carolina",
            defaults: new { controller = "Home", action = "GraphicDesign_In_SouthCarolina" }
        );

            //South Carolina
            routes.MapRoute(
                 name: "graphic-design-services-in-california_genrl",
                 url: "Home/GraphicDesign_In_California",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_California" }
               );

            routes.MapRoute(
            name: "graphic-design-services-in-california_default",
            url: "graphic-design-services-in-california",
            defaults: new { controller = "Home", action = "GraphicDesign_In_California" }
        );
            //florida
            routes.MapRoute(
                 name: "graphic-design-services-in-florida_genrl",
                 url: "Home/GraphicDesign_In_Florida",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_Florida" }
               );

            routes.MapRoute(
            name: "graphic-design-services-in-florida_default",
            url: "graphic-design-services-in-florida",
            defaults: new { controller = "Home", action = "GraphicDesign_In_Florida" }
        );
            // Texas
            routes.MapRoute(
                name: "graphic-design-services-in-texas_genrl",
                url: "Home/GraphicDesign_In_Taxes",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_Taxes" }
            );

            routes.MapRoute(
                name: "graphic-design-services-in-texas_default",
                url: "graphic-design-services-in-texas",
                defaults: new { controller = "Home", action = "GraphicDesign_In_Taxes" }
            );
            // KansasCity
            routes.MapRoute(
                name: "graphic-design-services-in-kansas-city_genrl",
                url: "Home/GraphicDesign_In_KansasCity",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_KansasCity" }
            );

            routes.MapRoute(
                name: "graphic-design-services-in-kansas-city_default",
                url: "graphic-design-services-in-kansas-city",
                defaults: new { controller = "Home", action = "GraphicDesign_In_KansasCity" }
            );
            // LosAngeles
            routes.MapRoute(
                name: "graphic-design-services-in-los-angeles_genrl",
                url: "Home/GraphicDesign_In_LosAngeles",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_LosAngeles" }
            );

            routes.MapRoute(
                name: "graphic-design-services-in-los-angeles_default",
                url: "graphic-design-services-in-los-angeles",
                defaults: new { controller = "Home", action = "GraphicDesign_In_LosAngeles" }
            );

            // NewJersey
            routes.MapRoute(
                name: "graphic-design-services-in-new-jersey_genrl",
                url: "Home/GraphicDesign_In_NewJersey",
                defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_NewJersey" }
            );

            routes.MapRoute(
                name: "graphic-design-services-in-new-jersey_default",
                url: "graphic-design-services-in-new-jersey",
                defaults: new { controller = "Home", action = "GraphicDesign_In_NewJersey" }
            );
            //Arizona 
            routes.MapRoute(
              name: "graphic-design-services-in-arizona_genrl",
              url: "Home/GraphicDesign_In_Arizona",
              defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_Arizona" }
          );

            routes.MapRoute(
                name: "graphic-design-services-in-arizona_default",
                url: "graphic-design-services-in-arizona",
                defaults: new { controller = "Home", action = "GraphicDesign_In_Arizona" }
            );

            //New York 
            routes.MapRoute(
            name: "graphic-design-services-in-new-york_genrl",
            url: "Home/GraphicDesign_In_NewYork",
            defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_NewYork" }
        );

            routes.MapRoute(
                name: "graphic-design-services-in-new-york_default",
                url: "graphic-design-services-in-new-york",
                defaults: new { controller = "Home", action = "GraphicDesign_In_NewYork" }
            );
            //Pennsylvania 
            routes.MapRoute(
           name: "graphic-design-services-in-pennsylvania_genrl",
           url: "Home/GraphicDesign_In_Pennsylvania",
           defaults: new { controller = "Home", action = "RedirectToGraphicDesign_In_Pennsylvania" }
       );

            routes.MapRoute(
                name: "graphic-design-services-in-pennsylvania_default",
                url: "graphic-design-services-in-pennsylvania",
                defaults: new { controller = "Home", action = "GraphicDesign_In_Pennsylvania" }
            );
            //Graphic design Routing end here 


            //PrivacyAndPolicy

            routes.MapRoute(
         name: "privacy-policy_genrl",
         url: "Home/PrivacyAndPolicy",
         defaults: new { controller = "Home", action = "RedirectToPrivacyAndPolicy" }
     );

            routes.MapRoute(
                name: "privacy-policy_default",
                url: "privacy-policy",
                defaults: new { controller = "Home", action = "PrivacyAndPolicy" }
            );

            //Copyright

            routes.MapRoute(
            name: "copyright_genrl",
            url: "Home/Copyright",
            defaults: new { controller = "Home", action = "RedirectToCopyright" }
            );

            routes.MapRoute(
                name: "copyright_default",
                url: "copyright",
                defaults: new { controller = "Home", action = "Copyright" }
            );

            //About
            routes.MapRoute(
          name: "about-us_genrl",
          url: "Home/About",
          defaults: new { controller = "Home", action = "RedirectToAbout" }
          );

            routes.MapRoute(
                name: "about-us_default",
                url: "about-us",
                defaults: new { controller = "Home", action = "About" }
            );

            //Portfolio
            routes.MapRoute(
        name: "portfolio_genrl",
        url: "Home/Portfolio",
        defaults: new { controller = "Home", action = "RedirectToPortfolio" }
        );

            routes.MapRoute(
                name: "portfolio_default",
                url: "portfolio",
                defaults: new { controller = "Home", action = "Portfolio" }
            );

            //TermsAndConditions
            routes.MapRoute(
      name: "terms-and-condition_genrl",
      url: "Home/TermsAndConditions",
      defaults: new { controller = "Home", action = "RedirectToTermsAndConditions" }
      );

            routes.MapRoute(
                name: "terms-and-condition_default",
                url: "terms-and-condition",
                defaults: new { controller = "Home", action = "TermsAndConditions" }
            );


            //Contact
            routes.MapRoute(
      name: "contact-us_genrl",
      url: "Home/ContactUs",
      defaults: new { controller = "Home", action = "RedirectToContactUs" }
      );

            routes.MapRoute(
                name: "Contact-us_default",
                url: "contact-us",
                defaults: new { controller = "Home", action = "ContactUs" }
            );




            //Blog

            routes.MapRoute(
      name: "Blog_genrl",
      url: "Home/Blog",
      defaults: new { controller = "Home", action = "RedirectToBlog" }
      );

            routes.MapRoute(
                name: "Blog_default",
                url: "Blog",
                defaults: new { controller = "Home", action = "Blog" }
            );


            //BlogDetails Slug Routing
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
           name: "BlogDetails",
           url: "BlogDetails/{Slug}", // Here url create 
           defaults: new { controller = "Home", action = "BlogDetails", Slug = UrlParameter.Optional }
       );

            //Default Routing
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
