using Dona.Globalize.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Globalize.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DtInsert { get; set; }
        public DateTime DtLastUpdate { get; set; }
        public bool Status { get; set; }
    }
}
