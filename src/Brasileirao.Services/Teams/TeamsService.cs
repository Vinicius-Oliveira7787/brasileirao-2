using Brasileirao.Api.Models.Entities;
using Infra.Repositories;
using System.Collections.Generic;

namespace Brasileirao.Services.Teams
{
    public class TeamsService : ITeamsService
    {
        private readonly ITeamsRepository _teamsRepository;
        public TeamsService(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        public void Create(string name)
        {
            var team = new Team(name);

            if (team.Validate().isValid)
            {
                _teamsRepository.Add(team);
            }
        }

        public IList<Team> GetAll()
        {
            return _teamsRepository.GetAllIncludingPlayers();
        }
    }
}
