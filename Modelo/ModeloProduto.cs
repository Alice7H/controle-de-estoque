using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        private int pro_cod;
        private string pro_nome;
        private string pro_descricao;
        private byte[] pro_foto;
        private double pro_valorpago;
        private double pro_valorvenda;
        private double pro_qtde;
        private int umed_cod;
        private int cat_cod;
        private int scat_cod;
        
        public ModeloProduto()
        {
            this.ProCod = 0;
            this.ProNome = "";
            this.ProDescricao = "";
            this.ProValorpago = 0;
            this.ProValorvenda = 0;
            this.ProQtde = 0;
            this.UmedCod = 0;
            this.CatCod = 0;
            this.ScatCod = 0;
        }  
        
        public ModeloProduto(int cod, String nome, String descricao, String foto, Double valorpago, Double valorvenda,
            double qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.ProCod = cod;
            this.ProNome = nome;
            this.ProDescricao = descricao;
            this.CarregaImagem(foto);
            this.ProValorpago = valorpago;
            this.ProValorvenda = valorvenda;
            this.ProQtde = qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        public ModeloProduto(int cod, String nome, String descricao, byte[] foto, Double valorpago, Double valorvenda,
          double qtde, int umed_cod, int cat_cod, int scat_cod)
        {
            this.ProCod = cod;
            this.ProNome = nome;
            this.ProDescricao = descricao;
            this.ProFoto = foto;
            this.ProValorpago = valorpago;
            this.ProValorvenda = valorvenda;
            this.ProQtde = qtde;
            this.UmedCod = umed_cod;
            this.CatCod = cat_cod;
            this.ScatCod = scat_cod;
        }

        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        } 

        public String ProNome
        {
            get { return this.pro_nome; }
            set { this.pro_nome = value; }
        }

        public String ProDescricao
        {
            get { return this.pro_descricao; }
            set { this.pro_descricao = value; }
        }

        public byte[] ProFoto
        {
            get { return this.pro_foto; }
            set { this.pro_foto = value; }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                {
                    return;
                }
                //fornece propriedades e métodos de instância para criar, copiar
                //excluir, mover e abrir arquivos. Também ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte síncrono e assíncrono, operações de leitura e gravação.
                FileStream fs = new FileStream(imgCaminho,FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.pro_foto = new byte[Convert.ToInt32(arqImagem.Length)];
                //lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido
                int iBytesRead = fs.Read(this.pro_foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
                
            } catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public Double ProValorpago
        {
            get { return this.pro_valorpago; }
            set { this.pro_valorpago = value; }
        }

        public Double ProValorvenda
        {
            get { return this.pro_valorvenda; }
            set { this.pro_valorvenda = value; }
        }

        public Double ProQtde
        {
            get { return this.pro_qtde; }
            set { this.pro_qtde = value; }
        }

        public int UmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        public int ScatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }
    }
}
