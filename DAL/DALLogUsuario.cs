using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLogUsuario
    {
        private DALConexao conexao;

        public DALLogUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Entrada(ModeloLogUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO logusuario (log_tempentrada,usu_cod) VALUES (@entrada,@usucod); SELECT @@IDENTITY;";
            cmd.Parameters.Add("@entrada", System.Data.SqlDbType.DateTime);
            cmd.Parameters["@entrada"].Value = modelo.LogTempEntrada;
            cmd.Parameters.AddWithValue("@usucod", modelo.UsuCod);
            conexao.Conectar();
            modelo.LogCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();

        }

        public void Saida(ModeloLogUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE logusuario SET log_tempsaida = @saida WHERE log_cod = @codigo;";
            cmd.Parameters.AddWithValue("@saida", modelo.LogTempSaida);
            cmd.Parameters.AddWithValue("@codigo", modelo.LogCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }
}
