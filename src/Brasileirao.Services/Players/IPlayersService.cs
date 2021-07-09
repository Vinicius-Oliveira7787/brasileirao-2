using System;

namespace Brasileirao.Services.Players
{
    public interface IPlayersService
    {
        void Create(Guid teamId, string name);
    }
}
