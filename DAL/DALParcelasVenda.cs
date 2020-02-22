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
    public class DALParcelasVenda
    {
        private DALConexao conexao;

        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO parcelasvenda (pve_cod,pve_valor,pve_datavecto, ven_cod) VALUES (@codigo,@valor,@datavecto,@vencod);";
                cmd.Parameters.AddWithValue("@codigo", modelo.PveCod);
                cmd.Parameters.AddWithValue("@valor", modelo.PveValor);         
                cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
                cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@datavecto"].Value = modelo.PveDataVecto;

                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void EfetuaRecebimentoParcela(int pvecod, int vencod, DateTime dtpagto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE parcelasvenda SET pve_datapagto = @datapagto WHERE pve_cod = @codigo AND ven_cod = @vencod;";
            cmd.Parameters.AddWithValue("@codigo", pvecod);
            cmd.Parameters.AddWithValue("@vencod", vencod);
            cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);
            cmd.Parameters["@datapagto"].Value = dtpagto;
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE parcelasvenda SET pve_valor = @valor, pve_datapagto = @datapagto, pve_datavecto = @datavecto" +
                    "WHERE pve_cod = @codigo AND ven_cod = @vencod;";
                cmd.Parameters.AddWithValue("@codigo", modelo.PveCod);
                cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
                cmd.Parameters.AddWithValue("@valor", modelo.PveValor);
                cmd.Parameters.Add("@datavecto", System.Data.SqlDbType.Date);
                cmd.Parameters["@datavecto"].Value = modelo.PveDataVecto;
                cmd.Parameters.Add("@datapagto", System.Data.SqlDbType.Date);

                if (modelo.PveDataPagto == null)
                {
                    cmd.Parameters["@datapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["@datapagto"].Value = modelo.PveDataPagto;
                }               
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }  
        }

        public void Excluir(ModeloParcelasVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM parcelasvenda WHERE pve_cod = @codigo AND ven_cod = @vencod;";
            cmd.Parameters.AddWithValue("@codigo", modelo.PveCod);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
   
            cmd.ExecuteNonQuery();          
        }

        public void ExcluirTodasAsParcelas(int valor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM parcelasvenda WHERE ven_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", valor);
            
            cmd.ExecuteNonQuery();         
        }

        public DataTable LocalizarPorVenda(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM parcelasvenda WHERE ven_cod =" + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int LocalizarParcelasPagas(int valor)
        {
            int quantidade = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT count(ven_cod) FROM parcelasvenda WHERE pve_datapagto is not null AND ven_cod = @codigo";
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
            cmd.CommandText = "SELECT count(ven_cod) FROM parcelasvenda WHERE pve_datapagto is null " +
                " and pve_datavecto BETWEEN '2018-01-01' AND DATEADD(DAY, 1, CAST(getdate()as date)) ";
            conexao.Conectar();
            quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

            return quantidade;
        }

        public ModeloParcelasVenda CarregaModeloParcelasVenda(int pvecod, int vencod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM parcelasvenda WHERE pve_cod = @codigo AND ven_cod = @vencod";
            cmd.Parameters.AddWithValue("@codigo", pvecod);
            cmd.Parameters.AddWithValue("@vencod", vencod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.PveCod = Convert.ToInt32(registro["pve_cod"]);
                modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
                modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
