using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloParcelasCompra
    {
        private int pco_cod;
        private double pco_valor;
        private DateTime pco_datapagto;
        private DateTime pco_datavecto;
        private int com_cod;

        public ModeloParcelasCompra()
        {
            this.PcoCod = 0;
            this.PcoValor = 0;
            this.PcoDataVecto = DateTime.Now;         
            this.ComCod = 0;
        }
        public ModeloParcelasCompra(int cod, double valor, DateTime pagto, DateTime vecto, int codcom)
        {
            this.PcoCod = cod;
            this.PcoValor = valor;
            this.PcoDataPagto = pagto;
            this.PcoDataVecto = vecto;
            this.ComCod = codcom;
        }

        public int PcoCod
        {
            get { return this.pco_cod; }
            set { this.pco_cod = value; }
        }
        public double PcoValor
        {
            get { return this.pco_valor; }
            set { this.pco_valor = value; }
        }
        public DateTime PcoDataPagto
        {
            get { return this.pco_datapagto; }
            set { this.pco_datapagto = value; }
        }
        public DateTime PcoDataVecto
        {
            get { return this.pco_datavecto; }
            set { this.pco_datavecto = value; }
        }
        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }
    }
}
