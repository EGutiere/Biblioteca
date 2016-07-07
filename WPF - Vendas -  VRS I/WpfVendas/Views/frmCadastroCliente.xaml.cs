using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfVendas.DAL;
using WpfVendas.Models;

namespace WpfVendas.Views
{
    /// <summary>
    /// Interaction logic for frmCadastroCliente.xaml
    /// </summary>
    public partial class frmCadastroCliente : Window
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.ClienteNome = txtNome.Text;
            c.ClienteCpf = txtCpf.Text;
            c.ClienteTelefone = txtTelefone.Text;
            if (ClienteDAO.AdicionarCliente(c))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Cliente",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Cliente",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txtNome.Text = "";
            txtNome.Focus();

        }
    }
}
