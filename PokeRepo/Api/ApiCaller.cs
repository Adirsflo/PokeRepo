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

                        _context.Abilities.Add(abilityModel);
                        newPokemon.Abilities.Add(abilityModel);
                    }

                    foreach (var type in result.Types)
                    {
                        TypeModel typeModel = new()
                        {
                            Name = type.Type.Name
                        };

                        _context.Types.Add(typeModel);
                        newPokemon.Types.Add(typeModel);
                    }

                    _context.Pokemons.Add(newPokemon);
                    _context.SaveChanges();

                    return result;
                }
            }
            throw new HttpRequestException("Could not deserialize Json");
        }
    }
}
