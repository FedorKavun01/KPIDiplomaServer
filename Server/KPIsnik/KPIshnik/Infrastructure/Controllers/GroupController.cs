using System.Threading.Tasks;
using KPIsnik.Core.Services.GroupServices;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KPIsnik.Infrastructure.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GroupController
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet("GetGroup")]
        public async Task<GroupDTO> GetGroup(string id) => _groupService.GetGroup(id);
    }
}