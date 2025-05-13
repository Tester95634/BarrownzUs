using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
    public class BlogData
    {
        [Key]
        public int Id { get; set; }
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
        public int CategoryId {  get; set; }
        [Required]
        public string BlogDescription { get; set; }

        // Add this to store category name from JOIN
        public string BlogCategory { get; set; }
    }
}