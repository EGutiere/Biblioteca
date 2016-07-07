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
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ItensVenda> ListaDeProdutos { get; set; }
        public DateTime DataDaCompra { get; set; }
        public Endereco Endereco { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        public Venda()
        {
            Cliente = new Model.Cliente();
            Vendedor = new Model.Vendedor();
            ListaDeProdutos = new List<ItensVenda>();
            Endereco = new Model.Endereco();
            FormaPagamento = new Model.FormaPagamento();
        }
    }
}
