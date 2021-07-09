using System;
using Brasileirao.Api.Models.Entities;
using Brasileirao.Data;
using Brasileirao.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TeamPlayersRepository : Repository<TeamPlayer>, ITeamPlayersRepository
    {
        public TeamPlayersRepository(BrasileiraoContext DBContext) : base(DBContext)
        {
        }

        public void Remove(Guid id)
        {
            var teamPlayer = new TeamPlayer(id);
            brasileiraoContext.Entry(teamPlayer).State = EntityState.Deleted;
            brasileiraoContext.SaveChanges();
        }
    }
}
