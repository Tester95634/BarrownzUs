using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
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

        //Fetching Category data
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
                TempData["error"] = ex.Message + "Category Deletion Failed";
                return RedirectToAction("AddBlogCategory", "Admin");
            }
        }

        //Show Category Edit Page
        
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

        //Edit  Category
        [HttpPost]
        public ActionResult EditCategory(tbl_BlogCategory data, int Id)
        {
            try
            {
                if (data.Id > 0)
                {
                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        string query = "UPDATE tbl_BlogCategory SET BlogCategory=@BlogCategory WHERE Id=@Id";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BlogCategory", data.BlogCategory);
                            cmd.Parameters.AddWithValue("@Id", data.Id);

                            con.Open();
                            cmd.ExecuteNonQuery();

                            TempData["Msg"] = "Category updated successfully";
                            return RedirectToAction("AddBlogCategory", "Admin");
                        }
                    }
                }

                TempData["Msg"] = "Category update failed";
                return RedirectToAction("EditCategory", "Admin");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Category update failed: " + ex.Message;
                return View(data);
            }
        }

        //Main method
        public ActionResult AddBlog()
        {
            if (Session["Password"] == null && Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            var categories=GetAllCategories();
            return View(categories);
        }

        //Here Add Blog
        [HttpPost]
        public ActionResult AddBlog(BlogData data, HttpPostedFileBase Blog_Img)
        {
            try
            {
                if (Blog_Img != null)
                {
                    string Folder_Path = Server.MapPath("~/Content/Blog_Uploaded_Image/");
                    string FileName =Blog_Img.FileName;
                    string Filepath = Path.Combine(Folder_Path, FileName);

                    if (!Directory.Exists(Folder_Path))
                    {
                        Directory.CreateDirectory(Folder_Path);
                    }

                    Blog_Img.SaveAs(Filepath);

                    using (SqlConnection conn = new SqlConnection(Connection))
                    {
                        string query = "INSERT INTO tbl_blog (BlogTitle, MetaTitle, MetaDescription, Slug, Blog_Img, CategoryId, BlogDescription) " +
                                       "VALUES (@BlogTitle, @MetaTitle, @MetaDescription, @Slug, @Blog_Img, @CategoryId, @BlogDescription)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BlogTitle", data.BlogTitle);
                            cmd.Parameters.AddWithValue("@MetaTitle", data.MetaTitle);
                            cmd.Parameters.AddWithValue("@MetaDescription", data.MetaDescription);
                            cmd.Parameters.AddWithValue("@Slug", data.Slug);
                            cmd.Parameters.AddWithValue("@Blog_Img", FileName);
                            cmd.Parameters.AddWithValue("@CategoryId", data.CategoryId);
                            cmd.Parameters.AddWithValue("@BlogDescription", data.BlogDescription);
                            conn.Open();
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                TempData["Success"] = "Blog added successfully";
                                return RedirectToAction("AddBlog", "Admin");
                            }
                        }
                    }
                }

                TempData["error"] = "Please upload an image.";
                return RedirectToAction("AddBlog", "Admin");
            }
            catch (Exception ex)
            {
                // Error Logging (if needed)
                TempData["error"] = "Error: " + ex.Message;
                return RedirectToAction("AddBlog", "Admin");
            }
        }


        //Add fetch Blog data
        public ActionResult BlogList()
        {
            if (Session["Password"] == null || Session["Email"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }

            List<BlogData> list_Blog = new List<BlogData>();

            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = @"
                SELECT 
                    b.Id, b.BlogTitle,  b.MetaTitle,   b.MetaDescription, b.Slug,   b.Blog_Img, b.CategoryId, b.BlogDescription  ,c.BlogCategory FROM 
                    tbl_blog b
                INNER JOIN 
                    tbl_BlogCategory c ON b.CategoryId = c.Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list_Blog.Add(new BlogData()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    BlogTitle = reader["BlogTitle"].ToString(),
                                    MetaTitle = reader["MetaTitle"].ToString(),
                                    MetaDescription = reader["MetaDescription"].ToString(),
                                    Slug = reader["Slug"].ToString(),
                                    Blog_Img = reader["Blog_Img"].ToString(),
                                    CategoryId = Convert.ToInt32(reader["CategoryId"]),
                                    BlogDescription = reader["BlogDescription"].ToString(),
                                    BlogCategory=reader["BlogCategory"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading blog list: " + ex.Message;
            }

            return View(list_Blog);
        }
    
        //Delete Blog
        [HttpPost]
        public ActionResult Delete_Blog(int Id)
        {
            string ImageName = string.Empty;
            string folderpath = Server.MapPath("~/Content/Blog_Uploaded_Image/");

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "Select Blog_Img from tbl_Blog where id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    con.Open();
                    ImageName = (string)cmd.ExecuteScalar();
                }
            }

            string filepath = Path.Combine(folderpath, ImageName);

            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "DELETE FROM tbl_blog where Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                TempData["Msg"] = "Data delete successfully";
                return RedirectToAction("BlogList", "Admin");
            }
        }
        //Edit Blog
        public ActionResult EditBlog(int Id)
        {
            BlogData data = new BlogData();

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM tbl_Blog WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.Id = Convert.ToInt32(reader["Id"]);
                            data.BlogTitle = reader["BlogTitle"].ToString();
                            data.MetaTitle = reader["MetaTitle"].ToString();
                            data.MetaDescription = reader["MetaDescription"].ToString();
                            data.Slug = reader["Slug"].ToString();
                            data.Blog_Img = reader["Blog_Img"].ToString();
                            data.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                            data.BlogDescription = reader["BlogDescription"].ToString();
                        }
                    }
                }
            }
            ViewBag.Categories = GetAllCategories(); // Method should return List<BlogCategory>

            return View(data);
        }

        //Upadte Blog
        [HttpPost]
        public ActionResult EditBlog(BlogData data, HttpPostedFileBase Blog_Img)
        {
            try
            {
                string oldImageName = "";
                string newImageName = "";

                //old image 
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    string selectQuery = "SELECT Blog_Img FROM tbl_blog WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", data.Id);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            oldImageName = result.ToString();
                        }
                        conn.Close();
                    }
                }

                if (Blog_Img != null)
                {
                    
                    string oldImagePath = Server.MapPath("~/Content/Blog_Uploaded_Image/" + oldImageName);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }

                    // New image upload
                    string Folder_Path = Server.MapPath("~/Content/Blog_Uploaded_Image/");
                    newImageName = Blog_Img.FileName;
                    string newFilePath = Path.Combine(Folder_Path, newImageName);

                    if (!Directory.Exists(Folder_Path))
                    {
                        Directory.CreateDirectory(Folder_Path);
                    }

                    Blog_Img.SaveAs(newFilePath);
                }
                else
                {
                  
                    newImageName = oldImageName;
                }

          
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    string updateQuery = @"UPDATE tbl_blog 
                                   SET BlogTitle = @BlogTitle,
                                       MetaTitle = @MetaTitle,
                                       MetaDescription = @MetaDescription,
                                       Slug = @Slug,
                                       Blog_Img = @Blog_Img,
                                       CategoryId = @CategoryId,
                                       BlogDescription = @BlogDescription
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", data.Id);
                        cmd.Parameters.AddWithValue("@BlogTitle", data.BlogTitle);
                        cmd.Parameters.AddWithValue("@MetaTitle", data.MetaTitle);
                        cmd.Parameters.AddWithValue("@MetaDescription", data.MetaDescription);
                        cmd.Parameters.AddWithValue("@Slug", data.Slug);
                        cmd.Parameters.AddWithValue("@Blog_Img", newImageName);
                        cmd.Parameters.AddWithValue("@CategoryId", data.CategoryId);
                        cmd.Parameters.AddWithValue("@BlogDescription", data.BlogDescription);

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            TempData["Success"] = "Blog updated successfully.";
                            return RedirectToAction("BlogList","Admin");
                        }
                    }
                }

                TempData["error"] = "Blog update failed.";
                return RedirectToAction("EditBlog","Admin");
            }
            catch (Exception ex)
            {
                TempData["error"] = "Error: " + ex.Message;
                return RedirectToAction("EditBlog","Admin");
            }
        }




        //Fetch Category
        public List<tbl_BlogCategory> GetAllCategories()
        {
            List<tbl_BlogCategory> categories = new List<tbl_BlogCategory>();

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT Id, BlogCategory FROM tbl_BlogCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new tbl_BlogCategory()
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                BlogCategory = reader["BlogCategory"].ToString()
                            });
                        }
                    }
                }
            }

            return categories;
        }
    }
}