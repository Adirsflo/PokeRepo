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
             * Läs alla namnen i enumen
             * skapa en stärng-lista av dom som en property
             * 
             * I HTML:
             * Loopa över stränglistan
             * Skapa en länk för varje namn som går till /details med asp-route-PokemonName
             */
        }
    }
}
