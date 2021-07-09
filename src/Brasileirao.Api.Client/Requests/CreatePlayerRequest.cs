using System;

namespace Brasileirao.Api.Client.Requests
{
    public class CreatePlayerRequest
    {
        public Guid TeamId { get; set; }
        public string Name { get; set; }
    }
}