using RelTransCustomer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Application.Contracts.Repositories
{
    public interface IActiveUserTrackerRepositoryAsync : IGenericRepositoryAsync<ActiveUserTracker>
    {
        public Task LoginActiveUserTracker(string userId, string email, string jwtToken);
        public Task LoggOutActiveUserTracker(string userId, string email, string jwtToken);
    }
}
