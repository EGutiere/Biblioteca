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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfVendas.DAL;

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
            cboTeste.ItemsSource = ClienteDAO.RetornarLista();
            cboTeste.DisplayMemberPath = "ClienteNome";
            cboTeste.SelectedValuePath = "ClienteId";
        }

        private void btnMensagem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cboTeste.SelectedValue.ToString(), "Mensagem",
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
    }
}
