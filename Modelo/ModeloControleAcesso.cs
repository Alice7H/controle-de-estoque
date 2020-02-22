using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloControleAcesso
    {
        private int ctrl_cod;
        private int niv_cod;
        private string ctrl_cadcat;
        private string ctrl_cadscat;
        private string ctrl_cadunidmed;
        private string ctrl_cadproduto;
        private string ctrl_cadusuario;
        private string ctrl_cadcliente;
        private string ctrl_cadfornecedor;
        private string ctrl_cadtipopagto;
        private string ctrl_compra;
        private string ctrl_venda;
        private string ctrl_recebimento;
        private string ctrl_pagamento;
        private string ctrl_consultacat;
        private string ctrl_consultascat;
        private string ctrl_consultaunidmed;
        private string ctrl_consultaproduto;
        private string ctrl_consultausuario;
        private string ctrl_consultacliente;
        private string ctrl_consultafornecedor;
        private string ctrl_consultatipopagto;
        private string ctrl_consultacompra;
        private string ctrl_consultavenda;
        private string ctrl_configbd;
        private string ctrl_backupbd;
        private string ctrl_relatorioproduto;
        private string ctrl_relatoriocliente;
        private string ctrl_relatoriofornecedor;
        private string ctrl_relatoriocompra;
        private string ctrl_relatoriovenda;
        private string ctrl_word;
        private string ctrl_excel;
        private string ctrl_bloconotas;
        private string ctrl_calculadora;

        public ModeloControleAcesso()
        {
            this.CtrlCod = 0;
            this.NivCod = 0;
            this.CtrlCadCat = "";
            this.CtrlCadScat = "";
            this.CtrlCadUnidMed = "";
            this.CtrlCadProduto = "";
            this.CtrlCadUsuario = "";
            this.CtrlCadCliente = "";
            this.CtrlCadFornecedor = "";
            this.CtrlCadTipoPagto = "";
            this.CtrlCompra = "";
            this.CtrlVenda = "";
            this.CtrlRecebimento = "";
            this.CtrlPagamento = "";
            this.CtrlConsultaCat = "";
            this.CtrlConsultaScat = "";
            this.CtrlConsultaUnidMed = "";
            this.CtrlConsultaProduto = "";
            this.CtrlConsultaUsuario = "";
            this.CtrlConsultaCliente = "";
            this.CtrlConsultaFornecedor = "";
            this.CtrlConsultaTipoPagto = "";
            this.CtrlConsultaCompra = "";
            this.CtrlConsultaVenda = "";
            this.CtrlConfigBD = "";
            this.CtrlBackupBD = "";
            this.CtrlRelatorioProduto = "";
            this.CtrlRelatorioCliente = "";
            this.CtrlRelatorioFornecedor = "";
            this.CtrlRelatorioCompra = "";
            this.CtrlRelatorioVenda = "";
            this.CtrlWord = "";
            this.CtrlExcel = "";
            this.CtrlBlocoNotas = "";
            this.CtrlCalculadora = "";
        }
        public ModeloControleAcesso(int cod, int nivcod, string cadcat, string cadscat, string cadunidmed, string cadproduto, string cadusuario, string cadcliente, string cadfornecedor,
            string cadtipopagto, string compra, string venda, string recebimento, string pagamento, string consultacat, string consultascat, string consultaproduto, string consultausuario, string consultacliente, string consultafornecedor,
            string consultatipopagto, string consultacompra, string consultavenda, string configbd, string backupbd, string relatorioproduto, string relatoriocliente, string relatoriofornecedor, string relatoriocompra, string relatoriovenda,
            string word, string excel, string bloconotas, string calculadora)
        {
            this.CtrlCod = cod;
            this.NivCod = nivcod;
            this.CtrlCadCat = cadcat;
            this.CtrlCadScat = cadscat;
            this.CtrlCadUnidMed = cadunidmed;
            this.CtrlCadProduto = cadproduto;
            this.CtrlCadUsuario = cadusuario;
            this.CtrlCadCliente = cadcliente;
            this.CtrlCadFornecedor = cadfornecedor;
            this.CtrlCadTipoPagto = cadtipopagto;
            this.CtrlCompra = compra;
            this.CtrlVenda = venda;
            this.CtrlRecebimento = recebimento;
            this.CtrlPagamento = pagamento;
            this.CtrlConsultaCat = consultacat;
            this.CtrlConsultaScat = consultascat;
            this.CtrlConsultaUnidMed = ctrl_consultaunidmed;
            this.CtrlConsultaProduto = consultaproduto;
            this.CtrlConsultaUsuario = consultausuario;
            this.CtrlConsultaCliente = consultacliente;
            this.CtrlConsultaFornecedor = consultafornecedor;
            this.CtrlConsultaTipoPagto = consultatipopagto;
            this.CtrlConsultaCompra = consultacompra;
            this.CtrlConsultaVenda = consultavenda;
            this.CtrlConfigBD = configbd;
            this.CtrlBackupBD = backupbd;
            this.CtrlRelatorioProduto = relatorioproduto;
            this.CtrlRelatorioCliente = relatoriocliente;
            this.CtrlRelatorioFornecedor = relatoriofornecedor;
            this.CtrlRelatorioCompra = relatoriocompra;
            this.CtrlRelatorioVenda = relatoriovenda;
            this.CtrlWord = word;
            this.CtrlExcel = excel;
            this.CtrlBlocoNotas = bloconotas;
            this.CtrlCalculadora = calculadora;
        }
        public int CtrlCod
        {
            get { return this.ctrl_cod; }
            set { this.ctrl_cod = value; }
        }
        public int NivCod
        {
            get { return this.niv_cod; }
            set { this.niv_cod = value; }
        }
        public string CtrlCadCat 
        {
            get { return this.ctrl_cadcat; }
            set { this.ctrl_cadcat = value; }
        }
        public string CtrlCadScat
        {
            get { return this.ctrl_cadscat; }
            set { this.ctrl_cadscat = value; }
        }
        public string CtrlCadUnidMed
        {
            get { return this.ctrl_cadunidmed; }
            set { this.ctrl_cadunidmed = value; }
        }
        public string CtrlCadProduto
        {
            get { return this.ctrl_cadproduto; }
            set { this.ctrl_cadproduto = value; }
        }
        public string CtrlCadUsuario
        {
            get { return this.ctrl_cadusuario; }
            set { this.ctrl_cadusuario = value; }
        }
        public string CtrlCadCliente
        {
            get { return this.ctrl_cadcliente; }
            set { this.ctrl_cadcliente = value; }
        }
        public string CtrlCadFornecedor
        {
            get { return this.ctrl_cadfornecedor; }
            set { this.ctrl_cadfornecedor = value; }
        }
        public string CtrlCadTipoPagto
        {
            get { return this.ctrl_cadfornecedor; }
            set { this.ctrl_cadfornecedor = value; }
        }
        public string CtrlCompra
        {
            get { return this.ctrl_compra; }
            set { this.ctrl_compra = value; }
        }
        public string CtrlVenda
        {
            get { return this.ctrl_venda; }
            set { this.ctrl_venda = value; }
        }
        public string CtrlRecebimento
        {
            get { return this.ctrl_recebimento; }
            set { this.ctrl_recebimento = value; }
        }
        public string CtrlPagamento
        {
            get { return this.ctrl_pagamento; }
            set { this.ctrl_pagamento = value; }
        }
        public string CtrlConsultaCat
        {
            get { return this.ctrl_consultacat; }
            set { this.ctrl_consultacat = value; }
        }
        public string CtrlConsultaScat
        {
            get { return this.ctrl_consultascat; }
            set { this.ctrl_consultascat = value; }
        }
        public string CtrlConsultaUnidMed
        { 
            get { return this.ctrl_consultaunidmed; }
            set { this.ctrl_consultaunidmed = value; }
        }
        public string CtrlConsultaProduto
        {
            get { return this.ctrl_consultaproduto; }
            set { this.ctrl_consultaproduto = value; }
        }
        public string CtrlConsultaUsuario
        {
            get { return this.ctrl_consultausuario; }
            set { this.ctrl_consultausuario = value; }
        }
        public string CtrlConsultaCliente
        {
            get { return this.ctrl_consultacliente; }
            set { this.ctrl_consultacliente = value; }
        }
        public string CtrlConsultaFornecedor
        {
            get { return this.ctrl_consultafornecedor; }
            set { this.ctrl_consultafornecedor = value; }
        }
        public string CtrlConsultaTipoPagto
        {
            get { return this.ctrl_consultatipopagto; }
            set { this.ctrl_consultatipopagto = value; }
        }
        public string CtrlConsultaCompra
        {
            get { return this.ctrl_consultacompra; }
            set { this.ctrl_consultacompra = value; }
        }
        public string CtrlConsultaVenda
        {
            get { return this.ctrl_consultavenda; }
            set { this.ctrl_consultavenda = value; }
        }
        public string CtrlConfigBD
        {
            get { return this.ctrl_configbd; }
            set { this.ctrl_configbd = value; }
        }
        public string CtrlBackupBD
        {
            get { return this.ctrl_backupbd; }
            set { this.ctrl_backupbd = value; }
        }
        public string CtrlRelatorioProduto
        {
            get { return this.ctrl_relatorioproduto; }
            set { this.ctrl_relatorioproduto = value; }
        }
        public string CtrlRelatorioCliente
        {
            get { return this.ctrl_relatoriocliente; }
            set { this.ctrl_relatoriocliente = value; }
        }
        public string CtrlRelatorioFornecedor
        {
            get { return this.ctrl_relatoriofornecedor; }
            set { this.ctrl_relatoriofornecedor = value; }
        }
        public string CtrlRelatorioCompra
        {
            get { return this.ctrl_relatoriocompra; }
            set { this.ctrl_relatoriocompra = value; }
        }
        public string CtrlRelatorioVenda
        {
            get { return this.ctrl_relatoriovenda; }
            set { this.ctrl_relatoriovenda = value; }
        }
        public string CtrlWord
        {
            get { return this.ctrl_word; }
            set { this.ctrl_word = value; }
        }
        public string CtrlExcel
        {
            get { return this.ctrl_excel; }
            set { this.ctrl_excel = value; }
        }
        public string CtrlBlocoNotas
        {
            get { return this.ctrl_bloconotas; }
            set { this.ctrl_bloconotas = value; }
        }
        public string CtrlCalculadora
        {
            get { return this.ctrl_calculadora; }
            set { this.ctrl_calculadora = value; }
        }


    }
}
