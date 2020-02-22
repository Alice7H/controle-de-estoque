using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoPagamento
    {
        private int tpa_cod;
        private string tpa_nome;

        public ModeloTipoPagamento()
        {
            this.TpaCod = 0;
            this.TpaNome = "";
        }

        public ModeloTipoPagamento(int tpacod, String tpanome)
        {
            this.TpaCod = tpacod;
            this.TpaNome = tpanome;
        }

        public int TpaCod
        {
            get { return this.tpa_cod; }
            set { this.tpa_cod = value; }
        }

        public String TpaNome
        {
            get { return this.tpa_nome; }
            set { this.tpa_nome = value; }
        }

    }
}
