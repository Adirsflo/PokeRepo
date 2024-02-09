using Newtonsoft.Json;
using PokeRepo.Database;
using PokeRepo.Models;

namespace PokeRepo.Api
{
    public class ApiCaller
    {
        public HttpClient Client { get; set; }
        private readonly PokemonDbContext _context;
        public ApiCaller(PokemonDbContext context)
        {
            _context = context;
            Client = new();

            Client.BaseAddress = new Uri("https://pokeapi.co/");
        }

        public async Task<Root> MakeCall(string Url)
        {

            HttpResponseMessage response = await Client.GetAsync(Url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                Root? result = JsonConvert.DeserializeObject<Root>(json);

                if (result != null)
                {
                    AddToDb(result);

                    return result;
                }
            }
            throw new HttpRequestException("Could not deserialize Json");
        }

        public async Task AddToDb(Root result)
        {
            var existingPokemon = _context.Pokemons.FirstOrDefault(p => p.Name == result.Name);
            if (existingPokemon == null)
            {
                PokemonModel newPokemon = new()
                {
                    Name = result.Name,
                    LocationAreaEncounters = result.LocationAreaEncounters,
                    Weight = result.Weight,
                    Sprites = result.Sprites.FrontDefault,
                };

                foreach (var ability in result.Abilities)
                {
                    AbilityModel abilityModel = new()
                    {
                        Name = ability.Ability.Name
                    };

                    newPokemon.Abilities.Add(abilityModel);
                }

                foreach (var type in result.Types)
                {
                    TypeModel typeModel = new()
                    {
                        Name = type.Type.Name
                    };

                    newPokemon.Types.Add(typeModel);
                }

                _context.Pokemons.Add(newPokemon);
                _context.SaveChanges();
            }
        }
    }
}
