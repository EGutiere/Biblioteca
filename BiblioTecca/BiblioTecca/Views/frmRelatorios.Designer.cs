namespace BiblioTecca.Views
{
    partial class frmRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsBanco = new BiblioTecca.Views.dsBanco();
            this.dsBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorioGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relatorio_GeralTableAdapter = new BiblioTecca.Views.dsBancoTableAdapters.Relatorio_GeralTableAdapter();
            this.tituloLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDLocaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLocaçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLimiteDevoluçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevoluçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloLivroDataGridViewTextBoxColumn,
            this.nomePessoaDataGridViewTextBoxColumn,
            this.iDLocaçãoDataGridViewTextBoxColumn,
            this.dataLocaçãoDataGridViewTextBoxColumn,
            this.dataLimiteDevoluçãoDataGridViewTextBoxColumn,
            this.dataDevoluçãoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.relatorioGeralBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // dsBanco
            // 
            this.dsBanco.DataSetName = "dsBanco";
            this.dsBanco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsBancoBindingSource
            // 
            this.dsBancoBindingSource.DataSource = this.dsBanco;
            this.dsBancoBindingSource.Position = 0;
            // 
            // relatorioGeralBindingSource
            // 
            this.relatorioGeralBindingSource.DataMember = "Relatorio_Geral";
            this.relatorioGeralBindingSource.DataSource = this.dsBancoBindingSource;
            // 
            // relatorio_GeralTableAdapter
            // 
            this.relatorio_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // tituloLivroDataGridViewTextBoxColumn
            // 
            this.tituloLivroDataGridViewTextBoxColumn.DataPropertyName = "Titulo Livro";
            this.tituloLivroDataGridViewTextBoxColumn.HeaderText = "Titulo Livro";
            this.tituloLivroDataGridViewTextBoxColumn.Name = "tituloLivroDataGridViewTextBoxColumn";
            // 
            // nomePessoaDataGridViewTextBoxColumn
            // 
            this.nomePessoaDataGridViewTextBoxColumn.DataPropertyName = "Nome Pessoa";
            this.nomePessoaDataGridViewTextBoxColumn.HeaderText = "Nome Pessoa";
            this.nomePessoaDataGridViewTextBoxColumn.Name = "nomePessoaDataGridViewTextBoxColumn";
            // 
            // iDLocaçãoDataGridViewTextBoxColumn
            // 
            this.iDLocaçãoDataGridViewTextBoxColumn.DataPropertyName = "ID Locação";
            this.iDLocaçãoDataGridViewTextBoxColumn.HeaderText = "ID Locação";
            this.iDLocaçãoDataGridViewTextBoxColumn.Name = "iDLocaçãoDataGridViewTextBoxColumn";
            this.iDLocaçãoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLocaçãoDataGridViewTextBoxColumn
            // 
            this.dataLocaçãoDataGridViewTextBoxColumn.DataPropertyName = "Data Locação";
            this.dataLocaçãoDataGridViewTextBoxColumn.HeaderText = "Data Locação";
            this.dataLocaçãoDataGridViewTextBoxColumn.Name = "dataLocaçãoDataGridViewTextBoxColumn";
            // 
            // dataLimiteDevoluçãoDataGridViewTextBoxColumn
            // 
            this.dataLimiteDevoluçãoDataGridViewTextBoxColumn.DataPropertyName = "Data Limite Devolução";
            this.dataLimiteDevoluçãoDataGridViewTextBoxColumn.HeaderText = "Data Limite Devolução";
            this.dataLimiteDevoluçãoDataGridViewTextBoxColumn.Name = "dataLimiteDevoluçãoDataGridViewTextBoxColumn";
            // 
            // dataDevoluçãoDataGridViewTextBoxColumn
            // 
            this.dataDevoluçãoDataGridViewTextBoxColumn.DataPropertyName = "Data Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.HeaderText = "Data Devolução";
            this.dataDevoluçãoDataGridViewTextBoxColumn.Name = "dataDevoluçãoDataGridViewTextBoxColumn";
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 269);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatorioGeralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dsBancoBindingSource;
        private dsBanco dsBanco;
        private System.Windows.Forms.BindingSource relatorioGeralBindingSource;
        private dsBancoTableAdapters.Relatorio_GeralTableAdapter relatorio_GeralTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLocaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLocaçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLimiteDevoluçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevoluçãoDataGridViewTextBoxColumn;
    }
}