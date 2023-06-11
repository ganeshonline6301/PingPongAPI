using MediatR;
using Microsoft.EntityFrameworkCore;
using PingPong.Application.Persistence;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Infrastructure.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext _db;

        public PlayerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Unit> CreatePlayer(PlayerModel player)
        {
            await _db.Players.AddAsync(player);
            _db.SaveChanges();
            int playersCount = await _db.Players.CountAsync();
            if (playersCount < 33)
            {
                player.IsParticipant = true;
            }
            else
            {
                player.IsParticipant = false;
            }
            await _db.SaveChangesAsync();

            return Unit.Value;
        }

        public async Task<List<PlayerModel>> GetAllPlayers()
        {
            return await _db.Players.Where(p => p.IsParticipant == true).ToListAsync();
        }

        public async Task<PlayerModel> GetPlayer(int id)
        {
            return await _db.Players.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
