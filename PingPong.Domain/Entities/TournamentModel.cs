using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Entities
{
    public class TournamentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamModel> Teams { get; set; }
    }
}
