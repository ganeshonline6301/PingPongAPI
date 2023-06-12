using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using PingPong.Application.Persistence;
using PingPong.Domain.Entities;

namespace PingPong.Infrastructure.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _db;

        public GroupRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Unit> CreateTeam(GroupModel team)
        {
            await _db.Groups.AddAsync(team);
            _db.SaveChanges();
            return Unit.Value;
        }

        public async Task<List<GroupModel>> GetAllTeams()
        {
            return await _db.Groups.ToListAsync();
        }

        public Task<GroupModel> GetTeam(int id)
        {
            throw new NotImplementedException();
        }
    }
}
