using AutoMapper;
using Breath_API.Dtos;
using Breath_API.Models;

namespace Breath_API.Helpers
{
    public class AutoMapperMappings : Profile
    {
        public AutoMapperMappings()
        {
            CreateMap<User, UserForDetailedDto>();
        }
    }
}