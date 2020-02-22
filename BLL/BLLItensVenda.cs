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
    public class BLLItensVenda
    {
        private DALConexao conexao;

        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatória.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da venda é obrigatório.");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório.");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que 0.");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que 0.");
            }

            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("A venda é obrigatória.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da venda é obrigatório.");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório.");
            }
            if (modelo.ItvQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que 0.");
            }
            if (modelo.ItvValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que 0.");
            }

            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModeloItensVenda modelo)
        {
            if (modelo.VenCod <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da venda é obrigatório.");
            }
            if (modelo.ItvCod <= 0)
            {
                throw new Exception("O código do item da venda é obrigatório.");
            }

            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.Excluir(modelo);
        }
        public void ExcluirTodos(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código da venda é obrigatório.");
            }

            DALItensVenda DALObj = new DALItensVenda(conexao);
            DALObj.ExcluirTodos(valor);
        }

        public DataTable LocalizarPorVenda(int valor)
        {
            DALItensVenda DALObj = new DALItensVenda(conexao);
            return DALObj.LocalizarPorVenda(valor);
        }

        public ModeloItensVenda CarregaModeloItensVenda(int itvCod, int venCod, int proCod)
        {
            DALItensVenda DALObj = new DALItensVenda(conexao);
            return DALObj.CarregaModeloItensVenda(itvCod, venCod, proCod);
        }
    }
}
