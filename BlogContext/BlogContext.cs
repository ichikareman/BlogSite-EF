using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DomainObjects;
using EntityConfig;


namespace BlogContext
{
    public class BlogContext : DbContext
    {
        public IDbSet<PostEntity> PostEntities { get; set; }

        public BlogContext()
            :base("name=BlogContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PostEntityConfig());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
