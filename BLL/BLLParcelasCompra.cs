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
    public class BLLParcelasCompra
    {
        private DALConexao conexao;

        public BLLParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra é obrigatório.");
            }
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela da compra é obrigatório.");
            }
    
            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que 0.");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Date < data.Date)
            {
                throw new Exception("Data de vencimento inferior à data atual.");
            }

            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            DALObj.Incluir(modelo);

        }

        public void EfetuaPagamentoParcela(int pcocod, int comcod, DateTime dtpagto) {
            //cobrar juros
            //if (dtpagto.Day != dtvecto.Day && dtpagto.Month != dtvecto.Month && dtpagto.Year != dtvecto.Year)
            //{
            //    throw new Exception("A data de pagamento está atrasada.");
            //}
            if (dtpagto == null) {
                throw new Exception("A data de pagamento é obrigatória.");
            }
            if (comcod <= 0)
            {
                throw new Exception("O código da compra é obrigatório.");
            }
            if (pcocod <= 0)
            {
                throw new Exception("O código da parcela da compra é obrigatório.");
            }
            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            DALObj.EfetuaPagamentoParcela(pcocod, comcod, dtpagto);
        }

        public void Alterar(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O códgo da compra é obrigatório.");
            }
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela da compra é obrigatório.");
            }

            if (modelo.PcoValor <= 0)
            {
                throw new Exception("O valor da parcela deve ser maior que 0.");
            }
            DateTime data = DateTime.Now;
            if (modelo.PcoDataVecto.Date < data.Date)
            {
                throw new Exception("Data de vencimento inferior à data atual.");
            }
            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModeloParcelasCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("O códgo da compra é obrigatório.");
            }
            if (modelo.PcoCod <= 0)
            {
                throw new Exception("O código da parcela da compra é obrigatório.");
            }

            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            DALObj.Excluir(modelo);
        }

        public void ExcluirTodasAsParcelas(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código da compra é obrigatório.");
            }
            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            DALObj.ExcluirTodasAsParcelas(valor);
        }

        public DataTable LocalizarPorCompra(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O códgo da compra é obrigatório.");
            }

            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            return DALObj.LocalizarPorCompra(valor);
        }

        public int LocalizarParcelasPagas(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O códgo da compra é obrigatório.");
            }
            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            return DALObj.LocalizarParcelasPagas(valor);
        }

        public int ContadorDeParcelas()
        {
            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            return DALObj.ContadorDeParcelas();
        }

        public ModeloParcelasCompra CarregaModelo(int pcoCod, int comCod)
        {
            if (comCod <= 0)
            {
                throw new Exception("O códgo da compra é obrigatório.");
            }
            if (pcoCod <= 0)
            {
                throw new Exception("O código da parcela é obrigatório.");
            }

            DALParcelasCompra DALObj = new DALParcelasCompra(conexao);
            return DALObj.CarregaModeloParcelasCompra(pcoCod, comCod);
        }
    }
}
