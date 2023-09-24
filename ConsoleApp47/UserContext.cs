using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp47
{
    class UserContext : DbContext
    {
        public UserContext() 
            :base("USERS")
        { }

        public DbSet<User> Users { get; set; }
    }
}
