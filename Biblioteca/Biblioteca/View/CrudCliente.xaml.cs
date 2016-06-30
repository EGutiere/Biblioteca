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
using Biblioteca.Model;
using Biblioteca.DAL;

namespace Biblioteca.View
{
    /// <summary>
    /// Interaction logic for Biblioteca.xaml
    /// </summary>
    public partial class Biblioteca : Window
    {
        private Pessoa p = new Pessoa();

        public Biblioteca()
        {
            InitializeComponent();
        }


        private void btn_Incluir_Click(object sender, RoutedEventArgs e)
        {
            p = new Pessoa();
            p.Nome = txt_Nome.Text;
            p.Cpf = txt_CPF.Text;

            if (PessoaDAO.AlterarPessoa(p))
            {
                MessageBox.Show("Gravado com sucesso!", "Cadastro de Pessoa",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não foi possível gravar!", "Cadastro de Pessoa",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }

            txt_Nome.Text = "";
            txt_Nome.Focus();
        }

        private void btn_Alterar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txt_CPF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
