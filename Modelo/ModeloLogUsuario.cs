using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloLogUsuario
    {
        private int log_cod;
        private DateTime log_tempentrada;
        private DateTime log_tempsaida;
        private int usu_cod;

        public ModeloLogUsuario()
        {
            this.LogCod = 0;
            this.LogTempEntrada = DateTime.Now;
            this.UsuCod = 0;
        }

        public ModeloLogUsuario(int logcod, DateTime tempentrada, DateTime tempsaida, int usucod)
        {
            this.LogCod = logcod;
            this.LogTempEntrada = tempentrada;
            this.LogTempSaida = tempsaida;
            this.UsuCod = usucod;
        }

        public int LogCod
        {
            get { return this.log_cod; }
            set { this.log_cod = value; }
        }

        public DateTime LogTempEntrada
        {
            get { return this.log_tempentrada; }
            set { this.log_tempentrada = value; }
        }

        public DateTime LogTempSaida
        {
            get { return this.log_tempsaida; }
            set { this.log_tempsaida = value; }
        }

        public int UsuCod
        {
            get { return this.usu_cod; }
            set { this.usu_cod = value; }
        }
    }
}
