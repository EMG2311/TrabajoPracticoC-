using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProyecto.CMD.Entidades
{
    internal class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CuilCuit { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public bool? EmailConfirmed { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public CustomerStatus Status { get; set; }

    }
}
