using CampusCoin.Models;
using CampusCoin.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusCoin.Models.Repositories
{
    public class UserDbRepository : ICampusCoinRepository<User>,IUserDbRepository
    {
        ApplicationDbContext db;

        public UserDbRepository(ApplicationDbContext _db)
        {
            db = _db;
        }
        public void Add(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var author = Find(id);

            db.Users.Remove(author);
            db.SaveChanges();
        }

        public User Find(int id)
        {
            

            return null;
        }

        public User FindBySsn(string ssn)
        {
            var user = db.Users.Include(x=>x.Wallet).SingleOrDefault(a => a.SSN == ssn);
            return user;
        }

        public User FindById(Guid id)
        {
            var user = db.Users.Include(x=>x.Wallet).SingleOrDefault(a => a.Id == id);
            return user;
        }

        public IList<User> List()
        {
            return db.Users.ToList();
        }

        public List<User> Search(string term)
        {
            return db.Users.Where(a => a.Name.Contains(term)).ToList();
        }

        public void Update(int id, User newAuthor)
        {
            db.Update(newAuthor);
            db.SaveChanges();
        }

        public Guid AddUser(User user)
        {
          var temp=  db.Users.Add(user);
            db.SaveChanges();
            return temp.Entity.Id;
        }

        public void UpdateById(Guid Id, User user)
        {
            db.Update(user);
            db.SaveChanges();
        }
    }
}