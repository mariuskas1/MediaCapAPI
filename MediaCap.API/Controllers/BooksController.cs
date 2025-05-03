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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var booksDomainModel = await bookRepository.GetAllAsync();
            return Ok (mapper.Map<List<BookDTO>>(booksDomainModel));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var bookDomainModel = await bookRepository.GetByIdAsync(id);

            if(bookDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BookDTO>(bookDomainModel));
        }

        [HttpPut]
        [Route("{id:guid}")]

        public async Task<IActionResult> Update([FromRoute] Guid id, BookDTO bookDTO)
        {
            var bookDomainModel = mapper.Map<Book>(bookDTO);
            bookDomainModel = await bookRepository.UpdateAsync(id, bookDomainModel);

            if (bookDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BookDTO>(bookDomainModel));
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var bookDomainModel = await bookRepository.DeleteAsync(id);

            if (bookDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<BookDTO>(bookDomainModel));
        }



    }
}
