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
    public class DALItensVenda
    {
        private DALConexao conexao;

        public DALItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO itensvenda (itv_cod, itv_qtde, itv_valor, ven_cod, pro_cod) VALUES (@codigo, @qtde, @valor, @vencod,@procod);";
                cmd.Parameters.AddWithValue("@codigo", modelo.ItvCod);
                cmd.Parameters.AddWithValue("@qtde", modelo.ItvQtde);
                cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
                cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
                cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Alterar(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "UPDATE itensvenda SET itv_qtde = @qtde, itv_valor = @valor " +
                " WHERE itv_cod = @codigo AND ven_cod = @vencod AND pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@qtde", modelo.ItvQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItvValor);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ItvCod);
      
            cmd.ExecuteNonQuery();  
        }

        public void Excluir(ModeloItensVenda modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM itensvenda WHERE itv_cod = @codigo AND ven_cod = @vencod AND pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@codigo", modelo.ItvCod);
            cmd.Parameters.AddWithValue("@vencod", modelo.VenCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);

            cmd.ExecuteNonQuery();    
        }

        public void ExcluirTodos(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM itensvenda WHERE ven_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();
        }

        public DataTable LocalizarPorVenda(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT i.itv_cod,i.ven_cod, i.pro_cod, p.pro_nome, i.itv_qtde, i.itv_valor " +
            " FROM itensvenda i INNER JOIN produto p ON i.pro_cod = p.pro_cod WHERE i.ven_cod = " + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensVenda CarregaModeloItensVenda(int itvCod, int venCod, int proCod)
        {
            ModeloItensVenda modelo = new ModeloItensVenda();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM itensvenda WHERE itv_cod = @codigo AND ven_cod = @vencod AND pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@codigo", itvCod);
            cmd.Parameters.AddWithValue("@vencod", venCod);
            cmd.Parameters.AddWithValue("@procod", proCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItvCod = Convert.ToInt32(registro["itv_cod"]);//itvCod;
                modelo.ItvQtde = Convert.ToDouble(registro["itv_qtde"]);
                modelo.ItvValor = Convert.ToDouble(registro["itv_valor"]);
                modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);//comCod;
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);//proCod;
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
