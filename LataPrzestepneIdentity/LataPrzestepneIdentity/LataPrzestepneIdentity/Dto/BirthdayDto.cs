namespace LataPrzestepneIdentity.Dto
{
    public class BirthdayDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Year { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ResultMessage { get; set; }
        public string UserId { get; set; }
    }
}
