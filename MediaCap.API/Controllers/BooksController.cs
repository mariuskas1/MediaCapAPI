using MediaCap.API.Data;
using MediaCap.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaCap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly MediacapDbContext dbContext;
        private readonly IBookRepository bookRepository;

        public BooksController(MediacapDbContext dbContext, IBookRepository bookRepository)
        {
            this.dbContext = dbContext;
            this.bookRepository = bookRepository;
        }
    }
}
