using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using English.Models;
using Microsoft.EntityFrameworkCore;

namespace English.Repository
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<User> NguoiDung { get; set; }

    }
}
