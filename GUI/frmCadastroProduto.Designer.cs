namespace GUI
{
    partial class frmCadastroProduto
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
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_valorpago = new System.Windows.Forms.TextBox();
            this.txt_valorvenda = new System.Windows.Forms.TextBox();
            this.txt_qtde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_umed = new System.Windows.Forms.ComboBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.cb_scat = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.btn_lo_foto = new System.Windows.Forms.Button();
            this.btn_rm_foto = new System.Windows.Forms.Button();
            this.btn_add_cat = new System.Windows.Forms.Button();
            this.btn_add_unidmed = new System.Windows.Forms.Button();
            this.btn_add_subcat = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btn_add_subcat);
            this.pnDados.Controls.Add(this.btn_add_unidmed);
            this.pnDados.Controls.Add(this.btn_add_cat);
            this.pnDados.Controls.Add(this.btn_rm_foto);
            this.pnDados.Controls.Add(this.btn_lo_foto);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cb_scat);
            this.pnDados.Controls.Add(this.cb_cat);
            this.pnDados.Controls.Add(this.cb_umed);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txt_qtde);
            this.pnDados.Controls.Add(this.txt_valorvenda);
            this.pnDados.Controls.Add(this.txt_valorpago);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txt_descricao);
            this.pnDados.Controls.Add(this.txt_nome);
            this.pnDados.Controls.Add(this.txt_codigo);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
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
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(51, 27);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(92, 20);
            this.txt_codigo.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(51, 71);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(345, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(51, 116);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(345, 116);
            this.txt_descricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Valor de Venda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantidade";
            // 
            // txt_valorpago
            // 
            this.txt_valorpago.Location = new System.Drawing.Point(51, 254);
            this.txt_valorpago.Name = "txt_valorpago";
            this.txt_valorpago.Size = new System.Drawing.Size(108, 20);
            this.txt_valorpago.TabIndex = 10;
            this.txt_valorpago.Text = "0.00";
            this.txt_valorpago.TextChanged += new System.EventHandler(this.txt_valorpago_TextChanged);
            // 
            // txt_valorvenda
            // 
            this.txt_valorvenda.Location = new System.Drawing.Point(216, 254);
            this.txt_valorvenda.Name = "txt_valorvenda";
            this.txt_valorvenda.Size = new System.Drawing.Size(137, 20);
            this.txt_valorvenda.TabIndex = 11;
            this.txt_valorvenda.Text = "0.00";
            this.txt_valorvenda.TextChanged += new System.EventHandler(this.txt_valorvenda_TextChanged);
            // 
            // txt_qtde
            // 
            this.txt_qtde.Location = new System.Drawing.Point(51, 300);
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.Size = new System.Drawing.Size(108, 20);
            this.txt_qtde.TabIndex = 12;
            this.txt_qtde.Text = "0.00";
            this.txt_qtde.TextChanged += new System.EventHandler(this.txt_qtde_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Unidade de Medida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Categoria";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "SubCategoria";
            // 
            // cb_umed
            // 
            this.cb_umed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_umed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_umed.FormattingEnabled = true;
            this.cb_umed.Location = new System.Drawing.Point(216, 299);
            this.cb_umed.Name = "cb_umed";
            this.cb_umed.Size = new System.Drawing.Size(137, 21);
            this.cb_umed.TabIndex = 16;
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(51, 346);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(115, 21);
            this.cb_cat.TabIndex = 17;
            this.cb_cat.SelectedIndexChanged += new System.EventHandler(this.cb_cat_SelectedIndexChanged);
            // 
            // cb_scat
            // 
            this.cb_scat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_scat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_scat.FormattingEnabled = true;
            this.cb_scat.Location = new System.Drawing.Point(216, 346);
            this.cb_scat.Name = "cb_scat";
            this.cb_scat.Size = new System.Drawing.Size(137, 21);
            this.cb_scat.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pb_imagem);
            this.panel1.Location = new System.Drawing.Point(423, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 206);
            this.panel1.TabIndex = 18;
            // 
            // pb_imagem
            // 
            this.pb_imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_imagem.Location = new System.Drawing.Point(0, 0);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(261, 204);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagem.TabIndex = 0;
            this.pb_imagem.TabStop = false;
            // 
            // btn_lo_foto
            // 
            this.btn_lo_foto.Image = global::GUI.Properties.Resources.câmera;
            this.btn_lo_foto.Location = new System.Drawing.Point(424, 289);
            this.btn_lo_foto.Name = "btn_lo_foto";
            this.btn_lo_foto.Size = new System.Drawing.Size(120, 80);
            this.btn_lo_foto.TabIndex = 20;
            this.btn_lo_foto.UseVisualStyleBackColor = true;
            this.btn_lo_foto.Click += new System.EventHandler(this.btn_lo_foto_Click);
            // 
            // btn_rm_foto
            // 
            this.btn_rm_foto.Image = global::GUI.Properties.Resources.remover_imagem;
            this.btn_rm_foto.Location = new System.Drawing.Point(566, 289);
            this.btn_rm_foto.Name = "btn_rm_foto";
            this.btn_rm_foto.Size = new System.Drawing.Size(120, 80);
            this.btn_rm_foto.TabIndex = 21;
            this.btn_rm_foto.UseVisualStyleBackColor = true;
            this.btn_rm_foto.Click += new System.EventHandler(this.btn_rm_foto_Click);
            // 
            // btn_add_cat
            // 
            this.btn_add_cat.Image = global::GUI.Properties.Resources.mais_16;
            this.btn_add_cat.Location = new System.Drawing.Point(173, 346);
            this.btn_add_cat.Name = "btn_add_cat";
            this.btn_add_cat.Size = new System.Drawing.Size(37, 23);
            this.btn_add_cat.TabIndex = 22;
            this.btn_add_cat.UseVisualStyleBackColor = true;
            this.btn_add_cat.Click += new System.EventHandler(this.btn_add_cat_Click);
            // 
            // btn_add_unidmed
            // 
            this.btn_add_unidmed.Image = global::GUI.Properties.Resources.mais_16;
            this.btn_add_unidmed.Location = new System.Drawing.Point(359, 297);
            this.btn_add_unidmed.Name = "btn_add_unidmed";
            this.btn_add_unidmed.Size = new System.Drawing.Size(37, 23);
            this.btn_add_unidmed.TabIndex = 23;
            this.btn_add_unidmed.UseVisualStyleBackColor = true;
            this.btn_add_unidmed.Click += new System.EventHandler(this.btn_add_unidmed_Click);
            // 
            // btn_add_subcat
            // 
            this.btn_add_subcat.Image = global::GUI.Properties.Resources.mais_16;
            this.btn_add_subcat.Location = new System.Drawing.Point(359, 344);
            this.btn_add_subcat.Name = "btn_add_subcat";
            this.btn_add_subcat.Size = new System.Drawing.Size(37, 23);
            this.btn_add_subcat.TabIndex = 24;
            this.btn_add_subcat.UseVisualStyleBackColor = true;
            this.btn_add_subcat.Click += new System.EventHandler(this.btn_add_subcat_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroProduto";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rm_foto;
        private System.Windows.Forms.Button btn_lo_foto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_scat;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.ComboBox cb_umed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_qtde;
        private System.Windows.Forms.TextBox txt_valorvenda;
        private System.Windows.Forms.TextBox txt_valorpago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Button btn_add_subcat;
        private System.Windows.Forms.Button btn_add_unidmed;
        private System.Windows.Forms.Button btn_add_cat;
    }
}
