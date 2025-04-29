using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YAZLAB1_PROJE2.Models
{
    public class AppDbContext : DbContext   
    {
        public DbSet<User> User { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Attender> Attender { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}