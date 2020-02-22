using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloNivelAcesso
    {
        private int niv_cod;
        private String niv_nome;

        public int NivCod
        {
            get { return this.niv_cod; }
        }

        public String NivNome
        {
            get { return this.niv_nome; }
        }
    }
}
