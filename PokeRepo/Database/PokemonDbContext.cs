using Microsoft.EntityFrameworkCore;
using PokeRepo.Models;

namespace PokeRepo.Database
{
    public class PokemonDbContext : DbContext
    {
        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {

        }
        public DbSet<PokemonModel> Pokemons { get; set; }
        public DbSet<AbilityModel> Abilities { get; set; }
        public DbSet<TypeModel> Types { get; set; }

    }
}
