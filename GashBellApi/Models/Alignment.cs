using System.ComponentModel.DataAnnotations;

namespace GashBellApi.Models
{
    public class Alignment
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string AligmentImage { get; set; }
        public string AligmentName { get; set; }
    }
}
