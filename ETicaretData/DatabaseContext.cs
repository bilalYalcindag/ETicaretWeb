using ETicaretCore.Entities;
using ETicaretData.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ETicaretData
{
    class DatabaseContext:DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-NPQR203;database=ETicaretDb;trusted_connection=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new AppUserConfiguration());
          //  modelBuilder.ApplyConfiguration(new BrandConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly
                (Assembly.GetExecutingAssembly());
           
            // Product.Price decimal ayarı
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");  // SQL tarafında uygun decimal tipi
            base.OnModelCreating(modelBuilder);
        }



    }
}
