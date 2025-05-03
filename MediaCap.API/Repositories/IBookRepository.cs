using MediaCap.API.Models.Domain;

namespace MediaCap.API.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
    }
}
