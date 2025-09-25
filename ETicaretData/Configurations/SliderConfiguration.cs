using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ETicaretData.Configurations
{
    class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
           builder.Property(x => x.Title).HasMaxLength(100).HasColumnType("varchar(250)");
           builder.Property(x => x.Description).HasMaxLength(150).HasColumnType("varchar(500)");
           builder.Property(x => x.ImageUrl).HasMaxLength(250).HasColumnType("varchar(100)");
           builder.Property(x => x.Link).HasMaxLength(100);
        }
    }
}
