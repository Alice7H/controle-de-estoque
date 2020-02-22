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
    public class BLLCompra
    {   
        private DALConexao conexao;

         public BLLCompra(DALConexao cx)
         {
             this.conexao = cx;
         }

        public void Incluir(ModeloCompra modelo)
        {                
            if (modelo.ComData.Year != DateTime.Now.Year && modelo.ComData.Month != DateTime.Now.Month && modelo.ComData.Day != DateTime.Now.Day
                && modelo.ComData.Hour != DateTime.Now.Hour && modelo.ComData.Minute != DateTime.Now.Minute)
            {
                throw new Exception("A data da compra não corresponde a data atual.");
            }
            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que 0.");
            }
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informado.");
            }

            modelo.ComStatus = modelo.ComStatus.ToUpper();

            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório.");
            }
            if (modelo.ComData.Year != DateTime.Now.Year && modelo.ComData.Month != DateTime.Now.Month && modelo.ComData.Day != DateTime.Now.Day
                && modelo.ComData.Hour != DateTime.Now.Hour && modelo.ComData.Minute != DateTime.Now.Minute)
            {
                throw new Exception("A data da compra não corresponde a data atual.");
            }
            if (modelo.ComNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que 0.");
            }
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informado.");
            }

            modelo.ComStatus = modelo.ComStatus.ToUpper();

            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Excluir(codigo);
        }
        public void Cancelar(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            DALObj.Cancelar(codigo);
        }
        public DataTable Localizar()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar();
        }

        public DataTable Localizar(int valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarPorFornecedor(int valor)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarPorFornecedor(valor);
        }

        public DataTable LocalizarPorParcelas()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarPorParcelas();
        }

        public DataTable LocalizarPorCancelada()
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.LocalizarPorCancelada();
        }

        public DataTable Localizar(DateTime inicial, DateTime final )
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.Localizar(inicial, final);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALObj = new DALCompra(conexao);
            return DALObj.CarregaModeloCompra(codigo);
        }
    }
}
