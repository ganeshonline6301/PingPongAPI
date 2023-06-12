using AutoMapper;
using MediatR;
using PingPong.Application.DTOs.GroupDto;
using PingPong.Application.DTOs.PlayerDto;
using PingPong.Application.Features.Group.Requests.Queries;
using PingPong.Application.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Group.Handlers.Queries
{
    public class GetGroupListRequestHandler : IRequestHandler<GetGroupsListRequest, List<GroupDto>>
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMapper _mapper;

        public GetGroupListRequestHandler(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }
        public async Task<List<GroupDto>> Handle(GetGroupsListRequest request, CancellationToken cancellationToken)
        {
            var getGroups = await _groupRepository.GetAllTeams();
            return _mapper.Map<List<GroupDto>>(getGroups);
        }
    }
}
