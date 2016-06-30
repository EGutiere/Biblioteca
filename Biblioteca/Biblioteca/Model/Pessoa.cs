using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Model
{
    [Table("Pessoas")]
    class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
    }
}
