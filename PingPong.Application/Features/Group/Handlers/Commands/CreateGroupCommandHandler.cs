using AutoMapper;
using MediatR;
using PingPong.Application.Features.Group.Requests.Commands;
using PingPong.Application.Persistence;
using PingPong.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Group.Handlers.Commands
{
    public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, Unit>
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMapper _mapper;

        public CreateGroupCommandHandler(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
        {
            var createGroup = _mapper.Map<GroupModel>(request.GroupDto);
            await _groupRepository.CreateTeam(createGroup);
            return Unit.Value;
        }
    }
}
