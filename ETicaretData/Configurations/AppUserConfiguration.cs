

using ETicaretCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaretData.Configurations
{
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
         builder.Property(x => x.Name).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
         builder.Property(x => x.Surname).HasMaxLength(50).IsRequired().HasColumnType("varchar(50)");
         builder.Property(x => x.Email).HasMaxLength(100).IsRequired().HasColumnType("varchar(100)");
         builder.Property(x => x.Phone).HasMaxLength(20).HasColumnType("varchar(20)");
         builder.Property(x => x.Password).HasMaxLength(200).IsRequired().HasColumnType("varchar(200)");
         builder.Property(x => x.UserName).HasMaxLength(50).HasColumnType("varchar(50)");
            builder.HasData(
              new AppUser
              {
                  Id = 1,
                  CreateDate = new DateTime(2025, 01, 01),
                  UserName = "admin",
                  Email = "admin@etcaret.io",
                  IsActive = true,
                  IsAdmin = true,
                  Name = "Test",
                  Password = "123456*",
                  Surname = "User",
                  Phone = "1234567890",
                  UserGuid = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")


              }
                );
        }
    }
}
