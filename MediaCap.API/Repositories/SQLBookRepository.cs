using MediaCap.API.Data;
using MediaCap.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace MediaCap.API.Repositories
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly MediacapDbContext dbContext;

        public SQLBookRepository(MediacapDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Book> CreateAsync(Book book)
        {
            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
            return book;
        }

        public async Task<Book?> DeleteAsync(Guid id)
        {
            var existingBook = await dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (existingBook == null)
            {
                return null;
            }
            dbContext.Books.Remove(existingBook);
            await dbContext.SaveChangesAsync();
            return existingBook;
        }

        public async Task<List<Book>> GetAllAsync()
        {
           return await dbContext.Books.ToListAsync();
        }

        public async Task<Book?> GetByIdAsync(Guid id)
        {
            return await dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
                 
        }

        public async Task<Book> UpdateAsync(Guid id, Book book)
        {
            var existingBook = dbContext.Books.FirstOrDefault(x => x.Id == id);
            if (existingBook == null)
            {
                return null;
            }
            existingBook.Title = book.Title;
            existingBook.Author = book.Author;
            existingBook.Rating = book.Rating;

            await dbContext.SaveChangesAsync();
            return existingBook;
        }
    }
}
