using AutoMapper;
using MediatR;
using PingPong.Application.DTOs;
using PingPong.Application.Features.Player.Requests.Queries;
using PingPong.Application.Persistence;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Player.Handlers.Queries
{
    public class GetPlayerScoreRequestHandler : IRequestHandler<GetPlayerScoreRequest, PlayerScoreDto>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public GetPlayerScoreRequestHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<PlayerScoreDto> Handle(GetPlayerScoreRequest request, CancellationToken cancellationToken)
        {
            var getPlayerScore = await _playerRepository.GetPlayer(request.Id);
            return _mapper.Map<PlayerScoreDto>(getPlayerScore);
        }
    }
}
