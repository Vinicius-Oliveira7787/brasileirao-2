using Brasileirao.Api.Models.Entities;
using System.Collections.Generic;

namespace Brasileirao.Services.Teams
{
    public interface ITeamsService
    {
        void Create(string name);
        IList<Team> GetAll();
    }
}
