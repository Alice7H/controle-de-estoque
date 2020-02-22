using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLogUsuario
    {
        private DALConexao conexao;
        public BLLLogUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Entrada(ModeloLogUsuario modelo)
        {        
            DALLogUsuario DALObj = new DALLogUsuario(conexao);
            DALObj.Entrada(modelo);
        }
        public void Saida(ModeloLogUsuario modelo)
        {
            DALLogUsuario DALObj = new DALLogUsuario(conexao);
            DALObj.Saida(modelo);
        }

    }
}
