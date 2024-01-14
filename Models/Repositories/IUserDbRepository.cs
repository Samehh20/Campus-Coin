using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models.Repositories
{
   public interface IUserDbRepository: ICampusCoinRepository<User>
    {
        User FindBySsn(string ssn);
        User FindById(Guid Id);
        Guid AddUser(User user);
        void UpdateById(Guid Id, User user);
    }
}
