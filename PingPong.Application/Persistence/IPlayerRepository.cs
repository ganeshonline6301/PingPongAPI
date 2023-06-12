using MediatR;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Persistence
{
    public interface IPlayerRepository
    {
        Task<List<PlayerModel>> GetAllPlayers();
        Task<PlayerModel> GetPlayer(int id);
        Task<PlayerModel> GetPlayerScore(int id);
        Task<Unit> CreatePlayer(PlayerModel player);
    }
}
