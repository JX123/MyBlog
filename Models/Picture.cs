using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    public class Picture
    {
        public int ID { get; set; }
        [ForeignKey("Blog")]
        public int BlogID { get; set; }
    }
}