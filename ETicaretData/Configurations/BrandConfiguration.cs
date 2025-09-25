using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaretData.Configurations
{
    class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Description).HasColumnType("text");
            builder.Property(x => x.Logo).HasMaxLength(250).HasColumnType("varchar(250)");


        }
    }
}
