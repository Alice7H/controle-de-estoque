﻿namespace GUI
{
    partial class frmConsultaCliente
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
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dgv_dados = new System.Windows.Forms.DataGridView();
            this.btn_localizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_cpfcnpj = new System.Windows.Forms.RadioButton();
            this.rb_nome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o Nome, CPF ou CNPJ do cliente";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(183, 73);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(453, 20);
            this.txt_valor.TabIndex = 1;
            // 
            // dgv_dados
            // 
            this.dgv_dados.AllowUserToAddRows = false;
            this.dgv_dados.AllowUserToDeleteRows = false;
            this.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dados.Location = new System.Drawing.Point(34, 117);
            this.dgv_dados.Name = "dgv_dados";
            this.dgv_dados.ReadOnly = true;
            this.dgv_dados.Size = new System.Drawing.Size(713, 414);
            this.dgv_dados.TabIndex = 2;
            this.dgv_dados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dados_CellDoubleClick);
            // 
            // btn_localizar
            // 
            this.btn_localizar.Location = new System.Drawing.Point(670, 56);
            this.btn_localizar.Name = "btn_localizar";
            this.btn_localizar.Size = new System.Drawing.Size(77, 37);
            this.btn_localizar.TabIndex = 3;
            this.btn_localizar.Text = "Localizar";
            this.btn_localizar.UseVisualStyleBackColor = true;
            this.btn_localizar.Click += new System.EventHandler(this.btn_localizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_cpfcnpj);
            this.groupBox1.Controls.Add(this.rb_nome);
            this.groupBox1.Location = new System.Drawing.Point(34, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Cliente";
            // 
            // rb_cpfcnpj
            // 
            this.rb_cpfcnpj.AutoSize = true;
            this.rb_cpfcnpj.Location = new System.Drawing.Point(21, 52);
            this.rb_cpfcnpj.Name = "rb_cpfcnpj";
            this.rb_cpfcnpj.Size = new System.Drawing.Size(77, 17);
            this.rb_cpfcnpj.TabIndex = 1;
            this.rb_cpfcnpj.Text = "CPF/CNPJ";
            this.rb_cpfcnpj.UseVisualStyleBackColor = true;
            // 
            // rb_nome
            // 
            this.rb_nome.AutoSize = true;
            this.rb_nome.Checked = true;
            this.rb_nome.Location = new System.Drawing.Point(21, 29);
            this.rb_nome.Name = "rb_nome";
            this.rb_nome.Size = new System.Drawing.Size(53, 17);
            this.rb_nome.TabIndex = 0;
            this.rb_nome.TabStop = true;
            this.rb_nome.Text = "Nome";
            this.rb_nome.UseVisualStyleBackColor = true;
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_localizar);
            this.Controls.Add(this.dgv_dados);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dgv_dados;
        private System.Windows.Forms.Button btn_localizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_cpfcnpj;
        private System.Windows.Forms.RadioButton rb_nome;
    }
}