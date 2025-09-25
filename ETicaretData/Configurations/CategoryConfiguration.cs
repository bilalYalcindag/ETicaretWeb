

using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaretData.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.Property(x => x.Name).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
           
           builder.Property(x => x.ImageUrl).HasMaxLength(250).HasColumnType("varchar(250)");
            builder.HasData(
           new Category
           {
               Name = "Elektronik",
               Id = 1,         
               IsActive = true,
               IsTopMenu = true,
               ParentId = 0,
               OrderNo = 1,

           },
           new Category
           {
               Name = "Bilgisayar",
               Id = 2,
               IsActive = true,
               IsTopMenu = true,
               ParentId = 1,
               OrderNo = 1,
           }
           );


        }
    }
}
