using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BiblioTecca.Model
{
    [Table("Livros")]
    class Livro
    {
        [Key]
        public int IdLivro { get; set; }
        public string LivroNome { get; set; }
        public string LivroColetanea { get; set; }
        public string LivroClassificacao { get; set; }
        public bool LivroStatus { get; set; }
    }
}
