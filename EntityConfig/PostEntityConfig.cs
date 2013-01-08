using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using DomainObjects;

namespace EntityConfig
{
    public class PostEntityConfig:EntityTypeConfiguration<PostEntity>
    {
        public PostEntityConfig()
        {
            ToTable("tbl_post");
            PropertyConfig();
            RelationshipConfig();
        }

        private void PropertyConfig()
        {
            Property(e => e.Id).HasColumnName("Id");
            Property(e => e.Title).HasColumnName("Title");
            Property(e => e.Message).HasColumnName("Message");
            Property(e => e.DatePosted).HasColumnName("DatePosted");
        }

        private void RelationshipConfig()
        {
            HasKey(e => e.Id);
        }
    }
}
