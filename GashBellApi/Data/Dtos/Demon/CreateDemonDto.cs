namespace GashBellApi.Data.Dtos.Demon
{
    public class CreateDemonDto
    {
        public string Image { get; set; }
        public string NameEnglish { get; set; }
        public string NameKana { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Attribute { get; set; }
        public string BookColor { get; set; }
        public int PartnerId { get; set; }
    }
}
