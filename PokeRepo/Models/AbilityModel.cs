using System.ComponentModel.DataAnnotations;

namespace PokeRepo.Models
{
    public class AbilityModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int PokemonId { get; set; }
        public PokemonModel? Pokemon { get; set; }
    }
}
