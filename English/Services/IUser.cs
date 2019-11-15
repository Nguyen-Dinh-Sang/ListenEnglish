using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using English.Models;

namespace English.Services
{
    public interface IUser
    {
        IEnumerable<User> getUsers { get; }

        User getUser(int? id);

        void add(User user);

        void remove(int? id);
    }
}
