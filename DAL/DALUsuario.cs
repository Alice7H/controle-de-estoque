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
    public class DALUsuario
    {
        private DALConexao conexao;

        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "INSERT INTO usuario (usu_nome, usu_senha, usu_status, niv_cod) VALUES (@nome, @senha, @status, @nivel); SELECT @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@status", modelo.UsuStatus);
            cmd.Parameters.AddWithValue("@nivel", modelo.NivCod);
            conexao.Conectar();
            modelo.UsuCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }
        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE usuario SET usu_nome = @nome, usu_senha=@senha, usu_status=@status, niv_cod=@nivel WHERE usu_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.UsuNome);
            cmd.Parameters.AddWithValue("@senha", modelo.UsuSenha);
            cmd.Parameters.AddWithValue("@status", modelo.UsuStatus);
            cmd.Parameters.AddWithValue("@nivel", modelo.NivCod);
            cmd.Parameters.AddWithValue("@codigo", modelo.UsuCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Cancelar(int codigo)
        {       
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "UPDATE usuario SET usu_status='INATIVO' WHERE usu_cod = @codigo; ";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.usu_cod,u.usu_nome,u.usu_senha,n.niv_nome, u.usu_status " +
            "from usuario as u inner join nivelacesso as n on u.niv_cod = n.niv_cod WHERE usu_nome LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Localizar(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select u.usu_cod,u.usu_nome,u.usu_senha,n.niv_nome, u.usu_status"+
            "from usuario as u inner join nivelacesso as n on u.niv_cod = n.niv_cod WHERE usu_cod = "+ valor.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public int LocalizarUsuario(string nome, string senha, string nivel)
        {
            int quantidade = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT count(usu_cod) FROM usuario WHERE usu_nome = @nome and usu_senha = @senha and niv_cod = @nivel";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            conexao.Conectar();
            quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return quantidade;
        }

        public int LocalizarCodigo(string nome, string senha, string nivel)
        {         
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT usu_cod FROM usuario WHERE usu_nome = @nome and usu_senha = @senha and niv_cod = @nivel";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            conexao.Conectar();
            int cod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
            return cod;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM usuario WHERE usu_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsuCod = Convert.ToInt32(registro["usu_cod"]);
                modelo.UsuNome = Convert.ToString(registro["usu_nome"]);
                modelo.UsuSenha = Convert.ToString(registro["usu_senha"]);
                modelo.NivCod = Convert.ToInt32(registro["niv_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
