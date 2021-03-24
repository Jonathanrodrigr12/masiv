//-----------------------------------------------------------------------------
// <copyright file="RouletteController.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Controllers
{
    using System.Collections.Generic;
    using Masiv.Roulette.API.Contracts;
    using Masiv.Roulette.API.Domain.Dtos;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class RouletteController : ControllerBase
    {
        private readonly IRouletteService rouletteService;

        public RouletteController(IRouletteService rouletteService)
        {
            this.rouletteService = rouletteService;
        }

        [HttpPost("add_rolutte")]
        [ProducesResponseType(typeof(RouletteAddResponseDto), StatusCodes.Status200OK)]
        public RouletteAddResponseDto AddRolutteController()
        {
            return this.rouletteService.AddRouletteService();
        }

        [HttpPost("start_rolutte")]
        [ProducesResponseType(typeof(RouletteStartResponseDto), StatusCodes.Status200OK)]
        public RouletteStartResponseDto StartRouletteController(RouletteStartDto rouletteStartDto)
        {
            return this.rouletteService.StartRouletteService(rouletteStartDto);
        }

        [HttpPost("bet")]
        public void Bet([FromHeader(Name = "user-id")] string userId, RouletteBetDto rouletteBetDto)
        {
            this.rouletteService.Bet(userId, rouletteBetDto);
        }

        [HttpPost("close_rolutte")]
        [ProducesResponseType(typeof(RouletteCloseResponseDto), StatusCodes.Status200OK)]
        public RouletteCloseResponseDto CloseRouletteController(RouletteCloseDto rouletteCloseDto)
        {
            return this.rouletteService.CloseRouletteService(rouletteCloseDto);
        }

        [HttpGet("get_rolutte_all")]
        [ProducesResponseType(typeof(List<RouletteDto>), StatusCodes.Status200OK)]
        public List<RouletteDto> GetAllRouletteWithStatusController()
        {
            return this.rouletteService.GetAllRoulettesWithStatusService();
        }
    }
}
