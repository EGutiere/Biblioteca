using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BiblioTecca.Model
{
    [Table("Pessoas")]
    class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaCpf { get; set; }
    }
}
