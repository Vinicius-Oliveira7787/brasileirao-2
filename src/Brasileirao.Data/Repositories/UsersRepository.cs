using Brasileirao.Api.Models.Entities;
using Brasileirao.Data;
using Brasileirao.Data.Repositories;

namespace Infra.Repositories
{
    public class UsersRepository : Repository<User>, IUsersRepository
    {
        public UsersRepository(BrasileiraoContext brasileiraoContext) : base(brasileiraoContext)
        {
        }
    }
}
