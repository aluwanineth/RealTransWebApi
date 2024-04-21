using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using RelTransCustomer.Application.Contracts.Repositories;
using RelTransCustomer.Domain.Entities;
using RelTransCustomer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Persistence.Repository
{
    public class ActiveUserTrackerRepositoryAsync : GenericRepositoryAsync<ActiveUserTracker>, IActiveUserTrackerRepositoryAsync
    {
        private readonly DbSet<ActiveUserTracker> _activeUserTracker;
        private readonly ApplicationDbContext _dbContext;
        public ActiveUserTrackerRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _activeUserTracker = dbContext.Set<ActiveUserTracker>();
            _dbContext = dbContext;
        }

        public async Task LoggOutActiveUserTracker(string userId, string email, string jwtToken)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Email", email),
                new SqlParameter("@JwtToken", jwtToken),

            };

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC SPLoggedOutActiveUserTracker @UserId, @Email, @JwtToken", parameters);
        }

        public async Task LoginActiveUserTracker(string userId, string email, string jwtToken)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserId", userId),
                new SqlParameter("@Email", email),
                new SqlParameter("@JwtToken", jwtToken),

            };

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC SPLoginActiveUserTracker @UserId, @Email, @JwtToken", parameters);
        }
    }
}
