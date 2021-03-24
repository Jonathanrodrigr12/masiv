//-----------------------------------------------------------------------------
// <copyright file="ICacheMiddleware.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Handler.Redis
{
    public interface ICacheMiddleware<T>
    {
        T GetValue(string key);

        void SetValue(string key, T value);
    }
}