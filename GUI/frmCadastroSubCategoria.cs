using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DAL;
using BLL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txt_codigo.Clear();
            txt_nome_subcategoria.Clear();
        }
        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cb_cat_cod.DataSource = bll.Localizar("");
            cb_cat_cod.DisplayMember = "cat_nome";
            cb_cat_cod.ValueMember =  "cat_cod";

        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != -1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo); 
                txt_codigo.Text = modelo.SCatCod.ToString();
                txt_nome_subcategoria.Text = modelo.SCatNome;
                cb_cat_cod.SelectedValue = modelo.CatCod;
                this.AlteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            f.Dispose();            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txt_codigo.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura de dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.SCatNome = txt_nome_subcategoria.Text;
                modelo.CatCod = Convert.ToInt32(cb_cat_cod.SelectedValue);

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar subcategoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado - Código " + modelo.SCatCod.ToString());
                }
                else
                {
                    //alterar categoria
                    modelo.SCatCod = Convert.ToInt32(txt_codigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado.");
                }
                this.LimpaTela();
                this.AlteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.AlteraBotoes(1);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cb_cat_cod.DataSource = bll.Localizar("");
            cb_cat_cod.DisplayMember = "cat_nome";
            cb_cat_cod.ValueMember = "cat_cod";
        }
    }
}
