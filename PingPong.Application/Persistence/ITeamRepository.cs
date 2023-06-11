using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Persistence
{
    public interface ITeamRepository
    {
        Task<List<TeamModel>> GetAllTeams();
        Task<TeamModel> GetTeam(int id);
        Task<TeamModel> CreateTeam(TeamModel team);
    }
}
