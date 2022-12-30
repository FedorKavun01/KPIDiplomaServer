using KPIsnik.Infrastructure.DTO;

namespace KPIsnik.Core.Services.UserServices
{
    public interface IUserService
    {
        public UserDTO GetUser(string id);
        public UserDTO SignIn(SignInEntityDTO entity);
    }
}