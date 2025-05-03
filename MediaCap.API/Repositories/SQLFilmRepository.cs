using MediaCap.API.Models.Domain;

namespace MediaCap.API.Repositories
{
    public class SQLFilmRepository : IFilmRepository
    {
        public Task<Film> CreateAsync(Film film)
        {
            throw new NotImplementedException();
        }

        public Task<Film?> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Film>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Film> UpdateAsync(Guid id, Film film)
        {
            throw new NotImplementedException();
        }
    }
}
