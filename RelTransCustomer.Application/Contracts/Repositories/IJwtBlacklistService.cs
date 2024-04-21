using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Contracts.Repositories
{
    public interface IJwtBlacklistService
    {
        void AddToBlacklist(string token);
        bool IsTokenBlacklisted(string token);
    }
}
