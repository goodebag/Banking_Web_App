using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Models
{
    public class ComfirmationToken
    {
        public Guid AcctIdentityNo { get; set; }
        public int pin { get; set; }
    }
}
