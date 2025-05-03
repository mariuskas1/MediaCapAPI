using MediaCap.API.Models.Domain;

namespace MediaCap.API.Repositories
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(Guid id);
        Task<Book> CreateAsync(Book book);
        Task<Book> UpdateAsync(Guid id, Book book);
        Task<Book?> DeleteAsync(Guid id);
    }
}
