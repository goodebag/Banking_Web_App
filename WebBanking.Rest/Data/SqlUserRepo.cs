using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;

namespace WebBanking.Rest.Data
{
    public class SqlUserRepo : IUsersRepo
    {
        private readonly AppDbContext context;

        public SqlUserRepo(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CheckEmailExistance(string email)
        {
            bool EmailExist;
           var user = await context.Users.FirstOrDefaultAsync(whoose => whoose.Email == email);
            if (user != null)
            {
                EmailExist = true;
            }
            else { EmailExist = false; }

            return EmailExist;
        }

        public async Task<bool> ConfirmTransaction(Guid IdentityNo, int pin)
        {
            var Result = await context.Users.FirstOrDefaultAsync(whom => whom.IdentityId== IdentityNo);
            if (Result.Pin.Equals(pin))
            {
                return true;
            }
            else
                return false;
        }

        public async Task<AcctHolder> DeleteUsers(int userToDelete)
        {
            var found = await context.Users.FindAsync(userToDelete);
            context.Users.Remove(found);
            await context.SaveChangesAsync();
            return found;
        }

        public async Task<AcctHolder> GetAccount(Guid CustomId )
        {
            var user = await context.Users
            .FirstOrDefaultAsync(whom => whom.IdentityId == CustomId);
            return user;
        }

        public async Task<AcctHolder> GetAcctByEmail(string email)
        {
            var result= await context.Users.FirstOrDefaultAsync(whom => whom.Email == email);
            return result;
        }

        public async Task<AirtimeTopUp> GetAirtimeTopUp(int Id)
        {
            return await context.AirtimeTopUps.FindAsync(Id);
        }

        public async Task<IEnumerable<AirtimeTopUp>> GetAirtimeTopUps(int AccountNo)
        {
            var Result = await context.AirtimeTopUps.Where(Whom => Whom.SenderId == AccountNo).ToListAsync();
            return Result;
        }

        public async Task<CableRecharge> GetCableRecharge(int Id)
        {
            return await context.CableRecharges
                .FindAsync(Id);
        }

        public async Task<IEnumerable<CableRecharge>> GetCableRecharges(int AccountNo)
        {
            var Result = await context.CableRecharges.Where(E => E.SenderId == AccountNo).ToListAsync();
            return Result;
        }

        public async Task<CashWithdrawal> GetCashWithdrawal(int Id)
        {
            return await context.CashWithdrawals.FindAsync(Id);
        }

        public async Task<IEnumerable<CashWithdrawal>> GetCashWithdrawals(int AccountNo)
        {
            var result =await context.CashWithdrawals.Where(whom => whom.WithdrawerId == AccountNo).ToListAsync();
            return result;
        }

        public async Task<Transactions> GetTransaction(int TransactionId)
        {
            var result = await context.Transactions.FindAsync(TransactionId);
            return result;
        }

        public async Task<IEnumerable<Transactions>> GetTransactions(int AcctNo)
        {
            var resulT = await context.Transactions.Where(e => e.UserId == AcctNo).ToListAsync();
            return resulT;
        }

        public async Task<Transfer> GetTransfer(int Id)
        {
            return await context.Transfers.FindAsync(Id);
        }

        public async Task<IEnumerable<Transfer>> GetTransfers(int AccountNo)
        {
            var Result = await context.Transfers.Where(E => E.SenderId == AccountNo).ToListAsync();
            return Result;
        }

        public async Task<AirtimeTopUp> SaveAirtimeTopUps(AirtimeTopUp AddRecord)
        {
           var result =await context.AirtimeTopUps.AddAsync(AddRecord);
          await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<CableRecharge> SaveCableRecharges(CableRecharge AddRecord)
        {
            var result = await context.CableRecharges.AddAsync(AddRecord);
           await  context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<CashWithdrawal> SaveCashWithdrawals(CashWithdrawal AddRecord)
        {
            var result = await context.CashWithdrawals.AddAsync(AddRecord);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Transactions> SaveTransactions(Transactions AddRecord)
        {
            var result = await context.Transactions.AddAsync(AddRecord);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Transfer> SaveTransfers(Transfer AddRecord)
        {
            var result = await context.Transfers.AddAsync(AddRecord);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<AcctHolder> SaveUsers(AcctHolder userTosave)
        {
            var result = await context.Users.AddAsync(userTosave);
            await context.SaveChangesAsync();
            return result.Entity;
        }

    
    }
}
