using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YAZLAB1_PROJE2.Models
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }
        public int UserID { get; set; }
        public int EarnedScore { get; set; }
        public DateTime Date { get; set; }
    }
}