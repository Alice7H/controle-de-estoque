namespace GUI
{
    partial class frmConsultaVenda
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
            this.rb_cancelada = new System.Windows.Forms.RadioButton();
            this.rb_avista = new System.Windows.Forms.RadioButton();
            this.rb_todas = new System.Windows.Forms.RadioButton();
            this.rb_data = new System.Windows.Forms.RadioButton();
            this.rb_parcelas = new System.Windows.Forms.RadioButton();
            this.rb_cli = new System.Windows.Forms.RadioButton();
            this.rb_vencod = new System.Windows.Forms.RadioButton();
            this.tbc_dados = new System.Windows.Forms.TabControl();
            this.tp_venda = new System.Windows.Forms.TabPage();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.tp_itens = new System.Windows.Forms.TabPage();
            this.dgv_itens = new System.Windows.Forms.DataGridView();
            this.tp_parcelas = new System.Windows.Forms.TabPage();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.pn_venda = new System.Windows.Forms.Panel();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_localizarVenda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_cli = new System.Windows.Forms.Panel();
            this.btn_localizaCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_clicod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_clinome = new System.Windows.Forms.TextBox();
            this.pn_data = new System.Windows.Forms.Panel();
            this.lb_datafinal = new System.Windows.Forms.Label();
            this.lb_datainicial = new System.Windows.Forms.Label();
            this.dtp_incial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.btn_localizarData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tbc_dados.SuspendLayout();
            this.tp_venda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.tp_itens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).BeginInit();
            this.tp_parcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.pn_venda.SuspendLayout();
            this.pn_cli.SuspendLayout();
            this.pn_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cancelada);
            this.groupBox1.Controls.Add(this.rb_avista);
            this.groupBox1.Controls.Add(this.rb_todas);
            this.groupBox1.Controls.Add(this.rb_data);
            this.groupBox1.Controls.Add(this.rb_parcelas);
            this.groupBox1.Controls.Add(this.rb_cli);
            this.groupBox1.Controls.Add(this.rb_vencod);
            this.groupBox1.Location = new System.Drawing.Point(39, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 110);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // rb_cancelada
            // 
            this.rb_cancelada.AutoSize = true;
            this.rb_cancelada.Location = new System.Drawing.Point(6, 84);
            this.rb_cancelada.Name = "rb_cancelada";
            this.rb_cancelada.Size = new System.Drawing.Size(119, 17);
            this.rb_cancelada.TabIndex = 7;
            this.rb_cancelada.TabStop = true;
            this.rb_cancelada.Text = "Vendas canceladas";
            this.rb_cancelada.UseVisualStyleBackColor = true;
            this.rb_cancelada.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_avista
            // 
            this.rb_avista.AutoSize = true;
            this.rb_avista.Location = new System.Drawing.Point(126, 40);
            this.rb_avista.Name = "rb_avista";
            this.rb_avista.Size = new System.Drawing.Size(91, 17);
            this.rb_avista.TabIndex = 6;
            this.rb_avista.TabStop = true;
            this.rb_avista.Text = "Venda à Vista";
            this.rb_avista.UseVisualStyleBackColor = true;
            this.rb_avista.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_todas
            // 
            this.rb_todas.AutoSize = true;
            this.rb_todas.Checked = true;
            this.rb_todas.Location = new System.Drawing.Point(6, 19);
            this.rb_todas.Name = "rb_todas";
            this.rb_todas.Size = new System.Drawing.Size(107, 17);
            this.rb_todas.TabIndex = 5;
            this.rb_todas.TabStop = true;
            this.rb_todas.Text = "Todas as vendas";
            this.rb_todas.UseVisualStyleBackColor = true;
            this.rb_todas.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_data
            // 
            this.rb_data.AutoSize = true;
            this.rb_data.Location = new System.Drawing.Point(166, 62);
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
            this.rb_parcelas.Location = new System.Drawing.Point(6, 62);
            this.rb_parcelas.Name = "rb_parcelas";
            this.rb_parcelas.Size = new System.Drawing.Size(130, 17);
            this.rb_parcelas.TabIndex = 2;
            this.rb_parcelas.Text = "Parcelas não quitadas";
            this.rb_parcelas.UseVisualStyleBackColor = true;
            this.rb_parcelas.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_cli
            // 
            this.rb_cli.AutoSize = true;
            this.rb_cli.Location = new System.Drawing.Point(6, 40);
            this.rb_cli.Name = "rb_cli";
            this.rb_cli.Size = new System.Drawing.Size(57, 17);
            this.rb_cli.TabIndex = 1;
            this.rb_cli.Text = "Cliente";
            this.rb_cli.UseVisualStyleBackColor = true;
            this.rb_cli.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // rb_vencod
            // 
            this.rb_vencod.AutoSize = true;
            this.rb_vencod.Location = new System.Drawing.Point(118, 19);
            this.rb_vencod.Name = "rb_vencod";
            this.rb_vencod.Size = new System.Drawing.Size(96, 17);
            this.rb_vencod.TabIndex = 0;
            this.rb_vencod.Text = "Cód. da Venda";
            this.rb_vencod.UseVisualStyleBackColor = true;
            this.rb_vencod.CheckedChanged += new System.EventHandler(this.rb_todas_CheckedChanged);
            // 
            // tbc_dados
            // 
            this.tbc_dados.Controls.Add(this.tp_venda);
            this.tbc_dados.Controls.Add(this.tp_itens);
            this.tbc_dados.Controls.Add(this.tp_parcelas);
            this.tbc_dados.Location = new System.Drawing.Point(39, 139);
            this.tbc_dados.Name = "tbc_dados";
            this.tbc_dados.SelectedIndex = 0;
            this.tbc_dados.Size = new System.Drawing.Size(713, 390);
            this.tbc_dados.TabIndex = 22;
            // 
            // tp_venda
            // 
            this.tp_venda.Controls.Add(this.dgv_dados);
            this.tp_venda.Location = new System.Drawing.Point(4, 22);
            this.tp_venda.Name = "tp_venda";
            this.tp_venda.Padding = new System.Windows.Forms.Padding(3);
            this.tp_venda.Size = new System.Drawing.Size(705, 364);
            this.tp_venda.TabIndex = 0;
            this.tp_venda.Text = "Vendas";
            this.tp_venda.UseVisualStyleBackColor = true;
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
            this.tp_itens.Size = new System.Drawing.Size(705, 364);
            this.tp_itens.TabIndex = 1;
            this.tp_itens.Text = "Itens da Venda Selecionada";
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
            this.tp_parcelas.Size = new System.Drawing.Size(705, 364);
            this.tp_parcelas.TabIndex = 2;
            this.tp_parcelas.Text = "Parcelas da Venda Selecionada";
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
            // pn_venda
            // 
            this.pn_venda.Controls.Add(this.txt_valor);
            this.pn_venda.Controls.Add(this.btn_localizarVenda);
            this.pn_venda.Controls.Add(this.label4);
            this.pn_venda.Location = new System.Drawing.Point(288, 19);
            this.pn_venda.Name = "pn_venda";
            this.pn_venda.Size = new System.Drawing.Size(459, 62);
            this.pn_venda.TabIndex = 23;
            this.pn_venda.Visible = false;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(22, 27);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(229, 20);
            this.txt_valor.TabIndex = 21;
            // 
            // btn_localizarVenda
            // 
            this.btn_localizarVenda.Location = new System.Drawing.Point(268, 14);
            this.btn_localizarVenda.Name = "btn_localizarVenda";
            this.btn_localizarVenda.Size = new System.Drawing.Size(170, 33);
            this.btn_localizarVenda.TabIndex = 8;
            this.btn_localizarVenda.Text = "Localizar Venda";
            this.btn_localizarVenda.UseVisualStyleBackColor = true;
            this.btn_localizarVenda.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cód. da Venda";
            // 
            // pn_cli
            // 
            this.pn_cli.Controls.Add(this.btn_localizaCliente);
            this.pn_cli.Controls.Add(this.label3);
            this.pn_cli.Controls.Add(this.txt_clicod);
            this.pn_cli.Controls.Add(this.label2);
            this.pn_cli.Controls.Add(this.txt_clinome);
            this.pn_cli.Location = new System.Drawing.Point(288, 18);
            this.pn_cli.Name = "pn_cli";
            this.pn_cli.Size = new System.Drawing.Size(460, 94);
            this.pn_cli.TabIndex = 24;
            this.pn_cli.Visible = false;
            // 
            // btn_localizaCliente
            // 
            this.btn_localizaCliente.Location = new System.Drawing.Point(270, 11);
            this.btn_localizaCliente.Name = "btn_localizaCliente";
            this.btn_localizaCliente.Size = new System.Drawing.Size(170, 33);
            this.btn_localizaCliente.TabIndex = 19;
            this.btn_localizaCliente.Text = "Localizar Venda";
            this.btn_localizaCliente.UseVisualStyleBackColor = true;
            this.btn_localizaCliente.Click += new System.EventHandler(this.btn_localizaCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome do Cliente";
            // 
            // txt_clicod
            // 
            this.txt_clicod.Enabled = false;
            this.txt_clicod.Location = new System.Drawing.Point(23, 24);
            this.txt_clicod.Name = "txt_clicod";
            this.txt_clicod.Size = new System.Drawing.Size(230, 20);
            this.txt_clicod.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cód. do Cliente";
            // 
            // txt_clinome
            // 
            this.txt_clinome.Enabled = false;
            this.txt_clinome.Location = new System.Drawing.Point(24, 66);
            this.txt_clinome.Name = "txt_clinome";
            this.txt_clinome.Size = new System.Drawing.Size(417, 20);
            this.txt_clinome.TabIndex = 6;
            // 
            // pn_data
            // 
            this.pn_data.Controls.Add(this.lb_datafinal);
            this.pn_data.Controls.Add(this.lb_datainicial);
            this.pn_data.Controls.Add(this.dtp_incial);
            this.pn_data.Controls.Add(this.dtp_final);
            this.pn_data.Controls.Add(this.btn_localizarData);
            this.pn_data.Location = new System.Drawing.Point(287, 22);
            this.pn_data.Name = "pn_data";
            this.pn_data.Size = new System.Drawing.Size(459, 94);
            this.pn_data.TabIndex = 25;
            this.pn_data.Visible = false;
            // 
            // lb_datafinal
            // 
            this.lb_datafinal.AutoSize = true;
            this.lb_datafinal.Location = new System.Drawing.Point(19, 51);
            this.lb_datafinal.Name = "lb_datafinal";
            this.lb_datafinal.Size = new System.Drawing.Size(52, 13);
            this.lb_datafinal.TabIndex = 13;
            this.lb_datafinal.Text = "Data final";
            // 
            // lb_datainicial
            // 
            this.lb_datainicial.AutoSize = true;
            this.lb_datainicial.Location = new System.Drawing.Point(19, 13);
            this.lb_datainicial.Name = "lb_datainicial";
            this.lb_datainicial.Size = new System.Drawing.Size(60, 13);
            this.lb_datainicial.TabIndex = 12;
            this.lb_datainicial.Text = "Data Inicial";
            // 
            // dtp_incial
            // 
            this.dtp_incial.Location = new System.Drawing.Point(22, 28);
            this.dtp_incial.Name = "dtp_incial";
            this.dtp_incial.Size = new System.Drawing.Size(226, 20);
            this.dtp_incial.TabIndex = 10;
            // 
            // dtp_final
            // 
            this.dtp_final.Location = new System.Drawing.Point(22, 65);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(225, 20);
            this.dtp_final.TabIndex = 11;
            // 
            // btn_localizarData
            // 
            this.btn_localizarData.Location = new System.Drawing.Point(276, 16);
            this.btn_localizarData.Name = "btn_localizarData";
            this.btn_localizarData.Size = new System.Drawing.Size(163, 33);
            this.btn_localizarData.TabIndex = 14;
            this.btn_localizarData.Text = "Localizar Venda";
            this.btn_localizarData.UseVisualStyleBackColor = true;
            this.btn_localizarData.Click += new System.EventHandler(this.btn_localizarData_Click);
            // 
            // frmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pn_cli);
            this.Controls.Add(this.pn_venda);
            this.Controls.Add(this.pn_data);
            this.Controls.Add(this.tbc_dados);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Venda";
            this.Load += new System.EventHandler(this.frmConsultaVenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbc_dados.ResumeLayout(false);
            this.tp_venda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.tp_itens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itens)).EndInit();
            this.tp_parcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.pn_venda.ResumeLayout(false);
            this.pn_venda.PerformLayout();
            this.pn_cli.ResumeLayout(false);
            this.pn_cli.PerformLayout();
            this.pn_data.ResumeLayout(false);
            this.pn_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_todas;
        private System.Windows.Forms.RadioButton rb_data;
        private System.Windows.Forms.RadioButton rb_parcelas;
        private System.Windows.Forms.RadioButton rb_cli;
        private System.Windows.Forms.RadioButton rb_vencod;
        private System.Windows.Forms.TabControl tbc_dados;
        private System.Windows.Forms.TabPage tp_venda;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.TabPage tp_itens;
        private System.Windows.Forms.DataGridView dgv_itens;
        private System.Windows.Forms.TabPage tp_parcelas;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.Panel pn_venda;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_localizarVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_cli;
        private System.Windows.Forms.Button btn_localizaCliente;
        private System.Windows.Forms.TextBox txt_clicod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_clinome;
        private System.Windows.Forms.Panel pn_data;
        private System.Windows.Forms.Label lb_datafinal;
        private System.Windows.Forms.Label lb_datainicial;
        private System.Windows.Forms.DateTimePicker dtp_incial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Button btn_localizarData;
        private System.Windows.Forms.RadioButton rb_avista;
        private System.Windows.Forms.RadioButton rb_cancelada;
    }
}