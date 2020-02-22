using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConfiguracaoBancoDados : Form
    {
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txt_servidor.Text);
                arquivo.WriteLine(txt_bd.Text);
                arquivo.WriteLine(txt_usuario.Text);
                arquivo.WriteLine(txt_senha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txt_servidor.Text = arquivo.ReadLine();
                txt_bd.Text = arquivo.ReadLine();
                txt_usuario.Text = arquivo.ReadLine();
                txt_senha.Text = arquivo.ReadLine();
                arquivo.Close();            
            }        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_testarconexao_Click(object sender, EventArgs e)
        {
            try
            {              
                DadosDaConexao.servidor = txt_servidor.Text;
                DadosDaConexao.banco = txt_bd.Text;
                DadosDaConexao.usuario = txt_usuario.Text;
                DadosDaConexao.senha = txt_senha.Text;            
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão efetuada com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao se conectar com o banco de dados. \n" +
                                "Verifique os dados informados ");
                MessageBox.Show(ex.Message);
            }
          
        }
    }
}
