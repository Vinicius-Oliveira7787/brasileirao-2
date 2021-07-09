using System;
using Brasileirao.Api.Models.Common;

namespace Brasileirao.Api.Models.Entities
{
    public class TeamPlayer : Entity
    {
        public virtual Team Team { get; private set; }
        public Guid TeamId { get; private set; }
        public virtual Player Player { get; private set; }
        public Guid PlayerId { get; private set; }

        public TeamPlayer(Guid id) : base(id) { }

        public TeamPlayer(Guid teamId, Guid playerId)
        {
            TeamId = teamId;
            PlayerId = playerId;
        }
    }
}
