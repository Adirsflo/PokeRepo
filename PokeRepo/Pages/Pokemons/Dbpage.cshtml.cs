using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Pages.Pokemons
{
    public class DbpageModel : PageModel
    {
        private readonly PokemonDbContext _context;
        public List<PokemonModel> Pokemons { get; set; }
        public DbpageModel(PokemonDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Pokemons = _context.Pokemons.Include(p => p.Abilities).Include(p => p.Types).ToList();
        }
    }
}
