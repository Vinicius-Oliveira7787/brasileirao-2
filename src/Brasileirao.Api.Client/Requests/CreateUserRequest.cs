using Brasileirao.Api.Models.Enums;

namespace Brasileirao.Api.Client.Requests
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public UserProfile Profile { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}