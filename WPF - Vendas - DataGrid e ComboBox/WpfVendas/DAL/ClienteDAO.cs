using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfVendas.Models;

namespace WpfVendas.DAL
{
    class ClienteDAO
    {
        private static Context ctx = new Context();

        public static List<Cliente> BuscarClientes()
        {
            return ctx.Clientes.Include("Endereco").ToList();
        }

        public static Cliente BuscarClientePorId(int id)
        {
            return ctx.Clientes.Find(id);
        }

        public static bool AdicionarCliente(Cliente c)
        {
            try
            {
                ctx.Clientes.Add(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
