using MediaCap.API.Data;
using MediaCap.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MediaCap.API.Repositories
{
    public class SQLFilmRepository : IFilmRepository
    {
        private readonly MediacapDbContext dbContext;

        public SQLFilmRepository(MediacapDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Film> CreateAsync(Film film)
        {
            await dbContext.Films.AddAsync(film);
            await dbContext.SaveChangesAsync();
            return film;
        }

        public async Task<Film?> DeleteAsync(Guid id)
        {
            var existingFilm = await dbContext.Films.FirstOrDefaultAsync(x => x.Id == id);
            if(existingFilm == null)
            {
                return null;
            }
            dbContext.Films.Remove(existingFilm);
            await dbContext.SaveChangesAsync();
            return existingFilm;
        }

        public async Task<List<Film>> GetAllAsync()
        {
            return await dbContext.Films.ToListAsync();
        }

        public async Task<Film?> GetByIdAsync(Guid id)
        {
            return await dbContext.Films.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Film?> UpdateAsync(Guid id, Film film)
        {
            var existingFilm = dbContext.Films.FirstOrDefault(x => x.Id == id);
            if (existingFilm == null)
            {
                return null;
            }
            existingFilm.Title = film.Title;
            existingFilm.Director = film.Director;
            existingFilm.Rating = film.Rating;

            await dbContext.SaveChangesAsync();
            return existingFilm;
        }
    }
}
