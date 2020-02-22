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
    public class BLLTipoPagamento
    {
        private DALConexao conexao;
        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório.");
            }
            modelo.TpaNome = modelo.TpaNome.ToUpper();

            DALTipoPagamento DALObj = new DALTipoPagamento(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório.");
            }
            modelo.TpaNome = modelo.TpaNome.ToUpper();

            DALTipoPagamento DALObj = new DALTipoPagamento(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTipoPagamento DALObj = new DALTipoPagamento(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTipoPagamento DALObj = new DALTipoPagamento(conexao);
            return DALObj.Localizar(valor);
        }
   
        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DALTipoPagamento DALObj = new DALTipoPagamento(conexao);
            return DALObj.CarregaModeloTipoPagamento(codigo);
        }
    }
}
