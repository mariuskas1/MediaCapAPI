using MediaCap.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaCap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly MediacapDbContext dbContext;

        public BooksController(MediacapDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
