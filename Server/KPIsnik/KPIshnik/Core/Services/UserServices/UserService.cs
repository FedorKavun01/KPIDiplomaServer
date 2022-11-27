using System;
using System.Linq;
using KPIsnik.Infrastructure;
using KPIsnik.Infrastructure.DTO;
using Microsoft.AspNetCore.Http;

namespace KPIsnik.Core.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly KPIshnikDBContext _context;
        
        public UserService(KPIshnikDBContext context)
        {
            _context = context;
        }
        
        public UserDTO GetUser(string id)
        {
            var user = _context.Users.ToList().Find(user => user.id == Guid.Parse(id));

            if (user == null)
            {
                throw new BadHttpRequestException("Incorrect user id");
            }

            var userDTO = new UserDTO
            {
                ID = user.id,
                GroupID = user.groupid,
                FirstName = user.firstname,
                LastName = user.lastname,
                Login = user.login,
                Password = user.password
            };

            return userDTO;
        }
    }
}