using Brasileirao.Api.Models.Entities;
using Brasileirao.Data.Interfaces;
using System.Collections.Generic;

namespace Infra.Repositories
{
    public interface ITeamsRepository : IRepository<Team>
    {
        IList<Team> GetAllIncludingPlayers();
    }
}