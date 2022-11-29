namespace GashBellApi.Data.Dtos.Human
{
    public class ReadHumanDto
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string NameEnglish { get; set; }
        public string NameKana { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Birthday { get; set; }// example : Setember 18
        public int Age { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string BloodType { get; set; }
    }
}
