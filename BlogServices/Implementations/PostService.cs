using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainObjects;

namespace BlogServices.Implementations
{
    public class PostService : IPostService
    {
        private BlogContext.BlogContext _context;
        public PostService()
        {
            _context = new BlogContext.BlogContext();
        }


        public PostEntity Get(int id)
        {
            return _context.Set<PostEntity>().Where(e => e.Id == id).FirstOrDefault();
        }

        public IEnumerable<PostEntity> All()
        {
            return _context.Set<PostEntity>().AsEnumerable();
        }
    }
}
