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
    public class GetPlayersListRequestHandler : IRequestHandler<GetPlayersListRequest, List<PlayerDto>>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayersListRequestHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<List<PlayerDto>> Handle(GetPlayersListRequest request, CancellationToken cancellationToken)
        {
            var getPlayers = await _playerRepository.GetAllPlayers();

            return _mapper.Map<List<PlayerDto>>(getPlayers);
        }
    }
}
