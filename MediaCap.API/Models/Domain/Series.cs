namespace MediaCap.API.Models.Domain
{
    public class Series
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public int Year { get; set; }
        public int YearWatched { get; set; }
        public int MonthWatched { get; set; }
        public bool Favorite { get; set; }
        public int Timestamp { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
    }
}
