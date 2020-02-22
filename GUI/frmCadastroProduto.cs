using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
	{
        public string foto = "";
        public frmCadastroProduto()
		{
			InitializeComponent();
		}

        public void LimpaTela()
        {
            txt_codigo.Clear();
            txt_nome.Clear();      
            txt_descricao.Clear();
            txt_valorpago.Clear();
            txt_valorvenda.Clear();
            this.foto = "";
            pb_imagem.Image = null;
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            //combo da categoria
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cb_cat.DataSource = bll.Localizar("");
            cb_cat.DisplayMember = "cat_nome";
            cb_cat.ValueMember = "cat_cod";

            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cb_scat.DataSource = sbll.LocalizarPorCategoria((int)cb_cat.SelectedValue);
                cb_scat.DisplayMember = "scat_nome";
                cb_scat.ValueMember = "scat_cod";
            }
            catch
            {
                //MessageBox.Show("Cadastre uma categoria");
            }
            //combo und medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cb_umed.DataSource = ubll.Localizar("");
            cb_umed.DisplayMember = "umed_nome";
            cb_umed.ValueMember = "umed_cod";


        }
          
        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }
        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
          
                txt_codigo.Text = modelo.ProCod.ToString();
                txt_nome.Text = modelo.ProNome;
                txt_descricao.Text = modelo.ProDescricao;                         
                txt_qtde.Text = modelo.ProQtde.ToString("N2");
                txt_valorpago.Text = modelo.ProValorpago.ToString("N2");
                txt_valorvenda.Text = modelo.ProValorvenda.ToString("N2");
                cb_cat.SelectedValue = modelo.CatCod;
                cb_scat.SelectedValue = modelo.ScatCod;
                cb_umed.SelectedValue = modelo.UmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pb_imagem.Image = Image.FromStream(ms);
                }
                catch { }

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
                    BLLProduto bll = new BLLProduto(cx);
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
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txt_nome.Text;
                modelo.ProDescricao = txt_descricao.Text;
                modelo.CarregaImagem(this.foto);              
                modelo.ProValorpago = Convert.ToDouble(txt_valorpago.Text);
                modelo.ProValorvenda = Convert.ToDouble(txt_valorvenda.Text);
                modelo.ProQtde = Convert.ToDouble(txt_qtde.Text);
                modelo.UmedCod = Convert.ToInt32(cb_umed.SelectedValue);
                modelo.CatCod = Convert.ToInt32(cb_cat.SelectedValue);
                modelo.ScatCod = Convert.ToInt32(cb_scat.SelectedValue);              
     
               //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(cx);

                if (this.operacao == "inserir")
                {
                    //cadastrar produto
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro realizado - Código " + modelo.ProCod.ToString());
                }
                else
                {
                    ////alterar cliente
                    modelo.ProCod= Convert.ToInt32(txt_codigo.Text);
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

        private void txt_valorpago_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_valorpago);
        }
        private void txt_valorvenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_valorvenda);
        }
        private void txt_qtde_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txt_qtde);
        }
        private void cb_cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cb_scat.DataSource = sbll.LocalizarPorCategoria((int)cb_cat.SelectedValue);
                cb_scat.DisplayMember = "scat_nome";
                cb_scat.ValueMember = "scat_cod";
            }
            catch {}
        }

        private void btn_lo_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pb_imagem.Load(this.foto);
            }
        }

        private void btn_rm_foto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pb_imagem.Image = null;
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cb_cat.DataSource = bll.Localizar("");
            cb_cat.DisplayMember = "cat_nome";
            cb_cat.ValueMember = "cat_cod";
        }

        private void btn_add_subcat_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                //combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(cx);
                cb_scat.DataSource = sbll.LocalizarPorCategoria((int)cb_cat.SelectedValue);
                cb_scat.DisplayMember = "scat_nome";
                cb_scat.ValueMember = "scat_cod";
            }
            catch
            {
                MessageBox.Show("Cadastre uma categoria");
            }
        }

        private void btn_add_unidmed_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(cx);
            cb_umed.DataSource = ubll.Localizar("");
            cb_umed.DisplayMember = "umed_nome";
            cb_umed.ValueMember = "umed_cod";
        }

        public static void Moeda(ref TextBox valor)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = valor.Text.Replace(".", "").Replace(",", "");             
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');

                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;

                valor.Text = string.Format("{0:N}", v);
                valor.SelectionStart = valor.Text.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
