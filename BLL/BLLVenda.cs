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
    public class BLLVenda
    {
        private DALConexao conexao;

        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloVenda modelo)
        {
            if (modelo.VenData.Year != DateTime.Now.Year && modelo.VenData.Month != DateTime.Now.Month && modelo.VenData.Day != DateTime.Now.Day
                && modelo.VenData.Hour != DateTime.Now.Hour && modelo.VenData.Minute != DateTime.Now.Minute)
            {
                throw new Exception("A data de venda não corresponde a data atual.");
            }
            if (modelo.VenNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que 0.");
            }
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente é obrigatório.");
            }
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser informado.");
            }
            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("A nota fiscal da venda deve ser informada.");
            }
            modelo.VenStatus = modelo.VenStatus.ToUpper();

            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }
            if (modelo.VenData.Year != DateTime.Now.Year && modelo.VenData.Month != DateTime.Now.Month && modelo.VenData.Day != DateTime.Now.Day
                && modelo.VenData.Hour != DateTime.Now.Hour && modelo.VenData.Minute != DateTime.Now.Minute)
            {
                throw new Exception("A data da venda não corresponde a data atual.");
            }
            if (modelo.VenNparcelas <= 0)
            {
                throw new Exception("O número de parcelas deve ser maior que 0.");
            }
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente é obrigatório.");
            }
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório.");
            }
            if (modelo.VenTotal <= 0)
            {
                throw new Exception("O valor da venda deve ser informado.");
            }
            if (modelo.VenNfiscal <= 0)
            {
                throw new Exception("A nota fiscal da venda deve ser informada.");
            }

            modelo.VenStatus = modelo.VenStatus.ToUpper();

            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Excluir(codigo);
        }
        public void Cancelar(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            DALObj.Cancelar(codigo);
        }

        public DataTable Localizar()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar();
        }

        public DataTable Localizar(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarPorCliente(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código do cliente é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorCliente(valor);
        }

        public DataTable LocalizarPorCliente(string valor)
        {
            if (valor != "")
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorCliente(valor);
        }

        public DataTable Localizar(DateTime inicial, DateTime final)
        {                    
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.Localizar(inicial, final);
        }

        public DataTable LocalizarPorParcelas()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorParcelas();
        }

        public DataTable LocalizarAvista()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarAvista();
        }

        public DataTable LocalizarPorCancelada()
        {
            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.LocalizarPorCancelada();
        }

        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            if (codigo <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }

            DALVenda DALObj = new DALVenda(conexao);
            return DALObj.CarregaModeloVenda(codigo);
        }
    }
}
