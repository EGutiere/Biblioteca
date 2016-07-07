using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("FormasPagamento")]
    class FormaPagamento
    {
        [Key]
        public int FormaPagamentoId { get; set; }
        public string Nome { get; set; }
    }
}
