using Microsoft.EntityFrameworkCore;
using PokeRepo.Models;

namespace PokeRepo.Database
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {

        }

        public DbSet<Root> Roots { get; set; }
        public DbSet<Sprites> Sprites { get; set; }
        public DbSet<TypeModel> TypeModels { get; set; }
        public DbSet<TypeCore> TypeCores { get; set; }
        public DbSet<AbilityModel> AbilityModels { get; set; }
        public DbSet<AbilityCore> AbilityCores { get; set; }

    }
}
