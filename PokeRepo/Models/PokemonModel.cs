using System.ComponentModel.DataAnnotations;

namespace PokeRepo.Models
{
    public class PokemonModel
    {
        [Key]
        public int Id { get; set; }
        public List<AbilityModel> Abilities { get; set; } = new();
        public string LocationAreaEncounters { get; set; }
        public string Name { get; set; }
        public List<TypeModel> Types { get; set; } = new();
        public int? Weight { get; set; }
        public string Sprites { get; set; }
    }
}
