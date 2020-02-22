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
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória.");
            }

            if (modelo.ProQtde < 0)
            {
                throw new Exception("A quantidade de produto deve ser maior ou igual a zero.");
            }

            if (modelo.ProValorpago < 0)
            {
                throw new Exception("O valor pago pelo produto deve ser maior ou igual a zero.");
            }

            if (modelo.ProValorvenda <= 0)
            {
                throw new Exception("O valor de venda do produto deve ser maior que zero.");
            }

            modelo.ProNome = modelo.ProNome.ToUpper();
            modelo.ProDescricao = modelo.ProDescricao.ToUpper();

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatória.");
            }

            if (modelo.ProQtde < 0)
            {
                throw new Exception("A quantidade de produto deve ser maior ou igual a zero.");
            }

            if (modelo.ProValorpago < 0)
            {
                throw new Exception("O valor pago pelo produto deve ser maior ou igual a zero.");
            }

            if (modelo.ProValorvenda <= 0)
            {
                throw new Exception("O valor de venda do produto deve ser maior que zero.");
            }

            modelo.ProNome = modelo.ProNome.ToUpper();
            modelo.ProDescricao = modelo.ProDescricao.ToUpper();

            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.Localizar(valor);
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALObj = new DALProduto(conexao);
            return DALObj.CarregaModeloProduto(codigo);
        }
    }
}
