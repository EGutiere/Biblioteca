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
using BiblioTecca.Views;

namespace BiblioTecca.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_CRUD_Pessoa_Click(object sender, RoutedEventArgs e)
        {
            frm_ManterPessoa p = new frm_ManterPessoa();
            p.ShowDialog();
        }

        private void Menu_CRUDLivro_Click(object sender, RoutedEventArgs e)
        {
            frm_ManterLivro l = new frm_ManterLivro();
            l.ShowDialog();
        }

        private void Menu_Alugar_Devolver_Click(object sender, RoutedEventArgs e)
        {
            frm_Alugar_Devolver a = new frm_Alugar_Devolver();
            a.ShowDialog();
        }
    }
}
