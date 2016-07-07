using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfVendas.DAL;
using WpfVendas.Models;

namespace WpfVendas.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Preencher GRID
            grdClientes.ItemsSource = ClienteDAO.BuscarClientes();

            //Preencher COMBO BOX
            cboClientes.ItemsSource = ClienteDAO.BuscarClientes();
            cboClientes.DisplayMemberPath = "ClienteNome";
            cboClientes.SelectedValuePath = "ClienteId";

        }

        private void btnMensagem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!", "Mensagem",
                MessageBoxButton.YesNo, MessageBoxImage.Information);
        }

        private void menuCadastroSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo...",
                MessageBoxButton.YesNo, MessageBoxImage.Question) ==
                MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuCadastroCliente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void btnLInhaSelecionada_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = (Cliente)grdClientes.SelectedItem;
            MessageBox.Show("\nNome: " + c.ClienteNome + "\nTelefone: " + c.ClienteTelefone);
        }

        private void btnItemSelecionado_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = ClienteDAO.BuscarClientePorId((int)cboClientes.SelectedValue);
            MessageBox.Show("\nNome: " + c.ClienteNome + "\nTelefone: " + c.ClienteTelefone);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //Atualizar GRID
            grdClientes.ItemsSource = null;
            grdClientes.ItemsSource = ClienteDAO.BuscarClientes();

            //Atualizar COMBO BOX
            cboClientes.ItemsSource = null;
            cboClientes.ItemsSource = ClienteDAO.BuscarClientes();
            cboClientes.DisplayMemberPath = "ClienteNome";
            cboClientes.SelectedValuePath = "ClienteId";
        }

    }
}
