using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokeRepo.Models
{
    public class TypeModel
    {
        [Key]
        [Column("type_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("pokemon_id")]
        public int PokemonId { get; set; }
        public PokemonModel? Pokemon { get; set; }
    }
}
