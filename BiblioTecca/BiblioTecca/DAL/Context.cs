using System.Data.Entity;
using BiblioTecca.Model;

namespace BiblioTecca.DAL
{
    class Context : DbContext
    {
        public Context()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }

    }
}
