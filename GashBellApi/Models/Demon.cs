using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GashBellApi.Models
{
    public class Demon
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string NameEnglish { get; set; }
        public string NameKana { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Attribute { get; set; }
        public string BookColor { get; set; }
        public virtual Human Partner { get; set; }
        public int PartnerId { get; set; }
        [JsonIgnore]
        public virtual List<Spell> Spells { get; set; }
       
    }
}
