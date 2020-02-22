namespace GUI
{
    partial class frmCadastroFornecedor
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
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_cel = new System.Windows.Forms.MaskedTextBox();
            this.txt_fone = new System.Windows.Forms.MaskedTextBox();
            this.txt_ie = new System.Windows.Forms.MaskedTextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_rgie = new System.Windows.Forms.Label();
            this.lb_cpfcnpj = new System.Windows.Forms.Label();
            this.txt_rsocial = new System.Windows.Forms.TextBox();
            this.lb_rsocial = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txt_email);
            this.pnDados.Controls.Add(this.txt_cep);
            this.pnDados.Controls.Add(this.txt_cel);
            this.pnDados.Controls.Add(this.txt_fone);
            this.pnDados.Controls.Add(this.txt_ie);
            this.pnDados.Controls.Add(this.txt_cnpj);
            this.pnDados.Controls.Add(this.txt_estado);
            this.pnDados.Controls.Add(this.txt_cidade);
            this.pnDados.Controls.Add(this.txt_num);
            this.pnDados.Controls.Add(this.txt_bairro);
            this.pnDados.Controls.Add(this.txt_endereco);
            this.pnDados.Controls.Add(this.label16);
            this.pnDados.Controls.Add(this.label15);
            this.pnDados.Controls.Add(this.label14);
            this.pnDados.Controls.Add(this.label13);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.lb_rgie);
            this.pnDados.Controls.Add(this.lb_cpfcnpj);
            this.pnDados.Controls.Add(this.txt_rsocial);
            this.pnDados.Controls.Add(this.lb_rsocial);
            this.pnDados.Controls.Add(this.txt_nome);
            this.pnDados.Controls.Add(this.txt_cod);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.label2);
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
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(379, 331);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(315, 20);
            this.txt_email.TabIndex = 67;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(39, 236);
            this.txt_cep.Mask = "99999-999";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(143, 20);
            this.txt_cep.TabIndex = 47;
            this.txt_cep.Leave += new System.EventHandler(this.txt_cep_Leave);
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(208, 331);
            this.txt_cel.Mask = "(99)99999-9999";
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(153, 20);
            this.txt_cel.TabIndex = 66;
            this.txt_cel.Leave += new System.EventHandler(this.txt_cel_Leave);
            // 
            // txt_fone
            // 
            this.txt_fone.Location = new System.Drawing.Point(39, 331);
            this.txt_fone.Mask = "(99)9999-9999";
            this.txt_fone.Name = "txt_fone";
            this.txt_fone.Size = new System.Drawing.Size(146, 20);
            this.txt_fone.TabIndex = 65;
            this.txt_fone.Leave += new System.EventHandler(this.txt_fone_Leave);
            // 
            // txt_ie
            // 
            this.txt_ie.Location = new System.Drawing.Point(392, 187);
            this.txt_ie.Mask = "000.000.000.000";
            this.txt_ie.Name = "txt_ie";
            this.txt_ie.Size = new System.Drawing.Size(302, 20);
            this.txt_ie.TabIndex = 46;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(39, 187);
            this.txt_cnpj.Mask = "00.000.000/0000-00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(322, 20);
            this.txt_cnpj.TabIndex = 45;
            this.txt_cnpj.Leave += new System.EventHandler(this.txt_cnpj_Leave);
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(545, 283);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(149, 20);
            this.txt_estado.TabIndex = 52;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(208, 283);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(317, 20);
            this.txt_cidade.TabIndex = 51;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(545, 236);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(149, 20);
            this.txt_num.TabIndex = 49;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(39, 283);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(146, 20);
            this.txt_bairro.TabIndex = 50;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(208, 236);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(317, 20);
            this.txt_endereco.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(542, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(205, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 60;
            this.label15.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(542, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Número";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "E-mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Celular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Bairro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Rua/Rodovia/Avenida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "CEP";
            // 
            // lb_rgie
            // 
            this.lb_rgie.AutoSize = true;
            this.lb_rgie.Location = new System.Drawing.Point(389, 173);
            this.lb_rgie.Name = "lb_rgie";
            this.lb_rgie.Size = new System.Drawing.Size(17, 13);
            this.lb_rgie.TabIndex = 55;
            this.lb_rgie.Text = "IE";
            // 
            // lb_cpfcnpj
            // 
            this.lb_cpfcnpj.AutoSize = true;
            this.lb_cpfcnpj.Location = new System.Drawing.Point(39, 173);
            this.lb_cpfcnpj.Name = "lb_cpfcnpj";
            this.lb_cpfcnpj.Size = new System.Drawing.Size(34, 13);
            this.lb_cpfcnpj.TabIndex = 54;
            this.lb_cpfcnpj.Text = "CNPJ";
            // 
            // txt_rsocial
            // 
            this.txt_rsocial.Location = new System.Drawing.Point(39, 144);
            this.txt_rsocial.Name = "txt_rsocial";
            this.txt_rsocial.Size = new System.Drawing.Size(655, 20);
            this.txt_rsocial.TabIndex = 44;
            // 
            // lb_rsocial
            // 
            this.lb_rsocial.AutoSize = true;
            this.lb_rsocial.Location = new System.Drawing.Point(36, 128);
            this.lb_rsocial.Name = "lb_rsocial";
            this.lb_rsocial.Size = new System.Drawing.Size(146, 13);
            this.lb_rsocial.TabIndex = 53;
            this.lb_rsocial.Text = "Razão Social/Nome Fantasia";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(39, 92);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(655, 20);
            this.txt_nome.TabIndex = 41;
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(39, 44);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroFornecedor";
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_cel;
        private System.Windows.Forms.MaskedTextBox txt_fone;
        private System.Windows.Forms.MaskedTextBox txt_ie;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_rgie;
        private System.Windows.Forms.Label lb_cpfcnpj;
        private System.Windows.Forms.TextBox txt_rsocial;
        private System.Windows.Forms.Label lb_rsocial;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
