using Dona.Globalize.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Globalize.Domain
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        public DateTime DtInsert { get; set; }
        public DateTime DtLastUpdate { get; set; }
        public bool Status { get; set; }
    }
}
