using BLL;
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
    public partial class frmConsultaUsuario : Form
    {
        public int codigo = 0;
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btn_localizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            if (rb_nome.Checked == true)
            {
                dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
            }
            else
            {
                dgv_dados.DataSource = bll.Localizar(txt_valor.Text);
            }
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            btn_localizar_Click(sender, e);
            dgv_dados.Columns[0].HeaderText = "Código";
            dgv_dados.Columns[0].Width = 50;
            dgv_dados.Columns[1].HeaderText = "Usuário";
            dgv_dados.Columns[1].Width = 270;         
            dgv_dados.Columns[3].HeaderText = "Nível de acesso";
            dgv_dados.Columns[3].Width = 200;
            dgv_dados.Columns[4].HeaderText = "Status";
            dgv_dados.Columns[4].Width = 150;

            dgv_dados.Columns[2].Visible = false;
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
