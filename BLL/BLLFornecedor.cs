using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório.");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O cnpj é obrigatório.");
            }

            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O cnpj é inválido.");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("A inscrição estadual (ie) é obrigatória.");
            }

            //verificar ie

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone é obrigatório.");
            }

            if (Validacao.IsFone(modelo.ForFone) == false)
            {
                throw new Exception("O número de telefone é inválido.");
            }

            modelo.ForNome = modelo.ForNome.ToUpper();
            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForBairro = modelo.ForBairro.ToUpper();
            modelo.ForCidade = modelo.ForCidade.ToUpper();
            modelo.ForEstado = modelo.ForEstado.ToUpper();
            modelo.ForRsocial = modelo.ForRsocial.ToUpper();

            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código do fornecedor é obrigatório.");
            }

            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do fornecedor é obrigatório.");
            }

            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O cnpj é obrigatório.");
            }

            if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O cnpj é inválido.");
            }

            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O ie é obrigatório.");
            }
           
            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone é obrigatório.");
            }

            modelo.ForNome = modelo.ForNome.ToUpper();
            modelo.ForEndereco = modelo.ForEndereco.ToUpper();
            modelo.ForBairro = modelo.ForBairro.ToUpper();
            modelo.ForCidade = modelo.ForCidade.ToUpper();
            modelo.ForEstado = modelo.ForEstado.ToUpper();
            modelo.ForRsocial = modelo.ForRsocial.ToUpper();

            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarCnpj(String valor)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.LocalizarCnpj(valor);
        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.CarregaModeloFornecedor(codigo);
        }
        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            DALFornecedor DALObj = new DALFornecedor(conexao);
            return DALObj.CarregaModeloFornecedor(cnpj);
        }
    }
}
