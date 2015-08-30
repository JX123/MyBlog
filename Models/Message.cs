using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    /// <summary>
    /// 留言表
    /// </summary>
    public class Message
    {
        public int ID { get; set; }
        public string Content { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime Time { get; set; }
        public int? FatherID { get; set; }

    }
}