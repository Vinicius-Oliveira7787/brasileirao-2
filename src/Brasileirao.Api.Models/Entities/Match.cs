namespace Brasileirao.Api.Models.Entities
{
    public class Match
    {
        public virtual Team HomeTeam { get; set; }
        public string HomeTeamId { get; set; }
        public int HomeGoals { get; set; }
        
        public virtual Team AwayTeam { get; set; }
        public string AwayTeamId { get; set; }
        public int AwayGoals { get; set; }
        
        public Match(string homeTeamId, int homeGoals, string awayTeamId, int awayGoals)
        {
            HomeTeamId = homeTeamId;
            HomeGoals = homeGoals;
            AwayTeamId = awayTeamId;
            AwayGoals = awayGoals;
        }
    }
}
