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
    public class DALParcelasCompra
    {
        private DALConexao conexao;
   
        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO parcelascompra (pco_cod,pco_valor,pco_datavecto, com_cod) VALUES (@codigo,@valor,@datavecto,@comcod);";
                cmd.Parameters.AddWithValue("@codigo", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@valor", modelo.PcoValor);
                cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@datavecto"].Value = modelo.PcoDataVecto;
                cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
             
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

        public void EfetuaPagamentoParcela(int pcocod, int comcod, DateTime dtpagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE parcelascompra SET pco_datapagto = @datapagto WHERE pco_cod = @codigo AND com_cod = @comcod;";
            cmd.Parameters.AddWithValue("@codigo", pcocod);
            cmd.Parameters.AddWithValue("@comcod", comcod);
            cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@datapagto"].Value = dtpagto;
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE parcelascompra SET pco_valor = @valor, pco_datapagto = @datapagto, pco_datavecto = @datavecto"+
                    "WHERE pco_cod = @codigo AND com_cod = @comcod;";
                cmd.Parameters.AddWithValue("@codigo", modelo.PcoCod);
                cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@valor", modelo.PcoValor);
                cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@datavecto"].Value = modelo.PcoDataVecto;
                cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);

                if (modelo.PcoDataPagto == null)
                {
                    cmd.Parameters["@datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@datapagto"].Value = modelo.PcoDataPagto;
                }
                                
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

        public void Excluir(ModeloParcelasCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM parcelascompra WHERE pco_cod = @codigo AND com_cod = @comcod;";
            cmd.Parameters.AddWithValue("@codigo", modelo.PcoCod);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.ExecuteNonQuery();
        }

        public void ExcluirTodasAsParcelas(int valor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM parcelascompra WHERE com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", valor);
            cmd.ExecuteNonQuery();
        }

        public DataTable LocalizarPorCompra(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM parcelascompra WHERE com_cod =" + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int LocalizarParcelasPagas(int valor)
        {
            int quantidade = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;     
            cmd.CommandText = "SELECT count(com_cod) FROM parcelascompra WHERE pco_datapagto is not null AND com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", valor);
            conexao.Conectar();
            quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return quantidade;
        }
        public int ContadorDeParcelas()
        {
            int quantidade = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT count(com_cod) FROM parcelascompra WHERE pco_datapagto is null " +
                "and pco_datavecto BETWEEN '2018-01-01' AND DATEADD(DAY, 1, CAST(getdate() as date)) ";          
            conexao.Conectar();
            quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return quantidade;
        }

        public ModeloParcelasCompra CarregaModeloParcelasCompra(int pcocod, int comcod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM parcelascompra WHERE pco_cod = @codigo AND com_cod = @comcod";
            cmd.Parameters.AddWithValue("@codigo", pcocod);
            cmd.Parameters.AddWithValue("@comcod", comcod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PcoCod = Convert.ToInt32(registro["pco_cod"]);
                modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
                modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
                modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
