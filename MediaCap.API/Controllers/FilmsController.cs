using AutoMapper;
using MediaCap.API.Data;
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

    }
}
