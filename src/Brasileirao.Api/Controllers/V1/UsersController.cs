using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using Brasileirao.Services.Users;
using Brasileirao.Api.Client.Requests;
using Brasileirao.Api.Client.Exceptions;

namespace WebAPI.Controllers.Users
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            throw new NotFoundException("not found test");
            _usersService.Create(
                request.Name,
                request.Profile,
                request.Email,
                request.Password
            );

            return NoContent();
        }

        [HttpGet("me")]
        public IActionResult GetById()
        {
            throw new BusinessException("BusinessException test");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new Exception("Exception test");
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _usersService.GetById(Guid.Parse(userId));

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
