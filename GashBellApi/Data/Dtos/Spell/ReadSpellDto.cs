namespace GashBellApi.Data.Dtos.Spell
{
    public class ReadSpellDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JapaneseName { get; set; }
        public string SpellStyle { get; set; } //attack/defense 
        public string Description { get; set; }
    }
}
