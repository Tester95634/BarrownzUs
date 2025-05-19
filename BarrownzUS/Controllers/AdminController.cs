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
    [CustomAuthorize]
    public class AdminController : Controller
    {
        //Database Connection

        private readonly string Connection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;

        // GET: Admin
        public ActionResult Dashboard()
        
        {

            var Houres = DateTime.Now.Hour;
            string greeting;
            if(Houres<12)
            {
                greeting = "Good Morning";
            }
            else if (Houres < 17)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }


            int UserCount = 0;
            int BlogCount = 0;
            int CategoryCount = 0;
         //User count
         using(SqlConnection con=new SqlConnection(Connection))
            {
                string query = "SELECT COUNT(*) FROM tbl_ContactEnquiry";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    UserCount = (int)cmd.ExecuteScalar();
                }
            }
         //Blog count
            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT COUNT(*) FROM tbl_Blog";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    BlogCount = (int)cmd.ExecuteScalar();
                }
            }
            //Category count
            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT COUNT(*) FROM tbl_BlogCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    CategoryCount = (int)cmd.ExecuteScalar();
                }
            }

            

            TempData["User"]= UserCount;
            TempData["blog"] = BlogCount;
            TempData["Category"] = CategoryCount;
            TempData["Greeting"] = greeting;
                return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //Admin Login
        [HttpPost]
        public ActionResult Login(Users data, string email,string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection))
                {
                    string query = "SELECT UserID,Username,Email,Password FROM tbl_Users WHERE Email=@Email";
                    using(SqlCommand cmd=new SqlCommand(query,conn)){
                        cmd.Parameters.AddWithValue("@Email", data.Email);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader()) {

                            if (reader.Read())
                            {
                                int UserID = Convert.ToInt32(reader["UserID"]);
                                string Username= reader["Username"].ToString();
                                string Email = reader["Email"].ToString();
                                string Password = reader["Password"].ToString();

                                Session["UserID"] = UserID;
                                Session["Username"] = Username;
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
         
            List<ContactEnquiry> Listdata=new List<ContactEnquiry>();
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "SELECT * FROM tbl_ContactEnquiry";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Listdata.Add(new ContactEnquiry()
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Service = reader["Service"].ToString(),
                                    Message = reader["Message"].ToString(),
                                    Created_dt = Convert.ToDateTime(reader["Created_dt"])

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
                    string query = "DELETE FROM tbl_ContactEnquiry WHERE ID=@ID";
                    using(SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", Id);
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
          
            List<BlogCategory> bloglist = new List<BlogCategory>();
            try
            {
                using(SqlConnection con=new SqlConnection(Connection))
                {
                    string query = "SELECT * FROM tbl_BlogCategory";
                    using(SqlCommand cmd=new SqlCommand(query,con))
                    {
                        con.Open();
                        using(SqlDataReader reader=cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bloglist.Add(new BlogCategory()
                                {
                                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                    BlogCategoryName = reader["BlogCategoryName"].ToString(),
                                    Created_dt = Convert.ToDateTime(reader["Created_dt"])
                                });

                            }
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
            }

            return View(bloglist);
        }

        //Add Blog Category

        [HttpPost]
        public ActionResult AddBlogCategory(BlogCategory CategoryData)
        {
              using(SqlConnection con=new SqlConnection(Connection))
                {
                    string query = "INSERT INTO tbl_BlogCategory(BlogCategoryName, Created_dt)" + "VALUES(@BlogCategoryName, @Created_dt)";
                    using(SqlCommand cmd=new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BlogCategoryName", CategoryData.BlogCategoryName);
                        cmd.Parameters.AddWithValue("@Created_dt", DateTime.Now);
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
        public ActionResult Delete_Category(int CategoryID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "DELETE FROM tbl_BlogCategory WHERE CategoryID=@CategoryID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CategoryID", CategoryID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                TempData["Msg"] = "Successfully delete";
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
            BlogCategory data = new BlogCategory();
            using(SqlConnection con=new SqlConnection(Connection))
            {
                string query = "SELECT * FROM tbl_BlogCategory WHERE CategoryID=@CategoryID";
                using(SqlCommand cmd=new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", Id);
                    con.Open();
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.CategoryID =Convert.ToInt32(reader["CategoryID"]);
                            data.BlogCategoryName = reader["BlogCategoryName"].ToString();
                        }
                    }

                }
            }

            return View(data);
        }

        //Edit  Category
        [HttpPost]
        public ActionResult EditCategory(BlogCategory data, int CategoryID)
        {
            try
            {
                if (data.CategoryID > 0)
                {
                    using (SqlConnection con = new SqlConnection(Connection))
                    {
                        string query = "UPDATE tbl_BlogCategory SET BlogCategoryName=@BlogCategoryName WHERE CategoryID=@CategoryID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@BlogCategoryName", data.BlogCategoryName);
                            cmd.Parameters.AddWithValue("@CategoryID", data.CategoryID);

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
                        string query = "INSERT INTO tbl_Blog (BlogTitle, MetaTitle, MetaDescription, Slug, Blog_Img, CategoryID, BlogDescription, Created_dt) " +
                                       "VALUES (@BlogTitle, @MetaTitle, @MetaDescription, @Slug, @Blog_Img, @CategoryID, @BlogDescription, @Created_dt)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BlogTitle", data.BlogTitle);
                            cmd.Parameters.AddWithValue("@MetaTitle", data.MetaTitle);
                            cmd.Parameters.AddWithValue("@MetaDescription", data.MetaDescription);
                            cmd.Parameters.AddWithValue("@Slug", data.Slug);
                            cmd.Parameters.AddWithValue("@Blog_Img", FileName);
                            cmd.Parameters.AddWithValue("@CategoryID", data.CategoryID);
                            cmd.Parameters.AddWithValue("@BlogDescription", data.BlogDescription);
                            cmd.Parameters.AddWithValue("@Created_dt",DateTime.Now);
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
                TempData["error"] = "Error: " + ex.Message;
                return RedirectToAction("AddBlog", "Admin");
            }
        }


        //Add fetch Blog data
        [ValidateInput(false)] //  Allows HTML content
        public ActionResult BlogList()
        {
            List<BlogData> list_Blog = new List<BlogData>();

            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = @"
                SELECT 
                    b.BlogID, b.BlogTitle,  b.MetaTitle,   b.MetaDescription, b.Slug,   b.Blog_Img, b.CategoryID, b.BlogDescription, b.Created_dt  ,c.BlogCategoryName FROM 
                    tbl_blog b
                INNER JOIN 
                    tbl_BlogCategory c ON b.CategoryID = c.CategoryID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list_Blog.Add(new BlogData()
                                {
                                    BlogID = Convert.ToInt32(reader["BlogID"]),
                                    BlogTitle = reader["BlogTitle"].ToString(),
                                    MetaTitle = reader["MetaTitle"].ToString(),
                                    MetaDescription = reader["MetaDescription"].ToString(),
                                    Slug = reader["Slug"].ToString(),
                                    Blog_Img = reader["Blog_Img"].ToString(),
                                    CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                    BlogDescription = reader["BlogDescription"].ToString(),
                                    BlogCategoryName=reader["BlogCategoryName"].ToString(),
                                    Created_dt = Convert.ToDateTime(reader["Created_dt"]),
                                    
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
        public ActionResult Delete_Blog(int BlogID)
        {
            try
            {
                string ImageName = string.Empty;
                string folderpath = Server.MapPath("~/Content/Blog_Uploaded_Image/");

                using (SqlConnection con = new SqlConnection(Connection))
                {
                    string query = "Select Blog_Img from tbl_Blog where BlogID=@BlogID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BlogID", BlogID);
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
                    string query = "DELETE FROM tbl_blog where BlogID=@BlogID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BlogID", BlogID);
                        con.Open();
                        cmd.ExecuteNonQuery();

                        TempData["Msg"] = "Data delete successfully";
                        return RedirectToAction("BlogList", "Admin");
                    }

                }
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
            }
            
            return View();
        }
        //Edit Blog
        public ActionResult EditBlog(int Id)
        {
            BlogData data = new BlogData();

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT * FROM tbl_Blog WHERE BlogID = @BlogID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@BlogID", Id);
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            data.BlogID = Convert.ToInt32(reader["BlogID"]);
                            data.BlogTitle = reader["BlogTitle"].ToString();
                            data.MetaTitle = reader["MetaTitle"].ToString();
                            data.MetaDescription = reader["MetaDescription"].ToString();
                            data.Slug = reader["Slug"].ToString();
                            data.Blog_Img = reader["Blog_Img"].ToString();
                            data.CategoryID = Convert.ToInt32(reader["CategoryID"]);
                            data.BlogDescription = reader["BlogDescription"].ToString();
                        }
                    }
                }
            }
            ViewBag.Categories = GetAllCategories(); // Method should return List<BlogCategory>
            return View(data);
        }
     //Upadate Blog
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
                    string selectQuery = "SELECT Blog_Img FROM tbl_Blog WHERE BlogID=@BlogID";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BlogID", data.BlogID);
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
                    string updateQuery = @"UPDATE tbl_Blog 
                                   SET BlogTitle = @BlogTitle,
                                       MetaTitle = @MetaTitle,
                                       MetaDescription = @MetaDescription,
                                       Slug = @Slug,
                                       Blog_Img = @Blog_Img,
                                       CategoryId = @CategoryId,
                                       BlogDescription = @BlogDescription
                                   WHERE BlogID = @BlogID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@BlogID", data.BlogID);
                        cmd.Parameters.AddWithValue("@BlogTitle", data.BlogTitle);
                        cmd.Parameters.AddWithValue("@MetaTitle", data.MetaTitle);
                        cmd.Parameters.AddWithValue("@MetaDescription", data.MetaDescription);
                        cmd.Parameters.AddWithValue("@Slug", data.Slug);
                        cmd.Parameters.AddWithValue("@Blog_Img", newImageName);
                        cmd.Parameters.AddWithValue("@CategoryID", data.CategoryID);
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
        public List<BlogCategory> GetAllCategories()
        {
            List<BlogCategory> categories = new List<BlogCategory>();

            using (SqlConnection con = new SqlConnection(Connection))
            {
                string query = "SELECT CategoryID, BlogCategoryName FROM tbl_BlogCategory";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new BlogCategory()
                            {
                                CategoryID = Convert.ToInt32(reader["CategoryID"]),
                                BlogCategoryName = reader["BlogCategoryName"].ToString()
                            });
                        }
                    }
                }
            }

            return categories;
        }
    }
}