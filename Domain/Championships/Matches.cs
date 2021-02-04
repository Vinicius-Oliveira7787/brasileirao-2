using Domain.Common;
using Domain.Teams;

namespace Domain.Championships
{
    public class Matches : Entity
    {
        public Team HomeTeam { get; private set; }
        public Team AwayTeam { get; private set; }

        public Matches(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        public void Validate()
        {
            
        }
    }
}