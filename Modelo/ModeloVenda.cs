using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloVenda
    {
        int ven_cod;
        DateTime ven_data;
        int ven_nfiscal;
        double ven_total;
        int ven_nparcelas;
        string ven_status;
        int cli_cod;
        int tpa_cod;
        int ven_avista; 

        public ModeloVenda()
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNfiscal = 0;
            this.VenTotal = 0;
            this.VenNparcelas = 0;
            this.VenStatus = "Válida";
            this.CliCod = 0;
            this.TpaCod = 0;
            this.VenAvista = 1;
        }

        public ModeloVenda(int cod, DateTime data, int nfiscal, double total, int nparcelas, string status, int clicod, int tpacod, int venavista)
        {
            this.VenCod = cod;
            this.VenData = data;
            this.VenNfiscal = nfiscal;
            this.VenTotal = total;
            this.VenNparcelas = nparcelas;
            this.VenStatus = status;
            this.CliCod = clicod;
            this.TpaCod = tpacod;
            this.VenAvista = venavista;
        }

        public int VenCod { get { return this.ven_cod; } set { this.ven_cod = value; } }
        public DateTime VenData { get { return this.ven_data; } set { this.ven_data = value; } }
        public int VenNfiscal { get { return this.ven_nfiscal; } set { this.ven_nfiscal = value; } }
        public double VenTotal { get { return this.ven_total; } set { this.ven_total = value; } }
        public int VenNparcelas { get { return this.ven_nparcelas; } set { this.ven_nparcelas = value; } }
        public string VenStatus { get { return this.ven_status; } set { this.ven_status = value; } }
        public int CliCod { get { return this.cli_cod; } set { this.cli_cod = value; } }
        public int TpaCod { get { return this.tpa_cod; } set { this.tpa_cod = value; } }
        public int VenAvista { get { return this.ven_avista; } set { this.ven_avista = value; } }
    }
}
