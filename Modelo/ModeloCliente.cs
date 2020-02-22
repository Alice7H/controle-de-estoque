using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        private int cli_cod;
        private String cli_nome;
        private String cli_cpfcnpj;
        private String cli_rgie;
        private String cli_rsocial;
        private int cli_tipo;
        private String cli_cep;
        private String cli_endereco;
        private String cli_bairro;
        private String cli_fone;
        private String cli_cel;
        private String cli_email;
        private String cli_endnumero;
        private String cli_cidade;
        private String cli_estado;

        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRsocial = "";
            this.CliTipo = 0;
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndnumero = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }
        public ModeloCliente(int clicod, String clinome, String clicpfcnpj, String clirgie, String clirsocial, int clitipo, String clicep,
            String cliendereco, String clibairro, String clifone, String clicel, String cliemail, String cliendnumero, String clicidade, String cliestado)
        {
            this.CliCod = clicod;
            this.CliNome = clinome;
            this.CliCpfCnpj = clicpfcnpj;
            this.CliRgIe = clirgie;
            this.CliRsocial = clirsocial;
            this.CliTipo = clitipo;
            this.CliCep = clicep;
            this.CliEndereco = cliendereco;
            this.CliBairro = clibairro;
            this.CliFone = clifone;
            this.CliCel = clicel;
            this.CliEmail = cliemail;
            this.CliEndnumero = cliendnumero;
            this.CliCidade = clicidade;
            this.CliEstado = cliestado;
        }

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }

        public String CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        public String CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        public String CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

       public String CliRsocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }
       public int CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        public String CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }
        public String CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }
        public String CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }
        public String CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }
        public String CliCel
        {
            get { return this.cli_cel; }
            set { this.cli_cel = value; }
        }
        public String CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }
        public String CliEndnumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }
        public String CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }
        public String CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }

    }
}
