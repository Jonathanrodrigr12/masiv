//-----------------------------------------------------------------------------
// <copyright file="CacheMiddleware.cs" company="Roulette API">
//     Copyright © Roulette API All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------
namespace Masiv.Roulette.API.Handler.Redis
{
    using System;
    using Microsoft.Extensions.Caching.Distributed;
    using Newtonsoft.Json;

    public class CacheMiddleware<T> : ICacheMiddleware<T>
    {
        private readonly IDistributedCache distributedCache;

        public CacheMiddleware(IDistributedCache distributedCache)
        {
            this.distributedCache = distributedCache;
        }

        public T GetValue(string key)
        {
            string cache = null;
            try
            {
                cache = this.distributedCache.GetString(key);
            }
            catch (Exception ex)
            {
                Console.Write("Error with cache " + ex.Message);
            }
            
            var data = (T)Activator.CreateInstance(typeof(T));
            if (cache != null)
                data = JsonConvert.DeserializeObject<T>(cache);

            return data;
        }

        public void SetValue(string key, T value)
        {
            try
            {
                this.distributedCache.SetString(key, JsonConvert.SerializeObject(value));
            }
            catch (Exception ex)
            {
                Console.Write("Error with cache " + ex.Message);
            }
        }
    }
}
