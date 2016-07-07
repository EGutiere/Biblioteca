using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTecca.Model
{
    [Table("Locacao")]
    class Locacao
    {
        [Key]
        public int IdLocacao { get; set; }
        public Pessoa LocacaoPessoa { get; set; }
        public Livro LocacaoLivro { get; set; }
        public DateTime LocacaoDataAluguel { get; set; }
        public DateTime LocacaoDataLimite { get; set; }
        public DateTime ? LocacaoDataDevolucao { get; set; }
        public bool LocacaoStatus { get; set; }
    }
}
