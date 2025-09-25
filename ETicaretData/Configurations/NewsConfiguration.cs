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
    class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired().HasColumnType("varchar(150)");
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.ImageUrl).HasMaxLength(100);
        }
    }
}
