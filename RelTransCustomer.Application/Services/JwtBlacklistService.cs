using RelTransCustomer.Application.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Services
{
    public class JwtBlacklistService : IJwtBlacklistService
    {
        private readonly HashSet<string> _blacklistTokens = new HashSet<string>();

        public void AddToBlacklist(string token)
        {
            _blacklistTokens.Add(token);
        }

        public bool IsTokenBlacklisted(string token)
        {
            return _blacklistTokens.Contains(token);
        }
    }
}
