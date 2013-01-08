using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;

namespace BlogServices
{
    public interface IPostService
    {
        PostEntity Get(int id);
        IEnumerable<PostEntity> All();
    }
}
