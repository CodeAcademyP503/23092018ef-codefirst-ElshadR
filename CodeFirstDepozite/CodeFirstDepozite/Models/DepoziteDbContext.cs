using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDepozite.Models
{
    public class DepoziteDbContext : DbContext
    {
        public DepoziteDbContext():base("CFDepoziteDb")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Credit> Credits { get; set; }
    }
}
