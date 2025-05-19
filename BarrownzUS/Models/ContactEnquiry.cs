using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
    public class ContactEnquiry
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Service { get; set; }
        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime Created_dt { get; set; }


    }
}