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
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;
        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.Umednome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório.");
            }

            modelo.Umednome = modelo.Umednome.ToUpper();

            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Incluir(modelo);
        }
        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.Umedcod <= 0) {
                throw new Exception("O código da unidade de medida é obrigatório.");
            }

            if (modelo.Umednome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório.");
            }
            modelo.Umednome = modelo.Umednome.ToUpper();

            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.Localizar(valor);
        }

        public int VerificaUnidadeMedida(String valor)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.VerificaUnidadeMedida(valor);
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida DALObj = new DALUnidadeDeMedida(conexao);
            return DALObj.CarregaModeloUnidadeDeMedida(codigo);
        }

    }
}
