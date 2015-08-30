using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index]
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Remark> Replies { get; set; }

        /// <summary>
        /// 浏览
        /// </summary>
        public int Browses { get; set; }
        public string TypeBelonger { get; set; }
    }
}