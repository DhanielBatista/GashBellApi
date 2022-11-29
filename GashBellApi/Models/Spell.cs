using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GashBellApi.Models
{
    public class Spell
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string JapaneseName { get; set; }
        [JsonIgnore]
        public virtual List<Types> Type { get; set; }
        public string SpellStyle { get; set; } //attack/defense 
        public string Description { get; set; }
    }
}
