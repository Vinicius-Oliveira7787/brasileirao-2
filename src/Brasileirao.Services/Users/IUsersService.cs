using Brasileirao.Api.Models.Entities;
using Brasileirao.Api.Models.Enums;
using System;

namespace Brasileirao.Services.Users
{
    public interface IUsersService
    {
        void Create(
            string name,
            UserProfile profile,
            string email,
            string password
        );

        User GetById(Guid id);
    }
}
