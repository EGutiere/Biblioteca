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

        public static Cliente VerificarClientePorCPF(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.ClienteCpf.Equals(c.ClienteCpf));
        }

        public static List<Cliente> RetornarLista()
        {
            //return listaDeClientes;
            return ctx.Clientes.ToList();
        }

        public static bool RemoverCliente(Cliente c)
        {
            try
            {
                ctx.Clientes.Remove(c);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool AlterarCliente(Cliente c)
        {
            try
            {
                ctx.Entry(c).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return true;
            }
        }

    }
}
