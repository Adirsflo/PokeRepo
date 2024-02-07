namespace PokeRepo.Models
{
    public class Root
    {
        public List<Ability> Abilities { get; set; }
        public List<Form> Forms { get; set; }
        public int? Id { get; set; }
        public string LocationAreaEncounters { get; set; }
        public string Name { get; set; }
        public List<Type> Types { get; set; }
        public int? Weight { get; set; }
    }

    public class Ability
    {
        public Ability Abilitys { get; set; }
        public bool? IsHidden { get; set; }
        public int? Slot { get; set; }
    }

    public class Form
    {
        public string Name { get; set; }

        public string Url { get; set; }
    }

    public class Type
    {
        public int? Slot { get; set; }
        public Type Types { get; set; }
    }


}
