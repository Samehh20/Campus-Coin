using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models.Repositories
{
   public interface IWalletDbRepository: ICampusCoinRepository<Wallet>
    {
        void UpdateByGuid(Guid Id, Wallet newWallet);
        Wallet FindByGuid(Guid Id);
        void Deposit(Guid Id, double amount);
        Guid AddWallet(Guid uId);
    }
}
