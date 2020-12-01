using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Team
{
    public class TeamRepository
    {
        private static List<Team> _teams = new List<Team>();
        public static IReadOnlyCollection<Team> Players => _teams;

        public static void Add(Team player)
        {
            _teams.Add(player);
        }

        public static Guid? Remove(Guid id)
        {
            var player = _teams.FirstOrDefault(x => x.Id == id);
            if (player == null){
                return null;
            }

            _teams.Remove(player);
            return id;
        }
    }
}