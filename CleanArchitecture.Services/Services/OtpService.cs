using CleanArchitecture.Services.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Services.Services
{
    public class OtpService : IOtpService
    {
        private readonly IConnectionMultiplexer _redis;

        public OtpService(IConnectionMultiplexer redis)
        {
            _redis = redis;
        }

        public async Task SetOtpAsync(string key, string otp, TimeSpan expiration)
        {
            var db = _redis.GetDatabase();
            await db.StringSetAsync(key, otp, expiration);
        }

        public async Task<string> GetOtpAsync(string key)
        {
            var db = _redis.GetDatabase();
            return await db.StringGetAsync(key);
        }

       
        public async Task RemoveOtpAsync(string key)
        {
            var db = _redis.GetDatabase();
            await db.KeyDeleteAsync(key);
        }
    }

}
