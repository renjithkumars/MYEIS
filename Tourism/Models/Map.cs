using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class Map
    {
        [DisplayName("Enter Latitude")]
        [Required]
        public string latitude { get; set; }
        [Required]
        [DisplayName("Enter Longitude")]
        public string logitude { get; set; }
    }
}