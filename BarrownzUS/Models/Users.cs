﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BarrownzUS.Models
{
	public class Users
	{
        [Key]
        public int Id { get; set; }
        [Required]
        public string Usernmae { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}