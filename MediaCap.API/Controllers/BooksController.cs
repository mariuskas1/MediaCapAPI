using AutoMapper;
using MediaCap.API.Data;
using MediaCap.API.Models.Domain;
using MediaCap.API.Models.DTO;
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
        private readonly IMapper mapper;

        public BooksController(MediacapDbContext dbContext, IBookRepository bookRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.bookRepository = bookRepository;
            this.mapper = mapper;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BookDTO bookDTO)
        {
            var bookDomainModel = mapper.Map<Book>(bookDTO);
            await bookRepository.CreateAsync(bookDomainModel);
            return Ok(mapper.Map<BookDTO>(bookDomainModel));
        }





    }
}
