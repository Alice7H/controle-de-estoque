using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        private int for_cod;
        private string for_nome;
        private string for_rsocial;
        private string for_ie;
        private string for_cnpj;
        private string for_cep;
        private string for_endereco;
        private string for_bairro;
        private string for_fone;
        private string for_cel;
        private string for_email;
        private string for_endnumero;
        private string for_cidade;
        private string for_estado;

        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRsocial = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndnumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        public ModeloFornecedor(int cod, String nome, String cnpj, String ie, String rsocial, String cep,
         String endereco, String bairro, String fone, String cel, String email, String endnumero, String cidade, String estado)
        {
            this.ForCod = cod;
            this.ForNome = nome;
            this.ForCnpj = cnpj;
            this.ForIe = ie;
            this.ForRsocial = rsocial;
            this.ForCep = cep;
            this.ForEndereco = endereco;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCel = cel;
            this.ForEmail = email;
            this.ForEndnumero = endnumero;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        public String ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        public String ForRsocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }
    
        public String ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }
        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }
        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }
        public String ForFone
        {
            get { return this.for_fone; }
            set { this.for_fone = value; }
        }
        public String ForCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }
        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }
        public String ForEndnumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }
        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }
        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }


    }
}
