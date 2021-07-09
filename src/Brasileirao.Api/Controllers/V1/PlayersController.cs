using Microsoft.AspNetCore.Mvc;
using Brasileirao.Services.Players;
using Brasileirao.Services.Users;
using Brasileirao.Api.Client.Requests;

namespace WebAPI.Controllers.Players
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayersService _playersService;
        private readonly IUsersService _usersService;
        
        public PlayersController(IUsersService usersService, IPlayersService playersService)
        {
            _usersService = usersService;
            _playersService = playersService;
        }

        [HttpPost]
        public IActionResult Create(CreatePlayerRequest request)
        {
            _playersService.Create(request.TeamId, request.Name);
            
            return Ok();
        }
    }
}
