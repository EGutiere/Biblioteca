using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("ItensVenda")]
    class ItensVenda
    {
        [Key]
        public int ItensVendaId { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }
        public double PrecoUnitario { get; set; }
    }
}
