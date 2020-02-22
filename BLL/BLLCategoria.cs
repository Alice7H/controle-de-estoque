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
    //regras de negócio
    public class BLLCategoria
    {
        private DALConexao conexao;

        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório.");
            }
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALObj = new DALCategoria(conexao);
            DALObj.Incluir(modelo);                 
        }
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatório.");
            }
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALObj = new DALCategoria(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCategoria DALObj = new DALCategoria(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCategoria DALObj = new DALCategoria(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALObj = new DALCategoria(conexao);
            return DALObj.CarregaModeloCategoria(codigo);
        }
    }
}
