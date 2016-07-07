using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;

namespace Vendas.DAL
{
    class InicilizarDados
    {
        public static void Inicilizar()
        {
            getClientes().ForEach(c => ClienteDAO.AdicionarCliente(c));
            getVendedores().ForEach(v => VendedorDAO.AdicionarVendedor(v));
            getProdutos().ForEach(p => ProdutoDAO.AdicionarProduto(p));
        }

        public static List<Cliente> getClientes()
        {
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente{
                    ClienteId = 1,
                    Nome = "Diogo Deconto",
                    Cpf = "1"
                },
                new Cliente{
                    ClienteId = 2,
                    Nome = "José da Silva",
                    Cpf = "2"
                },
                new Cliente{
                    ClienteId = 3,
                    Nome = "Maria Rocha",
                    Cpf = "3"
                }
            };
            return clientes;
        }

        public static List<Vendedor> getVendedores()
        {
            List<Vendedor> vendedores = new List<Vendedor>
            {
                new Vendedor{
                    VendedoresId = 1,
                    Nome = "Felipe Costa",
                    Cpf = "1"
                },
                new Vendedor{
                    VendedoresId = 2,
                    Nome = "Renata Silva",
                    Cpf = "2"
                },
                new Vendedor{
                    VendedoresId = 3,
                    Nome = "Augusto Rocha",
                    Cpf = "3"
                }
            };
            return vendedores;
        }


        public static List<Produto> getProdutos()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto{
                    Nome = "Bolacha",
                    PrecoCompra = 2.5,
                    Markup = 3
                },
                new Produto{
                    Nome = "Arroz",
                    PrecoCompra = 4.5,
                    Markup = 2
                },
                new Produto{
                    Nome = "Feijão",
                    PrecoCompra = 5,
                    Markup = 2
                }
            };
            return produtos;
        }
    }
}
