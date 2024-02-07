using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PokeRepo.Api;
using PokeRepo.Models;

namespace PokeRepo.Pages
{
    public class IndexModel : PageModel
    {
        public Root Pokemon { get; set; }

        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {

            string pokemonName = "charizard";

            try
            {
                Root result = await new ApiCaller().MakeCall($"/api/v2/pokemon/{pokemonName}");

                Pokemon = result;

            }
            catch (Exception ex)
            {

            }

        }
    }
}
