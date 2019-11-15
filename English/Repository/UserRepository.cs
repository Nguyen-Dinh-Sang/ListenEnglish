using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using English.Models;
using English.Services;

namespace English.Repository
{
    public class UserRepository : IUser
    {
        private DBContext db;

        public UserRepository(DBContext db)
        {
            this.db = db;
        }

        public IEnumerable<User> getUsers => db.NguoiDung;

        public void add(User user)
        {
            db.NguoiDung.Add(user);
            db.SaveChanges();
        }

        public User getUser(int? id)
        {
            User findResults = db.NguoiDung.Find(id);
            return findResults;
        }

        public void remove(int? id)
        {
            User findResults = db.NguoiDung.Find(id);
            db.NguoiDung.Remove(findResults);
            db.SaveChanges();
        }
    }
}
