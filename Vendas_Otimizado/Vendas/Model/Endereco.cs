using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Model
{
    [Table("Enderecos")]
    class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public String Rua { get; set; }
        public Int32 Numero { get; set; }
        public String Cep { get; set; }
    }
}
