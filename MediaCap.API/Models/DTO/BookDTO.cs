using MediaCap.API.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaCap.API.Models.DTO
{
    public class BookDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int Rating { get; set; }
        public int Year { get; set; }
        public int YearRead { get; set; }
        public int MonthRead { get; set; }
        public bool Favorite { get; set; }
        public int Timestamp { get; set; }
        public List<string> Genres { get; set; } = new List<string>();
    }
}
