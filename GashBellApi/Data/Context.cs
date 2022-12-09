using GashBellApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GashBellApi.Data
{
    public class Context : DbContext
    {
        public  Context(DbContextOptions<Context>opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Demon>()
                .HasOne(demon => demon.Partner)
                .WithOne(human => human.Demon)
                .HasForeignKey<Demon>(demon => demon.PartnerId);

        }

        public DbSet<Human> Humans { get; set; }
        public DbSet<Demon> Demons { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Alignment> Alignments { get; set; }

        
    }
}
