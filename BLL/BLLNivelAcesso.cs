using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLNivelAcesso
    {
        private DALConexao conexao;

        public BLLNivelAcesso(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable Localizar(int valor)
        {
            DALNivelAcesso DALObj = new DALNivelAcesso(conexao);
            return DALObj.Localizar(valor);
        }
        public DataTable Localizar(string valor)
        {
            DALNivelAcesso DALObj = new DALNivelAcesso(conexao);
            return DALObj.Localizar(valor);
        }
    }
}
