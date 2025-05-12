using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarrownzUS.Models;

namespace BarrownzUS.Controllers
{
    public class HomeController : Controller
    {

        //Database Connection

        private readonly string Connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        public ActionResult Index()
        {
            ViewBag.Title = "Web Development & Digital Marketing Experts | Barrownz Group";
            ViewBag.BodyClass = "Position";
            return View();
        }
       

        [HttpPost]
           public ActionResult IndexSaveData(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("Index", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }


        //Redirection
        public ActionResult RedirectToSEO_In_US()
        {
            return Redirect("/SEO_In_US");
        }

        public ActionResult SEO_In_US()
        {
            ViewBag.Title = "SEO_In_US";
            ViewBag.BodyClass = "Seo_Service";
            return View();
        }

        [HttpPost]
        public ActionResult Submit_Data_By_Seo_View(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("SEO_In_US", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("SEO_In_US", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }


        //Redirection
        public ActionResult RedirectToSEO_In_SouthCarolina()
        {
            return Redirect("/SEO_In_SouthCarolina");
        }

        public ActionResult SEO_In_SouthCarolina()
        {
            ViewBag.Title = "SEO_in_SouthCarolina";
            ViewBag.BodyClass = "SouthaCarolina";
            return View();
        }
        //Redirection
        public ActionResult RedirectToSEO_In_California()
        {
            return Redirect("/SEO_In_California");
        }
        public ActionResult SEO_In_California()
        {
            ViewBag.Title = "SEO_In_California";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToSEO_In_Florida()
        {
            return Redirect("/SEO_In_Florida");
        }
        public ActionResult SEO_In_Florida()
        {
            ViewBag.Title = "SEO_In_Florida";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToSEO_In_Taxes()
        {
            return Redirect("/SEO_In_Taxes");
        }
        public ActionResult SEO_In_Taxes()
        {
            ViewBag.Title = "SEO_In_Taxas";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToSEO_In_KansasCity()
        {
            return Redirect("/SEO_In_KansasCity");
        }
        public ActionResult SEO_In_KansasCity()
        {
            ViewBag.Title = "SEO_In_KansasCity";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToSEO_In_LosAngeles()
        {
            return Redirect("/SEO_In_LosAngeles");
        }
        public ActionResult SEO_In_LosAngeles()
        {
            ViewBag.Title = "SEO_In_LosAngeles";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToSEO_In_NewJersey()
        {
            return Redirect("/SEO_In_NewJersey");
        }
        public ActionResult SEO_In_NewJersey()
        {
            ViewBag.Title = "SEO_In_NewJersey";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToSEO_In_Arizona()
        {
            return Redirect("/SEO_In_Arizona");
        }
        public ActionResult SEO_In_Arizona()
        {
            ViewBag.Title = "SEO_In_Arizona";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToSEO_In_NewYork()
        {
            return Redirect("/SEO_In_NewYork");
        }
        public ActionResult SEO_In_NewYork()
        {
            ViewBag.Title = "SEO_In_NewYork";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToSEO_In_Pennsylvania()
        {
            return Redirect("/SEO_In_Pennsylvania");
        }
        public ActionResult SEO_In_Pennsylvania()
        {
            ViewBag.Title = "SEO_In_Pennsylvania";
            ViewBag.BodyClass = "locations";
            return View();
        }



        //DigitalMarketing

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_US()
        {
            return Redirect("/DigitalMarketing_In_US");
        }
        public ActionResult DigitalMarketing_In_US()
        {
            ViewBag.Title = "DigitalMarketing_In_US";
            ViewBag.BodyClass = "digital_marketing";
            return View();
        }
     

         [HttpPost]
        public ActionResult Submit_Data_By_DigitalMarketing_View(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("DigitalMarketing_In_US", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("DigitalMarketing_In_US", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_SouthCarolina()
        {
            return Redirect("/DigitalMarketing_In_SouthCarolina");
        }
        public ActionResult DigitalMarketing_In_SouthCarolina()
        {
            ViewBag.Title = "DigitalMarketing_In_SouthCarolina";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_California()
        {
            return Redirect("/DigitalMarketing_In_California");
        }
        public ActionResult DigitalMarketing_In_California()
        {
            ViewBag.Title = "DigitalMarketing_In_California";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_Florida()
        {
            return Redirect("/DigitalMarketing_In_Florida");
        }
        public ActionResult DigitalMarketing_In_Florida()
        {
            ViewBag.Title = "DigitalMarketing_In_Florida";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_Taxes()
        {
            return Redirect("/DigitalMarketing_In_Taxes");
        }
        public ActionResult DigitalMarketing_In_Taxes()
        {
            ViewBag.Title = "DigitalMarketing_In_Taxes";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_KansasCity()
        {
            return Redirect("/DigitalMarketing_In_KansasCity");
        }
        public ActionResult DigitalMarketing_In_KansasCity()
        {
            ViewBag.Title = "DigitalMarketing_In_KansasCity";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_LosAngeles()
        {
            return Redirect("/DigitalMarketing_In_LosAngeles");
        }
        public ActionResult DigitalMarketing_In_LosAngeles()
        {
            ViewBag.Title = "DigitalMarketing_In_LosAngeles";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_NewJersey()
        {
            return Redirect("/DigitalMarketing_In_NewJersey");
        }
        public ActionResult DigitalMarketing_In_NewJersey()
        {
            ViewBag.Title = "DigitalMarketing_In_NewJersey";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_Arizona()
        {
            return Redirect("/DigitalMarketing_In_Arizona");
        }
        public ActionResult DigitalMarketing_In_Arizona()
        {
            ViewBag.Title = "DigitalMarketing_In_Arizona";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_NewYork()
        {
            return Redirect("/DigitalMarketing_In_NewYork");
        }
        public ActionResult DigitalMarketing_In_NewYork()
        {
            ViewBag.Title = "DigitalMarketing_In_NewYork";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToDigitalMarketing_In_Pennsylvania()
        {
            return Redirect("/DigitalMarketing_In_NewYork");
        }
        public ActionResult DigitalMarketing_In_Pennsylvania()
        {
            ViewBag.Title = "DigitalMarketing_In_Pennsylvania";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Website Development

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_US()
        {
            return Redirect("/WebsiteDevelopment_In_US");
        }
        public ActionResult WebsiteDevelopment_In_US()
        {
            ViewBag.Title = "WebsiteDevelopment_In_US";
            ViewBag.BodyClass = "web_development";
            return View();
        }
    
         [HttpPost]
        public ActionResult Submit_Data_By_web_View(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("WebsiteDevelopment_In_US", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("WebsiteDevelopment_In_US", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }


        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_SouthCarolina()
        {
            return Redirect("/WebsiteDevelopment_In_SouthCarolina");
        }
        public ActionResult WebsiteDevelopment_In_SouthCarolina()
        {
            ViewBag.Title = "WebsiteDevelopment_In_SouthCarolina";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_California()
        {
            return Redirect("/WebsiteDevelopment_In_California");
        }
        public ActionResult WebsiteDevelopment_In_California()
        {
            ViewBag.Title = "WebsiteDevelopment_In_California";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_Florida()
        {
            return Redirect("/WebsiteDevelopment_In_Florida");
        }
        public ActionResult WebsiteDevelopment_In_Florida()
        {
            ViewBag.Title = "WebsiteDevelopment_In_Florida";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_Taxes()
        {
            return Redirect("/WebsiteDevelopment_In_Taxes");
        }
        public ActionResult WebsiteDevelopment_In_Taxes()
        {
            ViewBag.Title = "WebsiteDevelopment_In_Taxas";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_KansasCity()
        {
            return Redirect("/WebsiteDevelopment_In_Taxes");
        }
        public ActionResult WebsiteDevelopment_In_KansasCity()
        {
            ViewBag.Title = "WebsiteDevelopment_In_KansasCity";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_LosAngeles()
        {
            return Redirect("/WebsiteDevelopment_In_LosAngeles");
        }
        public ActionResult WebsiteDevelopment_In_LosAngeles()
        {
            ViewBag.Title = "WebsiteDevelopment_In_LosAngeles";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_NewJersey()
        {
            return Redirect("/WebsiteDevelopment_In_NewJersey");
        }
        public ActionResult WebsiteDevelopment_In_NewJersey()
        {
            ViewBag.Title = "WebsiteDevelopment_In_NewJersey";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_Arizona()
        {
            return Redirect("/WebsiteDevelopment_In_Arizona");
        }
        public ActionResult WebsiteDevelopment_In_Arizona()
        {
            ViewBag.Title = "WebsiteDevelopment_In_Arizona";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_NewYork()
        {
            return Redirect("/WebsiteDevelopment_In_NewYork");
        }
        public ActionResult WebsiteDevelopment_In_NewYork()
        {
            ViewBag.Title = "WebsiteDevelopment_In_NewYork";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToWebsiteDevelopment_In_Pennsylvania()
        {
            return Redirect("/WebsiteDevelopment_In_Pennsylvania");
        }
        public ActionResult WebsiteDevelopment_In_Pennsylvania()
        {
            ViewBag.Title = "WebsiteDevelopment_In_Pennsylvania";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Graphic design
        //Redirection
        public ActionResult RedirectToGraphicDesign_In_Us()
        {
            return Redirect("/GraphicDesign_In_Us");
        }
        public ActionResult GraphicDesign_In_Us()
        {
            ViewBag.Title = "GraphicDesign_In_Us";
            ViewBag.BodyClass = "GraphicDesign";
            return View();
        }
   
        [HttpPost]
        public ActionResult Submit_Data_By_Graphic_View(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("GraphicDesign_In_Us", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("GraphicDesign_In_Us", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_SouthCarolina()
        {
            return Redirect("/GraphicDesign_In_SouthCarolina");
        }
        public ActionResult GraphicDesign_In_SouthCarolina()
        {
            ViewBag.Title = "GraphicDesign_In_SouthCarolina";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_California()
        {
            return Redirect("/GraphicDesign_In_California");
        }
        public ActionResult GraphicDesign_In_California()
        {
            ViewBag.Title = "GraphicDesign_In_California";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToGraphicDesign_In_Florida()
        {
            return Redirect("/GraphicDesign_In_Florida");
        }
        public ActionResult GraphicDesign_In_Florida()
        {
            ViewBag.Title = "GraphicDesign_In_Florida";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_Taxes()
        {
            return Redirect("/GraphicDesign_In_Taxes");
        }
        public ActionResult GraphicDesign_In_Taxes()
        {
            ViewBag.Title = "GraphicDesign_In_Taxas";
            ViewBag.BodyClass = "locations";


          
            return View();
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_KansasCity()
        {
            return Redirect("/GraphicDesign_In_KansasCity");
        }
        public ActionResult GraphicDesign_In_KansasCity()
        {
            ViewBag.Title = "GraphicDesign_In_KansasCity";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_LosAngeles()
        {
            return Redirect("/GraphicDesign_In_LosAngeles");
        }
        public ActionResult GraphicDesign_In_LosAngeles()
        {
            ViewBag.Title = "GraphicDesign_In_LosAngeles";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToGraphicDesign_In_NewJersey()
        {
            return Redirect("/GraphicDesign_In_NewJersey");
        }
        public ActionResult GraphicDesign_In_NewJersey()
        {
            ViewBag.Title = "GraphicDesign_In_NewJersey";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToGraphicDesign_In_Arizona()
        {
            return Redirect("/GraphicDesign_In_Arizona");
        }
        public ActionResult GraphicDesign_In_Arizona()
        {
            ViewBag.Title = "GraphicDesign_In_Arizona";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToGraphicDesign_In_NewYork()
        {
            return Redirect("/GraphicDesign_In_NewYork");
        }
        public ActionResult GraphicDesign_In_NewYork()
        {
            ViewBag.Title = "GraphicDesign_In_NewYork";
            ViewBag.BodyClass = "locations";
            return View();
        }
        //Redirection
        public ActionResult RedirectToGraphicDesign_In_Pennsylvania()
        {
            return Redirect("/GraphicDesign_In_Pennsylvania");
        }
        public ActionResult GraphicDesign_In_Pennsylvania()
        {
            ViewBag.Title = "GraphicDesign_In_Pennsylvania";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToAbout()
        {
            return Redirect("/About");
        }
        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //Redirection
        public ActionResult RedirectToPortfolio()
        {
            return Redirect("/Portfolio");
        }
        public ActionResult Portfolio()
        {
            ViewBag.Title = "Portfolio";
            ViewBag.BodyClass = "locations";
            return View();
        }

        //public ActionResult Career()
        //{
        //    ViewBag.Title = "Career";
        //    ViewBag.BodyClass = "locations";
        //    return View();
        //}

        //Redirection
        public ActionResult RedirectToContactUs()
        {
            return Redirect("/ContactUs");
        }

        //Contact 
        // GET: ContactUs
        //[HttpGet]
        public ActionResult ContactUs()
        {
            ViewBag.Title = "ContactUs";
            ViewBag.BodyClass = "locations";
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(ContactEnquiry data)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
                         "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", data.Name);
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Service", data.Service);
                        cmd.Parameters.AddWithValue("@Message", data.Message);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {

                            TempData["Msg"] = "Your enquiry was submitted successfully!";
                            return RedirectToAction("ContactUs", "Home");
                        }

                    }

                }
                TempData["error"] = "Failed to submit your enquiry. Please try again.";
                return RedirectToAction("ContactUs", "Home");
            }
            catch (Exception ex) { 
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        

        //Redirection
        public ActionResult RedirectToTermsAndConditions()
        {
            return Redirect("/TermsAndConditions");
        }
        public ActionResult TermsAndConditions()
        {
            ViewBag.Title = "TermsAndCondition";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Redirection
        public ActionResult RedirectToPrivacyAndPolicy()
        {
            return Redirect("/PrivacyAndPolicy");
        }
        public ActionResult PrivacyAndPolicy()
        {
            ViewBag.Title = "PrivacyAndPolicy";
            ViewBag.BodyClass = "locations";
            return View();
        }

        public ActionResult RedirectToCopyright()
        {
            return Redirect("/Copyright");
        }
        public ActionResult Copyright()
        {
            ViewBag.Title = "Copyright";
            ViewBag.BodyClass = "locations";
            return View();
        }
        public ActionResult NotFound()
        {
            ViewBag.Title = "NotFound";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Blog Pages

        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";
            ViewBag.BodyClass = "locations";
            return View();
        }

        public ActionResult BlogDetails()
        {
            ViewBag.Title = "BlogDetails";
            ViewBag.BodyClass = "locations";
            return View();
        }


        //Data Insert Process

        //[HttpPost]
        //private void SaveData(ContactEnquiry data)
        //{
        //    using (SqlConnection con = new SqlConnection(Connection))
        //    {
        //        string query = "INSERT INTO tbl_ContactEnquiry(Name, Email, PhoneNumber, Service, Message) " +
        //             "VALUES (@Name, @Email, @PhoneNumber, @Service, @Message)";
        //        using (SqlCommand cmd = new SqlCommand(query, con))
        //        {
        //            cmd.Parameters.AddWithValue("@Name", data.Name);
        //            cmd.Parameters.AddWithValue("@Email", data.Email);
        //            cmd.Parameters.AddWithValue("@PhoneNumber", data.PhoneNumber);
        //            cmd.Parameters.AddWithValue("@Service", data.Service);
        //            cmd.Parameters.AddWithValue("@Message", data.Message);
        //            con.Open();
        //            int a = cmd.ExecuteNonQuery();
        //            if (a > 0)
        //            {
        //                TempData["Msg"] = "Data successfully insert";
        //            }

        //        }

        //    }
        //    ViewBag["Error"] = "Data insertion failed";
        //}
    }
}