using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        private int umed_cod;
        private string umed_nome;

        public ModeloUnidadeDeMedida()
        {
            this.Umedcod = 0;
            this.Umednome = "";
        }

        public ModeloUnidadeDeMedida(int cod, string nome)
        {
            this.Umedcod = cod;
            this.Umednome = nome;
        }

        public int Umedcod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        public string Umednome {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }

    }
}
