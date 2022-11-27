using System;
using System.Linq;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Http;

namespace KPIsnik.Core.Services.GroupServices
{
    public class GroupService : IGroupService
    {
        private readonly KPIshnikDBContext _context;

        public GroupService(KPIshnikDBContext context)
        {
            _context = context;
        }
        
        public GroupDTO GetGroup(string id)
        {
            var group = _context.Groups.ToList().Find(group => group.id == Guid.Parse(id));

            if (group == null)
            {
                throw new BadHttpRequestException("Incorrect group id");
            }

            var groupDTO = new GroupDTO()
            {
                ID = group.id,
                Name = group.name,
                CuratorName = group.curatorname
            };

            return groupDTO;
        }
    }
}