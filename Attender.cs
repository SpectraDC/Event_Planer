using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YAZLAB1_PROJE2.Models
{
    public class Attender
    {
        [Key]
        public int AttenderID { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }    
    }
}