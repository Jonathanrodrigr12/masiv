//-----------------------------------------------------------------------------
// <copyright file="GenerateRandom.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Utilities
{
    using System;

    /// <summary>
    /// Class to generate number random.
    /// </summary>
    public class GenerateRandom : IGenerateRandom
    {
        public int NextNumber(int min, int max)
        {
            return new Random().Next(min, max);
        }
    }
}
