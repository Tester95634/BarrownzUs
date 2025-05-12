using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
    public class tbl_BlogCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string BlogCategory {  get; set; }
    }
}