using System.Threading.Tasks;
using AutoMapper;
using Breath_API.Data;
using Breath_API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Breath_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
       private readonly IBreathRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IBreathRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _repo.GetUser(id);
            var userToReturn = _mapper.Map<UserForDetailedDto>(user);
            return Ok(userToReturn);
        }
    }
}