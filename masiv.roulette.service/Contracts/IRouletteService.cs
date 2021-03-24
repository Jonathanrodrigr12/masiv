//-----------------------------------------------------------------------------
// <copyright file="IRouletteService.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Contracts
{
    using System.Collections.Generic;
    using Masiv.Roulette.API.Domain.Dtos;

    public interface IRouletteService
    {
        RouletteAddResponseDto AddRouletteService();
        RouletteStartResponseDto StartRouletteService(RouletteStartDto rouletteStartDto);
        void Bet(string userId, RouletteBetDto rouletteBetDto);
        RouletteCloseResponseDto CloseRouletteService(RouletteCloseDto rouletteCloseDto);
        List<RouletteDto> GetAllRoulettesWithStatusService();
    }
}
