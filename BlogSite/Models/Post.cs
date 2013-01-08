using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Post
    {
        public string Title { get; set; }
        public DateTime DatePosted { get; set; }
        public string Message { get; set; }

    }
}