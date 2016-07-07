using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfVendas.Models;

namespace WpfVendas.DAL
{
    class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
