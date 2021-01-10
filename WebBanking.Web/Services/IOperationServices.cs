using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Web.Services
{
    public interface IOperationServices
    {
        Task<AcctHolder> AddAcctHolder(AcctHolder acctInfo);
        Task<AcctHolder> GetAcct(Guid IdentityId);
        Task<AcctHolder> DeleteUserAsync(int Id);
        Task<bool> ComfirmTransaction(ComfirmationToken token);
        Task<AirtimeTopUp> GetAirtimeTopUp(int Id);
        Task<AirtimeTopUp> AddAirtimeAsync(AirtimeTopUp Airtime);
        Task<IEnumerable<AirtimeTopUp>> GetAirtimeTopUpMatch(int AcctNo);
        Task<CableRecharge> GetCableRecharge(int Id);
        Task<IEnumerable<CableRecharge>> GetCableRechargeMatch(int AcctNo);
        Task<CableRecharge> AddCableRechargeAsync(CableRecharge cableTime);
        Task<CashWithdrawal> GetCashWithdrawal(int Id);
        Task<IEnumerable<CashWithdrawal>> GetCashWithdrawalMatch(int AcctNo);
        Task<CashWithdrawal> AddCashWithdrawalAsync(CashWithdrawal Withdrawal);
        Task<Transactions> GetTransaction(int Id);
        Task<IEnumerable<Transactions>> GetTransactionMatch(int AcctNo);
        Task<Transactions> AddTransactionAsync(Transactions Transaction);
        Task<Transfer> GetTransfer(int Id);
        Task<Transfer>AddTransferAsync(Transfer Transfer);
        Task<IEnumerable<Transfer>>GetTransferMatch(int AcctNo);


        }
}
