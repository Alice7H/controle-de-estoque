using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLParcelasVenda
    {
        private DALConexao conexao;

        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatória.");
            }
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela da venda é obrigatório.");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que 0.");
            }
            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Date < data.Date)
            {
                throw new Exception("Data de vencimento inferior à data atual.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            DALObj.Incluir(modelo);

        }

        public void EfetuaRecebimentoParcela(int pvecod, int vencod, DateTime dtpagto)
        {
            //cobrar juros
            //if (dtpagto.Day != dtvecto.Day && dtpagto.Month != dtvecto.Month && dtpagto.Year != dtvecto.Year)
            //{
            //    throw new Exception("A data de pagamento está atrasada.");
            //}
            if (dtpagto == null)
            {
                throw new Exception("A data de recebimento é obrigatória.");
            }
            if (vencod <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }
            if (pvecod <= 0)
            {
                throw new Exception("O código da parcela da venda é obrigatório.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            DALObj.EfetuaRecebimentoParcela(pvecod, vencod, dtpagto);
        }

        public void Alterar(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela da venda é obrigatório.");
            }

            if (modelo.PveValor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que 0.");
            }

            DateTime data = DateTime.Now;
            if (modelo.PveDataVecto.Date < data.Date)
            {
                throw new Exception("Data de vencimento inferior à data atual.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatória.");
            }
            if (modelo.PveCod <= 0)
            {
                throw new Exception("O código da parcela da venda é obrigatório.");
            }
          
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcelas(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O códgo da venda é obrigatória.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            DALObj.ExcluirTodasAsParcelas(valor);
        }

        public DataTable LocalizarPorVenda(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O códgo da venda é obrigatória.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            return DALObj.LocalizarPorVenda(valor);
        }

        public int LocalizarParcelasPagas(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código de venda é obrigatório.");
            }
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            return DALObj.LocalizarParcelasPagas(valor);
        }

        public int ContadorDeParcelas()
        {
            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            return DALObj.ContadorDeParcelas();
        }

        public ModeloParcelasVenda CarregaModelo(int pveCod, int venCod)
        {
            if (venCod <= 0)
            {
                throw new Exception("O códgo da venda é obrigatório.");
            }
            if (pveCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório.");
            }

            DALParcelasVenda DALObj = new DALParcelasVenda(conexao);
            return DALObj.CarregaModeloParcelasVenda(pveCod, venCod);
        }
    }
}
