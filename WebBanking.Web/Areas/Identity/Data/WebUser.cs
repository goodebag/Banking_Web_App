using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebBanking.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebUser class
    public class WebUser : IdentityUser<int>
    {
        public Guid CustomId { get; set; }
        public string Photopath { get; set; }
        public int Pin { get; set; }
        public string FullName { get; set; }
    }
}
