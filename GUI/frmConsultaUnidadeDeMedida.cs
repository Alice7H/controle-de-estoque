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
    public partial class frmConsultaUnidadeDeMedida : Form
    {
        public int codigo = 0;
        public frmConsultaUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
            dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
        }

        private void frmConsultaUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            btn_localizar_Click(sender, e);
            dgv_dados.Columns[0].HeaderText = "Código";
            dgv_dados.Columns[0].Width = 45;
            dgv_dados.Columns[1].HeaderText = "Unidade de Medida";
            dgv_dados.Columns[1].Width = 625;
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
