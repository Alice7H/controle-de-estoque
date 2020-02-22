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
    public class DALNivelAcesso
    {
        private DALConexao conexao;

        public DALNivelAcesso(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM nivelacesso WHERE niv_cod =" + valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM nivelacesso WHERE niv_nome LIKE '%" + valor +"%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
