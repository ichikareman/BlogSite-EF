using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DomainObjects;

namespace BlogContext
{
    public class DbInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var ent = new PostEntity
                                 {
                                     DatePosted = DateTime.Now,
                                     Message = "Hi",
                                     Title = "Hello world"
                                 };

            context.Entry(ent).State = EntityState.Added;

            ent = new PostEntity
            {
                DatePosted = DateTime.Now,
                Message = "Hi 2",
                Title = "Hello world 2"
            };

            context.Entry(ent).State = EntityState.Added;

            ent = new PostEntity
            {
                DatePosted = DateTime.Now,
                Message = "Hi 3",
                Title = "Hello world 3"
            };

            context.Entry(ent).State = EntityState.Added;

            ent = new PostEntity
            {
                DatePosted = DateTime.Now,
                Message = "Hi 4",
                Title = "Hello world 4"
            };

            context.Entry(ent).State = EntityState.Added;

            context.SaveChanges();


            base.Seed(context);
        }

        //public DbInitializer()
        //{
        //     InitializeDatabase(new BlogContext());   
        //}


        public void InitializeDatabase(BlogContext context)
        {
            
            
        }
    }
}
