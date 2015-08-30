using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Controllers.ViewModel
{
    public class vCurrentUser
    {
        public int ID { get; set; }
        public string CurrentName { get; set; }
        public byte[] Picture { get; set; }
        public vCurrentUser() { }
        public vCurrentUser(User model)
        {
            this.ID = model.ID;
            this.CurrentName = model.UserName;
            this.Picture = model.Picture;

        }
    }
}