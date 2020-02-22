using BLL;
using DAL;
using Modelo;
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
    public partial class frmControleAcesso : Form
    {     
        public frmControleAcesso()
        {
            InitializeComponent();
        }

        private void rb_gerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_gerente.Checked == true)
            {
                lb_nome.Text = "Gerente";
                this.CarregaNivelAcesso();   
            }
            else
            {
                lb_nome.Text = "Vendedor";
                this.CarregaNivelAcesso();
            }
        }

        private void CarregaNivelAcesso()
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLControleAcesso bll = new BLLControleAcesso(cx);
            ModeloControleAcesso modelo;
            if (rb_gerente.Checked == true)
            {
                modelo = bll.CarregaModeloControleAcesso(2);
            }
            else
            {
                modelo = bll.CarregaModeloControleAcesso(3);
            }

            txt_cod.Text = modelo.CtrlCod.ToString();
            cb_cadastrocat.Text = modelo.CtrlCadCat;
            cb_cadastrosubcat.Text = modelo.CtrlCadScat;
            cb_cadastrounidmed.Text = modelo.CtrlCadUnidMed;
            cb_cadastroprod.Text = modelo.CtrlCadProduto;
            cb_cadastrousuario.Text = modelo.CtrlCadUsuario;
            cb_cadastrocliente.Text = modelo.CtrlCadCliente;
            cb_cadastrofornecedor.Text = modelo.CtrlCadFornecedor;
            cb_cadastrotipopagto.Text = modelo.CtrlCadTipoPagto;
            cb_compra.Text = modelo.CtrlCompra;
            cb_venda.Text = modelo.CtrlVenda;
            cb_recebimento.Text = modelo.CtrlRecebimento;
            cb_pagamento.Text = modelo.CtrlPagamento;
            cb_consultacat.Text = modelo.CtrlConsultaCat;
            cb_consultasubcat.Text = modelo.CtrlConsultaScat;
            cb_consultaunidmed.Text = modelo.CtrlConsultaUnidMed;
            cb_consultaprod.Text = modelo.CtrlConsultaProduto;
            cb_consultausuario.Text = modelo.CtrlConsultaUsuario;
            cb_consultacliente.Text = modelo.CtrlConsultaCliente;
            cb_consultafornecedor.Text = modelo.CtrlConsultaFornecedor;
            cb_consultatipopagto.Text = modelo.CtrlConsultaTipoPagto;
            cb_consultacompra.Text = modelo.CtrlConsultaCompra;
            cb_consultavenda.Text = modelo.CtrlConsultaVenda;
            cb_configbd.Text = modelo.CtrlConfigBD;
            cb_backupbd.Text = modelo.CtrlBackupBD;
            cb_relatorioproduto.Text = modelo.CtrlRelatorioProduto;
            cb_relatoriocliente.Text = modelo.CtrlRelatorioCliente;
            cb_relatoriofornecedor.Text = modelo.CtrlRelatorioFornecedor;
            cb_relatoriocompra.Text = modelo.CtrlRelatorioCompra;
            cb_relatoriovenda.Text = modelo.CtrlRelatorioVenda;
            cb_word.Text = modelo.CtrlWord;
            cb_excel.Text = modelo.CtrlExcel;
            cb_bloconotas.Text = modelo.CtrlBlocoNotas;
            cb_calculadora.Text = modelo.CtrlCalculadora;
        }


        private void frmNivelAcesso_Load(object sender, EventArgs e)
        {
            this.CarregaNivelAcesso();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloControleAcesso modelo = new ModeloControleAcesso();
                modelo.CtrlCod = Convert.ToInt32(txt_cod.Text);
                if (rb_gerente.Checked == true)
                {
                    modelo.NivCod = 2;
                }
                else
                {
                    modelo.NivCod = 3;
                }
                modelo.CtrlCadScat = cb_cadastrosubcat.Text;
                modelo.CtrlCadUnidMed = cb_cadastrounidmed.Text;
                modelo.CtrlCadProduto = cb_cadastroprod.Text;
                modelo.CtrlCadUsuario = cb_cadastrousuario.Text;
                modelo.CtrlCadCliente = cb_cadastrocliente.Text;
                modelo.CtrlCadFornecedor = cb_cadastrofornecedor.Text;
                modelo.CtrlCadTipoPagto = cb_cadastrotipopagto.Text;
                modelo.CtrlCompra = cb_compra.Text;
                modelo.CtrlVenda = cb_venda.Text;
                modelo.CtrlRecebimento = cb_recebimento.Text;
                modelo.CtrlPagamento = cb_pagamento.Text;
                modelo.CtrlConsultaCat = cb_consultacat.Text;
                modelo.CtrlConsultaScat = cb_consultasubcat.Text;
                modelo.CtrlConsultaUnidMed = cb_consultaunidmed.Text;
                modelo.CtrlConsultaProduto = cb_consultaprod.Text;
                modelo.CtrlConsultaUsuario = cb_consultausuario.Text;
                modelo.CtrlConsultaCliente = cb_consultacliente.Text;
                modelo.CtrlConsultaFornecedor = cb_consultafornecedor.Text;
                modelo.CtrlConsultaTipoPagto = cb_consultatipopagto.Text;
                modelo.CtrlConsultaCompra = cb_consultacompra.Text;
                modelo.CtrlConsultaVenda = cb_consultavenda.Text;
                modelo.CtrlConfigBD = cb_configbd.Text;
                modelo.CtrlBackupBD = cb_backupbd.Text;
                modelo.CtrlRelatorioProduto = cb_relatorioproduto.Text;
                modelo.CtrlRelatorioCliente = cb_relatoriocliente.Text;
                modelo.CtrlRelatorioFornecedor = cb_relatoriofornecedor.Text;
                modelo.CtrlRelatorioCompra = cb_relatoriocompra.Text;
                modelo.CtrlRelatorioVenda = cb_relatoriovenda.Text;
                modelo.CtrlWord = cb_word.Text;
                modelo.CtrlExcel = cb_excel.Text;
                modelo.CtrlBlocoNotas = cb_bloconotas.Text;
                modelo.CtrlCalculadora = cb_calculadora.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLControleAcesso bll = new BLLControleAcesso(cx);
                //alterar controle de acesso   
                modelo.CtrlCadCat = cb_cadastrocat.Text;
                bll.Alterar(modelo);
                MessageBox.Show("Controle alterado.");            
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }       
        }
    }
}
