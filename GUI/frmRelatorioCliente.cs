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
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_controledeestoqueDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.db_controledeestoqueDataSet.cliente);
            this.reportViewer1.RefreshReport();

        }
    }
}
