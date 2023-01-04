using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.GroupServices
{
    public interface IGroupService
    {
        public GroupDTO GetGroup(string id);
    }
}