using System.Threading.Tasks;
using KPIsnik.Core.Services.UserServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUser")]
        public async Task<UserDTO> GetGroup(string id) => _userService.GetUser(id);

        [HttpPost("SignIn")]
        public async Task<UserDTO> SignIn(SignInEntityDTO dto) => _userService.SignIn(dto);
    }
}