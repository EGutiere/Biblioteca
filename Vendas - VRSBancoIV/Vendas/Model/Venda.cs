using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("Vendas")]
    class Venda
    {
        [Key]
        public int VendaId { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItensVenda> ListaDeProdutos { get; set; }
        public DateTime DataDaCompra { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }

        public Venda()
        {
            FormaDePagamento = new Model.FormaDePagamento();
            Cliente = new Model.Cliente();
            Vendedor = new Model.Vendedor();
            ListaDeProdutos = new List<ItensVenda>();
        }
    }
}
