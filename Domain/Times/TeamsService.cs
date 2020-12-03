using System;

namespace Domain.Teams
{
    public class TeamService
    {
        public CreatedTeamDTO Create(string name)
        {
            var team = new Team(name);
            var teamValidation = team.Validate();

            if (teamValidation.isValid)
            {
                TeamRepository.Add(team);
                return new CreatedTeamDTO(team.Id);
            }

            return new CreatedTeamDTO(teamValidation.errors);
        }

        public CreatedTeamDTO Update(Guid id, string name)
        {
            var player = new Team(name);
            var playerValidation = player.Validate();

            if (playerValidation.isValid)
            {
                TeamRepository.Remove(id);
                TeamRepository.Add(player);
                return new CreatedTeamDTO(player.Id);
            }

            return new CreatedTeamDTO(playerValidation.errors);
        }

        public Guid? Remove(Guid id)
        {
            return TeamRepository.Remove(id);
        }
    }
}