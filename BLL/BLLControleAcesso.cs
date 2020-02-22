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
    public class BLLControleAcesso
    {
        private DALConexao conexao;

        public BLLControleAcesso(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloControleAcesso modelo)
        {
            if (modelo.NivCod <= 0)
            {
                throw new Exception("O código de nível é obrigatório.");
            }      

            DALControleAcesso DALObj = new DALControleAcesso(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloControleAcesso modelo)
        {
            if (modelo.CtrlCod <= 0)
            {
                throw new Exception("O código do controle de acesso é obrigatório.");
            }
            if (modelo.NivCod <= 0)
            {
                throw new Exception("O código do nível de acesso é obrigatório.");
            }

            DALControleAcesso DALObj = new DALControleAcesso(conexao);
            DALObj.Alterar(modelo);
        }
        public DataTable Localizar(int valor)
        {
            DALControleAcesso DALObj = new DALControleAcesso(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloControleAcesso CarregaModeloControleAcesso(int codigo)
        {
            DALControleAcesso DALObj = new DALControleAcesso(conexao);
            return DALObj.CarregaModeloControleAcesso(codigo);
        }
    }
}
