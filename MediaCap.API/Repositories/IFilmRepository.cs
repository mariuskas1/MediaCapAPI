using MediaCap.API.Models.Domain;

namespace MediaCap.API.Repositories
{
    public interface IFilmRepository
    {
        Task<List<Film>> GetAllAsync();
        Task<Film?> GetByIdAsync(Guid id);
        Task<Film> CreateAsync(Film film);
        Task<Film?> UpdateAsync(Guid id, Film film);
        Task<Film?> DeleteAsync(Guid id);
    }
}
