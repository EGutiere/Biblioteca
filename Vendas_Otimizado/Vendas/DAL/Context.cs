using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;


namespace Vendas.DAL
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FormaPagamento> FormasDePagamento { get; set; }
        public DbSet<ItensVenda> ItensVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }




    }
}
