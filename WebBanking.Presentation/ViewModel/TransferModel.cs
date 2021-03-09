using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Presentation.ViewModel
{
    public class TransferModel : Transfer
    {
        [Required]
        public Guid SendersIdentity { get; set; }
    }
}
