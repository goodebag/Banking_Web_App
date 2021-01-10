using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Web.Services
{
    public class OperationServices : IOperationServices
    {
        private readonly HttpClient httpClient;

        public OperationServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<AcctHolder> AddAcctHolder(AcctHolder acctInfo)
        {
            return await httpClient.GetJsonAsync<AcctHolder>($"api/process/AddUser/{acctInfo}");
        }

        public async Task<AirtimeTopUp> AddAirtimeAsync(AirtimeTopUp Airtime)
        {
            return await httpClient.GetJsonAsync<AirtimeTopUp>($"api/process/AddAirtime/{Airtime}");
        }

        public async Task<CableRecharge> AddCableRechargeAsync(CableRecharge cableTime)
        {
            return await httpClient.GetJsonAsync<CableRecharge>($"api/process/AddCableRecharge/{cableTime}");
        }

        public async Task<CashWithdrawal> AddCashWithdrawalAsync(CashWithdrawal Withdrawal)
        {
            return await httpClient.GetJsonAsync<CashWithdrawal>($"api/process/AddCashWithdrawal/{ Withdrawal}");
        }

        public async Task<Transactions> AddTransactionAsync(Transactions Transaction)
        {
            return await httpClient.GetJsonAsync<Transactions>($"api/process/AddTransaction/{Transaction}");
        }

        public async Task<Transfer> AddTransferAsync(Transfer Transfer)
        {
            return await httpClient.GetJsonAsync<Transfer>($"api/process/AddTransfer/{Transfer}");
        }

        public async Task<bool> ComfirmTransaction(ComfirmationToken token)
        {
            return await httpClient.GetJsonAsync<bool>($"api/process/ComfirmTransaction/{token}");
        }

        public async Task<AcctHolder> DeleteUserAsync(int Id)
        {
            return await httpClient.GetJsonAsync<AcctHolder>($"api/process/DeleteUser/{Id}");
        }

        public async Task<AcctHolder> GetAcct(Guid IdentityId)
        {
            return await httpClient.GetJsonAsync<AcctHolder>($"api/process/GetUser/{IdentityId}");
        }

        public async Task<AirtimeTopUp> GetAirtimeTopUp(int Id)
        {
            return await httpClient.GetJsonAsync<AirtimeTopUp>($"api/process/GetAirtimeTopUp/{Id}");
        }

        public async Task<IEnumerable<AirtimeTopUp>> GetAirtimeTopUpMatch(int AcctNo)
        {
            return await httpClient.GetJsonAsync<AirtimeTopUp[]>($"api/process/GetAirtimeTopUpMatch/{AcctNo}");
        }

        public async Task<CableRecharge> GetCableRecharge(int Id)
        {
            return await httpClient.GetJsonAsync<CableRecharge>($"api/process/GetCableRecharge/{Id}");
        }

        public async Task<IEnumerable<CableRecharge>> GetCableRechargeMatch(int AcctNo)
        {
            return await httpClient.GetJsonAsync<CableRecharge[]> ($"api/process/GetCableRechargeMatch/{AcctNo}");
        }

        public async Task<CashWithdrawal> GetCashWithdrawal(int Id)
        {
            return await httpClient.GetJsonAsync<CashWithdrawal>($"api/process/GetCashWithdrawal/{Id}");
        }

        public async Task<IEnumerable<CashWithdrawal>> GetCashWithdrawalMatch(int AcctNo)
        {
            return await httpClient.GetJsonAsync<CashWithdrawal[]>($"api/process/GetCashWithdrawalMatch/{AcctNo}");
        }

        public async Task<Transactions> GetTransaction(int Id)
        {
            return await httpClient.GetJsonAsync<Transactions>($"api/process/GetTransaction/{Id}");
        }

        public async Task<IEnumerable<Transactions>> GetTransactionMatch(int AcctNo)
        {
            return await httpClient.GetJsonAsync<Transactions[]>($"api/process/GetTransactionMatch/{AcctNo}");
        }

        public async Task<Transfer> GetTransfer(int Id)
        {
            return await httpClient.GetJsonAsync<Transfer>($"api/process/GetTransfer/{Id}");
        }

        public async Task<IEnumerable<Transfer>> GetTransferMatch(int AcctNo)
        {
            return await httpClient.GetJsonAsync<Transfer[]>($"api/process/GetTransferMatch/{AcctNo}");
        }
    }
}
