using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("Vendedores")]
    class Vendedor
    {
        [Key]
        public int VendedoresId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Comissao { get; set; }
    }
}
