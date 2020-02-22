using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        private int scat_cod;
        private String scat_nome;
        private int cat_cod;

        public ModeloSubCategoria()
        {
            this.SCatCod = 0;
            this.SCatNome = "";
            this.CatCod = 0;
        }
        public ModeloSubCategoria(int scatcod, String scatnome, int catcod)
        {
            this.SCatCod = scatcod;
            this.SCatNome = scatnome;
            this.CatCod = catcod;
        }
        public int SCatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }

        public String SCatNome
        {
            get { return this.scat_nome; }
            set { this.scat_nome = value; }
        }
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

    }
}
