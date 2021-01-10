using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Models
{
    public class AirtimeTopUp:BaseEntity
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public virtual AcctHolder Sender { get; set; }
        public double PhoneNo { get; set; }
        public NetworkType networkType { get; set; }
        public int Amount { get; set; }
    }
    public enum NetworkType
    {
        MTN = 1,
        Etisalat,
        Airtel,
        Glo
    }
}

