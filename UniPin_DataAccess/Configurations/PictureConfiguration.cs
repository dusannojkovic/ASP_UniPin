using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniPin_DataAccess.Configurations
{
    public class PictureConfiguration : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.Property(s => s.Alt).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Putanja).IsRequired().HasMaxLength(50);
            
            
        }
    }
}
