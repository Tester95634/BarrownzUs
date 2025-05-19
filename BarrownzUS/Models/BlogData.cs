using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarrownzUS.Models
{
    public class BlogData
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        public string BlogTitle { get; set; }
        [Required]
        public string MetaTitle { get; set; }
        [Required]
        public string MetaDescription { get; set; }
        [Required]
        public string Slug {  get; set; }
        [Required]
        public string Blog_Img { get; set; }
        [Required]
        public int CategoryID {  get; set; }

        [AllowHtml] //  Allows HTML content in BlogDescription
        [Required]
        public string BlogDescription { get; set; }

        // Add this to store category name from JOIN
        public string BlogCategoryName { get; set; }

        public DateTime Created_dt { get; set; }
     


    }
}