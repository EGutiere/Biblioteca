using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioTecca.Views
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBanco.Relatorio_Geral' table. You can move, or remove it, as needed.
            this.relatorio_GeralTableAdapter.Fill(this.dsBanco.Relatorio_Geral);
            // TODO: This line of code loads data into the 'dsBanco.Relatorio_Geral' table. You can move, or remove it, as needed.
            this.relatorio_GeralTableAdapter.Fill(this.dsBanco.Relatorio_Geral);
            // TODO: This line of code loads data into the 'dsBanco.Relatorio_Geral' table. You can move, or remove it, as needed.
            this.relatorio_GeralTableAdapter.Fill(this.dsBanco.Relatorio_Geral);

        }

        private void Relatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Relatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
