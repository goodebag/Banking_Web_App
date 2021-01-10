namespace WebBanking.Rest.Models
{
    public class Transactions:BaseEntity
    {
        public int Id { get; set; }
        public int theTransactionId { get; set; }
        public int UserId { get; set; }
        public TransactionType GetTransactionType { get; set; }
        public enum TransactionType
        {
            Transfer=1,
            CableRecharge,
            AirtimeTopUp,
            CashWithdrawal
        }
    }
}