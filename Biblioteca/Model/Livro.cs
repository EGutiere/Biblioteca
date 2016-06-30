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
    class Livro
    {
        [Key]
        public int IdLivro { get; set; }
        public string Nome { get; set; }
        public string Coletanea { get; set; }
        public string Ano { get; set; }
    }
}
