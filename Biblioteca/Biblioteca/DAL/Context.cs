using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class Context : DbContext
    {
        public Context()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Pessoa> Pessoas { get; set; }        
        public DbSet<Livro> Livros { get; set; }
        
    }
}
