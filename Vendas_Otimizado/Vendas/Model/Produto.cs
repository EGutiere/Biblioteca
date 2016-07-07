using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("Produtos")]
    class Produto
    {
        [Key]
        public int ProdutosId { get; set; }
        public string Nome { get; set; }
        public double PrecoCompra { get; set; }
        public double Markup { get; set; }
    }
}
