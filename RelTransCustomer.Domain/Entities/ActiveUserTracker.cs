using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelTransCustomer.Domain.Entities
{
    public class ActiveUserTracker
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string JWTToken { get; set; }
        public DateTime LoginTime { get; set; }

    }
}
