using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("FormasDePagamento")]
    class FormaDePagamento
    {
        [Key]
        public int FormaDePagamentoId { get; set; }

        public string Nome { get; set; }
    }
}
