namespace GashBellApi.Data.Dtos.Spell
{
    public class CreateSpellDto
    {
        public string Name { get; set; }
        public string JapaneseName { get; set; }
        public string SpellStyle { get; set; } //attack/defense 
        public string Description { get; set; }
    }
}
