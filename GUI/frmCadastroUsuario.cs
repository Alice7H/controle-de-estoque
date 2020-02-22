using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }    
        public void LimpaTela()
        {
            txt_cod.Clear();
            txt_usuario.Clear();
            txt_senha.Clear();
            txt_confirmsenha.Clear();
            cb_nivel.SelectedIndex = 0;
        }

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLNivelAcesso bll = new BLLNivelAcesso(cx);
            cb_nivel.DataSource = bll.Localizar("");
            cb_nivel.DisplayMember = "niv_nome";
            cb_nivel.ValueMember = "niv_cod";
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != -1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txt_cod.Text = modelo.UsuCod.ToString();
                txt_usuario.Text = modelo.UsuNome;
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
                DialogResult d = MessageBox.Show("Deseja inativar o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Cancelar(Convert.ToInt32(txt_cod.Text));
                    this.LimpaTela();
                    this.AlteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível cancelar o registro. \n O registro está sendo utilizado em outro local.");
                this.AlteraBotoes(3);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura de dados
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsuNome = txt_usuario.Text;
                modelo.UsuSenha = txt_senha.Text;
                modelo.UsuStatus = "ATIVO";
                modelo.NivCod = Convert.ToInt32(cb_nivel.SelectedValue);             

                if (txt_senha.Text != txt_confirmsenha.Text)
                {
                    throw new Exception("A confirmação de senha não corresponde à senha.");
                }
                else
                {
                    //obj para gravar os dados no banco
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);

                    if (this.operacao == "inserir")
                    {
                        //cadastrar 
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro realizado - Código " + modelo.UsuCod.ToString());
                    }
                    else
                    {
                        //alterar 
                        modelo.UsuCod = Convert.ToInt32(txt_cod.Text);
                        bll.Alterar(modelo);
                        MessageBox.Show("Cadastro alterado.");
                    }
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
    }
}
