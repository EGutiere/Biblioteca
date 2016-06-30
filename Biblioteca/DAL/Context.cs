using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using System.Data.Entity;

namespace Biblioteca.DAL
{
    class Context : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        
        public DbSet<Livro> Livros { get; set; }
    }
}
