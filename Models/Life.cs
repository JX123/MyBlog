using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Life
    {
        public int ID { get; set; }
        public byte[] Picture { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
    }
}