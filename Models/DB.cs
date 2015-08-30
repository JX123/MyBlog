using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class DB:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Remark> Raemarks { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Life> Lifes { get; set; }
        public DB() : base("sqlserverdb") { }
    }
}