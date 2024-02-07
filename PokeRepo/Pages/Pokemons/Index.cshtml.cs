using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Models;

namespace PokeRepo.Pages.Pokemons
{
    public class IndexModel : PageModel
    {
        public List<string> Pokemons { get; set; } = new();
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {

            foreach (PokemonName pokemon in Enum.GetValues(typeof(PokemonName)))
            {
                Pokemons.Add(pokemon.ToString());
            }

            /*
             * L�s alla namnen i enumen
             * skapa en st�rng-lista av dom som en property
             * 
             * I HTML:
             * Loopa �ver str�nglistan
             * Skapa en l�nk f�r varje namn som g�r till /details med asp-route-PokemonName
             */
        }
    }
}
