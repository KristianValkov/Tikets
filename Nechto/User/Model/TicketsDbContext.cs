using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace User.Model
{
    public class TicketsDbContext
    {
        public class DishesDbContext : DbContext
        {
            public DishesDbContext() : base("TiketsDbContext")
            {

            }
            // Създаване редовете на таблица Tikets
            public DbSet<Ticket> Tickets { get; set; }
            // Създаване редовете на таблица Users
            public DbSet<User> Users { get; set; }
        }
    }
}
