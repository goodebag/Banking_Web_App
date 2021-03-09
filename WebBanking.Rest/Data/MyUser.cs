using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Data
{
    public class MyUser : IdentityUser<int>
    {
        public string FullName { get; set; }
        public string PhotoUrl { get; set; }
        public Guid AcctLinkingId { get; set; }
    }
}