using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensCompra
    {
        private int itc_cod;
        private double itc_qtde;
        private double itc_valor;
        private int com_cod;
        private int pro_cod;

        public ModeloItensCompra()
        {
            this.ItcCod = 0;
            this.ItcQtde = 0;
            this.ItcValor = 0;
            this.ComCod = 0;
            this.ProCod = 0;
        }

        public ModeloItensCompra(int cod, double qtd, double valor, int codcom, int codpro )
        {
            this.ItcCod = cod;
            this.ItcQtde = qtd;
            this.ItcValor = valor;
            this.ComCod = codcom;
            this.ProCod = codpro;
        }

        public int ItcCod
        {
            get { return this.itc_cod; }
            set { this.itc_cod = value; }
        }
        public double ItcQtde
        {
            get { return this.itc_qtde; }
            set { this.itc_qtde = value; }
        }
        public double ItcValor
        {
            get { return this.itc_valor; }
            set { this.itc_valor = value; }
        }
        public int ComCod
        {
            get { return this.com_cod; }
            set { this.com_cod = value; }
        }
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }

    }
}
