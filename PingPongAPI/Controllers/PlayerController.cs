using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PingPong.Application.DTOs;
using PingPong.Application.Features.Player.Requests.Queries;

namespace PingPongAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PlayerController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<PlayerDto>>> GetAllPlayers()
        {
            return Ok(await _mediator.Send(new GetPlayersListRequest()));
        }

        [HttpGet("Id")]
        public async Task<ActionResult<PlayerDto>> GetPlayer(int id)
        {
            return Ok(await _mediator.Send(new GetPlayerRequest { Id = id }));
        }

        [HttpGet("PlayerScore")]
        public async Task<ActionResult<PlayerScoreDto>> GetPlayerScore(int id)
        {
            return Ok(await _mediator.Send(new GetPlayerRequest { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer([FromBody]PlayerDto playerDto)
        {

        }
    }
}
