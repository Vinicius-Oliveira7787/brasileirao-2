using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public readonly UsersService _usersService;

        public UsersController()
        {
            _usersService = new UsersService();
        }

        [HttpPost]
        public IActionResult Post(CreateUserRequest request)
        {
            if (request.Profile == Profile.CBF && request.Password != "admin123")
            {
                // return status
                return Unauthorized();
            }
            
            // return BadRequest("O nome está inválido");
                
            var userId = _usersService.Create(request.Name, request.Profile);
            return Ok(userId);
        }
    }
}
