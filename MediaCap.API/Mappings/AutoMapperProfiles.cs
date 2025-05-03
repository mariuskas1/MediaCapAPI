using AutoMapper;
using MediaCap.API.Models.Domain;
using MediaCap.API.Models.DTO;

namespace MediaCap.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<BookDTO, Book>().ReverseMap();

        }
    }
}
