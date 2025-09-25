using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretData.Configurations
{
    class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
           builder.Property(x => x.Name).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
           builder.Property(x => x.Surname).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
           builder.Property(x => x.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
           builder.Property(x => x.Phone).HasMaxLength(11).HasColumnType("varchar(11)");
           builder.Property(x => x.Message).HasMaxLength(50).IsRequired();
        }
    }
}
