﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCliente : Form
    {
        public int codigo = 0;
        public frmConsultaCliente()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            if (rb_nome.Checked == true)
            {
                dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
            }
            else
            {
                dgv_dados.DataSource = bll.LocalizarCpfCnpj(txt_valor.Text);
            }      
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e)
        {
            btn_localizar_Click(sender, e);
            dgv_dados.Columns[0].HeaderText = "Código";
            dgv_dados.Columns[0].Width = 45;
            dgv_dados.Columns[1].HeaderText = "Cliente";
            dgv_dados.Columns[1].Width = 100;
            dgv_dados.Columns[2].HeaderText = "CPF/CNPJ";
            dgv_dados.Columns[2].Width = 45;
            dgv_dados.Columns[3].HeaderText = "RG/IE";
            dgv_dados.Columns[3].Width = 45;
            dgv_dados.Columns[4].HeaderText = "Razão Social";
            dgv_dados.Columns[4].Width = 45;
            dgv_dados.Columns[5].HeaderText = "Tipo";
            dgv_dados.Columns[5].Width = 45;
            dgv_dados.Columns[6].HeaderText = "CEP";
            dgv_dados.Columns[6].Width = 45;
            dgv_dados.Columns[7].HeaderText = "Endereço";
            dgv_dados.Columns[7].Width = 45;
            dgv_dados.Columns[8].HeaderText = "Bairro";
            dgv_dados.Columns[8].Width = 45;
            dgv_dados.Columns[9].HeaderText = "Telefone";
            dgv_dados.Columns[9].Width = 45;
            dgv_dados.Columns[10].HeaderText = "Celular";
            dgv_dados.Columns[10].Width = 45;
            dgv_dados.Columns[11].HeaderText = "E-mail";
            dgv_dados.Columns[11].Width = 45;
            dgv_dados.Columns[12].HeaderText = "Núm. Endereço";
            dgv_dados.Columns[12].Width = 45;
            dgv_dados.Columns[13].HeaderText = "Cidade";
            dgv_dados.Columns[13].Width = 45;
            dgv_dados.Columns[14].HeaderText = "Estado";
            dgv_dados.Columns[14].Width = 45;
        }

        private void dgv_dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
