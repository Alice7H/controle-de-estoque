using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;

        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória.");
            }

            if (modelo.UsuSenha.Trim().Length <= 5)
            {
                throw new Exception("A senha deve conter pelo menos 6 caracteres.");
            }

            if (modelo.NivCod <= 0)
            {
                throw new Exception("O nível de acesso é obrigatório.");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.UsuCod <= 0)
            {
                throw new Exception("O código do usuário é obrigatório.");
            }
            if (modelo.UsuNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            if (modelo.UsuSenha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória.");
            }

            if (modelo.UsuSenha.Trim().Length <= 5)
            {
                throw new Exception("A senha deve conter pelo menos 6 caracteres.");
            }

            if (modelo.NivCod <= 0)
            {
                throw new Exception("O nível de acesso é obrigatório.");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Alterar(modelo);
        }
        public void Cancelar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código do usuário é obrigatório.");
            }
            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Cancelar(codigo);
        }

        public DataTable Localizar(String valor)
        {        
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable Localizar(int valor)
        { 
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.Localizar(valor);
        }

        public int LocalizarUsuario(string nome, string senha, string nivel)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarUsuario(nome, senha, nivel);
        }

        public int LocalizarCodigo(string nome, string senha, string nivel)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarCodigo(nome, senha, nivel);
        }
    
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregaModeloUsuario(codigo);
        }
    }
}
