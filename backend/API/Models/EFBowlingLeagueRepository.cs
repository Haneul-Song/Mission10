
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class EFBowlingLeagueRepository : IBowlingLeagueRepository
    {
        private BowlingLeagueContext _bowlingLeagueContext;
        public EFBowlingLeagueRepository(BowlingLeagueContext temp)
        {
            _bowlingLeagueContext = temp;
        }

        object IBowlingLeagueRepository.GetBowlersWithTeam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Bowler> GetBowlersWithTeam()
        {
            var joinedData = from Bowler in _bowlingLeagueContext.Bowlers
                             join Team in _bowlingLeagueContext.Teams
                             on Bowler.TeamId equals Team.TeamId
                             select new
                             {
                                 BowlerId = Bowler.BowlerId,
                                 TeamName = Bowler.Team.TeamName,
                                 FirstName = Bowler.BowlerFirstName,
                                 MiddleName = Bowler.BowlerMiddleInit,
                                 LastName = Bowler.BowlerLastName,
                                 Address = Bowler.BowlerAddress,
                                 City = Bowler.BowlerCity,
                                 State = Bowler.BowlerState,
                                 Zip = Bowler.BowlerZip,
                                 PhoneNumber = Bowler.BowlerPhoneNumber
                             };

            var GetBowlersWithTeam = joinedData.Select(j => new Bowler
            {
                BowlerId = j.BowlerId,
                // Assume there's a property in Bowler for the team name
                TeamName = j.TeamName, // Corrected reference
                FirstName = j.FirstName,
                MiddleName = j.MiddleName,
                LastName = j.LastName,
                Address = j.Address,
                City = j.City,
                State = j.State,
                Zip = j.Zip,
                PhoneNumber = j.PhoneNumber
            }).ToList();

            return GetBowlersWithTeam;
        }

        IEnumerable<Bowler> IBowlingLeagueRepository.GetAllBowlersWithTeam()
        {
            throw new NotImplementedException();
        }
    }
}