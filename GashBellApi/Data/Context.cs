using GashBellApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GashBellApi.Data
{
    public class Context : DbContext
    {
        public  Context(DbContextOptions<Context>opt) : base(opt)
        {

        }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Demon> Demons { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Types> Types { get; set; }
    }
}
