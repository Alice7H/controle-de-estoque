using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasVenda
    {
        private int pve_cod;
        private double pve_valor;
        private DateTime pve_datapagto;
        private DateTime pve_datavecto;
        private int ven_cod;

        public ModeloParcelasVenda()
        {
            this.PveCod = 0;
            this.PveValor = 0;
            this.PveDataVecto = DateTime.Now;
            this.VenCod = 0;
        }
        public ModeloParcelasVenda(int cod, double valor, DateTime pagto, DateTime vecto, int vencom)
        {
            this.PveCod = cod;
            this.PveValor = valor;
            this.PveDataPagto = pagto;
            this.PveDataVecto = vecto;
            this.VenCod = vencom;
        }

        public int PveCod
        {
            get { return this.pve_cod; }
            set { this.pve_cod = value; }
        }
        public double PveValor
        {
            get { return this.pve_valor; }
            set { this.pve_valor = value; }
        }
        public DateTime PveDataPagto
        {
            get { return this.pve_datapagto; }
            set { this.pve_datapagto = value; }
        }
        public DateTime PveDataVecto
        {
            get { return this.pve_datavecto; }
            set { this.pve_datavecto = value; }
        }
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }
    }
}
