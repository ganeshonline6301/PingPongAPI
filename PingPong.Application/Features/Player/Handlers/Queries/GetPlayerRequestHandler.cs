using AutoMapper;
using MediatR;
using PingPong.Application.DTOs;
using PingPong.Application.Features.Player.Requests.Queries;
using PingPong.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Player.Handlers.Queries
{
    public class GetPlayerRequestHandler : IRequestHandler<GetPlayerRequest, PlayerDto>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayerRequestHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<PlayerDto> Handle(GetPlayerRequest request, CancellationToken cancellationToken)
        {
            var getPlayer = await _playerRepository.GetPlayer(request.Id);
            return _mapper.Map<PlayerDto>(getPlayer);
        }
    }
}
