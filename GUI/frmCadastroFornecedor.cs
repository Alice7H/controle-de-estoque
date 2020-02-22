using BLL;
using DAL;
using Ferramentas;
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
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txt_cod.Clear();
            txt_nome.Clear();
            txt_rsocial.Clear();
            txt_cnpj.Clear();
            txt_ie.Clear();
            txt_cep.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
            txt_fone.Clear();
            txt_cel.Clear();
            txt_email.Clear();
        }
        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != -1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);

                txt_cod.Text = modelo.ForCod.ToString();
                txt_nome.Text = modelo.ForNome;
                txt_rsocial.Text = modelo.ForRsocial;
                txt_cnpj.Text = modelo.ForCnpj;
                txt_ie.Text = modelo.ForIe;
                txt_cep.Text = modelo.ForCep;
                txt_endereco.Text = modelo.ForEndereco;
                txt_num.Text = modelo.ForEndnumero;
                txt_bairro.Text = modelo.ForBairro;
                txt_cidade.Text = modelo.ForCidade;
                txt_estado.Text = modelo.ForEstado;
                txt_fone.Text = modelo.ForFone;
                txt_cel.Text = modelo.ForCel;
                txt_email.Text = modelo.ForEmail;

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
                    BLLFornecedor bll = new BLLFornecedor(cx);
                    bll.Excluir(Convert.ToInt32(txt_cod.Text));
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
                ModeloFornecedor modelo = new ModeloFornecedor();
                modelo.ForNome = txt_nome.Text;
                modelo.ForCnpj = txt_cnpj.Text;
                modelo.ForIe = txt_ie.Text;
                modelo.ForRsocial = txt_rsocial.Text;
                modelo.ForCep = txt_cep.Text;
                modelo.ForEndereco = txt_endereco.Text;
                modelo.ForBairro = txt_bairro.Text;
                modelo.ForFone = txt_fone.Text;
                modelo.ForCel = txt_cel.Text;
                modelo.ForEmail = txt_email.Text;
                modelo.ForEndnumero = txt_num.Text;
                modelo.ForCidade = txt_cidade.Text;
                modelo.ForEstado = txt_estado.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar fornecedor
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado - Código " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar fornecedor
                    modelo.ForCod = Convert.ToInt32(txt_cod.Text);
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
        private void txt_cep_Leave(object sender, EventArgs e)
        {

            if (BuscaEndereco.verificaCEP(txt_cep.Text) == true)
            {
                txt_estado.Text = BuscaEndereco.estado;
                txt_cidade.Text = BuscaEndereco.cidade;
                txt_bairro.Text = BuscaEndereco.bairro;
                txt_endereco.Text = BuscaEndereco.endereco;
            }
            if (!Validacao.IsCep(txt_cep.Text))
            {
                MessageBox.Show("CEP inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cep.Focus();
                txt_cep.Clear();
                txt_estado.Clear();
                txt_cidade.Clear();
                txt_bairro.Clear();
                txt_endereco.Clear();
            }

        }
        private void txt_cnpj_Leave(object sender, EventArgs e)
        {        
                if (!Validacao.IsCnpj(txt_cnpj.Text))
                {
                    MessageBox.Show("CNPJ inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cnpj.Focus();
                    txt_cnpj.Clear();
                }          
        }
        private void txt_email_Leave(object sender, EventArgs e)
        {
            if (!Validacao.IsEmail(txt_email.Text))
            {
                MessageBox.Show("E-mail inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_email.Focus();
                txt_email.Clear();
            }
        }

        private void txt_fone_Leave(object sender, EventArgs e)
        {
            if (!Validacao.IsFone(txt_fone.Text))
            {
                MessageBox.Show("Número de telefone inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_fone.Focus();
                txt_fone.Clear();
            }

        }

        private void txt_cel_Leave(object sender, EventArgs e)
        {
            if (!Validacao.IsCel(txt_cel.Text))
            {
                MessageBox.Show("Número de celular inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_cel.Focus();
                txt_cel.Clear();
            }
        }
    }
}
