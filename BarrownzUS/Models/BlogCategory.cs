using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
	public class BlogCategory
	{
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string BlogCategoryName { get; set; }
        public DateTime Created_dt { get; set; }
    }
}