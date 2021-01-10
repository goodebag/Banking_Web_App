using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Models
{
    public class CableRecharge:BaseEntity
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public virtual AcctHolder Sender { get; set; }
        public int CableNo { get; set; }
        public CableType CableType { get; set; }
        public int Amount { get; set; }
        
    }

    public enum CableType
    {
        Dstv = 1,
        Gotv,
        Startimes
    }
}

