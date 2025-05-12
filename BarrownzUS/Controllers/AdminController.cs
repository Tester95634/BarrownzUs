using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarrownzUS.Models;

namespace BarrownzUS.Controllers
{
    public class AdminController : Controller
    {
        //Database Connection

        private readonly string Connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        // GET: Admin
        public ActionResult Dashboard()
        {
            if (Session["Password"]==null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //Admin Login
        [HttpPost]
        public ActionResult Login(tbl_Admin data, string email,string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    string query = "SELECT Id,Email,Password FROM tbl_Admin WHERE Email=@Email";
                    using(SqlCommand cmd=new SqlCommand(query,conn)){
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {

                            if (reader.Read())
                            {
                                int Id = Convert.ToInt32(reader["id"]);
                                string Email = reader["Email"].ToString();
                                string Password = reader["Password"].ToString();

                                Session["Id"] = Id;
                                Session["Email"] = Email;
                                Session["Password"] = Password;

                                if (Email == email && Password == password)
                                {

                                    TempData["Msg"] = "Login Successfully";
                                    return RedirectToAction("Dashboard", "Admin");

                                }
                            }

                        }
                    }
                        TempData["error"] = "Email or Password invalid";
                       return View();
                    }
                  
             
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }

        //Logout Process
        public ActionResult Logout()
        {
            if (Session["Email"]!=null && Session["Password"] != null)
            {
                Session.Clear();
                Session.Abandon();
                return RedirectToAction("Login","Admin");
            }

            return View();
        }

        //All User fetch data
        public ActionResult UserList()
        {
            if (Session["Password"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }


            List<ContactEnquiry> Listdata=new List<ContactEnquiry>();
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "SELECT *FROM tbl_ContactEnquiry";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Listdata.Add(new ContactEnquiry()
                                {
                                    Id = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Service = reader["Service"].ToString(),
                                    Message = reader["Message"].ToString()

                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
            ViewBag.Message = ex.Message; 
            }

            return View(Listdata);
        }

        //Delete data process
        public ActionResult Delete_User(int Id)
        {
            try
            {
                using(SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "DELETE FROM tbl_ContactEnquiry WHERE Id=@Id";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return RedirectToAction("UserList","Admin");
            }
            catch(Exception ex)
            {
                ViewBag["error"]=ex.Message;
                return View();
            }

        }

        public ActionResult AddBlogCategory()
        {
            if (Session["Password"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            List<tbl_BlogCategory> bloglist = new List<tbl_BlogCategory>();
            try
            {
                using(SqlConnection con=new SqlConnection(Connection))
                {
                    string query = "SELECT *FROM tbl_BlogCategory";
                    using(SqlCommand cmd=new SqlCommand(query,con))
                    {
                        con.Open();
                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bloglist.Add(new tbl_BlogCategory()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    BlogCategory = reader["BlogCategory"].ToString()

                                });

                            }
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                ViewBag["error"] = ex.Message;
            }

            return View(bloglist);
        }

        //Add Blog Category

        [HttpPost]
        public ActionResult AddBlogCategory(tbl_BlogCategory CategoryData)
        {
              using(SqlConnection con=new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_BlogCategory(BlogCategory)" + "VALUES(@BlogCategory)";
                    using(SqlCommand cmd=new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BlogCategory", CategoryData.BlogCategory);
                        con.Open();
                        int row=cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            TempData["Msg"] = "Category add Successfully";
                            return RedirectToAction("AddBlogCategory", "Admin");
                        }
                    }
                }
                TempData["error"] = "Category add failed";
                return RedirectToAction("AddBlogCategory", "Admin");
        }

        //Delete Category
        public ActionResult Delete_Category(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "DELETE FROM tbl_BlogCategory WHERE Id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return RedirectToAction("AddBlogCategory", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag["error"] = ex.Message;
                return View();
            }
        }

        //Edit BlogCategory
        public ActionResult EditCategory(int Id)
        {
            tbl_BlogCategory data = new tbl_BlogCategory();
            using(SqlConnection con=new SqlConnection(Connection))
            {
                string query = "SELECT *FROM tbl_BlogCategory WHERE Id=@Id";
                using(SqlCommand cmd=new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.Id=Convert.ToInt32(reader["id"]);
                            data.BlogCategory = reader["BlogCategory"].ToString();
                        }
                    }

                }
            }

            return View(data);
        }





        public ActionResult AddBlog()
        {
            if (Session["Password"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            return View();
        }

        public ActionResult BlogList()
        {

            if (Session["Password"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            return View();        
        }

    }
}