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
    public class DALItensCompra
    {
        private DALConexao conexao;

        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            try
            { 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO itenscompra (itc_cod, itc_qtde, itc_valor, com_cod, pro_cod) VALUES (@codigo, @qtde, @valor, @comcod, @procod);";
                cmd.Parameters.AddWithValue("@codigo", modelo.ItcCod);
                cmd.Parameters.AddWithValue("@qtde", modelo.ItcQtde);
                cmd.Parameters.AddWithValue("@valor", modelo.ItcValor);
                cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
                cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
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
     
        public void Alterar(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;          
            cmd.CommandText = "UPDATE itenscompra SET itc_qtde = @qtde, itc_valor = @valor "+
                " WHERE itc_cod = @codigo AND com_cod = @comcod AND pro_cod = @procod;";    
            cmd.Parameters.AddWithValue("@qtde", modelo.ItcQtde);
            cmd.Parameters.AddWithValue("@valor", modelo.ItcValor);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.ItcCod);
         
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ModeloItensCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM itenscompra WHERE itc_cod = @codigo AND com_cod = @comcod AND pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@codigo", modelo.ItcCod);
            cmd.Parameters.AddWithValue("@comcod", modelo.ComCod);
            cmd.Parameters.AddWithValue("@procod", modelo.ProCod);
          
            cmd.ExecuteNonQuery();
        }
        public void ExcluirTodos(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = conexao.ObjetoTransacao;
            cmd.CommandText = "DELETE FROM itenscompra WHERE com_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            cmd.ExecuteNonQuery();

        }

        public DataTable LocalizarPorCompra(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT i.itc_cod, i.com_cod, i.pro_cod, p.pro_nome, i.itc_qtde, i.itc_valor" + 
            " FROM itenscompra i INNER JOIN produto p ON i.pro_cod = p.pro_cod WHERE i.com_cod = " + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloItensCompra CarregaModeloItensCompra(int itcCod, int comCod, int proCod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM itenscompra WHERE itc_cod = @codigo AND com_cod = @comcod AND pro_cod = @procod;";
            cmd.Parameters.AddWithValue("@codigo", itcCod);
            cmd.Parameters.AddWithValue("@comcod", comCod);
            cmd.Parameters.AddWithValue("@procod", proCod);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ItcCod = Convert.ToInt32(registro["itc_cod"]);//itcCod;
                modelo.ItcQtde = Convert.ToDouble(registro["itc_qtde"]);
                modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);//comCod;
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);//proCod;
            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
