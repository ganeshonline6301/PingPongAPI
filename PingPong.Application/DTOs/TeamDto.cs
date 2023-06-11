using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.DTOs
{
    public class TeamDto
    {
        public string Name { get; set; }
        public List<PlayerModel> Players { get; set; }
    }
}
