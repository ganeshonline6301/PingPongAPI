using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PingPong.Application.DTOs;
using PingPong.Application.DTOs.PlayerDto;
using PingPong.Application.Features.Player.Requests.Commands;
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
        public async Task<ActionResult<List<GetPlayerDto>>> GetAllPlayers()
        {
            return Ok(await _mediator.Send(new GetPlayersListRequest()));
        }

        [HttpGet("Id")]
        public async Task<ActionResult<GetPlayerDto>> GetPlayer(int id)
        {
            return Ok(await _mediator.Send(new GetPlayerRequest { Id = id }));
        }

        [HttpGet("PlayerScore")]
        public async Task<ActionResult<PlayerScoreDto>> GetPlayerScore(int id)
        {
            return Ok(await _mediator.Send(new GetPlayerScoreRequest { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlayer([FromForm]CreatePlayerDto playerDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (string.IsNullOrEmpty(playerDto.FirstName) || string.IsNullOrEmpty(playerDto.LastName)||string.IsNullOrEmpty(playerDto.Mail) || string.IsNullOrEmpty(playerDto.Gender))
            {
                return BadRequest("Name, Mail, and Gender are required fields.");
            }
            return Ok(await _mediator.Send(new CreatePlayerCommand { PlayerDto = playerDto }));
        }
    }
}
