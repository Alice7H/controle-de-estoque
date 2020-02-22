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
    public class BLLItensCompra
    {
        private DALConexao conexao;

        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("A compra é obrigatória.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório.");
            }
            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que 0.");
            }
            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que 0.");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("A compra é obrigatória.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório.");
            }
            if (modelo.ItcQtde <= 0)
            {
                throw new Exception("A quantidade deve ser maior que 0.");
            }
            if (modelo.ItcValor <= 0)
            {
                throw new Exception("O valor do item deve ser maior que 0.");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(ModeloItensCompra modelo)
        {
            if (modelo.ComCod <= 0)
            {
                throw new Exception("A compra é obrigatória.");
            }
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto da compra é obrigatório.");
            }
            if (modelo.ItcCod <= 0)
            {
                throw new Exception("O código do item da compra é obrigatório.");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.Excluir(modelo);
        }
        public void ExcluirTodos(int valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O código da compra é obrigatória.");
            }

            DALItensCompra DALObj = new DALItensCompra(conexao);
            DALObj.ExcluirTodos(valor);
        }
        public DataTable LocalizarPorCompra(int valor)
        {
            DALItensCompra DALObj = new DALItensCompra(conexao);
            return DALObj.LocalizarPorCompra(valor);
        }

        public ModeloItensCompra CarregaModeloItensCompra(int itcCod, int comCod, int proCod )
        {
            DALItensCompra DALObj = new DALItensCompra(conexao);
            return DALObj.CarregaModeloItensCompra(itcCod, comCod, proCod);
        }
    }
}
