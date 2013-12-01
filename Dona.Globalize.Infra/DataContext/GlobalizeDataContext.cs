using Dona.Globalize.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Globalize.Infra.DataContext
{
    public class GlobalizeDataContext : DbContext
    {
        public GlobalizeDataContext() : base("Globalize")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
