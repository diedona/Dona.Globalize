using Dona.Globalize.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dona.Globalize.Domain
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DtBirthday { get; set; }
        public DateTime DtInsert { get; set; }
        public DateTime DtLastUpdate { get; set; }
        public bool Status { get; set; }
    }
}
