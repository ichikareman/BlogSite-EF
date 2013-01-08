using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainObjects
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePosted { get; set; }
        public string Message { get; set; }

    }
}
