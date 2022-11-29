using GashBellApi.Models;

namespace GashBellApi.Data.Dtos.Demon
{
    public class ReadDemonDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string NameEnglish { get; set; }
        public string NameKana { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Attribute { get; set; }
        public string BookColor { get; set; }
        
    }
}
