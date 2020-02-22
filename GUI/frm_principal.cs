using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_principal : Form
    {
        private int coduser = 0, codlog=0;
        private string nivel;
        public frm_principal(int usuariocod, int codlog)
        {
            InitializeComponent();
            this.coduser = usuariocod;
            this.codlog = codlog;         
        }
        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.ContParcela();     
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            ModeloUsuario modelo = bll.CarregaModeloUsuario(this.coduser);
            lb_datahora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            lb_nome.Text = modelo.UsuNome;

            BLLNivelAcesso blln = new BLLNivelAcesso(cx); 
            DataTable tabela = blln.Localizar(modelo.NivCod);                                    
            this.nivel = tabela.Rows[0]["niv_nome"].ToString();
            lb_nivel.Text = this.nivel;

            this.CarregaNivelAcesso();      
        }

        private void CarregaNivelAcesso()
        {         
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLControleAcesso bll = new BLLControleAcesso(cx);
            DataTable tabela;
            if (this.nivel == "administrador")
            {
                nívelDeAcessoToolStripMenuItem.Visible = true;
            }
            else
            {
                if (this.nivel == "gerente")
                {
                    nívelDeAcessoToolStripMenuItem.Visible = false;
                    tabela = bll.Localizar(2);                 
                }
                else
                {
                    nívelDeAcessoToolStripMenuItem.Visible = false;
                    tabela = bll.Localizar(3);
                }

                string cadcat, cadscat,cadunidmed, cadproduto, cadusuario, cadcliente, cadfornecedor, cadtipopagto, cadcompra, cadvenda, recebimento, pagamento,
                    concat, conscat, conunidmed, conproduto, conusuario,concliente,confornecedor,contipopagto, concompra,convenda,configbd, backupbd,
                    relproduto, relcliente, relfornecedor, relcompra, relvenda, word, excel, bloconotas, calculadora;

                //carregar o controle de acesso
                cadcat = tabela.Rows[0]["ctrl_cadcat"].ToString();
                if (cadcat == "SIM") { categoriaToolStripMenuItem.Enabled = true; } else { categoriaToolStripMenuItem.Enabled = false; }

                cadscat = tabela.Rows[0]["ctrl_cadscat"].ToString();
                if (cadscat == " SIM") { subCategoriaToolStripMenuItem.Enabled = true; } else { subCategoriaToolStripMenuItem.Enabled = false; }

                cadunidmed = tabela.Rows[0]["ctrl_cadunidmed"].ToString();
                if (cadunidmed == "SIM") { unidadeDeMedidaToolStripMenuItem.Enabled = true; }else { subCategoriaToolStripMenuItem.Enabled = false; }

                cadproduto = tabela.Rows[0]["ctrl_cadproduto"].ToString();
                if (cadproduto == "SIM") { produtoToolStripMenuItem.Enabled = true; } else { produtoToolStripMenuItem.Enabled = false; }

                cadusuario = tabela.Rows[0]["ctrl_cadusuario"].ToString();
                if (cadusuario == "SIM") { usuárioToolStripMenuItem.Enabled = true; } else { usuárioToolStripMenuItem.Enabled = false; }

                cadcliente = tabela.Rows[0]["ctrl_cadcliente"].ToString();
                if (cadcliente == "SIM") { clienteToolStripMenuItem.Enabled = true; } else { clienteToolStripMenuItem.Enabled = false; }

                cadfornecedor = tabela.Rows[0]["ctrl_cadfornecedor"].ToString();
                if (cadfornecedor == "SIM") { fornecedorToolStripMenuItem.Enabled = true; } else { fornecedorToolStripMenuItem.Enabled = false; }

                cadtipopagto = tabela.Rows[0]["ctrl_cadtipopagto"].ToString();
                if (cadtipopagto == "SIM") { tipoDePagamentoToolStripMenuItem.Enabled = true; } else { tipoDePagamentoToolStripMenuItem.Enabled = false; }

                cadcompra = tabela.Rows[0]["ctrl_compra"].ToString();
                if (cadcompra == "SIM") { compraToolStripMenuItem.Enabled = true; } else { compraToolStripMenuItem.Enabled = false; }

                cadvenda = tabela.Rows[0]["ctrl_venda"].ToString();
                if (cadvenda == "SIM") { vendaToolStripMenuItem.Enabled = true; } else { vendaToolStripMenuItem.Enabled = false; }

                recebimento = tabela.Rows[0]["ctrl_recebimento"].ToString();
                if (recebimento == "SIM") { recebimentoToolStripMenuItem.Enabled = true; } else { recebimentoToolStripMenuItem.Enabled = false; }

                pagamento = tabela.Rows[0]["ctrl_pagamento"].ToString();
                if (pagamento == "SIM") { pagamentoToolStripMenuItem.Enabled = true; } else { pagamentoToolStripMenuItem.Enabled = false; }

                concat = tabela.Rows[0]["ctrl_consultacat"].ToString();
                if (concat == "SIM") { categoriaToolStripMenuItem1.Enabled = true; } else { categoriaToolStripMenuItem1.Enabled = false; }

                conscat = tabela.Rows[0]["ctrl_consultascat"].ToString();
                if (conscat == "SIM") { subCategoriaToolStripMenuItem1.Enabled = true; } else { subCategoriaToolStripMenuItem1.Enabled = false; }

                conunidmed = tabela.Rows[0]["ctrl_consultaunidmed"].ToString();
                if (conunidmed == "SIM") { unidadeDeMedidaToolStripMenuItem1.Enabled = true; } else { unidadeDeMedidaToolStripMenuItem1.Enabled = false; }

                conproduto = tabela.Rows[0]["ctrl_consultaproduto"].ToString();
                if (conproduto == "SIM") { produtoToolStripMenuItem1.Enabled = true; } else { produtoToolStripMenuItem1.Enabled = false; }

                conusuario = tabela.Rows[0]["ctrl_consultausuario"].ToString();
                if (conusuario == "SIM") { usuárioToolStripMenuItem1.Enabled = true; } else { usuárioToolStripMenuItem1.Enabled = false; }

                concliente = tabela.Rows[0]["ctrl_consultacliente"].ToString();
                if (concliente == "SIM") { clienteToolStripMenuItem1.Enabled = true; } else { clienteToolStripMenuItem1.Enabled = false; }

                confornecedor = tabela.Rows[0]["ctrl_consultafornecedor"].ToString();
                if (confornecedor == "SIM") { fornecedorToolStripMenuItem1.Enabled = true; } else { fornecedorToolStripMenuItem1.Enabled = false; }

                contipopagto = tabela.Rows[0]["ctrl_consultatipopagto"].ToString();
                if (contipopagto == "SIM") { tipoDePagamentoToolStripMenuItem1.Enabled = true; } else { tipoDePagamentoToolStripMenuItem1.Enabled = false; }

                concompra = tabela.Rows[0]["ctrl_consultacompra"].ToString();
                if (concompra == "SIM"){
                    compraToolStripMenuItem1.Enabled = true;
                    btn_consulta_compra.Enabled = true;
                }
                else {
                    compraToolStripMenuItem1.Enabled = false;
                    btn_consulta_compra.Enabled = false;
                }

                convenda = tabela.Rows[0]["ctrl_consultavenda"].ToString();
                if (convenda == "SIM") {
                    vendaToolStripMenuItem1.Enabled = true;
                    btn_consulta_venda.Enabled = true;
                } else {
                    vendaToolStripMenuItem1.Enabled = false;
                    btn_consulta_venda.Enabled = false;
                }

                configbd = tabela.Rows[0]["ctrl_configbd"].ToString();
                if (configbd == "SIM") { configuraçãoDoBancoDeDadosToolStripMenuItem.Enabled = true; } else { configuraçãoDoBancoDeDadosToolStripMenuItem.Enabled = false; }

                backupbd = tabela.Rows[0]["ctrl_backupbd"].ToString();
                if (backupbd == "SIM") { backupDoBancoDeDadosToolStripMenuItem.Enabled = true; } else { backupDoBancoDeDadosToolStripMenuItem.Enabled = false; }

                relproduto = tabela.Rows[0]["ctrl_relatorioproduto"].ToString();
                if (relproduto == "SIM") { produtoToolStripMenuItem2.Enabled = true; } else { produtoToolStripMenuItem2.Enabled = false; }

                relcliente = tabela.Rows[0]["ctrl_relatoriocliente"].ToString();
                if (relcliente == "SIM") { clienteToolStripMenuItem2.Enabled = true; } else { clienteToolStripMenuItem2.Enabled = false; }

                relfornecedor = tabela.Rows[0]["ctrl_relatoriofornecedor"].ToString();
                if (relfornecedor == "SIM") { fornecedorToolStripMenuItem2.Enabled = true; } else { fornecedorToolStripMenuItem2.Enabled = false; }

                relcompra = tabela.Rows[0]["ctrl_relatoriocompra"].ToString();
                if (relcompra == "SIM") { compraToolStripMenuItem2.Enabled = true; } else { compraToolStripMenuItem2.Enabled = false; }

                relvenda = tabela.Rows[0]["ctrl_relatoriovenda"].ToString();
                if (relvenda == "SIM") { vendaToolStripMenuItem2.Enabled = true; } else { compraToolStripMenuItem2.Enabled = false; }

                word = tabela.Rows[0]["ctrl_word"].ToString();
                if (word == "SIM") { microsoftWordToolStripMenuItem.Enabled = true; } else { microsoftWordToolStripMenuItem.Enabled = false; }

                excel = tabela.Rows[0]["ctrl_excel"].ToString();
                if (excel == "SIM") { microsoftExcelToolStripMenuItem.Enabled = true; } else { microsoftExcelToolStripMenuItem.Enabled = false; }

                bloconotas = tabela.Rows[0]["ctrl_bloconotas"].ToString();
                if (bloconotas == "SIM") { blocoDeNotasToolStripMenuItem.Enabled = true; } else { microsoftExcelToolStripMenuItem.Enabled = false; }

                calculadora = tabela.Rows[0]["ctrl_calculadora"].ToString();
                if (calculadora == "SIM") { calculadoraToolStripMenuItem.Enabled = true; } else { calculadoraToolStripMenuItem.Enabled = false; }
            }
        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);

            //log de saida
            ModeloLogUsuario modelo = new ModeloLogUsuario();
            modelo.LogCod = this.codlog;
            modelo.LogTempSaida = DateTime.Now;
            modelo.UsuCod = this.coduser;
            BLLLogUsuario bllu = new BLLLogUsuario(cx);
            bllu.Saida(modelo);
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void subCategoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeDeMedida f = new frmConsultaUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProduto f = new frmCadastroProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void configuraçãoDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void backupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackupBancoDeDados f = new frmBackupBancoDeDados();
            f.ShowDialog();
            f.Dispose();
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }
     
        public void ContParcela() {
            //contador de parcelas a receber e a pagar
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLParcelasCompra bllc = new BLLParcelasCompra(cx);
            BLLParcelasVenda bllv = new BLLParcelasVenda(cx);

            int qtdeparccompra = bllc.ContadorDeParcelas();
            int qtdeparcvenda = bllv.ContadorDeParcelas();

            lb_qtdec.Text = qtdeparccompra.ToString();
            lb_qtdev.Text = qtdeparcvenda.ToString();
        }

        private void tipoDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoPagamento f = new frmCadastroTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTipoPagamento f = new frmConsultaTipoPagamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedor f = new frmCadastroFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre f = new frmSobre();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCompra f = new frmCadastroCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamentoCompra f = new frmPagamentoCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVenda f = new frmCadastroVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void recebimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecebimentoVenda f = new frmRecebimentoVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void btn_consulta_compra_Click(object sender, EventArgs e)
        {
            frmConsultaCompra f = new frmConsultaCompra();
            f.ShowDialog();
            f.Dispose();
            this.ContParcela();
        }

        private void btn_consulta_venda_Click(object sender, EventArgs e)
        {
            frmConsultaVenda f = new frmConsultaVenda();
            f.ShowDialog();
            f.Dispose();
            this.ContParcela();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            this.ContParcela();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente f = new frmRelatorioCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioFornecedor f = new frmRelatorioFornecedor();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioProduto f = new frmRelatorioProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void compraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioCompra f = new frmRelatorioCompra();
            f.ShowDialog();
            f.Dispose();
        }

        private void vendaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda f = new frmRelatorioVenda();
            f.ShowDialog();
            f.Dispose();
        }

        private void frm_principal_MouseMove(object sender, MouseEventArgs e)
        {
            this.ContParcela();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario f = new frmCadastroUsuario();
            f.ShowDialog();
            f.Dispose();
        }

        private void nívelDeAcessoToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmControleAcesso f = new frmControleAcesso();
           f.ShowDialog();
            f.Dispose();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            f.Dispose();
        }
 
    }
}
