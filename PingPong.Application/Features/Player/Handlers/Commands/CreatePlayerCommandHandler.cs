using AutoMapper;
using MediatR;
using PingPong.Application.Features.Player.Requests.Commands;
using PingPong.Application.Persistence;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Player.Handlers.Commands
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Unit>
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public CreatePlayerCommandHandler(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            var createPlayer = _mapper.Map<PlayerModel>(request.PlayerDto);
            if (createPlayer == null)
            {
                throw new ArgumentNullException(nameof(createPlayer), "Player object cannot be null.");
            }
            await _playerRepository.CreatePlayer(createPlayer);
            return Unit.Value;
            
        }
    }
}
