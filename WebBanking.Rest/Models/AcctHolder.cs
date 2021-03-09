using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBanking.Rest.Models
{
    public class AcctHolder:BaseEntity
    { 
        public int Id { get; set; }
        public double AccountNumber { get; set; }
        public double Balance { get; set; }
        public string FullName { get; set; }
        public string photopath { get; set; }
        public int Pin { get; set; }
        public int TransactionId { get; set; }
        [ForeignKey("TransactionId")]
        public virtual IList <Transactions> Transactions {get;set;}
        public Guid IdentityId { get; set; }
        public double phonenumber { get; set; }
        public string Email { get; set; }

    }
}