﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloItensVenda
    {
        private int itv_cod;
        private double itv_qtde;
        private double itv_valor;
        private int ven_cod;
        private int pro_cod;

        public ModeloItensVenda()
        {
            this.ItvCod = 0;
            this.ItvQtde = 0;
            this.ItvValor = 0;
            this.VenCod = 0;
            this.ProCod = 0;
        }

        public ModeloItensVenda(int cod, double qtd, double valor, int codven, int codpro)
        {
            this.ItvCod = cod;
            this.ItvQtde = qtd;
            this.ItvValor = valor;
            this.VenCod = codven;
            this.ProCod = codpro;
        }

        public int ItvCod
        {
            get { return this.itv_cod; }
            set { this.itv_cod = value; }
        }
        public double ItvQtde
        {
            get { return this.itv_qtde; }
            set { this.itv_qtde = value; }
        }
        public double ItvValor
        {
            get { return this.itv_valor; }
            set { this.itv_valor = value; }
        }
        public int VenCod
        {
            get { return this.ven_cod; }
            set { this.ven_cod = value; }
        }
        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }

    }
}
