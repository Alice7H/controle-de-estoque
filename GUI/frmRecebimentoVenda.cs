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
    public partial class frmRecebimentoVenda : Form
    {
        public int pvecod = 0;
        public frmRecebimentoVenda()
        {
            InitializeComponent();
        }
        private void btn_localizar_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLVenda bll = new BLLVenda(cx);
                ModeloVenda modelo = bll.CarregaModeloVenda(f.codigo);
                txt_cod.Text = modelo.VenCod.ToString();
                dtp_data.Value = modelo.VenData;
                txt_valor.Text = modelo.VenTotal.ToString();

                BLLCliente bllc = new BLLCliente(cx);
                ModeloCliente modeloc = bllc.CarregaModeloCliente(Convert.ToInt32(modelo.CliCod));
                txt_nome.Text = modeloc.CliNome;

                BLLParcelasVenda bllparc = new BLLParcelasVenda(cx);
                dgv_parcelas.DataSource = bllparc.LocalizarPorVenda(modelo.VenCod);
                this.AtualizaDataGridView();
            }
            f.Dispose();
        }

        private void AtualizaDataGridView()
        {
            dgv_parcelas.Columns[0].HeaderText = "Código da Parcela";
            dgv_parcelas.Columns[1].HeaderText = "Valor da parcela";
            dgv_parcelas.Columns[1].DefaultCellStyle.Format = "n2";
            dgv_parcelas.Columns[2].HeaderText = "Data do recebimento";
            dgv_parcelas.Columns[3].HeaderText = "Data de vencimento";
            dgv_parcelas.Columns[4].Visible = false;
        }

        private void btn_receber_Click(object sender, EventArgs e)
        {
            //dtp_datapagto;
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasVenda bll = new BLLParcelasVenda(cx);
            int vencod = Convert.ToInt32(txt_cod.Text);
            bll.EfetuaRecebimentoParcela(this.pvecod, vencod, dtp_datarec.Value);
            MessageBox.Show("Recebimento efetuado na venda de código " + vencod + ".");
            btn_receber.Enabled = false;

            //exibir grid atualizada
            BLLParcelasVenda bllparc = new BLLParcelasVenda(cx);
            dgv_parcelas.DataSource = bllparc.LocalizarPorVenda(vencod);
            this.AtualizaDataGridView();
            //qtde de parcelas a receber
        }

        private void dgv_parcelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_parcelas.Rows[e.RowIndex].Cells[2].Value.ToString() == "")
            {
                btn_receber.Enabled = true;
                this.pvecod = Convert.ToInt32(dgv_parcelas.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Não é possível alterar o pagamento de uma parcela já paga.");
                this.pvecod = 0;
                btn_receber.Enabled = false;
            }
        }
    }
}
