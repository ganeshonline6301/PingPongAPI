using MediatR;
using PingPong.Application.DTOs.GroupDto;
using PingPong.Application.DTOs.PlayerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Group.Requests.Commands
{
    public class CreateGroupCommand : IRequest<Unit>
    {
        public GroupDto GroupDto { get; set; }
    }
}
