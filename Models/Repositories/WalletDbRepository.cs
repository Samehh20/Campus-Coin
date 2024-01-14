using CampusCoin.Models;
using CampusCoin.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models.Repositories
{
    public class WalletDbRepository : IWalletDbRepository
    {
        ApplicationDbContext db;

        public WalletDbRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Add(Wallet entity)
        {
            db.Wallets.Add(entity);
            db.SaveChanges();
        }

        public Guid AddWallet(Guid uId)
        {
            Guid walletId = Guid.NewGuid();
            Wallet newWallet = new Wallet
            {
                Id = walletId,
                Ballance = 0,
                IsActive = true,
                UserId = uId
            };
            db.Wallets.Add(newWallet);
            db.SaveChanges();
            return walletId;
        }

        public void Delete(int id)
        {
            //var author = Find(id);

            //db.Users.Remove(author);
            db.SaveChanges();
        }

        public void Deposit(Guid Id, double amount)
        {
            var wallet = FindByGuid(Id);
            wallet.Ballance += amount;
            UpdateByGuid(Id, wallet);
        }

        public Wallet Find(int id)
        {
            

            return null;
        }

        public Wallet FindByGuid(Guid Id)
        {
            var wallet = db.Wallets.Include(x => x.User).SingleOrDefault(a => a.Id == Id);
            return wallet;
        }

        public IList<Wallet> List()
        {
            return db.Wallets.Include(x => x.User).ToList();
        }

        public List<Wallet> Search(string term)
        {
            return null;
        }

        public void Update(int id, Wallet newWallet)
        {
            //db.Update(newWallet);
            db.SaveChanges();
        }

        public void UpdateByGuid(Guid Id, Wallet newWallet)
        {
            db.Update(newWallet);
            db.SaveChanges();
        }

       
    }
}