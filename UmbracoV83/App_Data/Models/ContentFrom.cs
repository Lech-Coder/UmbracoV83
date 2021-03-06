﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UmbracoV83.Models
{
    public class ContentFrom {
        [Required]
        public String Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required]
        public String Subject { get; set; }
        [Required]
        public String Message { get; set; }
    }
}