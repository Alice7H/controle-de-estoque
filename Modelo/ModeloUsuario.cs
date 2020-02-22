using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        private int usu_cod;
        private string usu_nome;
        private string usu_senha;
        private string usu_status;
        private int niv_cod;

        public ModeloUsuario()
        {
            this.UsuCod = 0;
            this.UsuNome = "";
            this.UsuSenha = "";
            this.UsuStatus = "ATIVO";
            this.NivCod = 0;
        }
        public ModeloUsuario(int usucod, String usunome, String ususenha,String status, int nivel)
        {
            this.UsuCod = usucod;
            this.UsuNome = usunome;
            this.UsuSenha = ususenha;
            this.UsuStatus = status;
            this.NivCod = nivel; 
        }

        public int UsuCod
        {
            get { return this.usu_cod; }
            set { this.usu_cod = value; }
        }

        public String UsuNome
        {
            get { return this.usu_nome; }
            set { this.usu_nome = value; }
        }

        public String UsuSenha
        {
            get { return this.usu_senha; }
            set { this.usu_senha = value; }
        }

        public String UsuStatus
        {
            get { return this.usu_status; }
            set { this.usu_status = value; }
        }

        public int NivCod
        {
            get { return this.niv_cod; }
            set { this.niv_cod = value; }
        }
    }
}
