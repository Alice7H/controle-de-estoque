using DAL;
using BLL;
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
    public partial class frmConsultaProduto : Form
    {
        public int codigo = 0;
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLProduto bll = new BLLProduto(cx);
            dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            btn_localizar_Click(sender, e);
            dgv_dados.Columns[0].HeaderText = "Código";
            dgv_dados.Columns[0].Width = 45;
            dgv_dados.Columns[1].HeaderText = "Produto";
            dgv_dados.Columns[1].Width = 150;
            dgv_dados.Columns[2].HeaderText = "Descrição";
            dgv_dados.Columns[2].Width = 100; 
            dgv_dados.Columns[3].HeaderText = "Foto";
            dgv_dados.Columns[3].Width = 32;
            dgv_dados.Columns[4].HeaderText = "Valor Pago";
            dgv_dados.Columns[4].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[4].Width = 45;
            dgv_dados.Columns[5].HeaderText = "Valor de Venda";
            dgv_dados.Columns[5].DefaultCellStyle.Format = "n2";
            dgv_dados.Columns[5].Width = 50;
            dgv_dados.Columns[6].HeaderText = "Quantidade";
            dgv_dados.Columns[6].Width = 65; 
            dgv_dados.Columns[7].HeaderText = "Código da Unid. de Medida";
            dgv_dados.Columns[7].Width = 50;
            dgv_dados.Columns[8].HeaderText = "Codigo da Categoria";
            dgv_dados.Columns[8].Width = 60;
            dgv_dados.Columns[9].HeaderText = "Código da SubCategoria";
            dgv_dados.Columns[9].Width = 78;
            dgv_dados.Columns[10].HeaderText = "Unid. de Medida";
            dgv_dados.Columns[10].Width = 60;
            dgv_dados.Columns[11].HeaderText = "Categoria";
            dgv_dados.Columns[11].Width = 65;
            dgv_dados.Columns[12].HeaderText = "SubCategoria";
            dgv_dados.Columns[12].Width = 85; 

            //ocultar colunas
            dgv_dados.Columns["umed_cod"].Visible = false; 
            dgv_dados.Columns["cat_cod"].Visible = false;  
            dgv_dados.Columns["scat_cod"].Visible = false;
            dgv_dados.Columns["pro_foto"].Visible = false;

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
