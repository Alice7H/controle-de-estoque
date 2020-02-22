﻿using BLL;
using DAL;
using Modelo;
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
    public partial class frmConsultaVenda : Form
    {
        public int codigo = 0;
        public frmConsultaVenda()
        {
            InitializeComponent();
        }

        private void frmConsultaVenda_Load(object sender, EventArgs e)
        {
            rb_todas_CheckedChanged(sender, e);
        }

        private void AtualizaDataGridView()
        {        
            dgv_dados.Columns[0].HeaderText = "Cód. da Venda";
            dgv_dados.Columns[1].HeaderText = "Data da Venda";
            dgv_dados.Columns[2].HeaderText = "Nota fiscal";
            dgv_dados.Columns[3].HeaderText = "Venda à vista";
            dgv_dados.Columns[4].HeaderText = "Número de Parcelas";                    
            dgv_dados.Columns[5].HeaderText = "Status";
            dgv_dados.Columns[6].HeaderText = "Cliente";
            dgv_dados.Columns[6].Width = 200;         
            dgv_dados.Columns[7].HeaderText = "Total";
            dgv_dados.Columns[7].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[7].Width = 60;
            dgv_dados.Columns[8].HeaderText = "Tipo de Pagamento";
            dgv_dados.Columns[8].Width = 80;

            dgv_dados.Columns[3].Visible = false;
            dgv_dados.Columns[4].Visible = false;
            dgv_dados.Columns[5].Visible = false;
        }

        private void AtualizaDataGridViewParcela()
        {           
            dgv_dados.Columns[0].HeaderText = "Cód. da Venda";
            dgv_dados.Columns[1].HeaderText = "Data da Venda";
            dgv_dados.Columns[2].HeaderText = "Nota fiscal";
            dgv_dados.Columns[3].HeaderText = "Venda à vista";
            dgv_dados.Columns[4].HeaderText = "Data de Vencimento";
            dgv_dados.Columns[5].HeaderText = "Valor da Parcela";
            dgv_dados.Columns[5].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[6].HeaderText = "Número de Parcelas";
            dgv_dados.Columns[7].HeaderText = "Status";
            dgv_dados.Columns[8].HeaderText = "Cliente";
            dgv_dados.Columns[8].Width = 210;     
            dgv_dados.Columns[9].HeaderText = "Total";
            dgv_dados.Columns[9].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[9].Width = 60;
            dgv_dados.Columns[10].HeaderText = "Tipo de Pagamento";
            dgv_dados.Columns[10].Width = 80;

            dgv_dados.Columns[3].Visible = false;
            dgv_dados.Columns[6].Visible = false;
            dgv_dados.Columns[7].Visible = false;
        }

        private void AtualizaDataGriViewItensVenda()
        {
            dgv_itens.Columns[0].HeaderText = "Cód. do Item";
            dgv_itens.Columns[1].HeaderText = "Código da Venda";
            dgv_itens.Columns[2].HeaderText = "Código do Produto";
            dgv_itens.Columns[3].HeaderText = "Produto";
            dgv_itens.Columns[3].Width = 300;
            dgv_itens.Columns[4].HeaderText = "Quantidade";
            dgv_itens.Columns[5].HeaderText = "Valor";
            dgv_itens.Columns[5].DefaultCellStyle.Format = "n2";

            dgv_itens.Columns[1].Visible = false;
            dgv_itens.Columns[2].Visible = false;
        }

        private void AtualizaDataGriViewParcelasCompra()
        {
            dgv_parcelas.Columns[0].HeaderText = "Cód. da Parcela";
            dgv_parcelas.Columns[1].HeaderText = "Valor da Parcela";
            dgv_parcelas.Columns[1].DefaultCellStyle.Format = "n2";
            dgv_parcelas.Columns[2].HeaderText = "Data de Pagamento";
            dgv_parcelas.Columns[3].HeaderText = "Data de Vencimento";
            dgv_parcelas.Columns[4].HeaderText = "Código da Venda";

            dgv_parcelas.Columns[4].Visible = false;
        }

        private void rb_todas_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);

            pn_data.Visible = false;
            pn_cli.Visible = false;
            pn_venda.Visible = false;
            dgv_dados.DataSource = null;
            dgv_itens.DataSource = null;
            dgv_parcelas.DataSource = null;
            txt_valor.Text = "";
            txt_clicod.Text = "";
            txt_clinome.Text = "";

            if (rb_todas.Checked == true)
            {
                try
                {
                    dgv_dados.DataSource = bll.Localizar();
                    this.AtualizaDataGridView();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

            if (rb_vencod.Checked == true)
            {
                pn_venda.Visible = true;
            }

            if (rb_data.Checked == true)
            {
                pn_data.Visible = true;
            }

            if (rb_cli.Checked == true)
            {
                pn_cli.Visible = true;
            }

            if (rb_avista.Checked == true)
            {
                dgv_dados.DataSource = bll.LocalizarAvista();
                this.AtualizaDataGridView();
            }

            if (rb_parcelas.Checked == true)
            {
                dgv_dados.DataSource = bll.LocalizarPorParcelas();
                this.AtualizaDataGridViewParcela();
            }

            if (rb_cancelada.Checked == true)
            {
                dgv_dados.DataSource = bll.LocalizarPorCancelada();
                this.AtualizaDataGridView();
            }
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            try
            {
                dgv_dados.DataSource = bll.Localizar(Convert.ToInt32(txt_valor.Text));
                this.AtualizaDataGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_localizarData_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLVenda bll = new BLLVenda(cx);
            try
            {
                dgv_dados.DataSource = bll.Localizar(Convert.ToDateTime(dtp_incial.Text), Convert.ToDateTime(dtp_final.Text));
                this.AtualizaDataGridView();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_localizaCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txt_clicod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txt_clinome.Text = modelo.CliNome;
                BLLVenda bllc = new BLLVenda(cx);
                try
                {
                    dgv_dados.DataSource = bllc.LocalizarPorCliente(Convert.ToInt32(f.codigo));
                    this.AtualizaDataGridView();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                txt_clicod.Text = "";
                txt_clinome.Text = "";
            }
            f.Dispose();
        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensVenda bll = new BLLItensVenda(cx);
                dgv_itens.DataSource = bll.LocalizarPorVenda(Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value));
                this.AtualizaDataGriViewItensVenda();

                BLLParcelasVenda bllp = new BLLParcelasVenda(cx);
                dgv_parcelas.DataSource = bllp.LocalizarPorVenda(Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value));
                this.AtualizaDataGriViewParcelasCompra();
            }
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
