using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Pages.Pokemons
{
    public class DetailsModel : PageModel
    {
        private readonly PokemonDbContext _context;
        public DetailsModel(PokemonDbContext context)
        {
            _context = context;
        }
        public Root Pokemon { get; set; }
        public string? ErrorMessage { get; set; }
        public async Task OnGet(string pokemonName)
        {

            try
            {
                Root result = await new ApiCaller(_context).MakeCall($"/api/v2/pokemon/{pokemonName.ToLower()}");

                Pokemon = result;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
