using System.Collections.Generic;
using Domain.Teams;

namespace Domain.Championships
{
    public class ChampionshipService
    {
        private List<(Team HomeTeam, Team AwayTeam)> _matches { get; set; }
        public bool HasStarted { get; private set; }

        public void Create((Team HomeTeam, Team AwayTeam) teams)
        {
            
        }
    }
}