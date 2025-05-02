namespace MediaCap.API.Models.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public int Year { get; set; }
        public int YearRead { get; set; }
        public int MonthRead { get; set; }
        public bool Favorite { get; set; }
        public int Timestamp { get; set; }
        public List<string> Genres { get; set; } = new List<string>();

    }
}
