using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Models
{
    public class Transfer:BaseEntity
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        [ForeignKey("SenderId")]
        public virtual AcctHolder Sender { get; set; }
        public int ReciverAccountNo { get; set; }
        public int Amount { get; set; }
        public Bank WhichBank { get; set; }
    }
    public enum Bank
    {
        Access = 1,
        First,
        FCMB,
        Fidelity,
        Heritage,
        Eco,
        UBA,
        Starling
    }
}
