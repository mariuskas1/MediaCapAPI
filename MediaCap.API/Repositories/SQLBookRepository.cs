using MediaCap.API.Data;
using MediaCap.API.Models.Domain;

namespace MediaCap.API.Repositories
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly MediacapDbContext dbContext;

        public SQLBookRepository(MediacapDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Book> CreateAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book?> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(Guid id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
