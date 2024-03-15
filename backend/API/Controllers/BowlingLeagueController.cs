using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlingLeagueRepository _bowlingLeagueRepository;

        public BowlingLeagueController(IBowlingLeagueRepository temp)
        {
            _bowlingLeagueRepository = temp;    
        }

        [HttpGet]
        public IEnumerable<Bowler> Get()
        {
            var data = _bowlingLeagueRepository.GetAllBowlersWithTeam()
                        .Where(b => b.TeamName == "Marlins" || b.TeamName == "Sharks")
                        .ToArray();

            return data;
        }


    }
}
