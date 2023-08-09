using Microsoft.EntityFrameworkCore;

namespace EFCrudUygulama2.Data
{
    public class HayvanContext : DbContext
    {
        public DbSet<Hayvan> Hayvanlar => Set<Hayvan>();

        public HayvanContext(DbContextOptions<HayvanContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hayvan>().HasData(
                new Hayvan { Id = 1, Ad = "Kedi"},
                new Hayvan { Id = 2, Ad = "Köpek" },
                new Hayvan { Id = 3, Ad = "Aslan" },
                new Hayvan { Id = 4, Ad = "Kuş" }
                );
        }
    }
}
