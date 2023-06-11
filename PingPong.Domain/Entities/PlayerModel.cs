using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Domain.Entities
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public string? TeamName { get; set; }
        public int Score { get; set; }
        public bool IsParticipant { get; set; }
    }
}
