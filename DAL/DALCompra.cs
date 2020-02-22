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
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO compra (com_data, com_nfiscal, com_total, com_nparcelas, com_status, for_cod, tpa_cod)"+
                    " VALUES (@comdata,@comnfiscal,@comtotal,@comnparcelas,@comstatus,@forcod,@tpacod); SELECT @@IDENTITY;";             
                cmd.Parameters.Add("@comdata", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@comdata"].Value  = modelo.ComData;              
                cmd.Parameters.AddWithValue("@comnfiscal", modelo.ComNotafiscal);
                cmd.Parameters.AddWithValue("@comtotal", modelo.ComTotal);
                cmd.Parameters.AddWithValue("@comnparcelas", modelo.ComNparcelas);
                cmd.Parameters.AddWithValue("@comstatus", modelo.ComStatus);
                cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
                cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
                //conexao.Conectar();
                modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            //finally
            //{
            //    conexao.Desconectar();
            //}
        }

        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE compra SET com_data=@comdata, com_nfiscal=@comnfiscal, com_total=@comtotal, com_nparcelas=@comnparcelas,"+
                    " com_status=@comstatus, for_cod=@forcod, tpa_cod=@tpacod WHERE com_cod = @codigo;";
                cmd.Parameters.Add("@comdata", System.Data.SqlDbType.DateTime);
                cmd.Parameters["@comdata"].Value = modelo.ComData;

                cmd.Parameters.AddWithValue("@comnfiscal", modelo.ComNotafiscal);
                cmd.Parameters.AddWithValue("@comtotal", modelo.ComTotal);
                cmd.Parameters.AddWithValue("@comnparcelas", modelo.ComNparcelas);
                cmd.Parameters.AddWithValue("@comstatus", modelo.ComStatus);
                cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
                cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
                cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);
              
                //conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            //finally
            //{
            //    conexao.Desconectar();
            //}
        }
        //não está em uso
        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM compra WHERE com_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                //conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            //finally
            //{
            //    conexao.Desconectar();
            //}
        }
        public void Cancelar(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE compra SET com_status='INATIVA' WHERE com_cod = @codigo; ";
                cmd.Parameters.AddWithValue("@codigo", codigo);
               // conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            //finally
            //{
            //    conexao.Desconectar();
            //}
        }
        //todos
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_status,f.for_nome,c.com_total, t.tpa_nome " +
                " FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod where c.com_status <> 'INATIVA' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //código da compra
        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_status, f.for_nome,c.com_total, t.tpa_nome " +
                " FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                " WHERE c.com_status <> 'INATIVA' and c.com_cod = " + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //cod fornecedor
        public DataTable LocalizarPorFornecedor(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_status, f.for_nome,c.com_total, t.tpa_nome " +
                " FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                " WHERE  c.com_status <> 'INATIVA' and f.for_cod =" + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //parcelas não quitadas
        public DataTable LocalizarPorParcelas()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT c.com_cod, c.com_data, c.com_nfiscal, p.pco_datavecto, p.pco_valor, c.com_nparcelas, c.com_status,f.for_nome," +
                " c.com_total, t.tpa_nome FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                " inner join parcelascompra p ON p.com_cod = c.com_cod " +
                " WHERE  c.com_status <> 'INATIVA' and p.pco_datapagto IS NULL", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        //compras canceladas
        public DataTable LocalizarPorCancelada()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_status,f.for_nome,c.com_total, t.tpa_nome " +
                " FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod where c.com_status = 'INATIVA' ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        //data
        public DataTable Localizar(DateTime inicio, DateTime fim)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_status,f.for_nome,c.com_total, t.tpa_nome " +
                " FROM compra c inner join fornecedor f ON c.for_cod = f.for_cod inner join tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                " WHERE  c.com_status <> 'INATIVA'  and c.com_data BETWEEN @dtinicio AND @dtfim";
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

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM compra WHERE com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]); //ou codigo;
                modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                modelo.ComNotafiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                modelo.ComNparcelas = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus = Convert.ToString(registro["com_status"]);              
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
