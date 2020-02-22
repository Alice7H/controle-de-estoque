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
    public class DALVenda
    {
        private DALConexao conexao;
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO venda (ven_data, ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod,ven_avista)" +
                    " VALUES (@vendata, @vennfiscal, @ventotal, @vennparcelas, @venstatus, @clicod, @tpacod, @venavista); SELECT @@IDENTITY;";

                cmd.Parameters.Add("@vendata", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@vendata"].Value = modelo.VenData;
                cmd.Parameters.AddWithValue("@vennfiscal", modelo.VenNfiscal);
                cmd.Parameters.AddWithValue("@ventotal", modelo.VenTotal);
                cmd.Parameters.AddWithValue("@vennparcelas", modelo.VenNparcelas);
                cmd.Parameters.AddWithValue("@venstatus", modelo.VenStatus);
                cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@venavista", modelo.VenAvista);

                modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }            
        }

        public void Alterar(ModeloVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;         
                cmd.CommandText = "UPDATE venda SET ven_data=@vendata, ven_nfiscal=@vennfiscal, ven_total=@ventotal, ven_nparcelas=@vennparcelas," +
                    " ven_status=@venstatus, cli_cod=@clicod, tpa_cod=@tpacod, ven_avista = @venavista WHERE ven_cod = @codigo;";
                cmd.Parameters.Add("@vendata", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@vendata"].Value = modelo.VenData;

                cmd.Parameters.AddWithValue("@vennfiscal", modelo.VenNfiscal);
                cmd.Parameters.AddWithValue("@ventotal", modelo.VenTotal);
                cmd.Parameters.AddWithValue("@vennparcelas", modelo.VenNparcelas);
                cmd.Parameters.AddWithValue("@venstatus", modelo.VenStatus);
                cmd.Parameters.AddWithValue("@clicod", modelo.CliCod);
                cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.VenCod);
                cmd.Parameters.AddWithValue("@venavista", modelo.VenAvista);
              
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }        
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM venda WHERE ven_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);               
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }            
        }

        public void Cancelar(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE venda SET ven_status='CANCELADA' WHERE ven_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod  WHERE v.ven_status <> 'CANCELADA'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod " +
                " WHERE v.ven_status <> 'CANCELADA' AND v.ven_cod = " + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCliente(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod  " +
                " WHERE v.ven_status <> 'CANCELADA' AND v.cli_cod = " + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCliente(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod " +
                " WHERE v.ven_status <> 'CANCELADA' AND c.cli_nome LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorParcelas()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, p.pve_datavecto, p.pve_valor,v.ven_nparcelas, v.ven_status, c.cli_nome," +
                " v.ven_total, t.tpa_nome FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod " +
                " inner join parcelasvenda p ON v.ven_cod = p.ven_cod" +
                " WHERE  v.ven_status <> 'CANCELADA' and p.pve_datapagto IS NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarAvista()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod " +
                " WHERE  v.ven_status <> 'CANCELADA' AND  v.ven_avista = 1 ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarPorCancelada()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod  WHERE v.ven_status = 'CANCELADA'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar(DateTime inicio, DateTime fim)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT v.ven_cod, v.ven_data, v.ven_nfiscal, v.ven_avista, v.ven_nparcelas, v.ven_status, c.cli_nome, v.ven_total, t.tpa_nome  " +
                " FROM venda v inner join cliente c ON v.cli_cod = c.cli_cod inner join tipopagamento t ON v.tpa_cod = t.tpa_cod  " +
                " WHERE v.ven_status <> 'CANCELADA' and v.ven_data BETWEEN @dtinicio AND @dtfim";
            cmd.Parameters.Add("@dtinicio", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtinicio"].Value = inicio;
            cmd.Parameters.Add("@dtfim", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@dtfim"].Value = fim;
            conexao.Conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
        }
        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM venda WHERE ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]); //ou codigo;
                modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                modelo.VenNfiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                modelo.VenNparcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                modelo.VenStatus = Convert.ToString(registro["ven_status"]);
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
