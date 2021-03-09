using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Presentation.ViewModel
{
    public class AirtimeModel : AirtimeTopUp
    {
        public Guid SendersIdentity { get; set; }
    }
}
