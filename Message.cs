using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YAZLAB1_PROJE2.Models
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}