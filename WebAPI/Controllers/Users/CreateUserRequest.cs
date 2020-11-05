using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain;

namespace WebAPI.Controllers
{
    public class CreateUserRequest : ControllerBase
    {
        public string Name { get; set; }
        public Profile Profile { get; set; }
        public string Password { get; set; }
    }
}

