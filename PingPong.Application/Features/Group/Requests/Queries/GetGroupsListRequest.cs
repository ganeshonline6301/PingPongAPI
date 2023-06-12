using MediatR;
using PingPong.Application.DTOs.GroupDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Application.Features.Group.Requests.Queries
{
    public class GetGroupsListRequest : IRequest<List<GroupDto>>
    {
    }
}
