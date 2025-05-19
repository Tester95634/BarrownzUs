using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
    public class CategoryWithBlogModal
    {
        public List<BlogCategory> Category { get; set; }
        public List<BlogData> Posts { get; set; }
        
    }
}