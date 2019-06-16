using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace UniPin_DataAccess.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Ime).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Prezime).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Lozinka).IsRequired().HasMaxLength(30);
            builder.Property(u => u.KorisnickoIme).IsRequired().HasMaxLength(30);

            builder.HasIndex(u => u.KorisnickoIme).IsUnique();

           
        }
    }
}
