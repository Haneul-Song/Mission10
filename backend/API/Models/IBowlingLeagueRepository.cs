namespace API.Models
{
    public interface IBowlingLeagueRepository
    {
        object GetBowlersWithTeam { get; set; }

        IEnumerable<Bowler> GetAllBowlersWithTeam();
    }
}
