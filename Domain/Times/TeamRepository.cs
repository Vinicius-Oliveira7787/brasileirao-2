using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Teams
{
    public class TeamRepository
    {
        private static List<Team> _teams = new List<Team>();
        public static IReadOnlyCollection<Team> Players => _teams;

        public static void Add(Team team)
        {
            _teams.Add(team);
        }

        public static Guid? Remove(Guid id)
        {
            var team = _teams.FirstOrDefault(x => x.Id == id);
            if (team == null)
            {
                return null;
            }

            _teams.Remove(team);
            return id;
        }
    }
}