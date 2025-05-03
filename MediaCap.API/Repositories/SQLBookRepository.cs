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
        public async Task<List<Book>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
