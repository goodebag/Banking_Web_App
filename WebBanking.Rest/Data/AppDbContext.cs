using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanking.Rest.Models;
using static WebBanking.Rest.Models.Transactions;

namespace WebBanking.Rest.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
        {
        }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<CashWithdrawal> CashWithdrawals { get; set; }
        public DbSet<AirtimeTopUp> AirtimeTopUps { get; set; }
        public DbSet<CableRecharge> CableRecharges { get; set; }
        public DbSet<AcctHolder> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Transactions>().HasData(new Transactions { Id = 1,  GetTransactionType = TransactionType.CashWithdrawal });
            //modelBuilder.Entity<Transactions>().HasData(new Transactions { Id = 2, UserId = 20005, GetTransactionType = TransactionType.Tranfer });
            //modelBuilder.Entity<Transactions>().HasData(new Transactions { Id = 3, UserId = 20005, GetTransactionType = TransactionType.AirtimeTopUp });
            //modelBuilder.Entity<Transactions>().HasData(new Transactions { Id = 3, UserId = 20005, GetTransactionType = TransactionType.CableRecharge });


            modelBuilder.Entity<AcctHolder>().HasData(new AcctHolder
            {
                Id = 1,
                Pin = 2020,
                FullName = "chima",
                AccountNumber = 20005,
                Balance = 50000,
                photopath = "image2.jpg",
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<Transfer>().HasData(new Transfer
            {
                Id = 1,
                Amount = 2000,
                SenderId = 1,
                ReciverAccountNo = 20006,
                WhichBank = Bank.FCMB,
                 CreatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<AirtimeTopUp>().HasData(new AirtimeTopUp
            {
                Id = 1,
                Amount = 500,
                networkType = NetworkType.Airtel,
                SenderId = 1,
                PhoneNo = 09094096185
                ,
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<CashWithdrawal>().HasData(new CashWithdrawal
            {
                Id = 1,
                Amount = 1000,
                WithdrawerId = 1,
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<CableRecharge>().HasData(new CableRecharge
            {
                Id = 1,
                Amount = 2900,
                SenderId = 1,
                CableType = CableType.Dstv,
                CableNo = 9012345,
                CreatedAt = DateTime.UtcNow
            });

            modelBuilder.Entity<Transactions>().HasData(new Transactions
            {
                Id = 1,
                GetTransactionType = TransactionType.Transfer,
                theTransactionId = 1,
                UserId = 20005
                ,
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<Transactions>().HasData(new Transactions
            {
                Id = 2,
                GetTransactionType = TransactionType.AirtimeTopUp,
                theTransactionId = 1,
                UserId = 20005,
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<Transactions>().HasData(new Transactions
            {
                Id = 3,
                GetTransactionType = TransactionType.CashWithdrawal,
                theTransactionId = 1,
                UserId = 20005,
                CreatedAt = DateTime.UtcNow
            });
            modelBuilder.Entity<Transactions>().HasData(new Transactions
            {
                Id = 4,
                GetTransactionType = TransactionType.CableRecharge,
                theTransactionId = 1,
                UserId = 20005,
                CreatedAt = DateTime.UtcNow
            });
        }
    }
}
