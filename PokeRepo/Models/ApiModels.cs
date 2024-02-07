using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PokeRepo.Models
{
    public class Root
    {
        [Key]
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("abilities")]
        public List<AbilityModel> Abilities { get; set; }
        [JsonProperty("location_area_encounters")]
        public string LocationAreaEncounters { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public List<TypeModel> Types { get; set; }
        [JsonProperty("weight")]
        public int? Weight { get; set; }

        [JsonProperty("sprites")]
        public Sprites Sprites { get; set; }
    }

    public class Sprites
    {
        [JsonProperty("back_default")]
        public string BackDefault { get; set; }

        [JsonProperty("back_female")]
        public string BackFemale { get; set; }

        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }

        [JsonProperty("back_shiny_female")]
        public string BackShinyFemale { get; set; }

        [JsonProperty("front_default")]
        public string FrontDefault { get; set; }

        [JsonProperty("front_female")]
        public string FrontFemale { get; set; }

        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }

        [JsonProperty("front_shiny_female")]
        public string FrontShinyFemale { get; set; }
    }

    public class TypeModel
    {
        [JsonProperty("slot")]
        public int? Slot { get; set; }

        [JsonProperty("type")]
        public TypeCore Type { get; set; }
    }

    public class TypeCore
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AbilityModel
    {
        [JsonProperty("ability")]
        public AbilityCore Ability { get; set; }
    }

    public class AbilityCore
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
