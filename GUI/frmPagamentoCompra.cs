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
    public partial class frmPagamentoCompra : Form
    {
        public int pcocod=0;
        public frmPagamentoCompra()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCompra bll = new BLLCompra(cx);
                ModeloCompra modelo = bll.CarregaModeloCompra(f.codigo);
                txt_cod.Text = modelo.ComCod.ToString();
                dtp_data.Value =modelo.ComData;
                txt_valor.Text = modelo.ComTotal.ToString();
                                      
                BLLFornecedor bllf = new BLLFornecedor(cx);
                ModeloFornecedor modelof = bllf.CarregaModeloFornecedor(Convert.ToInt32(modelo.ForCod));
                txt_nome.Text = modelof.ForNome;

                BLLParcelasCompra bllparc = new BLLParcelasCompra(cx);           
                dgv_parcelas.DataSource = bllparc.LocalizarPorCompra(modelo.ComCod);
                this.AtualizaDataGridView();              
            }      
            f.Dispose();
        }

        private void AtualizaDataGridView()
        {
            dgv_parcelas.Columns[0].HeaderText = "Código da Parcela";
            dgv_parcelas.Columns[1].HeaderText = "Valor da parcela";
            dgv_parcelas.Columns[1].DefaultCellStyle.Format = "n2";
            dgv_parcelas.Columns[2].HeaderText = "Data de pagamento";
            dgv_parcelas.Columns[3].HeaderText = "Data de vencimento";
            dgv_parcelas.Columns[4].Visible = false;
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            //dtp_datapagto;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasCompra bll = new BLLParcelasCompra(cx);
            int comcod = Convert.ToInt32(txt_cod.Text);
            bll.EfetuaPagamentoParcela(this.pcocod, comcod, dtp_datapagto.Value);
            MessageBox.Show("Pagamento efetuado na compra de código " + comcod + ".");
            btn_pagar.Enabled = false;

            //exibir grid atualizada
            BLLParcelasCompra bllparc = new BLLParcelasCompra(cx);
            dgv_parcelas.DataSource = bllparc.LocalizarPorCompra(comcod);
            this.AtualizaDataGridView();

            //qtde a serem pagas da compra
        }

        private void dgv_parcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_parcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btn_pagar.Enabled = true;
                this.pcocod = Convert.ToInt32(dgv_parcelas.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                MessageBox.Show(" Não é possível alterar o pagamento de uma parcela já paga.");
                this.pcocod = 0;
                btn_pagar.Enabled = false;
            }
        }
    }
}
