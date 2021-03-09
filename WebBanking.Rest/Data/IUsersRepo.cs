using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Rest.Data
{
   public  interface IUsersRepo
    {
        public Task<bool> CheckEmailExistance(string email);
        public Task<AcctHolder> SaveUsers(AcctHolder userTosave);
        public Task< CableRecharge> SaveCableRecharges(CableRecharge AddRecord);
        public Task<AcctHolder> DeleteUsers(int userToDelete);
        public Task<CashWithdrawal> SaveCashWithdrawals(CashWithdrawal AddRecord);
        public Task<Transfer> SaveTransfers(Transfer AddRecord);
        public Task<AirtimeTopUp> SaveAirtimeTopUps(AirtimeTopUp AddRecord);
        public Task<Transactions> SaveTransactions(Transactions AddRecord);
        public Task<Transactions> GetTransaction(int TransactionId);
        public Task<IEnumerable<Transactions>> GetTransactions(int AcctNo);
        public Task<AcctHolder> GetAccount(Guid CustomId);
        public Task<bool> ConfirmTransaction (Guid IdentityNo,int pin);
        public Task<AcctHolder> GetAcctByEmail(string email);
        public Task<Transfer> GetTransfer(int Id);
        public Task<IEnumerable<Transfer>> GetTransfers(int AccountNo);
        public Task< CableRecharge> GetCableRecharge(int Id);
        public Task <IEnumerable<CableRecharge>> GetCableRecharges(int AccountNo);
        public Task<AirtimeTopUp> GetAirtimeTopUp(int Id);
        public Task<IEnumerable<AirtimeTopUp>> GetAirtimeTopUps(int AccountNo);
        public Task<CashWithdrawal> GetCashWithdrawal(int Id);
        public Task<IEnumerable<CashWithdrawal>> GetCashWithdrawals(int AccountNo);
    }
}
