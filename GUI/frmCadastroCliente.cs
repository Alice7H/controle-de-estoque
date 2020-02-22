using BLL;
using DAL;
using Modelo;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txt_cod.Clear();
            txt_nome.Clear();
            txt_rsocial.Clear();
            txt_cpfcnpj.Clear();
            txt_rgie.Clear();
            txt_cep.Clear();
            txt_endereco.Clear();
            txt_num.Clear();
            txt_bairro.Clear();
            txt_cidade.Clear();
            txt_estado.Clear();
            txt_fone.Clear();
            txt_cel.Clear();
            txt_email.Clear();
            rb_fisica.Checked = true;
            rb_juridica.Checked = false;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
   
            if (rb_fisica.Checked == true)
            {
                lb_rsocial.Visible = false;
                txt_rsocial.Visible = false;            
                lb_cpfcnpj.Text = "CPF";
                lb_rgie.Text = "RG";
                txt_cpfcnpj.Mask = "000.000.000-00";
                txt_rgie.Mask = "00.000.000-00";
               
            }
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != -1)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                if (modelo.CliTipo == 0)
                {
                    rb_fisica.Checked = true;        
                    lb_cpfcnpj.Text = "CPF";
                    lb_rgie.Text = "RG";
                    txt_cpfcnpj.Mask = "000.000.000-00";
                    txt_rgie.Mask = "00.000.000-00";               
                }
                else
                {                   
                    rb_juridica.Checked = true;         
                    lb_cpfcnpj.Text = "CNPJ";
                    lb_rgie.Text = "IE";
                    txt_cpfcnpj.Mask = "00.000.000/0000-00";
                    txt_rgie.Mask = "000.000.000.000";
                }

                txt_cod.Text = modelo.CliCod.ToString();
                txt_nome.Text = modelo.CliNome;
                txt_rsocial.Text = modelo.CliRsocial;
                txt_cpfcnpj.Text = modelo.CliCpfCnpj;
                txt_rgie.Text = modelo.CliRgIe;
                txt_cep.Text = modelo.CliCep;
                txt_endereco.Text = modelo.CliEndereco;
                txt_num.Text = modelo.CliEndnumero;
                txt_bairro.Text = modelo.CliBairro;
                txt_cidade.Text = modelo.CliCidade;
                txt_estado.Text = modelo.CliEstado;
                txt_fone.Text = modelo.CliFone;
                txt_cel.Text = modelo.CliCel;
                txt_email.Text = modelo.CliEmail;

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
                    BLLCliente bll = new BLLCliente(cx);
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
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliNome = txt_nome.Text;             
                modelo.CliCpfCnpj = txt_cpfcnpj.Text;
                modelo.CliRgIe = txt_rgie.Text;
                modelo.CliRsocial = txt_rsocial.Text;
                if (rb_fisica.Checked == true)
                {
                    modelo.CliTipo = 0;
                    modelo.CliRsocial = "";
                }
                else
                {                 
                    modelo.CliTipo = 1;                  
                }

                modelo.CliCep = txt_cep.Text;
                modelo.CliEndereco = txt_endereco.Text;
                modelo.CliBairro = txt_bairro.Text;
                modelo.CliFone = txt_fone.Text;
                modelo.CliCel = txt_cel.Text;
                modelo.CliEmail = txt_email.Text;
                modelo.CliEndnumero = txt_num.Text;
                modelo.CliCidade = txt_cidade.Text;
                modelo.CliEstado = txt_estado.Text;

                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar cliente
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado - Código " + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar cliente
                    modelo.CliCod = Convert.ToInt32(txt_cod.Text);
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

        private void rb_fisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fisica.Checked == true)
            {
                lb_rsocial.Visible = false;
                txt_rsocial.Visible = false;
                lb_cpfcnpj.Text = "CPF";
                lb_rgie.Text = "RG";
                txt_rgie.Mask = "00.000.000-00";
                txt_cpfcnpj.Mask = "000.000.000-00";
            }
            else
            {
                lb_rsocial.Visible = true;
                txt_rsocial.Visible = true;
                lb_cpfcnpj.Text = "CNPJ";
                lb_rgie.Text = "IE";
                txt_cpfcnpj.Mask = "00.000.000/0000-00";
                txt_rgie.Mask = "000.000.000.000";
            }
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

        }

        private void txt_cpfcnpj_Leave(object sender, EventArgs e)
        {
           
            if (rb_fisica.Checked == true)
            {
                if (!Validacao.IsCpf(txt_cpfcnpj.Text))
                {
                    MessageBox.Show("CPF inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cpfcnpj.Focus();
                    txt_cpfcnpj.Clear();
                }
            }
            else
            {
                if (!Validacao.IsCnpj(txt_cpfcnpj.Text))
                {
                    MessageBox.Show("CNPJ inválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_cpfcnpj.Focus();
                    txt_cpfcnpj.Clear();
                }
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
