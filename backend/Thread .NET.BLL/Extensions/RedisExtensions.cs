using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Thread_.NET.BLL.Extensions
{
    public static class RedisExtensions
    {
        const string _keyFmt = ":thread:{0}:{1}";

        public static async Task<TResult> GetFromCache<TResult>(this IDistributedCache cache,
            string key,
            string val,
            Func<Task<object>> func)
        {
            var cacheKey = string.Format(_keyFmt, key, val);
            var data = await cache.GetStringAsync(cacheKey);

            if (string.IsNullOrEmpty(data))
            {
                data = JsonConvert.SerializeObject(await func());

                await cache.SetStringAsync(
                    cacheKey,
                    data);
            }

            return JsonConvert.
                DeserializeObject<TResult>(data);
        }
    }
}
