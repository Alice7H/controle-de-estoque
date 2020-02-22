using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALControleAcesso
    {
        private DALConexao conexao;

        public DALControleAcesso(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloControleAcesso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO controleacesso (niv_cod, ctrl_cadcat, ctrl_cadscat, ctrl_cadunidmed, ctrl_cadproduto, ctrl_cadusuario, ctrl_cadcliente,"+
            "ctrl_cadfornecedor, ctrl_cadtipopagto, ctrl_compra, ctrl_venda, ctrl_recebimento, ctrl_pagamento, ctrl_consultacat, ctrl_consultascat, ctrl_consultaunidmed,"+
            "ctrl_consultaproduto, ctrl_consultausuario, ctrl_consultacliente, ctrl_consultafornecedor, ctrl_consultatipopagto, ctrl_consultacompra, ctrl_consultavenda, ctrl_configbd, ctrl_backupbd,"+
            "ctrl_relatorioproduto, ctrl_relatoriocliente, ctrl_relatoriofornecedor, ctrl_relatoriocompra, ctrl_relatoriovenda, ctrl_word, ctrl_excel, ctrl_bloconotas, ctrl_calculadora) "+
            "VALUES (@niv_cod, @ctrl_cadcat, @ctrl_cadscat, @ctrl_cadunidmed, @ctrl_cadproduto, @ctrl_cadusuario, @ctrl_cadcliente," +
            "@ctrl_cadfornecedor, @ctrl_cadtipopagto, @ctrl_compra, @ctrl_venda, @ctrl_recebimento, @ctrl_pagamento, @ctrl_consultacat, @ctrl_consultascat, @ctrl_consultaunidmed," +
            "@ctrl_consultaproduto, @ctrl_consultausuario, @ctrl_consultacliente, @ctrl_consultafornecedor, @ctrl_consultatipopagto, @ctrl_consultacompra, @ctrl_consultavenda, @ctrl_configbd, @ctrl_backupbd," +
            "@ctrl_relatorioproduto, @ctrl_relatoriocliente, @ctrl_relatoriofornecedor, @ctrl_relatoriocompra, @ctrl_relatoriovenda, @ctrl_word, @ctrl_excel, @ctrl_bloconotas, @ctrl_calculadora); SELECT @@IDENTITY;";

            cmd.Parameters.AddWithValue("@niv_cod", modelo.NivCod);
            cmd.Parameters.AddWithValue("@ctrl_cadcat", modelo.CtrlCadCat);
            cmd.Parameters.AddWithValue("@ctrl_cadscat", modelo.CtrlCadScat);
            cmd.Parameters.AddWithValue("@ctrl_cadunidmed", modelo.CtrlCadUnidMed);
            cmd.Parameters.AddWithValue("@ctrl_cadproduto", modelo.CtrlCadProduto);
            cmd.Parameters.AddWithValue("@ctrl_cadusuario", modelo.CtrlCadUsuario);
            cmd.Parameters.AddWithValue("@ctrl_cadcliente", modelo.CtrlCadCliente);
            cmd.Parameters.AddWithValue("@ctrl_cadfornecedor", modelo.CtrlCadFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_cadtipopagto", modelo.CtrlCadTipoPagto);
            cmd.Parameters.AddWithValue("@ctrl_compra", modelo.CtrlCompra);
            cmd.Parameters.AddWithValue("@ctrl_venda", modelo.CtrlVenda);
            cmd.Parameters.AddWithValue("@ctrl_recebimento", modelo.CtrlRecebimento);
            cmd.Parameters.AddWithValue("@ctrl_pagamento", modelo.CtrlPagamento);
            cmd.Parameters.AddWithValue("@ctrl_consultacat", modelo.CtrlConsultaCat);
            cmd.Parameters.AddWithValue("@ctrl_consultascat", modelo.CtrlConsultaScat);
            cmd.Parameters.AddWithValue("@ctrl_consultaunidmed", modelo.CtrlConsultaUnidMed);
            cmd.Parameters.AddWithValue("@ctrl_consultaproduto", modelo.CtrlConsultaProduto);
            cmd.Parameters.AddWithValue("@ctrl_consultausuario", modelo.CtrlConsultaUsuario);
            cmd.Parameters.AddWithValue("@ctrl_consultacliente", modelo.CtrlConsultaCliente);
            cmd.Parameters.AddWithValue("@ctrl_consultafornecedor", modelo.CtrlConsultaFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_consultatipopagto", modelo.CtrlConsultaTipoPagto);
            cmd.Parameters.AddWithValue("@ctrl_consultacompra", modelo.CtrlConsultaCompra);
            cmd.Parameters.AddWithValue("@ctrl_consultavenda", modelo.CtrlConsultaVenda);
            cmd.Parameters.AddWithValue("@ctrl_configbd", modelo.CtrlConfigBD);
            cmd.Parameters.AddWithValue("@ctrl_backupbd", modelo.CtrlBackupBD);
            cmd.Parameters.AddWithValue("@ctrl_relatorioproduto", modelo.CtrlRelatorioProduto);
            cmd.Parameters.AddWithValue("@ctrl_relatoriocliente", modelo.CtrlRelatorioCliente);
            cmd.Parameters.AddWithValue("@ctrl_relatoriofornecedor", modelo.CtrlRelatorioFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_relatoriocompra", modelo.CtrlRelatorioCompra);
            cmd.Parameters.AddWithValue("@ctrl_relatoriovenda", modelo.CtrlRelatorioVenda);
            cmd.Parameters.AddWithValue("@ctrl_word", modelo.CtrlWord);
            cmd.Parameters.AddWithValue("@ctrl_excel", modelo.CtrlExcel);
            cmd.Parameters.AddWithValue("@ctrl_bloconotas", modelo.CtrlBlocoNotas);
            cmd.Parameters.AddWithValue("@ctrl_calculadora", modelo.CtrlCalculadora);
            conexao.Conectar();
            modelo.CtrlCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Alterar(ModeloControleAcesso modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE controleacesso SET niv_cod = @niv_cod,ctrl_cadcat = @ctrl_cadcat, ctrl_cadscat = @ctrl_cadscat, ctrl_cadunidmed = @ctrl_cadunidmed, ctrl_cadproduto = @ctrl_cadproduto, ctrl_cadusuario = @ctrl_cadusuario, ctrl_cadcliente = @ctrl_cadcliente," +
            "ctrl_cadfornecedor = @ctrl_cadfornecedor, ctrl_cadtipopagto = @ctrl_cadtipopagto,ctrl_compra = @ctrl_compra, ctrl_venda = @ctrl_venda,ctrl_recebimento = @ctrl_recebimento, ctrl_pagamento = @ctrl_pagamento, ctrl_consultacat = @ctrl_consultacat, ctrl_consultascat = @ctrl_consultascat, ctrl_consultaunidmed = @ctrl_consultaunidmed," +
            "ctrl_consultaproduto = @ctrl_consultaproduto, ctrl_consultausuario = @ctrl_consultausuario, ctrl_consultacliente = @ctrl_consultacliente, ctrl_consultafornecedor = @ctrl_consultafornecedor, ctrl_consultatipopagto = @ctrl_consultatipopagto, ctrl_consultacompra = @ctrl_consultacompra, ctrl_consultavenda = @ctrl_consultavenda, ctrl_configbd = @ctrl_configbd, ctrl_backupbd = @ctrl_backupbd," +
            "ctrl_relatorioproduto = @ctrl_relatorioproduto, ctrl_relatoriocliente = @ctrl_relatoriocliente, ctrl_relatoriofornecedor = @ctrl_relatoriofornecedor, ctrl_relatoriocompra = @ctrl_relatoriocompra, ctrl_relatoriovenda = @ctrl_relatoriovenda,ctrl_word = @ctrl_word, ctrl_excel = @ctrl_excel, ctrl_bloconotas = @ctrl_bloconotas, ctrl_calculadora = @ctrl_calculadora" +
            " WHERE ctrl_cod = @codigo;";       
            cmd.Parameters.AddWithValue("@codigo", modelo.CtrlCod);
            cmd.Parameters.AddWithValue("@niv_cod", modelo.NivCod);
            cmd.Parameters.AddWithValue("@ctrl_cadcat", modelo.CtrlCadCat);
            cmd.Parameters.AddWithValue("@ctrl_cadscat", modelo.CtrlCadScat);
            cmd.Parameters.AddWithValue("@ctrl_cadunidmed", modelo.CtrlCadUnidMed);
            cmd.Parameters.AddWithValue("@ctrl_cadproduto", modelo.CtrlCadProduto);
            cmd.Parameters.AddWithValue("@ctrl_cadusuario", modelo.CtrlCadUsuario);
            cmd.Parameters.AddWithValue("@ctrl_cadcliente", modelo.CtrlCadCliente);
            cmd.Parameters.AddWithValue("@ctrl_cadfornecedor", modelo.CtrlCadFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_cadtipopagto", modelo.CtrlCadTipoPagto);
            cmd.Parameters.AddWithValue("@ctrl_compra", modelo.CtrlCompra);
            cmd.Parameters.AddWithValue("@ctrl_venda", modelo.CtrlVenda);
            cmd.Parameters.AddWithValue("@ctrl_recebimento", modelo.CtrlRecebimento);
            cmd.Parameters.AddWithValue("@ctrl_pagamento", modelo.CtrlPagamento);
            cmd.Parameters.AddWithValue("@ctrl_consultacat", modelo.CtrlConsultaCat);
            cmd.Parameters.AddWithValue("@ctrl_consultascat", modelo.CtrlConsultaScat);
            cmd.Parameters.AddWithValue("@ctrl_consultaunidmed", modelo.CtrlConsultaUnidMed);
            cmd.Parameters.AddWithValue("@ctrl_consultaproduto", modelo.CtrlConsultaProduto);
            cmd.Parameters.AddWithValue("@ctrl_consultausuario", modelo.CtrlConsultaUsuario);
            cmd.Parameters.AddWithValue("@ctrl_consultacliente", modelo.CtrlConsultaCliente);
            cmd.Parameters.AddWithValue("@ctrl_consultafornecedor", modelo.CtrlConsultaFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_consultatipopagto", modelo.CtrlConsultaTipoPagto);
            cmd.Parameters.AddWithValue("@ctrl_consultacompra", modelo.CtrlConsultaCompra);
            cmd.Parameters.AddWithValue("@ctrl_consultavenda", modelo.CtrlConsultaVenda);
            cmd.Parameters.AddWithValue("@ctrl_configbd", modelo.CtrlConfigBD);
            cmd.Parameters.AddWithValue("@ctrl_backupbd", modelo.CtrlBackupBD);
            cmd.Parameters.AddWithValue("@ctrl_relatorioproduto", modelo.CtrlRelatorioProduto);
            cmd.Parameters.AddWithValue("@ctrl_relatoriocliente", modelo.CtrlRelatorioCliente);
            cmd.Parameters.AddWithValue("@ctrl_relatoriofornecedor", modelo.CtrlRelatorioFornecedor);
            cmd.Parameters.AddWithValue("@ctrl_relatoriocompra", modelo.CtrlRelatorioCompra);
            cmd.Parameters.AddWithValue("@ctrl_relatoriovenda", modelo.CtrlRelatorioVenda);
            cmd.Parameters.AddWithValue("@ctrl_word", modelo.CtrlWord);
            cmd.Parameters.AddWithValue("@ctrl_excel", modelo.CtrlExcel);
            cmd.Parameters.AddWithValue("@ctrl_bloconotas", modelo.CtrlBlocoNotas);
            cmd.Parameters.AddWithValue("@ctrl_calculadora", modelo.CtrlCalculadora);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM controleacesso WHERE niv_cod =" + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloControleAcesso CarregaModeloControleAcesso(int codigo)
        {
            ModeloControleAcesso modelo = new ModeloControleAcesso();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM controleacesso WHERE niv_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();           
                modelo.CtrlCod = Convert.ToInt32(registro["ctrl_cod"]);
                modelo.NivCod = Convert.ToInt32(registro["niv_cod"]);
                modelo.CtrlCadCat = Convert.ToString(registro["ctrl_cadcat"]);
                modelo.CtrlCadScat = Convert.ToString(registro["ctrl_cadscat"]);
                modelo.CtrlCadUnidMed = Convert.ToString(registro["ctrl_cadunidmed"]);
                modelo.CtrlCadProduto = Convert.ToString(registro["ctrl_cadproduto"]);
                modelo.CtrlCadUsuario = Convert.ToString(registro["ctrl_cadusuario"]);
                modelo.CtrlCadCliente = Convert.ToString(registro["ctrl_cadcliente"]);
                modelo.CtrlCadFornecedor = Convert.ToString(registro["ctrl_cadfornecedor"]);
                modelo.CtrlCadTipoPagto = Convert.ToString(registro["ctrl_cadtipopagto"]);
                modelo.CtrlCompra = Convert.ToString(registro["ctrl_compra"]);
                modelo.CtrlVenda = Convert.ToString(registro["ctrl_venda"]);
                modelo.CtrlRecebimento = Convert.ToString(registro["ctrl_recebimento"]);
                modelo.CtrlPagamento = Convert.ToString(registro["ctrl_pagamento"]);
                modelo.CtrlConsultaCat = Convert.ToString(registro["ctrl_consultacat"]);
                modelo.CtrlConsultaScat = Convert.ToString(registro["ctrl_consultascat"]);
                modelo.CtrlConsultaUnidMed = Convert.ToString(registro["ctrl_consultaunidmed"]);
                modelo.CtrlConsultaProduto = Convert.ToString(registro["ctrl_consultaproduto"]);
                modelo.CtrlConsultaUsuario = Convert.ToString(registro["ctrl_consultausuario"]);
                modelo.CtrlConsultaCliente = Convert.ToString(registro["ctrl_consultacliente"]);
                modelo.CtrlConsultaFornecedor = Convert.ToString(registro["ctrl_consultafornecedor"]);
                modelo.CtrlConsultaTipoPagto = Convert.ToString(registro["ctrl_consultatipopagto"]);
                modelo.CtrlConsultaCompra = Convert.ToString(registro["ctrl_consultacompra"]);
                modelo.CtrlConsultaVenda = Convert.ToString(registro["ctrl_consultavenda"]);
                modelo.CtrlConfigBD = Convert.ToString(registro["ctrl_configbd"]);
                modelo.CtrlBackupBD = Convert.ToString(registro["ctrl_backupbd"]);
                modelo.CtrlRelatorioProduto = Convert.ToString(registro["ctrl_relatorioproduto"]);
                modelo.CtrlRelatorioCliente = Convert.ToString(registro["ctrl_relatoriocliente"]);
                modelo.CtrlRelatorioFornecedor = Convert.ToString(registro["ctrl_relatoriofornecedor"]);
                modelo.CtrlRelatorioCompra = Convert.ToString(registro["ctrl_compra"]);
                modelo.CtrlRelatorioVenda = Convert.ToString(registro["ctrl_venda"]);
                modelo.CtrlWord = Convert.ToString(registro["ctrl_word"]);
                modelo.CtrlExcel = Convert.ToString(registro["ctrl_excel"]);
                modelo.CtrlBlocoNotas = Convert.ToString(registro["ctrl_bloconotas"]);
                modelo.CtrlCalculadora = Convert.ToString(registro["ctrl_calculadora"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
