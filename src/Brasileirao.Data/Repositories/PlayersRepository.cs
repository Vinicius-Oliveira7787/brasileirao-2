using Brasileirao.Api.Models.Entities;
using Brasileirao.Data.Interfaces;

namespace Brasileirao.Data.Repositories
{
    public class PlayersRepository : Repository<Player>, IPlayersRepository
    {
        public PlayersRepository(BrasileiraoContext DBContext) : base(DBContext)
        {
        }
    }
}
