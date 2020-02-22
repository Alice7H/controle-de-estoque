namespace GUI
{
    partial class frmCadastroVenda
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
            this.pn_pagamento = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_totalvenda = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_cancelaFinalizaVenda = new System.Windows.Forms.Button();
            this.btn_salvaFinalizaVenda = new System.Windows.Forms.Button();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.pve_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pve_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pve_datavecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_addprod = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_valunitario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.lb_produto = new System.Windows.Forms.Label();
            this.txt_codpro = new System.Windows.Forms.TextBox();
            this.btn_localizaprod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.btn_localizacli = new System.Windows.Forms.Button();
            this.txt_codcli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_itensvenda = new System.Windows.Forms.DataGridView();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_datainirec = new System.Windows.Forms.DateTimePicker();
            this.cb_tpa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_nparcelas = new System.Windows.Forms.ComboBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datavenda = new System.Windows.Forms.DateTimePicker();
            this.txt_nfiscal = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ckb_vista = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.pn_pagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itensvenda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txt_total);
            this.pnDados.Controls.Add(this.ckb_vista);
            this.pnDados.Controls.Add(this.label18);
            this.pnDados.Controls.Add(this.btn_addprod);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.txt_valunitario);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txt_qtd);
            this.pnDados.Controls.Add(this.lb_produto);
            this.pnDados.Controls.Add(this.txt_codpro);
            this.pnDados.Controls.Add(this.btn_localizaprod);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.lb_cliente);
            this.pnDados.Controls.Add(this.btn_localizacli);
            this.pnDados.Controls.Add(this.txt_codcli);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgv_itensvenda);
            this.pnDados.Controls.Add(this.dtp_datainirec);
            this.pnDados.Controls.Add(this.cb_tpa);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cb_nparcelas);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.dtp_datavenda);
            this.pnDados.Controls.Add(this.txt_nfiscal);
            this.pnDados.Controls.Add(this.txt_cod);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label19);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Image = global::GUI.Properties.Resources.icancelar_2;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Localizar
            // 
            this.btn_Localizar.Click += new System.EventHandler(this.btn_Localizar_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // pn_pagamento
            // 
            this.pn_pagamento.Controls.Add(this.label22);
            this.pn_pagamento.Controls.Add(this.lb_totalvenda);
            this.pn_pagamento.Controls.Add(this.label20);
            this.pn_pagamento.Controls.Add(this.btn_cancelaFinalizaVenda);
            this.pn_pagamento.Controls.Add(this.btn_salvaFinalizaVenda);
            this.pn_pagamento.Controls.Add(this.dgv_parcelas);
            this.pn_pagamento.Controls.Add(this.label16);
            this.pn_pagamento.Controls.Add(this.label15);
            this.pn_pagamento.Controls.Add(this.label17);
            this.pn_pagamento.Location = new System.Drawing.Point(28, 25);
            this.pn_pagamento.Name = "pn_pagamento";
            this.pn_pagamento.Size = new System.Drawing.Size(730, 511);
            this.pn_pagamento.TabIndex = 3;
            this.pn_pagamento.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(628, 365);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 16);
            this.label22.TabIndex = 33;
            this.label22.Text = "R$";
            // 
            // lb_totalvenda
            // 
            this.lb_totalvenda.AutoSize = true;
            this.lb_totalvenda.Location = new System.Drawing.Point(652, 366);
            this.lb_totalvenda.Name = "lb_totalvenda";
            this.lb_totalvenda.Size = new System.Drawing.Size(34, 13);
            this.lb_totalvenda.TabIndex = 24;
            this.lb_totalvenda.Text = "00.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(534, 366);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Total da Venda";
            // 
            // btn_cancelaFinalizaVenda
            // 
            this.btn_cancelaFinalizaVenda.Image = global::GUI.Properties.Resources.icancelar2;
            this.btn_cancelaFinalizaVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelaFinalizaVenda.Location = new System.Drawing.Point(606, 404);
            this.btn_cancelaFinalizaVenda.Name = "btn_cancelaFinalizaVenda";
            this.btn_cancelaFinalizaVenda.Size = new System.Drawing.Size(80, 90);
            this.btn_cancelaFinalizaVenda.TabIndex = 22;
            this.btn_cancelaFinalizaVenda.Text = "Cancelar";
            this.btn_cancelaFinalizaVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelaFinalizaVenda.UseVisualStyleBackColor = true;
            this.btn_cancelaFinalizaVenda.Click += new System.EventHandler(this.btn_cancelaFinalizaVenda_Click);
            // 
            // btn_salvaFinalizaVenda
            // 
            this.btn_salvaFinalizaVenda.Image = global::GUI.Properties.Resources.Salvar;
            this.btn_salvaFinalizaVenda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salvaFinalizaVenda.Location = new System.Drawing.Point(495, 404);
            this.btn_salvaFinalizaVenda.Name = "btn_salvaFinalizaVenda";
            this.btn_salvaFinalizaVenda.Size = new System.Drawing.Size(80, 90);
            this.btn_salvaFinalizaVenda.TabIndex = 21;
            this.btn_salvaFinalizaVenda.Text = "Salvar";
            this.btn_salvaFinalizaVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvaFinalizaVenda.UseVisualStyleBackColor = true;
            this.btn_salvaFinalizaVenda.Click += new System.EventHandler(this.btn_salvaFinalizaVenda_Click);
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pve_cod,
            this.pve_valor,
            this.pve_datavecto});
            this.dgv_parcelas.Location = new System.Drawing.Point(51, 92);
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.ReadOnly = true;
            this.dgv_parcelas.Size = new System.Drawing.Size(635, 262);
            this.dgv_parcelas.TabIndex = 20;
            // 
            // pve_cod
            // 
            this.pve_cod.HeaderText = "Código da Parcela";
            this.pve_cod.Name = "pve_cod";
            this.pve_cod.ReadOnly = true;
            this.pve_cod.Width = 150;
            // 
            // pve_valor
            // 
            this.pve_valor.HeaderText = "Valor";
            this.pve_valor.Name = "pve_valor";
            this.pve_valor.ReadOnly = true;
            this.pve_valor.Width = 180;
            // 
            // pve_datavecto
            // 
            this.pve_datavecto.HeaderText = "Data de Recebimento";
            this.pve_datavecto.Name = "pve_datavecto";
            this.pve_datavecto.ReadOnly = true;
            this.pve_datavecto.Width = 150;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Parcelas da Venda";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(269, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Dados do Recebimento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(12, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(707, 15);
            this.label17.TabIndex = 19;
            this.label17.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(585, 350);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 65;
            this.label19.Text = "R$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(460, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 64;
            this.label18.Text = "R$";
            // 
            // btn_addprod
            // 
            this.btn_addprod.Location = new System.Drawing.Point(611, 145);
            this.btn_addprod.Name = "btn_addprod";
            this.btn_addprod.Size = new System.Drawing.Size(75, 34);
            this.btn_addprod.TabIndex = 62;
            this.btn_addprod.Text = "Adicionar";
            this.btn_addprod.UseVisualStyleBackColor = true;
            this.btn_addprod.Click += new System.EventHandler(this.btn_addprod_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Itens da Venda";
            // 
            // txt_valunitario
            // 
            this.txt_valunitario.Location = new System.Drawing.Point(488, 160);
            this.txt_valunitario.Name = "txt_valunitario";
            this.txt_valunitario.Size = new System.Drawing.Size(106, 20);
            this.txt_valunitario.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(485, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Valor Unitário";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Quantidade";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(322, 160);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(121, 20);
            this.txt_qtd.TabIndex = 57;
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_produto.Location = new System.Drawing.Point(46, 126);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(247, 13);
            this.lb_produto.TabIndex = 56;
            this.lb_produto.Text = " Informe o código do produto ou clique em localizar";
            // 
            // txt_codpro
            // 
            this.txt_codpro.Location = new System.Drawing.Point(51, 162);
            this.txt_codpro.Name = "txt_codpro";
            this.txt_codpro.Size = new System.Drawing.Size(121, 20);
            this.txt_codpro.TabIndex = 55;
            this.txt_codpro.Leave += new System.EventHandler(this.txt_codpro_Leave);
            // 
            // btn_localizaprod
            // 
            this.btn_localizaprod.Location = new System.Drawing.Point(186, 148);
            this.btn_localizaprod.Name = "btn_localizaprod";
            this.btn_localizaprod.Size = new System.Drawing.Size(75, 34);
            this.btn_localizaprod.TabIndex = 54;
            this.btn_localizaprod.Text = "Localizar";
            this.btn_localizaprod.UseVisualStyleBackColor = true;
            this.btn_localizaprod.Click += new System.EventHandler(this.btn_localizaprod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 53;
            this.label11.Text = "Código do Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Data Inicial do Recebimento";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_cliente.Location = new System.Drawing.Point(48, 56);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(239, 13);
            this.lb_cliente.TabIndex = 50;
            this.lb_cliente.Text = "Informe o código do cliente ou clique em localizar";
            // 
            // btn_localizacli
            // 
            this.btn_localizacli.Location = new System.Drawing.Point(188, 75);
            this.btn_localizacli.Name = "btn_localizacli";
            this.btn_localizacli.Size = new System.Drawing.Size(75, 34);
            this.btn_localizacli.TabIndex = 49;
            this.btn_localizacli.Text = "Localizar";
            this.btn_localizacli.UseVisualStyleBackColor = true;
            this.btn_localizacli.Click += new System.EventHandler(this.btn_localizacli_Click);
            // 
            // txt_codcli
            // 
            this.txt_codcli.Location = new System.Drawing.Point(52, 89);
            this.txt_codcli.Name = "txt_codcli";
            this.txt_codcli.Size = new System.Drawing.Size(121, 20);
            this.txt_codcli.TabIndex = 48;
            this.txt_codcli.Leave += new System.EventHandler(this.txt_codcli_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Código do Cliente";
            // 
            // dgv_itensvenda
            // 
            this.dgv_itensvenda.AllowUserToAddRows = false;
            this.dgv_itensvenda.AllowUserToDeleteRows = false;
            this.dgv_itensvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itensvenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_cod,
            this.pro_nome,
            this.pro_qtd,
            this.pro_valorvenda,
            this.pro_total});
            this.dgv_itensvenda.Location = new System.Drawing.Point(51, 210);
            this.dgv_itensvenda.Name = "dgv_itensvenda";
            this.dgv_itensvenda.ReadOnly = true;
            this.dgv_itensvenda.Size = new System.Drawing.Size(635, 111);
            this.dgv_itensvenda.TabIndex = 46;
            this.dgv_itensvenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itensvenda_CellDoubleClick);
            // 
            // pro_cod
            // 
            this.pro_cod.HeaderText = "Código";
            this.pro_cod.Name = "pro_cod";
            this.pro_cod.ReadOnly = true;
            // 
            // pro_nome
            // 
            this.pro_nome.HeaderText = "Nome";
            this.pro_nome.Name = "pro_nome";
            this.pro_nome.ReadOnly = true;
            this.pro_nome.Width = 190;
            // 
            // pro_qtd
            // 
            this.pro_qtd.HeaderText = "Quantidade";
            this.pro_qtd.Name = "pro_qtd";
            this.pro_qtd.ReadOnly = true;
            // 
            // pro_valorvenda
            // 
            this.pro_valorvenda.HeaderText = "Valor Unitário";
            this.pro_valorvenda.Name = "pro_valorvenda";
            this.pro_valorvenda.ReadOnly = true;
            // 
            // pro_total
            // 
            this.pro_total.HeaderText = "Valor Total";
            this.pro_total.Name = "pro_total";
            this.pro_total.ReadOnly = true;
            // 
            // dtp_datainirec
            // 
            this.dtp_datainirec.Location = new System.Drawing.Point(305, 345);
            this.dtp_datainirec.Name = "dtp_datainirec";
            this.dtp_datainirec.Size = new System.Drawing.Size(138, 20);
            this.dtp_datainirec.TabIndex = 45;
            // 
            // cb_tpa
            // 
            this.cb_tpa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_tpa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tpa.FormattingEnabled = true;
            this.cb_tpa.Location = new System.Drawing.Point(166, 345);
            this.cb_tpa.Name = "cb_tpa";
            this.cb_tpa.Size = new System.Drawing.Size(121, 21);
            this.cb_tpa.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tipo de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Número de Parcelas";
            // 
            // cb_nparcelas
            // 
            this.cb_nparcelas.FormattingEnabled = true;
            this.cb_nparcelas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_nparcelas.Location = new System.Drawing.Point(51, 345);
            this.cb_nparcelas.Name = "cb_nparcelas";
            this.cb_nparcelas.Size = new System.Drawing.Size(94, 21);
            this.cb_nparcelas.TabIndex = 41;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Window;
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(606, 348);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(80, 20);
            this.txt_total.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(608, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Valor Total";
            // 
            // dtp_datavenda
            // 
            this.dtp_datavenda.Location = new System.Drawing.Point(458, 25);
            this.dtp_datavenda.Name = "dtp_datavenda";
            this.dtp_datavenda.Size = new System.Drawing.Size(228, 20);
            this.dtp_datavenda.TabIndex = 38;
            // 
            // txt_nfiscal
            // 
            this.txt_nfiscal.Location = new System.Drawing.Point(186, 25);
            this.txt_nfiscal.Name = "txt_nfiscal";
            this.txt_nfiscal.Size = new System.Drawing.Size(257, 20);
            this.txt_nfiscal.TabIndex = 37;
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(51, 25);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(121, 20);
            this.txt_cod.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Data da Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Número da Nota Fiscal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(707, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(12, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(707, 15);
            this.label14.TabIndex = 63;
            this.label14.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // ckb_vista
            // 
            this.ckb_vista.AutoSize = true;
            this.ckb_vista.Location = new System.Drawing.Point(461, 347);
            this.ckb_vista.Name = "ckb_vista";
            this.ckb_vista.Size = new System.Drawing.Size(114, 17);
            this.ckb_vista.TabIndex = 66;
            this.ckb_vista.Text = "Pagamento à vista";
            this.ckb_vista.UseVisualStyleBackColor = true;
            this.ckb_vista.CheckedChanged += new System.EventHandler(this.ckb_vista_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(77, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(233, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "O botão excluir apenas muda o status da venda";
            // 
            // frmCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pn_pagamento);
            this.Controls.Add(this.label21);
            this.Name = "frmCadastroVenda";
            this.Text = "Movimentação - Venda";
            this.Load += new System.EventHandler(this.frmCadastroVenda_Load);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pn_pagamento, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.pn_pagamento.ResumeLayout(false);
            this.pn_pagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itensvenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_pagamento;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_totalvenda;
        private System.Windows.Forms.Label label20;
        protected System.Windows.Forms.Button btn_cancelaFinalizaVenda;
        protected System.Windows.Forms.Button btn_salvaFinalizaVenda;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_addprod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_valunitario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.TextBox txt_codpro;
        private System.Windows.Forms.Button btn_localizaprod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Button btn_localizacli;
        private System.Windows.Forms.TextBox txt_codcli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_itensvenda;
        private System.Windows.Forms.DateTimePicker dtp_datainirec;
        private System.Windows.Forms.ComboBox cb_tpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_nparcelas;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datavenda;
        private System.Windows.Forms.TextBox txt_nfiscal;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pve_datavecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_total;
        private System.Windows.Forms.CheckBox ckb_vista;
        private System.Windows.Forms.Label label21;
    }
}
