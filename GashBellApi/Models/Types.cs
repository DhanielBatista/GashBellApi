using System.ComponentModel.DataAnnotations;

namespace GashBellApi.Models
{
    public class Types
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
