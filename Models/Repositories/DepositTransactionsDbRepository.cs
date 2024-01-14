using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models.Repositories
{
    public class DepositTransactionsDbRepository : ICampusCoinRepository<DepositTransaction>,IDepositTransactionsRepository
    {
        ApplicationDbContext db;

        public DepositTransactionsDbRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Add(DepositTransaction entity)
        {
            db.DepositTransactions.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var DepositTransaction = Find(id);
            db.DepositTransactions.Remove(DepositTransaction);
            db.SaveChanges();
        }

        public DepositTransaction Find(int id)
        {
            var DepositTransaction = db.DepositTransactions.Include(a => a.Wallet).ThenInclude(a=>a.User)
                .SingleOrDefault(b => b.Id == id);

            return DepositTransaction;
        }

        public IList<DepositTransaction> List()
        {
            return db.DepositTransactions.Include(a=>a.Wallet).ToList();
        }

        public List<DepositTransaction> Search(string term)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, DepositTransaction newDepositTransaction)
        {
            db.Update(newDepositTransaction);
            db.SaveChanges();
        }

    }
}
