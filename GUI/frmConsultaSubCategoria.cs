using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btn_localizar_Click(sender, e);
            dgv_dados.Columns[0].HeaderText = "Código da Subcategoria";
            dgv_dados.Columns[0].Width = 85;
            dgv_dados.Columns[1].HeaderText = "SubCategoria";
            dgv_dados.Columns[1].Width = 250;
            dgv_dados.Columns[2].HeaderText = "Código da Categoria";
            dgv_dados.Columns[2].Width = 85;
            dgv_dados.Columns[3].HeaderText = "Categoria";
            dgv_dados.Columns[3].Width = 250;
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
