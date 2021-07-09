using System;
using Brasileirao.Api.Models.Entities;
using Brasileirao.Api.Models.Enums;
using Infra.Repositories;

namespace Brasileirao.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Create(
            string name,
            UserProfile profile,
            string email,
            string password
        )
        {
            var user = new User(name, password, email, profile);

            if (user.Validate().isValid)
            {
                _usersRepository.Add(user);
            }
        }

        public User GetById(Guid id)
        {
            return _usersRepository.Get(x => x.Id == id);
        }
    }
}
