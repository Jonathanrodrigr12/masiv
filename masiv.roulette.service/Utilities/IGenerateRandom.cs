//-----------------------------------------------------------------------------
// <copyright file="IGenerateRandom.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Utilities
{
    /// <summary>
    /// Interface to generate number random.
    /// </summary>
    public interface IGenerateRandom
    {
        int NextNumber(int min, int max);
    }
}