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
    public class FilmsController : ControllerBase
    {
        private readonly MediacapDbContext dbContext;
        private readonly IFilmRepository filmRepository;
        private readonly IMapper mapper;

        public FilmsController(MediacapDbContext dbContext, IFilmRepository filmRepository, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.filmRepository = filmRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] FilmDTO filmDTO)
        {
            var filmDomainModel = mapper.Map<Film>(filmDTO);
            await filmRepository.CreateAsync(filmDomainModel);
            return Ok(mapper.Map<FilmDTO>(filmDomainModel));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var filmsDomainModel = await filmRepository.GetAllAsync();
            return Ok(mapper.Map<List<FilmDTO>>(filmsDomainModel));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var filmDomainModel = await filmRepository.GetByIdAsync(id);
            if (filmDomainModel == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<FilmDTO>(filmDomainModel));
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, FilmDTO filmDTO)
        {
            var filmDomainModel = mapper.Map<Film>(filmDTO);
            filmDomainModel = await filmRepository.UpdateAsync(id, filmDomainModel);

            if(filmDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<FilmDTO>(filmDomainModel));
        }


        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var filmDomainModel = await filmRepository.DeleteAsync(id);
            if (filmDomainModel == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<FilmDTO>(filmDomainModel));
        }
    }
}
