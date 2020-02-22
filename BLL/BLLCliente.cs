using DAL;
using Modelo;
using Ferramentas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {        
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O cpf/cnpj é obrigatório.");
            }

            if (modelo.CliTipo == 0)
            {
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O cpf é inválido.");
                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O cnpj é inválido.");
                }
            }

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O rg/ie é obrigatório.");
            }

            //verificar rg/ie

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone é obrigatório.");
            }

            if (Validacao.IsFone(modelo.CliFone) == false) {
                throw new Exception("O número de telefone é inválido.");
            }

            //cli_tipo = 0 =>físico   cli_tipo = 1 =>jurídico

            modelo.CliNome = modelo.CliNome.ToUpper();
            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliBairro = modelo.CliBairro.ToUpper();
            modelo.CliCidade = modelo.CliCidade.ToUpper();
            modelo.CliEstado = modelo.CliEstado.ToUpper();
            modelo.CliRsocial = modelo.CliRsocial.ToUpper();

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliCod <= 0)
            {
                throw new Exception("O código do cliente é obrigatório.");
            }

            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O cpf/cnpj é obrigatório.");
            }

            //verificar cpf/cnpj

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O rg/ie é obrigatório.");
            }

            //verificar rg/ie

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone é obrigatório.");
            }

            modelo.CliNome = modelo.CliNome.ToUpper();
            modelo.CliEndereco = modelo.CliEndereco.ToUpper();
            modelo.CliBairro = modelo.CliBairro.ToUpper();
            modelo.CliCidade = modelo.CliCidade.ToUpper();
            modelo.CliEstado = modelo.CliEstado.ToUpper();
            modelo.CliRsocial = modelo.CliRsocial.ToUpper();

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarCpfCnpj(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarCpfCnpj(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModeloCliente(codigo);
        }
        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModeloCliente(cpfcnpj);
        }

    }
}
