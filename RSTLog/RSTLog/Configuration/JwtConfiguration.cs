using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSTLog.Configuration
{
    public class JwtConfiguration
    {

        public string SecurityKey { get; set; }

        public string ValidIssuer { get; set; }

        public string ValidAudience { get; set; }

        public string ExpiryInMinutes { get; set; }

    }
}
