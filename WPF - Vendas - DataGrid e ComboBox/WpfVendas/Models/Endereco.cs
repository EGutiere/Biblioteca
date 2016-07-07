using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVendas.Models
{
    [Table("Enderecos")]
    class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }
        public string EnderecoRua { get; set; }
    }
}
