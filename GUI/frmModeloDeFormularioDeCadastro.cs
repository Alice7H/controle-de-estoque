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
    public partial class frmModeloDeFormularioDeCadastro : Form
    {
        public String operacao;
        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            //operacao
            // 1 inserir e localizar
            // 2 inserir/alterar
            // 3 excluir/alterar

            pnDados.Enabled = false;
            btn_Inserir.Enabled = false;
            btn_Localizar.Enabled = false;
            btn_Alterar.Enabled = false;
            btn_Excluir.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_Inserir.Enabled = true;
                btn_Localizar.Enabled = true;

            } else if (op == 2)
                    {
                        pnDados.Enabled = true;
                        btn_Salvar.Enabled = true;                                 
                        btn_Cancelar.Enabled = true;

                    } else if(op == 3)
                        {
                            btn_Excluir.Enabled = true;
                            btn_Alterar.Enabled = true;
                            btn_Cancelar.Enabled = true;
                        }
        }

        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void frmModeloDeFormularioDeCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
