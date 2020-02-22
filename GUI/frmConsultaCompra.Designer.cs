namespace GUI
{
    partial class frmConsultaCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_todas = new System.Windows.Forms.RadioButton();
            this.rb_data = new System.Windows.Forms.RadioButton();
            this.rb_parcelas = new System.Windows.Forms.RadioButton();
            this.rb_for = new System.Windows.Forms.RadioButton();
            this.rb_comcod = new System.Windows.Forms.RadioButton();
            this.btn_localizarCompra = new System.Windows.Forms.Button();
            this.txt_fornome = new System.Windows.Forms.TextBox();
            this.dtp_incial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.lb_datainicial = new System.Windows.Forms.Label();
            this.lb_datafinal = new System.Windows.Forms.Label();
            this.pn_data = new System.Windows.Forms.Panel();
            this.btn_localizarData = new System.Windows.Forms.Button();
            this.txt_forcod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_for = new System.Windows.Forms.Panel();
            this.btn_localizaFornecedor = new System.Windows.Forms.Button();
            this.pn_compra = new System.Windows.Forms.Panel();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbc_dados = new System.Windows.Forms.TabControl();
            this.tp_compra = new System.Windows.Forms.TabPage();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.tp_itens = new System.Windows.Forms.TabPage();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.tp_parcelas = new System.Windows.Forms.TabPage();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.rb_cancelada = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.pn_data.SuspendLayout();
            this.pn_for.SuspendLayout();
            this.pn_compra.SuspendLayout();
            this.tbc_dados.SuspendLayout();
            this.tp_compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.tp_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.tp_parcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cancelada);
            this.groupBox1.Controls.Add(this.rb_todas);
            this.groupBox1.Controls.Add(this.rb_data);
            this.groupBox1.Controls.Add(this.rb_parcelas);
            this.groupBox1.Controls.Add(this.rb_for);
            this.groupBox1.Controls.Add(this.rb_comcod);
            this.groupBox1.Location = new System.Drawing.Point(36, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 110);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // rb_todas
            // 
            this.rb_todas.AutoSize = true;
            this.rb_todas.Checked = true;
            this.rb_todas.Location = new System.Drawing.Point(6, 19);
            this.rb_todas.Name = "rb_todas";
            this.rb_todas.Size = new System.Drawing.Size(112, 17);
            this.rb_todas.TabIndex = 5;
            this.rb_todas.TabStop = true;
            this.rb_todas.Text = "Todas as compras";
            this.rb_todas.UseVisualStyleBackColor = true;
            this.rb_todas.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_data
            // 
            this.rb_data.AutoSize = true;
            this.rb_data.Location = new System.Drawing.Point(124, 42);
            this.rb_data.Name = "rb_data";
            this.rb_data.Size = new System.Drawing.Size(48, 17);
            this.rb_data.TabIndex = 4;
            this.rb_data.Text = "Data";
            this.rb_data.UseVisualStyleBackColor = true;
            this.rb_data.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_parcelas
            // 
            this.rb_parcelas.AutoSize = true;
            this.rb_parcelas.Location = new System.Drawing.Point(6, 65);
            this.rb_parcelas.Name = "rb_parcelas";
            this.rb_parcelas.Size = new System.Drawing.Size(130, 17);
            this.rb_parcelas.TabIndex = 2;
            this.rb_parcelas.Text = "Parcelas não quitadas";
            this.rb_parcelas.UseVisualStyleBackColor = true;
            this.rb_parcelas.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_for
            // 
            this.rb_for.AutoSize = true;
            this.rb_for.Location = new System.Drawing.Point(6, 42);
            this.rb_for.Name = "rb_for";
            this.rb_for.Size = new System.Drawing.Size(79, 17);
            this.rb_for.TabIndex = 1;
            this.rb_for.Text = "Fornecedor";
            this.rb_for.UseVisualStyleBackColor = true;
            this.rb_for.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_comcod
            // 
            this.rb_comcod.AutoSize = true;
            this.rb_comcod.Location = new System.Drawing.Point(124, 19);
            this.rb_comcod.Name = "rb_comcod";
            this.rb_comcod.Size = new System.Drawing.Size(101, 17);
            this.rb_comcod.TabIndex = 0;
            this.rb_comcod.Text = "Cód. da Compra";
            this.rb_comcod.UseVisualStyleBackColor = true;
            this.rb_comcod.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // btn_localizarCompra
            // 
            this.btn_localizarCompra.Location = new System.Drawing.Point(289, 19);
            this.btn_localizarCompra.Name = "btn_localizarCompra";
            this.btn_localizarCompra.Size = new System.Drawing.Size(163, 33);
            this.btn_localizarCompra.TabIndex = 8;
            this.btn_localizarCompra.Text = "Localizar Compra";
            this.btn_localizarCompra.UseVisualStyleBackColor = true;
            this.btn_localizarCompra.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // txt_fornome
            // 
            this.txt_fornome.Enabled = false;
            this.txt_fornome.Location = new System.Drawing.Point(36, 65);
            this.txt_fornome.Name = "txt_fornome";
            this.txt_fornome.Size = new System.Drawing.Size(417, 20);
            this.txt_fornome.TabIndex = 6;
            // 
            // dtp_incial
            // 
            this.dtp_incial.Location = new System.Drawing.Point(35, 29);
            this.dtp_incial.Name = "dtp_incial";
            this.dtp_incial.Size = new System.Drawing.Size(226, 20);
            this.dtp_incial.TabIndex = 10;
            // 
            // dtp_final
            // 
            this.dtp_final.Location = new System.Drawing.Point(36, 65);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(229, 20);
            this.dtp_final.TabIndex = 11;
            // 
            // lb_datainicial
            // 
            this.lb_datainicial.AutoSize = true;
            this.lb_datainicial.Location = new System.Drawing.Point(33, 14);
            this.lb_datainicial.Name = "lb_datainicial";
            this.lb_datainicial.Size = new System.Drawing.Size(60, 13);
            this.lb_datainicial.TabIndex = 12;
            this.lb_datainicial.Text = "Data Inicial";
            // 
            // lb_datafinal
            // 
            this.lb_datafinal.AutoSize = true;
            this.lb_datafinal.Location = new System.Drawing.Point(33, 52);
            this.lb_datafinal.Name = "lb_datafinal";
            this.lb_datafinal.Size = new System.Drawing.Size(52, 13);
            this.lb_datafinal.TabIndex = 13;
            this.lb_datafinal.Text = "Data final";
            // 
            // pn_data
            // 
            this.pn_data.Controls.Add(this.lb_datafinal);
            this.pn_data.Controls.Add(this.lb_datainicial);
            this.pn_data.Controls.Add(this.dtp_incial);
            this.pn_data.Controls.Add(this.dtp_final);
            this.pn_data.Controls.Add(this.btn_localizarData);
            this.pn_data.Location = new System.Drawing.Point(270, 18);
            this.pn_data.Name = "pn_data";
            this.pn_data.Size = new System.Drawing.Size(479, 94);
            this.pn_data.TabIndex = 14;
            this.pn_data.Visible = false;
            // 
            // btn_localizarData
            // 
            this.btn_localizarData.Location = new System.Drawing.Point(289, 29);
            this.btn_localizarData.Name = "btn_localizarData";
            this.btn_localizarData.Size = new System.Drawing.Size(163, 33);
            this.btn_localizarData.TabIndex = 14;
            this.btn_localizarData.Text = "Localizar Compra";
            this.btn_localizarData.UseVisualStyleBackColor = true;
            this.btn_localizarData.Click += new System.EventHandler(this.btn_localizarData_Click);
            // 
            // txt_forcod
            // 
            this.txt_forcod.Enabled = false;
            this.txt_forcod.Location = new System.Drawing.Point(36, 26);
            this.txt_forcod.Name = "txt_forcod";
            this.txt_forcod.Size = new System.Drawing.Size(230, 20);
            this.txt_forcod.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cód. do Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome do Fornecedor";
            // 
            // pn_for
            // 
            this.pn_for.Controls.Add(this.btn_localizaFornecedor);
            this.pn_for.Controls.Add(this.txt_forcod);
            this.pn_for.Controls.Add(this.label2);
            this.pn_for.Controls.Add(this.label3);
            this.pn_for.Controls.Add(this.txt_fornome);
            this.pn_for.Location = new System.Drawing.Point(270, 18);
            this.pn_for.Name = "pn_for";
            this.pn_for.Size = new System.Drawing.Size(479, 94);
            this.pn_for.TabIndex = 19;
            this.pn_for.Visible = false;
            // 
            // btn_localizaFornecedor
            // 
            this.btn_localizaFornecedor.Location = new System.Drawing.Point(283, 13);
            this.btn_localizaFornecedor.Name = "btn_localizaFornecedor";
            this.btn_localizaFornecedor.Size = new System.Drawing.Size(170, 33);
            this.btn_localizaFornecedor.TabIndex = 19;
            this.btn_localizaFornecedor.Text = "Localizar Compra";
            this.btn_localizaFornecedor.UseVisualStyleBackColor = true;
            this.btn_localizaFornecedor.Click += new System.EventHandler(this.btn_localizaFornecedor_Click);
            // 
            // pn_compra
            // 
            this.pn_compra.Controls.Add(this.txt_valor);
            this.pn_compra.Controls.Add(this.btn_localizarCompra);
            this.pn_compra.Controls.Add(this.label4);
            this.pn_compra.Location = new System.Drawing.Point(270, 18);
            this.pn_compra.Name = "pn_compra";
            this.pn_compra.Size = new System.Drawing.Size(479, 62);
            this.pn_compra.TabIndex = 20;
            this.pn_compra.Visible = false;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(36, 30);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(229, 20);
            this.txt_valor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cód. da Compra";
            // 
            // tbc_dados
            // 
            this.tbc_dados.Controls.Add(this.tp_compra);
            this.tbc_dados.Controls.Add(this.tp_itens);
            this.tbc_dados.Controls.Add(this.tp_parcelas);
            this.tbc_dados.Location = new System.Drawing.Point(36, 134);
            this.tbc_dados.Name = "tbc_dados";
            this.tbc_dados.SelectedIndex = 0;
            this.tbc_dados.Size = new System.Drawing.Size(713, 394);
            this.tbc_dados.TabIndex = 21;
            // 
            // tp_compra
            // 
            this.tp_compra.Controls.Add(this.dgv_dados);
            this.tp_compra.Location = new System.Drawing.Point(4, 22);
            this.tp_compra.Name = "tp_compra";
            this.tp_compra.Padding = new System.Windows.Forms.Padding(3);
            this.tp_compra.Size = new System.Drawing.Size(705, 368);
            this.tp_compra.TabIndex = 0;
            this.tp_compra.Text = "Compras";
            this.tp_compra.UseVisualStyleBackColor = true;
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(4, 1);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(698, 367);
            this.dgv_dados.TabIndex = 8;
            this.dgv_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellClick);
            this.dgv_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellDoubleClick);
            // 
            // tp_itens
            // 
            this.tp_itens.Controls.Add(this.dgv_itens);
            this.tp_itens.Location = new System.Drawing.Point(4, 22);
            this.tp_itens.Name = "tp_itens";
            this.tp_itens.Padding = new System.Windows.Forms.Padding(3);
            this.tp_itens.Size = new System.Drawing.Size(705, 368);
            this.tp_itens.TabIndex = 1;
            this.tp_itens.Text = "Itens da Compra Selecionada";
            this.tp_itens.UseVisualStyleBackColor = true;
            // 
            // dgv_itens
            // 
            this.dgv_itens.AllowUserToAddRows = false;
            this.dgv_itens.AllowUserToDeleteRows = false;
            this.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itens.Location = new System.Drawing.Point(3, 1);
            this.dgv_itens.Name = "dgv_itens";
            this.dgv_itens.ReadOnly = true;
            this.dgv_itens.Size = new System.Drawing.Size(698, 367);
            this.dgv_itens.TabIndex = 9;
            // 
            // tp_parcelas
            // 
            this.tp_parcelas.Controls.Add(this.dgv_parcelas);
            this.tp_parcelas.Location = new System.Drawing.Point(4, 22);
            this.tp_parcelas.Name = "tp_parcelas";
            this.tp_parcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tp_parcelas.Size = new System.Drawing.Size(705, 368);
            this.tp_parcelas.TabIndex = 2;
            this.tp_parcelas.Text = "Parcelas da Compra Selecionada";
            this.tp_parcelas.UseVisualStyleBackColor = true;
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Location = new System.Drawing.Point(3, 1);
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.ReadOnly = true;
            this.dgv_parcelas.Size = new System.Drawing.Size(698, 367);
            this.dgv_parcelas.TabIndex = 9;
            // 
            // rb_cancelada
            // 
            this.rb_cancelada.AutoSize = true;
            this.rb_cancelada.Location = new System.Drawing.Point(5, 87);
            this.rb_cancelada.Name = "rb_cancelada";
            this.rb_cancelada.Size = new System.Drawing.Size(124, 17);
            this.rb_cancelada.TabIndex = 6;
            this.rb_cancelada.TabStop = true;
            this.rb_cancelada.Text = "Compras canceladas";
            this.rb_cancelada.UseVisualStyleBackColor = true;
            this.rb_cancelada.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // frmConsultaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tbc_dados);
            this.Controls.Add(this.pn_compra);
            this.Controls.Add(this.pn_for);
            this.Controls.Add(this.pn_data);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Compra";
            this.Load += new System.EventHandler(this.frmConsultaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pn_data.ResumeLayout(false);
            this.pn_data.PerformLayout();
            this.pn_for.ResumeLayout(false);
            this.pn_for.PerformLayout();
            this.pn_compra.ResumeLayout(false);
            this.pn_compra.PerformLayout();
            this.tbc_dados.ResumeLayout(false);
            this.tp_compra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.tp_itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.tp_parcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_for;
        private System.Windows.Forms.RadioButton rb_comcod;
        private System.Windows.Forms.Button btn_localizarCompra;
        private System.Windows.Forms.TextBox txt_fornome;
        private System.Windows.Forms.RadioButton rb_parcelas;
        private System.Windows.Forms.RadioButton rb_todas;
        private System.Windows.Forms.RadioButton rb_data;
        private System.Windows.Forms.DateTimePicker dtp_incial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label lb_datainicial;
        private System.Windows.Forms.Label lb_datafinal;
        private System.Windows.Forms.Panel pn_data;
        private System.Windows.Forms.TextBox txt_forcod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pn_for;
        private System.Windows.Forms.Button btn_localizaFornecedor;
        private System.Windows.Forms.Panel pn_compra;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_localizarData;
        private System.Windows.Forms.TabControl tbc_dados;
        private System.Windows.Forms.TabPage tp_compra;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TabPage tp_itens;
        private System.Windows.Forms.TabPage tp_parcelas;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.RadioButton rb_cancelada;
    }
}