using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanking.Rest.Models
{
    public class CashWithdrawal:BaseEntity
    {
        public int Id { get; set; }
        public int WithdrawerId { get; set; }
        [ForeignKey("WithdrawerId")]
        public virtual AcctHolder Withdrawer { get; set; }
        public int Amount { get; set; }
    }
}
