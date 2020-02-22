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
    public class BLLSubCategoria
    {
        private DALConexao conexao;

        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório.");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }
            modelo.SCatNome = modelo.SCatNome.ToUpper();

            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }
            if (modelo.SCatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório.");
            }
            if (modelo.SCatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da subcategoria é obrigatório.");
            }
            modelo.SCatNome = modelo.SCatNome.ToUpper();

            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarPorCategoria(int valor)
        {
            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            return DALObj.LocalizarPorCategoria(valor);
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DALObj = new DALSubCategoria(conexao);
            return DALObj.CarregaModeloSubCategoria(codigo);
        }
    }
}
