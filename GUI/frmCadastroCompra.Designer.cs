namespace GUI
{
    partial class frmCadastroCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_nfiscal = new System.Windows.Forms.TextBox();
            this.dtp_datacompra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.cb_nparcelas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tpa = new System.Windows.Forms.ComboBox();
            this.dtp_datainipag = new System.Windows.Forms.DateTimePicker();
            this.dgv_itenscompra = new System.Windows.Forms.DataGridView();
            this.pro_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_valorpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codfor = new System.Windows.Forms.TextBox();
            this.btn_localizafor = new System.Windows.Forms.Button();
            this.lb_fornecedor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_localizaprod = new System.Windows.Forms.Button();
            this.txt_codpro = new System.Windows.Forms.TextBox();
            this.lb_produto = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_valunitario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_addprod = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.pn_pagamento = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_totalcompra = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_cancelaFinalizaCompra = new System.Windows.Forms.Button();
            this.btn_salvaFinalizaCompra = new System.Windows.Forms.Button();
            this.dgv_parcelas = new System.Windows.Forms.DataGridView();
            this.pco_cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pco_datapagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itenscompra)).BeginInit();
            this.pn_pagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label19);
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
            this.pnDados.Controls.Add(this.lb_fornecedor);
            this.pnDados.Controls.Add(this.btn_localizafor);
            this.pnDados.Controls.Add(this.txt_codfor);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.dgv_itenscompra);
            this.pnDados.Controls.Add(this.dtp_datainipag);
            this.pnDados.Controls.Add(this.cb_tpa);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.cb_nparcelas);
            this.pnDados.Controls.Add(this.txt_total);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.dtp_datacompra);
            this.pnDados.Controls.Add(this.txt_nfiscal);
            this.pnDados.Controls.Add(this.txt_cod);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label14);
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
            this.btn_Excluir.Image = global::GUI.Properties.Resources.icancelar_21;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número da Nota Fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da Compra";
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(51, 28);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(121, 20);
            this.txt_cod.TabIndex = 3;
            // 
            // txt_nfiscal
            // 
            this.txt_nfiscal.Location = new System.Drawing.Point(186, 28);
            this.txt_nfiscal.Name = "txt_nfiscal";
            this.txt_nfiscal.Size = new System.Drawing.Size(257, 20);
            this.txt_nfiscal.TabIndex = 4;
            // 
            // dtp_datacompra
            // 
            this.dtp_datacompra.Location = new System.Drawing.Point(458, 28);
            this.dtp_datacompra.Name = "dtp_datacompra";
            this.dtp_datacompra.Size = new System.Drawing.Size(228, 20);
            this.dtp_datacompra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(591, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Total";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Window;
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(590, 351);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(96, 20);
            this.txt_total.TabIndex = 7;
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
            this.cb_nparcelas.Location = new System.Drawing.Point(51, 350);
            this.cb_nparcelas.Name = "cb_nparcelas";
            this.cb_nparcelas.Size = new System.Drawing.Size(121, 21);
            this.cb_nparcelas.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Número de Parcelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Pagamento";
            // 
            // cb_tpa
            // 
            this.cb_tpa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_tpa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_tpa.FormattingEnabled = true;
            this.cb_tpa.Location = new System.Drawing.Point(186, 350);
            this.cb_tpa.Name = "cb_tpa";
            this.cb_tpa.Size = new System.Drawing.Size(121, 21);
            this.cb_tpa.TabIndex = 11;
            // 
            // dtp_datainipag
            // 
            this.dtp_datainipag.Location = new System.Drawing.Point(322, 351);
            this.dtp_datainipag.Name = "dtp_datainipag";
            this.dtp_datainipag.Size = new System.Drawing.Size(228, 20);
            this.dtp_datainipag.TabIndex = 12;
            // 
            // dgv_itenscompra
            // 
            this.dgv_itenscompra.AllowUserToAddRows = false;
            this.dgv_itenscompra.AllowUserToDeleteRows = false;
            this.dgv_itenscompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itenscompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pro_cod,
            this.pro_nome,
            this.pro_qtd,
            this.pro_valorpago,
            this.pro_total});
            this.dgv_itenscompra.Location = new System.Drawing.Point(51, 221);
            this.dgv_itenscompra.Name = "dgv_itenscompra";
            this.dgv_itenscompra.ReadOnly = true;
            this.dgv_itenscompra.Size = new System.Drawing.Size(635, 111);
            this.dgv_itenscompra.TabIndex = 13;
            this.dgv_itenscompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itenscompra_CellDoubleClick);
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
            // pro_valorpago
            // 
            this.pro_valorpago.HeaderText = "Valor Unitário";
            this.pro_valorpago.Name = "pro_valorpago";
            this.pro_valorpago.ReadOnly = true;
            // 
            // pro_total
            // 
            this.pro_total.HeaderText = "Valor Total";
            this.pro_total.Name = "pro_total";
            this.pro_total.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Código do Fornecedor";
            // 
            // txt_codfor
            // 
            this.txt_codfor.Location = new System.Drawing.Point(52, 92);
            this.txt_codfor.Name = "txt_codfor";
            this.txt_codfor.Size = new System.Drawing.Size(121, 20);
            this.txt_codfor.TabIndex = 15;
            this.txt_codfor.Leave += new System.EventHandler(this.txt_codfor_Leave);
            // 
            // btn_localizafor
            // 
            this.btn_localizafor.Location = new System.Drawing.Point(188, 78);
            this.btn_localizafor.Name = "btn_localizafor";
            this.btn_localizafor.Size = new System.Drawing.Size(75, 34);
            this.btn_localizafor.TabIndex = 16;
            this.btn_localizafor.Text = "Localizar";
            this.btn_localizafor.UseVisualStyleBackColor = true;
            this.btn_localizafor.Click += new System.EventHandler(this.btn_localizafor_Click);
            // 
            // lb_fornecedor
            // 
            this.lb_fornecedor.AutoSize = true;
            this.lb_fornecedor.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_fornecedor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_fornecedor.Location = new System.Drawing.Point(48, 59);
            this.lb_fornecedor.Name = "lb_fornecedor";
            this.lb_fornecedor.Size = new System.Drawing.Size(259, 13);
            this.lb_fornecedor.TabIndex = 17;
            this.lb_fornecedor.Text = "Informe o código do fornecedor ou clique em localizar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(12, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(707, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data Inicial do Pagamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Código do Produto";
            // 
            // btn_localizaprod
            // 
            this.btn_localizaprod.Location = new System.Drawing.Point(187, 157);
            this.btn_localizaprod.Name = "btn_localizaprod";
            this.btn_localizaprod.Size = new System.Drawing.Size(75, 34);
            this.btn_localizaprod.TabIndex = 21;
            this.btn_localizaprod.Text = "Localizar";
            this.btn_localizaprod.UseVisualStyleBackColor = true;
            this.btn_localizaprod.Click += new System.EventHandler(this.btn_localizaprod_Click);
            // 
            // txt_codpro
            // 
            this.txt_codpro.Location = new System.Drawing.Point(51, 170);
            this.txt_codpro.Name = "txt_codpro";
            this.txt_codpro.Size = new System.Drawing.Size(121, 20);
            this.txt_codpro.TabIndex = 22;
            this.txt_codpro.Leave += new System.EventHandler(this.txt_codpro_Leave);
            // 
            // lb_produto
            // 
            this.lb_produto.AutoSize = true;
            this.lb_produto.BackColor = System.Drawing.Color.SkyBlue;
            this.lb_produto.Location = new System.Drawing.Point(46, 135);
            this.lb_produto.Name = "lb_produto";
            this.lb_produto.Size = new System.Drawing.Size(247, 13);
            this.lb_produto.TabIndex = 23;
            this.lb_produto.Text = " Informe o código do produto ou clique em localizar";
            // 
            // txt_qtd
            // 
            this.txt_qtd.Location = new System.Drawing.Point(322, 171);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(121, 20);
            this.txt_qtd.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Lavender;
            this.label12.Location = new System.Drawing.Point(487, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Valor Unitário";
            // 
            // txt_valunitario
            // 
            this.txt_valunitario.Location = new System.Drawing.Point(488, 171);
            this.txt_valunitario.Name = "txt_valunitario";
            this.txt_valunitario.Size = new System.Drawing.Size(106, 20);
            this.txt_valunitario.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(49, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Itens da Compra";
            // 
            // btn_addprod
            // 
            this.btn_addprod.Location = new System.Drawing.Point(611, 157);
            this.btn_addprod.Name = "btn_addprod";
            this.btn_addprod.Size = new System.Drawing.Size(75, 34);
            this.btn_addprod.TabIndex = 29;
            this.btn_addprod.Text = "Adicionar";
            this.btn_addprod.UseVisualStyleBackColor = true;
            this.btn_addprod.Click += new System.EventHandler(this.btn_addprod_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(12, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(707, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "_________________________________________________________________________________" +
    "___________________";
            // 
            // pn_pagamento
            // 
            this.pn_pagamento.Controls.Add(this.label22);
            this.pn_pagamento.Controls.Add(this.lb_totalcompra);
            this.pn_pagamento.Controls.Add(this.label20);
            this.pn_pagamento.Controls.Add(this.btn_cancelaFinalizaCompra);
            this.pn_pagamento.Controls.Add(this.btn_salvaFinalizaCompra);
            this.pn_pagamento.Controls.Add(this.dgv_parcelas);
            this.pn_pagamento.Controls.Add(this.label16);
            this.pn_pagamento.Controls.Add(this.label15);
            this.pn_pagamento.Controls.Add(this.label17);
            this.pn_pagamento.Location = new System.Drawing.Point(21, 25);
            this.pn_pagamento.Name = "pn_pagamento";
            this.pn_pagamento.Size = new System.Drawing.Size(737, 511);
            this.pn_pagamento.TabIndex = 2;
            this.pn_pagamento.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(640, 371);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 16);
            this.label22.TabIndex = 33;
            this.label22.Text = "R$";
            // 
            // lb_totalcompra
            // 
            this.lb_totalcompra.AutoSize = true;
            this.lb_totalcompra.Location = new System.Drawing.Point(664, 374);
            this.lb_totalcompra.Name = "lb_totalcompra";
            this.lb_totalcompra.Size = new System.Drawing.Size(34, 13);
            this.lb_totalcompra.TabIndex = 24;
            this.lb_totalcompra.Text = "00.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(546, 374);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Total da Compra:";
            // 
            // btn_cancelaFinalizaCompra
            // 
            this.btn_cancelaFinalizaCompra.Image = global::GUI.Properties.Resources.icancelar1;
            this.btn_cancelaFinalizaCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cancelaFinalizaCompra.Location = new System.Drawing.Point(618, 407);
            this.btn_cancelaFinalizaCompra.Name = "btn_cancelaFinalizaCompra";
            this.btn_cancelaFinalizaCompra.Size = new System.Drawing.Size(80, 90);
            this.btn_cancelaFinalizaCompra.TabIndex = 22;
            this.btn_cancelaFinalizaCompra.Text = "Cancelar";
            this.btn_cancelaFinalizaCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelaFinalizaCompra.UseVisualStyleBackColor = true;
            this.btn_cancelaFinalizaCompra.Click += new System.EventHandler(this.btn_cancelaFinalizaCompra_Click);
            // 
            // btn_salvaFinalizaCompra
            // 
            this.btn_salvaFinalizaCompra.Image = global::GUI.Properties.Resources.Salvar;
            this.btn_salvaFinalizaCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_salvaFinalizaCompra.Location = new System.Drawing.Point(502, 407);
            this.btn_salvaFinalizaCompra.Name = "btn_salvaFinalizaCompra";
            this.btn_salvaFinalizaCompra.Size = new System.Drawing.Size(80, 90);
            this.btn_salvaFinalizaCompra.TabIndex = 21;
            this.btn_salvaFinalizaCompra.Text = "Salvar";
            this.btn_salvaFinalizaCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_salvaFinalizaCompra.UseVisualStyleBackColor = true;
            this.btn_salvaFinalizaCompra.Click += new System.EventHandler(this.btn_salvaFinalizaCompra_Click);
            // 
            // dgv_parcelas
            // 
            this.dgv_parcelas.AllowUserToAddRows = false;
            this.dgv_parcelas.AllowUserToDeleteRows = false;
            this.dgv_parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pco_cod,
            this.pco_valor,
            this.pco_datapagto});
            this.dgv_parcelas.Location = new System.Drawing.Point(58, 94);
            this.dgv_parcelas.Name = "dgv_parcelas";
            this.dgv_parcelas.ReadOnly = true;
            this.dgv_parcelas.Size = new System.Drawing.Size(640, 262);
            this.dgv_parcelas.TabIndex = 20;
            // 
            // pco_cod
            // 
            this.pco_cod.HeaderText = "Código da Parcela";
            this.pco_cod.Name = "pco_cod";
            this.pco_cod.ReadOnly = true;
            this.pco_cod.Width = 150;
            // 
            // pco_valor
            // 
            this.pco_valor.HeaderText = "Valor";
            this.pco_valor.Name = "pco_valor";
            this.pco_valor.ReadOnly = true;
            this.pco_valor.Width = 180;
            // 
            // pco_datapagto
            // 
            this.pco_datapagto.HeaderText = "Data de Pagamento";
            this.pco_datapagto.Name = "pco_datapagto";
            this.pco_datapagto.ReadOnly = true;
            this.pco_datapagto.Width = 150;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Parcelas da Compra";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(289, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Dados do Pagamento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(21, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(700, 15);
            this.label17.TabIndex = 19;
            this.label17.Text = "_________________________________________________________________________________" +
    "__________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(461, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "R$";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(562, 353);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "R$";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(76, 413);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(238, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "O botão excluir apenas muda o status da compra";
            // 
            // frmCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pn_pagamento);
            this.Controls.Add(this.label21);
            this.Name = "frmCadastroCompra";
            this.Text = "Movimentação - Compra";
            this.Load += new System.EventHandler(this.frmCadastroCompra_Load);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.pnDados, 0);
            this.Controls.SetChildIndex(this.pnBotoes, 0);
            this.Controls.SetChildIndex(this.pn_pagamento, 0);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itenscompra)).EndInit();
            this.pn_pagamento.ResumeLayout(false);
            this.pn_pagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_parcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_valunitario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label lb_produto;
        private System.Windows.Forms.TextBox txt_codpro;
        private System.Windows.Forms.Button btn_localizaprod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_fornecedor;
        private System.Windows.Forms.Button btn_localizafor;
        private System.Windows.Forms.TextBox txt_codfor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_itenscompra;
        private System.Windows.Forms.DateTimePicker dtp_datainipag;
        private System.Windows.Forms.ComboBox cb_tpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_nparcelas;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datacompra;
        private System.Windows.Forms.TextBox txt_nfiscal;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addprod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_valorpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_total;
        private System.Windows.Forms.Panel pn_pagamento;
        private System.Windows.Forms.DataGridView dgv_parcelas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Button btn_cancelaFinalizaCompra;
        protected System.Windows.Forms.Button btn_salvaFinalizaCompra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_totalcompra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pco_datapagto;
        private System.Windows.Forms.Label label21;
    }
}
