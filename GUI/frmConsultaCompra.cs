using BLL;
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
    public partial class frmConsultaCompra : Form
    {
        public int codigo = 0;
        public frmConsultaCompra()
        {
            InitializeComponent();
        }

        private void frmConsultaCompra_Load(object sender, EventArgs e)
        {     
            rb_todas_CheckedChanged(sender, e);         
        }

        private void AtualizaDataGridView()
        {
            dgv_dados.Columns[0].HeaderText = "Cód. da Compra";        
            dgv_dados.Columns[1].HeaderText = "Data da Compra";          
            dgv_dados.Columns[2].HeaderText = "Nota fiscal";         
            dgv_dados.Columns[3].HeaderText = "Número de Parcelas";          
            dgv_dados.Columns[4].HeaderText = "Status";          
            dgv_dados.Columns[5].HeaderText = "Fornecedor";
            dgv_dados.Columns[5].Width = 200;
            dgv_dados.Columns[6].HeaderText = "Total";
            dgv_dados.Columns[6].Width = 60;
            dgv_dados.Columns[6].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[7].HeaderText = "Tipo de Pagamento";
            dgv_dados.Columns[7].Width = 80;
            
            dgv_dados.Columns[3].Visible = false;
            dgv_dados.Columns[4].Visible = false;
        }

        private void AtualizaDataGridViewParcela()
        {           
            dgv_dados.Columns[0].HeaderText = "Cód. da Compra";
            dgv_dados.Columns[1].HeaderText = "Data da Compra";
            dgv_dados.Columns[2].HeaderText = "Nota fiscal";
            dgv_dados.Columns[3].HeaderText = "Data de Vencimento";
            dgv_dados.Columns[4].HeaderText = "Valor da Parcela";
            dgv_dados.Columns[4].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[5].HeaderText = "Número de Parcelas";
            dgv_dados.Columns[6].HeaderText = "Status";
            dgv_dados.Columns[7].HeaderText = "Fornecedor";
            dgv_dados.Columns[7].Width = 210;
            dgv_dados.Columns[8].HeaderText = "Total";
            dgv_dados.Columns[8].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[8].Width = 60;
            dgv_dados.Columns[9].HeaderText = "Tipo de Pagamento";
            dgv_dados.Columns[9].Width = 80;

            dgv_dados.Columns[5].Visible = false;
            dgv_dados.Columns[6].Visible = false;
        }

        private void AtualizaDataGriViewItensCompra()
        {
            dgv_itens.Columns[0].HeaderText = "Cód. do Item";
            dgv_itens.Columns[1].HeaderText = "Código da Compra";
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
            dgv_parcelas.Columns[4].HeaderText = "Código da Compra";

            dgv_parcelas.Columns[4].Visible = false;
        }

        private void rb_todas_CheckedChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);

            pn_data.Visible = false;
            pn_for.Visible = false;
            pn_compra.Visible = false;
            dgv_dados.DataSource = null;
            dgv_itens.DataSource = null;
            dgv_parcelas.DataSource = null;

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

            if (rb_comcod.Checked == true)
            {
                pn_compra.Visible = true;             
            }

            if (rb_data.Checked == true)
            {
                pn_data.Visible = true;        
            }

            if (rb_for.Checked == true)
            {             
                pn_for.Visible = true;                
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
            BLLCompra bll = new BLLCompra(cx);
            try { 
                dgv_dados.DataSource = bll.Localizar(Convert.ToInt32(txt_valor.Text));
                this.AtualizaDataGridView();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_localizarData_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCompra bll = new BLLCompra(cx);
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

        private void btn_localizaFornecedor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();

            if (f.codigo != 0)
            {
                txt_forcod.Text = f.codigo.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txt_fornome.Text = modelo.ForNome;
                BLLCompra bllc = new BLLCompra(cx);
                try
                {
                    dgv_dados.DataSource = bllc.LocalizarPorFornecedor(Convert.ToInt32(f.codigo));
                    this.AtualizaDataGridView();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else {
                txt_forcod.Text = "";
                txt_fornome.Text = "";
            }
            f.Dispose();
        }

        private void dgv_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {              
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLItensCompra bll = new BLLItensCompra(cx);
                dgv_itens.DataSource = bll.LocalizarPorCompra(Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value));
                this.AtualizaDataGriViewItensCompra();

                BLLParcelasCompra bllp = new BLLParcelasCompra(cx);
                dgv_parcelas.DataSource = bllp.LocalizarPorCompra(Convert.ToInt32(dgv_dados.Rows[e.RowIndex].Cells[0].Value));
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
