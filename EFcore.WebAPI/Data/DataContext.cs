using EFcore.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcore.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => { 
                 entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
            });
        }
    }
}
