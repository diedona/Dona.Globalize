using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Globalize.Domain.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        bool Status { get; set; }
        DateTime DtInsert { get; set; }
        DateTime DtLastUpdate { get; set; }
    }
}
