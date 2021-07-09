using System;
using Brasileirao.Api.Models.Entities;
using Brasileirao.Data.Interfaces;
using Infra.Repositories;

namespace Brasileirao.Services.Players
{
    public class PlayersService : IPlayersService
    {
        private readonly IPlayersRepository _playersRepository;
        private readonly ITeamPlayersRepository _teamPlayersRepository;

        public PlayersService(IPlayersRepository playersRepository, ITeamPlayersRepository teamPlayersRepository)
        {
            _playersRepository = playersRepository;
            _teamPlayersRepository = teamPlayersRepository;
        }

        public void Create(Guid teamId, string name)
        {
            var player = new Player(name);

            if (player.Validate().isValid)
            {
                player.AddTeam(teamId);
                _playersRepository.Add(player);
            }
        }
    }
}
