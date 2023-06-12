using MediatR;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Persistence
{
    public interface IGroupRepository
    {
        Task<List<GroupModel>> GetAllTeams();
        Task<GroupModel> GetTeam(int id);
        Task<Unit> CreateTeam(GroupModel team);
    }
}
