using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    /// <summary>
    /// 评论表
    /// </summary>
    public class Remark
    {
        public int ID { get; set; }
        public string  Content { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("Blog")]
        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
        public int? FatherID { get; set; }
    }
}