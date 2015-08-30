using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    /// <summary>
    /// 博文表
    /// </summary>
    public class Blog
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public byte[] Picture { get; set; }
    }
}