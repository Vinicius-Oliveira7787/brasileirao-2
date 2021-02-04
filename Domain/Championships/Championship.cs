using System.Collections.Generic;
using Domain.Common;
using Domain.Teams;

namespace Domain.Championships
{
    public class Championship : Entity
    {
        private List<(Team HomeTeam, Team AwayTeam)> _matches { get; set; }
        public bool HasStarted { get; private set; }

        public Championship(List<(Team HomeTeam, Team AwayTeam)> matches)
        {
            
        }

        public Championship()
        {
            
        }
    }
}