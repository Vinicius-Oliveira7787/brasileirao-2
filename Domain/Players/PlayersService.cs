using System;
using System.Linq;

namespace Domain.Players
{
    public class PlayersService
    {
        public CreatedPlayerDTO Create(string name)
        {
            var player = new Player(name);
            var playerValidation = player.Validate();

            if (playerValidation.isValid)
            {
                PlayersRepository.Add(player);
                return new CreatedPlayerDTO(player.Id);
            }

            return new CreatedPlayerDTO(playerValidation.errors);
        }

        public CreatedPlayerDTO Update(string name, Guid playerId)
        {
            var player = new Player(name);
            var playerValidation = player.Validate();

            if (playerValidation.isValid)
            {
                var playerToRemove = PlayersRepository.Players.FirstOrDefault(item => item.Id == playerId);
                PlayersRepository.Remove(playerToRemove.Id);
                PlayersRepository.Add(player);
            }
        }
    }
}
