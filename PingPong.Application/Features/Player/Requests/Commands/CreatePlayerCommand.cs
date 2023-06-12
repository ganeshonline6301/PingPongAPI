using MediatR;
using PingPong.Application.DTOs.PlayerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Player.Requests.Commands
{
    public class CreatePlayerCommand : IRequest<Unit>
    {
        public CreatePlayerDto PlayerDto { get; set; }
    }
}
