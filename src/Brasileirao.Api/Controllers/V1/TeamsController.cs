using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Brasileirao.Services.Teams;
using Brasileirao.Services.Users;
using Brasileirao.Api.Client.Requests;

namespace WebAPI.Controllers.Teams
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamsService _teamsService;
        private readonly IUsersService _usersService;

        public TeamsController(IUsersService usersService, ITeamsService teamsService)
        {
            _usersService = usersService;
            _teamsService = teamsService;
        }

        [HttpPost]
        public IActionResult Create(CreateTeamRequest request)
        {
            _teamsService.Create(request.Name);

            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var teams = _teamsService.GetAll();

            // if (string.IsNullOrWhiteSpace(name))
            // {
            //     return Ok(teams);
            // }

            // var transformedName = name.ToLower().Trim();
            // var filteredTeams = teams.Where(x => x.Name.ToLower().Contains(transformedName));
            
            var resp = teams.Select(x => new {
                name = x.Name,
                playersCount = x.Players.Count
            });

            return Ok(resp);
        }
    }
}
