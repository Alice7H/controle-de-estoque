namespace GUI
{
    partial class frmCadastroCliente
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
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_juridica = new System.Windows.Forms.RadioButton();
            this.rb_fisica = new System.Windows.Forms.RadioButton();
            this.lb_rsocial = new System.Windows.Forms.Label();
            this.txt_rsocial = new System.Windows.Forms.TextBox();
            this.lb_cpfcnpj = new System.Windows.Forms.Label();
            this.lb_rgie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_cpfcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_rgie = new System.Windows.Forms.MaskedTextBox();
            this.txt_fone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cel = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txt_email);
            this.pnDados.Controls.Add(this.txt_cep);
            this.pnDados.Controls.Add(this.txt_cel);
            this.pnDados.Controls.Add(this.txt_fone);
            this.pnDados.Controls.Add(this.txt_rgie);
            this.pnDados.Controls.Add(this.txt_cpfcnpj);
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
            this.pnDados.Controls.Add(this.groupBox1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txt_cod
            // 
            this.txt_cod.Enabled = false;
            this.txt_cod.Location = new System.Drawing.Point(31, 44);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 3;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(31, 92);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(655, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_juridica);
            this.groupBox1.Controls.Add(this.rb_fisica);
            this.groupBox1.Location = new System.Drawing.Point(177, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // rb_juridica
            // 
            this.rb_juridica.AutoSize = true;
            this.rb_juridica.Location = new System.Drawing.Point(146, 20);
            this.rb_juridica.Name = "rb_juridica";
            this.rb_juridica.Size = new System.Drawing.Size(101, 17);
            this.rb_juridica.TabIndex = 1;
            this.rb_juridica.Text = "Pessoa Jurídica";
            this.rb_juridica.UseVisualStyleBackColor = true;
            this.rb_juridica.CheckedChanged += new System.EventHandler(this.rb_fisica_CheckedChanged);
            // 
            // rb_fisica
            // 
            this.rb_fisica.AutoSize = true;
            this.rb_fisica.Checked = true;
            this.rb_fisica.Location = new System.Drawing.Point(23, 19);
            this.rb_fisica.Name = "rb_fisica";
            this.rb_fisica.Size = new System.Drawing.Size(92, 17);
            this.rb_fisica.TabIndex = 0;
            this.rb_fisica.TabStop = true;
            this.rb_fisica.Text = "Pessoa Física";
            this.rb_fisica.UseVisualStyleBackColor = true;
            this.rb_fisica.CheckedChanged += new System.EventHandler(this.rb_fisica_CheckedChanged);
            // 
            // lb_rsocial
            // 
            this.lb_rsocial.AutoSize = true;
            this.lb_rsocial.Location = new System.Drawing.Point(28, 128);
            this.lb_rsocial.Name = "lb_rsocial";
            this.lb_rsocial.Size = new System.Drawing.Size(146, 13);
            this.lb_rsocial.TabIndex = 19;
            this.lb_rsocial.Text = "Razão Social/Nome Fantasia";
            this.lb_rsocial.Visible = false;
            // 
            // txt_rsocial
            // 
            this.txt_rsocial.Location = new System.Drawing.Point(31, 144);
            this.txt_rsocial.Name = "txt_rsocial";
            this.txt_rsocial.Size = new System.Drawing.Size(655, 20);
            this.txt_rsocial.TabIndex = 5;
            this.txt_rsocial.Visible = false;
            // 
            // lb_cpfcnpj
            // 
            this.lb_cpfcnpj.AutoSize = true;
            this.lb_cpfcnpj.Location = new System.Drawing.Point(31, 173);
            this.lb_cpfcnpj.Name = "lb_cpfcnpj";
            this.lb_cpfcnpj.Size = new System.Drawing.Size(27, 13);
            this.lb_cpfcnpj.TabIndex = 20;
            this.lb_cpfcnpj.Text = "CPF";
            // 
            // lb_rgie
            // 
            this.lb_rgie.AutoSize = true;
            this.lb_rgie.Location = new System.Drawing.Point(381, 173);
            this.lb_rgie.Name = "lb_rgie";
            this.lb_rgie.Size = new System.Drawing.Size(23, 13);
            this.lb_rgie.TabIndex = 21;
            this.lb_rgie.Text = "RG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "CEP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Rua/Rodovia/Avenida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Bairro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Celular";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "E-mail";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(534, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Número";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(197, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Cidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(534, 269);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Estado";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(200, 236);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(317, 20);
            this.txt_endereco.TabIndex = 11;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(31, 283);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(146, 20);
            this.txt_bairro.TabIndex = 13;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(537, 236);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(149, 20);
            this.txt_num.TabIndex = 12;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(200, 283);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(317, 20);
            this.txt_cidade.TabIndex = 14;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(537, 283);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(149, 20);
            this.txt_estado.TabIndex = 15;
            // 
            // txt_cpfcnpj
            // 
            this.txt_cpfcnpj.Location = new System.Drawing.Point(31, 187);
            this.txt_cpfcnpj.Name = "txt_cpfcnpj";
            this.txt_cpfcnpj.Size = new System.Drawing.Size(322, 20);
            this.txt_cpfcnpj.TabIndex = 6;
            this.txt_cpfcnpj.Leave += new System.EventHandler(this.txt_cpfcnpj_Leave);
            // 
            // txt_rgie
            // 
            this.txt_rgie.Location = new System.Drawing.Point(384, 187);
            this.txt_rgie.Name = "txt_rgie";
            this.txt_rgie.Size = new System.Drawing.Size(302, 20);
            this.txt_rgie.TabIndex = 7;
            // 
            // txt_fone
            // 
            this.txt_fone.Location = new System.Drawing.Point(31, 331);
            this.txt_fone.Mask = "(99)9999-9999";
            this.txt_fone.Name = "txt_fone";
            this.txt_fone.Size = new System.Drawing.Size(146, 20);
            this.txt_fone.TabIndex = 36;
            this.txt_fone.Leave += new System.EventHandler(this.txt_fone_Leave);
            // 
            // txt_cel
            // 
            this.txt_cel.Location = new System.Drawing.Point(200, 331);
            this.txt_cel.Mask = "(99)99999-9999";
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(153, 20);
            this.txt_cel.TabIndex = 37;
            this.txt_cel.Leave += new System.EventHandler(this.txt_cel_Leave);
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(31, 236);
            this.txt_cep.Mask = "99999-999";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(143, 20);
            this.txt_cep.TabIndex = 8;
            this.txt_cep.Leave += new System.EventHandler(this.txt_cep_Leave);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(371, 331);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(315, 20);
            this.txt_email.TabIndex = 39;
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_rsocial;
        private System.Windows.Forms.Label lb_rsocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_juridica;
        private System.Windows.Forms.RadioButton rb_fisica;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cod;
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
        private System.Windows.Forms.MaskedTextBox txt_cpfcnpj;
        private System.Windows.Forms.MaskedTextBox txt_rgie;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_cel;
        private System.Windows.Forms.MaskedTextBox txt_fone;
        private System.Windows.Forms.TextBox txt_email;
    }
}
