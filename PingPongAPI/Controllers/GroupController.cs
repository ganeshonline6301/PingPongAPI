using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PingPong.Application.DTOs.GroupDto;
using PingPong.Application.Features.Group.Requests.Commands;
using PingPong.Application.Features.Group.Requests.Queries;
using PingPong.Domain.Entities;
using System.Text.RegularExpressions;

namespace PingPongAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroup(GroupDto groupDto)
        {
            return Ok(await _mediator.Send(new CreateGroupCommand { GroupDto = groupDto }));
        }

        [HttpGet]
        public async Task<ActionResult<List<GroupDto>>> GetPlayerGroups()
        {
            return Ok(await _mediator.Send(new GetGroupsListRequest()));
        }
    }
}
