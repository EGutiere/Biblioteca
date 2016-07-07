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
using BiblioTecca.DAL;
using BiblioTecca.Model;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for frmManterPessoa.xaml
    /// </summary>
    public partial class frm_ManterPessoa : Window
    {
        //Inicializa o Pessoa
        private Pessoa p = new Pessoa();
        //Inicializa componentes 
        public frm_ManterPessoa()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Cpf_Click(object sender, RoutedEventArgs e)
        {
            p = new Pessoa();
            if (!string.IsNullOrEmpty(txt_Cpf_Busca.Text))
            {
                p.PessoaCpf = txt_Cpf_Busca.Text;
                p = PessoaDAO.VerificarPessoaPorCPF(p);
                if (p != null)
                {
                    txt_Nome.Text = p.PessoaNome;
                    txt_Cpf.Text = p.PessoaCpf;
                }
                else
                {
                    MessageBox.Show("Pessoa não encontrado!", "Cadastro de Pessoa",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher o campo da busca", "Cadastro de Pessoa",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btn_frmPessoa_Inserir_Click(object sender, RoutedEventArgs e)
        {
            p = new Pessoa();
            p.PessoaNome = txt_Nome.Text;
            p.PessoaCpf = txt_Cpf.Text;

            if (PessoaDAO.AdicionarPessoa(p))
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

        private void btn_frmPessoa_Alterar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o registro?", "Cadastro de Pessoa",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                p.PessoaNome = txt_Nome.Text;
                p.PessoaCpf = txt_Cpf.Text;

                if (PessoaDAO.AlterarPessoa(p))
                {
                    MessageBox.Show("Cliente alterado com sucesso", "Cadastra Pessoa", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não alterado!", "Cadastra Pessoa", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }
        }

        private void btn_frmPessoa_Excluir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja remover o registro?", "Cadastro de Pessoa",
               MessageBoxButton.YesNo, MessageBoxImage.Question) ==
               MessageBoxResult.Yes)
            {
                if (PessoaDAO.RemoverPessoa(p))
                {
                    MessageBox.Show("Cliente removido com sucesso", "Cadastra Pessoa", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não removido!", "Cadastra Pessoa", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                DesabilitarBotoes();
            }
            else
            {
                DesabilitarBotoes();
            }
        }

        private void btn_frmPessoa_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DesabilitarBotoes();
        }

        public void HabilitarBotoes()
        {
            btn_frmPessoa_Inserir.IsEnabled = true;
            btn_frmPessoa_Alterar.IsEnabled = true;
            btn_frmPessoa_Excluir.IsEnabled = true;
            btn_frmPessoa_Cancelar.IsEnabled = false;
        }

        public void DesabilitarBotoes()
        {
            btn_frmPessoa_Inserir.IsEnabled = false;
            btn_frmPessoa_Alterar.IsEnabled = false;
            btn_frmPessoa_Excluir.IsEnabled = false;
            btn_frmPessoa_Cancelar.IsEnabled = true;
            txt_Cpf_Busca.Clear();
            txt_Nome.Clear();
            txt_Cpf.Clear();
            txt_Cpf_Busca.Focus();
        }     
    }
}
